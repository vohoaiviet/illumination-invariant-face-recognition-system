using System;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Eutility;
using System.Xml;
using System.IO;
using System.Threading;
namespace IKnowYou_v2
{
    class ICA
    {
        private static int height;
        private static int width;
        //private static int noOfSuspects = 8;
        private int noOfImages = 0;
        private static int trainData;
        private float[,] C; // actual all images
        private float[,] dC;  //deviation from mean
        private float[,] tdC;  //transpose dC
        private float[,] L; //Value of dC*tdC
        private float[,] V;  //Eigen vector of L
        private float[,] sV;//sorted V
        private float[] Vd; // Eigen values of L
        private float[,] rc;//reconstruct 
        private float[] mean = new float[height * width]; ///mean of the all train images pixels 
        private int sweep;    //how many times you've gone thru the data
        //private int P;        //how many timepoints in the data
        //private int N;        //how many input (mixed) sources there are
        //private int M;        //how many outputs you have
        //private float Lr;        //learning rate
        //private int B;        //batch-block size (ie: how many presentations per weight update.)
        //private float t;        //time index of data
        //private float[,] sources;  //NxP matrix of the N sources you read in
        private float[,] x;        //NxP matrix of mixtures
        private float[,] tx;         // Temporary x
        private float[,] r;        // (deviation of mean)' *( reconstructed matric(ie rc) )
        private float[,] u;        //MxP matrix of hopefully unmixed sources
        private float[,] xSp;         // Sphered matrix 
        private float[,] a;        //NxN mixing matrix
        private static int midat;          // number of feature need to extract
        private float[,] w;        //MxN unmixing matrix (actually w*wz is the full unmixing matrix
        //in this case)
        private float wz;       //zero-phase whitening: a matrix used to remove 
        //correlations from between the mixtures x. Useful as a 
        //preprocessing step.
        private int noblocks; //how many blocks in a sweep;
        private float[,] oldw;     //value of w before the last sweep
        private float[,] delta;    //w-oldw
        private float[] olddelta; //value of delta before the last sweep
        private float angle;    //angle in degrees between delta and olddelta
        private float change;   //squared length of delta vector 
        //Id;       //an identity matrix
        //permute;  //a vector of length P used to scramble the time order of the
        //sources for stationarity during learning.
        private float count;
        private float[,] temX; // temporary of X
        private float[,] temp;
        private float[,] stemp;
        private float[,] dis_eu;
        private float[,] testIm;
        private double[,] el = new double[1, trainData];
        private static int minEudDistance = 0;        

        public static void setFunction(int noOfFaces, int noOfPersons)
        {
            trainData = noOfFaces;
            midat = noOfPersons;
        }

        public static int getMinEudDistance()
        {
            return minEudDistance;
        }
        //testing from file
        public ICA() { }
        public ICA(int wi, int h, int totalda, int mix)
        {
            height = h;
            width = wi;
            trainData = totalda;
            midat = mix;
            change = 0;
            C = new float[height * width, trainData]; // actual all images
            dC = new float[height * width, trainData]; //deviation from mean
            tdC = new float[trainData, height * width]; //transpose dC
            L = new float[trainData, trainData]; //Value of dC*tdC
            V = new float[trainData, trainData]; //Eigen vector of L
            sV = new float[trainData, trainData]; //sorted V
            Vd = new float[trainData]; // Eigen value of L
            mean = new float[height * width]; ///mean of the all train images pixels 
            temp = new float[height * width, trainData];
            stemp = new float[height * width, trainData];
            x = new float[height * width, trainData];
            tx = new float[height * width, trainData];
            xSp = new float[midat, trainData]; //this will be changed if less feature is extracted from PCA
            rc = new float[height * width, trainData];
            r = new float[trainData, trainData];
            w = new float[midat, midat];
            temX = new float[midat, trainData];
            dis_eu=new float[1,trainData/4];
            testIm = new float[1, height * width];
            

        }
        public void savp(string a, float[,] mat)
        {
            using (StreamWriter writer = File.CreateText(a))
            {
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {


                        writer.Write(mat[i, j].ToString() + "\t");
                    }


                    // Insert a new line.
                    writer.Write(writer.NewLine);
                }
                writer.Close();

            }

        }
        public void sav()
        {
            // value of V- eign vector PCA
            savp("test_v.txt", V);
            // value of deviation from mean PCA
            savp("test_devi.txt", dC);
            // value of L (before eigen processing (PCA))
            savp("test_cov.txt", L);
            // value of recontruction i.e dc*V
            savp("test_Recons_notsorted.txt", temp);
            // value of R
            savp("test_R.txt", rc);
            // value of reconstruction, sorted
            savp("test_Recons.sorted.txt", stemp);

        }
        public float[,] matmul(ref float[,] mat1, ref float[,] mat2)
        {
            float sum = 0;
            float[,] ret = new float[mat1.GetLength(0), mat2.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    sum = 0;
                    for (int k = 0; k < mat1.GetLength(1); k++)
                        sum += mat1[i, k] * mat2[k, j];
                    ret[i, j] = sum;
                }
            }
            return ret;

        }
        //load images
        public void imreadall()
        {
            string Location = "C:\\major\\";
            for (int i = 1; i <= trainData; i++)
            {
                int j = 0;

                Bitmap alphaBmp = (Bitmap)Image.FromFile(String.Concat(Location, Convert.ToString(i), ".jpg"));
                Bitmap bmp = ImageProcessingUtilities.emguCVconvert2Grayscale(alphaBmp);
                ImageProcessingUtilities.hist_equalize(bmp);
                BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
                unsafe
                {
                    byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                    int stopAddress = (int)p + bmData.Stride * bmData.Height;
                    while ((int)p != stopAddress)
                    {
                        // if (i==3) continue;
                        C[j, i - 1] = p[0];
                        //images.SetValue(p[0], j, i - 1);
                        j++;
                        p++;


                    }
                    p = null;
                    j = 0;
                }
                bmp.UnlockBits(bmData);


            }


        }
        private static void Find_R_C(float[,] Mat, out int Row, out int Col)
        {
            Row = Mat.GetUpperBound(0);
            Col = Mat.GetUpperBound(1);
        }
        /// <summary>
        /// ////Inverse matrix ////
        /// </summary>
        /// <param name="Mat"></param>
        /// <returns></returns>
        public static float[,] Inverse(float[,] Mat)
        {
            float[,] AI, Mat1;
            float AIN, AF;
            int Rows, Cols;
            int LL, LLM, L1, L2, LC, LCA, LCB;
            Find_R_C(Mat, out Rows, out Cols);
            Mat1 = (float[,])Mat.Clone();
            LL = Rows;
            LLM = Cols;
            AI = new float[LL + 1, LL + 1];

            for (L2 = 0; L2 <= LL; L2++)
            {
                for (L1 = 0; L1 <= LL; L1++) AI[L1, L2] = 0;
                AI[L2, L2] = 1;
            }

            for (LC = 0; LC <= LL; LC++)
            {
                if (Math.Abs(Mat1[LC, LC]) < 0.0000000001)
                {
                    for (LCA = LC + 1; LCA <= LL; LCA++)
                    {
                        if (LCA == LC) continue;
                        if (Math.Abs(Mat1[LC, LCA]) > 0.0000000001)
                        {
                            for (LCB = 0; LCB <= LL; LCB++)
                            {
                                Mat1[LCB, LC] = Mat1[LCB, LC] + Mat1[LCB, LCA];
                                AI[LCB, LC] = AI[LCB, LC] + AI[LCB, LCA];
                            }
                            break;
                        }
                    }
                }
                AIN = 1 / Mat1[LC, LC];
                for (LCA = 0; LCA <= LL; LCA++)
                {
                    Mat1[LCA, LC] = AIN * Mat1[LCA, LC];
                    AI[LCA, LC] = AIN * AI[LCA, LC];
                }

                for (LCA = 0; LCA <= LL; LCA++)
                {
                    if (LCA == LC) continue;
                    AF = Mat1[LC, LCA];
                    for (LCB = 0; LCB <= LL; LCB++)
                    {
                        Mat1[LCB, LCA] = Mat1[LCB, LCA] - AF * Mat1[LCB, LC];
                        AI[LCB, LCA] = AI[LCB, LCA] - AF * AI[LCB, LC];
                    }
                }
            }
            return AI;
        }


        /// Covariance matrix
        public float[,] cov(float[,] Mat)
        {
            float[,] cl;
            float[,] rt;
            float[] mm;
            int Row, Col;
            Find_R_C(Mat, out Row, out Col);
            mm = new float[Row + 1];
            rt = new float[Row + 1, Row + 1];
            cl = (float[,])Mat.Clone();
            for (int i = 0; i <= Row; i++)
            {
                for (int j = 0; j <= Col; j++)
                {
                    mm[i] += cl[i, j];
                }
                mm[i] /= (Col + 1);
            }
            for (int i = 0; i <= Col; i++)
            {
                for (int j = 0; j <= Row; j++)
                {
                    cl[j, i] -= mm[j];
                }

            }

            for (int i = 0; i <= Row; i++)
            {
                for (int j = 0; j <= Row; j++)
                {
                    for (int k = 0; k <= Col; k++)
                    {
                        rt[i, j] += cl[i, k] * cl[j, k];

                    }
                    rt[i, j] /= (Col);
                }
            }
            return (rt);


        }

        /// <summary>
        /// /////PCA Generation//////////
        /// </summary>
        public void pca()
        {

            for (int i = 0; i < height * width; i++)
            {
                float sum = 0;
                for (int j = 0; j < trainData; j++)
                {
                    sum += C[i, j];

                }
                mean[i] = (float)(sum / trainData);

            }
            //-------------deviation from mean----------------------
            for (int i = 0; i < height * width; i++)
            {
                for (int j = 0; j < trainData; j++)
                {

                    dC[i, j] = (C[i, j] - mean[i]);

                }

            }
            //--------------multiply transpose(dC)*dC---------------

            for (int i = 0; i < height * width; i++)
            {
                for (int j = 0; j < trainData; j++)
                {
                    tdC[j, i] = dC[i, j];
                }
            }

            for (int i = 0; i < trainData; i++)
            {
                for (int j = 0; j < trainData; j++)
                {
                    float sum = 0;
                    for (int k = 0; k < height * width; k++)
                    {
                        sum += tdC[i, k] * dC[k, j];

                    }
                    L[i, j] = sum / (trainData);
                }
            }
            //-------------------calculate Eigenvector of L----------------//
            MWArray c = null;
            Eutilityclass Ev = new Eutilityclass();
            c = Ev.Eigenvtr1((MWNumericArray)L);
            MWNumericArray D = (MWNumericArray)c;
            Array pA = D.ToVector(MWArrayComponent.Real);
            float[] doubleArray1 = (float[])pA;
            int icount = 0;
            for (int i = 0; i < trainData; i++)
            {
                for (int j = 0; j < trainData; j++)
                {
                    V[j, i] = doubleArray1[icount];
                    sV[j, trainData - i - 1] = doubleArray1[icount];
                    icount++;
                }
            }
            savp("realEig.txt", (float[,])sV.Clone());
            /*
            //Eigen value
            c = Ev.Eigenvlu1((MWNumericArray)L);
            float[] eigenval = new float[L.GetLength(0)];
            D = (MWNumericArray)c;
            pA = D.ToVector(MWArrayComponent.Real);
            doubleArray1 = (float[])pA;
            icount = 0;
            int count = 0;
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for (int j = 0; j < L.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        eigenval[count] = Math.Abs(doubleArray1[icount]);
                        count++;
                    }
                    icount++;
                }
            }
            Vd = (float[])eigenval;
            //----------------------V=dC*V----------------------------
            */
            float[] sm = new float[trainData];
            float[] ssm = new float[trainData];



            temp = matmul(ref dC, ref V);
            stemp = matmul(ref dC, ref sV);
            for (int i = 0; i < height * width; i++)
            {
                for (int j = 0; j < trainData; j++)
                {

                    sm[j] += temp[i, j] * temp[i, j];
                    ssm[j] += stemp[i, j] * stemp[i, j];

                }
            }
            //Improving classification by dividing by length (i think mormalization)
            /*
            for (int j = 0; j < trainData; j++)
            {

                sm[j] = (float)Math.Pow(sm[j], .5);
                ssm[j] = (float)Math.Pow(ssm[j], .5);

            }
             * */
            for (int i = 0; i < height * width; i++)
            {
                for (int j = 0; j < trainData; j++)
                {

                    temp[i, j] = temp[i, j] / (float)Math.Pow(sm[j], .5);
                    stemp[i, j] = stemp[i, j] / (float)Math.Pow(ssm[j], .5);

                }
            }

            // obtaining the value of 'r'=tDc*V
            /*
            float summ = 0;
            
            for (int i = 0; i < trainData; i++)
            {
                for (int j = 0; j < trainData; j++)
                {

                    for (int k = 0; k < height * width; k++)
                    {
                        summ += tdC[i, k] * stemp[k, j];

                    }
                    rc[i, j] = summ;
                    summ = 0;
                }
            }
             * 
             */
            rc = matmul(ref tdC, ref stemp);


        }

        

        public int recogn(Bitmap imgtrec)
        {

            int indel = 0;


            float tmean = 0; //mean of test image
            //float[,] testim;
            // final vector of the distance

            ImageProcessingUtilities.hist_equalize(imgtrec);
            //if (imgtrec.PixelFormat == PixelFormat.Format8bppIndexed)
            //{
            BitmapData bmData = imgtrec.LockBits(new Rectangle(0, 0, imgtrec.Width, imgtrec.Height), ImageLockMode.ReadWrite, imgtrec.PixelFormat);
            unsafe
            {
                int j = 0;
                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                int stopAddress = (int)p + bmData.Stride * bmData.Height;
                //while ((int)p != stopAddress)
                while ((int)p != stopAddress)
                {
                    testIm[0, j] = p[0];
                    j++;
                    p++;
                }
                p = null;
                j = 0;
            }
            imgtrec.UnlockBits(bmData);

            //}


            /////////Deviation from mean////////////////////////
            //MessageBox.Show("stemp" + stemp.GetLength(0) + "," + stemp.GetLength(1) + "\n" + testIm.GetLength(0) + "," + testIm.GetLength(1));
            for (int i = 0; i < testIm.GetLength(1); i++)
                tmean = tmean + testIm[0, i];

            tmean /= testIm.GetLength(1);
            //MessageBox.Show(tmean.ToString());
            for (int i = 0; i < testIm.GetLength(1); i++)
                testIm[0, i] = testIm[0, i] - tmean;

            ///////// imgR*V   V=stemp///////////////////////

            //ThreadStart m1 = new ThreadStart(th1);
            //Thread mth1 = new Thread(m1);
            //mth1.Start();
            //ThreadStart m2 = new ThreadStart(th2);
            //Thread mth2 = new Thread(m2);
            //mth2.Start();


            //ThreadStart m3 = new ThreadStart(th3);
            //Thread mth3 = new Thread(m3);
            //mth3.Start();

            //testim = this.matmul(ref imgR, ref stemp);
            float sum1 = 0;
            dis_eu = new float[1, trainData / 4];
            for (int j = 0; j < (trainData / 4); j++)
            {
                sum1 = 0;
                for (int k = 0; k < testIm.GetLength(1); k++)
                    sum1 += testIm[0, k] * stemp[k, j];
                dis_eu[0, j] = sum1;
            }

            //MessageBox.Show("coordinate" + dis_eu[0, 0] + "," + dis_eu[0, 1] + "," + dis_eu[0, 2] + "," + dis_eu[0, 3] + ",");




            //this.savp("justy", testim);
            /*
            double[,] rett = new double[testim.GetLength(0), testim.GetLength(1)];
            for (int i = 0; i < rett.GetLength(0); i++)
            {

                for (int j = 0; j < rett.GetLength(1); j++)
                    rett[i, j] = (double)testim[i, j];

            }
             */
            //MessageBox.Show("rc=(" + rc.GetLength(0) + "," + rc.GetLength(1)+")\n"+trainData);
            ///////////////recognition//////////////////////////
            double devsumsq = 0;
            el = new double[1, trainData];
            for (int i = 0; i < trainData; i++)
            {

                for (int j = 0; j < (trainData/4); j++)
                    devsumsq += Math.Pow((rc[i, j] - dis_eu[0, j]), 2);
                el[0, i] = Math.Pow(devsumsq, .5);
                devsumsq = 0;
            }
            double min = el[0, 0];
            for (int i = 0; i < trainData; i++)
            {
                if (el[0, i] < min)
                {
                    min = el[0, i];
                    indel = i;
                }
            }
            minEudDistance = (int)min;


            //MessageBox.Show("Index:"+indel.ToString());






            int classIndex; 
            /*
            if (min > 4500)
            {
                indel = -1;
                MessageBox.Show("Unknown Face");
            } 
             */
            
            //else
            {
                classIndex = indel / 10;          
                indel = 1 + (indel / 10) * 10;
                //MessageBox.Show("min : " + Convert.ToString(min));
              double maxE = findMaxEuclidian();
                //MessageBox.Show("max : " + Convert.ToString(maxE));
                //MessageBox.Show("diff : " + Convert.ToString(maxE - min));
            }
            //this code will set the input vector for lvq
            /*
            int inputVectorIndex=1;
            LVQ.setInputVectors(minEudDistance, 0);
            for (int i = indel; i < (indel + 5); i++)
            {
                LVQ.setInputVectors((int)el[0,i], inputVectorIndex);
                inputVectorIndex++;
            }
             */
            Sorter.BubbleSort(el);
            int[] pat = Sorter.getSortedPatterns();
            
            FaceRecognition.writeEudPat(pat);
            
            return indel;
        }


        
        public double findIntraClassMax(int classIndex)
        {
            int initialMaxIndex=1+(classIndex*10);
            double intraMax = el[0, initialMaxIndex];
            int intraIndex = classIndex*10 + 1;
            for (int i = intraIndex; i < (intraIndex + 10); i++)
            {
                if (el[0,i] > intraMax)
                    intraMax = el[0,i];
            }
            return intraMax;
        }
        public double getEl(int index)
        {            
            return el[0, index];
        }
        public double findInterClassMin(int classIndex)
        {
            double interMin;
            int initialMinIndex;
            if(classIndex==0)
            {
                initialMinIndex=1+(classIndex+1)*10;
            }
            else
                initialMinIndex=1+(classIndex-1)*10;
            interMin=el[0,initialMinIndex];
            for (int i = 1; i < trainData; i++)
            {
                if ((i / 10) != classIndex)
                {
                    if (el[0, i] < interMin)
                        interMin = el[0, i];
                }
            }
            return interMin;
        }
        public double findMaxEuclidian()
        {
            double max = el[0, 0];
            for (int i = 1; i < trainData; i++)
            {
                if (max < el[0, i])
                    max = el[0, i];
            }
            return max;
        }
        public void XMLW()
        {
            string s1, s2;
            int i = 0, j = 0;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\r\n";
            XmlWriter xmlWriter = XmlWriter.Create("C:\\major\\XML_me.xml", settings);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("main");

            xmlWriter.WriteStartElement("var");
                xmlWriter.WriteElementString("TotalIm", trainData.ToString());

                xmlWriter.WriteElementString("ImH", height.ToString());

                xmlWriter.WriteElementString("ImW", width.ToString());

            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("pca_v");
                for (i = 0; i < height * width; i++)
                {
                    for (j = 0; j < (trainData/4); j++)
                    {
                        s1 = i.ToString();
                        s2 = j.ToString();
                        string s3 = "f" + s1 + "f" + s2;
                        xmlWriter.WriteElementString(s3, stemp[i, j].ToString());


                    }
                }

            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("pca_rc");

                for (i = 0; i < trainData; i++)
                {
                    for (j = 0; j < (trainData/4); j++)
                    {
                        s1 = i.ToString();
                        s2 = j.ToString();
                        string s3 = "l" + s1 + "l" + s2;
                        xmlWriter.WriteElementString(s3, rc[i, j].ToString());


                    }
                }

            xmlWriter.WriteEndElement();
        xmlWriter.WriteEndElement();

        xmlWriter.WriteEndDocument();
        xmlWriter.Close();
        }
        public void XMLR()
        {
            XmlReader textreader = XmlReader.Create("C:\\major\\XML_me.xml");
            //textReader.Read();
            int i = 0, j = 0;

            //while (textreader.ReadToFollowing("main"))
            {

                textreader.ReadToFollowing("var");
                textreader.ReadToFollowing("TotalIm");
                trainData = Convert.ToInt32(textreader.ReadInnerXml());
                textreader.ReadToFollowing("ImH");
                height = Convert.ToInt32(textreader.ReadInnerXml());


                textreader.ReadToFollowing("ImW");
                width = Convert.ToInt32(textreader.ReadInnerXml());

                textreader.ReadToFollowing("pca_v");
                stemp = new float[height * width, (trainData / 4)];
                for (i = 0; i < height * width; i++)
                {

                    for (j = 0; j < (trainData/4); j++)
                    {
                        textreader.ReadToFollowing("f" + i.ToString() + "f" + j.ToString());
                        stemp[i, j] = Convert.ToSingle(textreader.ReadInnerXml());
                    }
                }

                textreader.ReadToFollowing("pca_rc");
                rc=new float[trainData,trainData/4];
                for (i = 0; i < trainData; i++)
                {

                    for (j = 0; j < (trainData/4); j++)
                    {
                        textreader.ReadToFollowing("l" + i.ToString() + "l" + j.ToString());
                        rc[i, j] = Convert.ToSingle(textreader.ReadInnerXml());
                    }
                }








            }
            textreader.Close();

        }


    }
}
