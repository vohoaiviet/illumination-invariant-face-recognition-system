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

namespace IKnowYou_v2
{
    class RLda
    {
        private static int height = 101;
        private static int width = 76;
        private static int noOfSuspects ;
        private static int trainData ;
        private int noOfImages = 0;        
        private int[] imagePerClass = new int[noOfSuspects];
        //private Array imagePerClass = Array.CreateInstance(typeof(int), noOfSuspects);
        private int[,] images;
        //private Array images = Array.CreateInstance(typeof(int), height*width, trainData);
        private double VERY_SMALL = Math.Exp(-3);
        private int SSS_Rate = 0;
        private double eta_sw = 0;
        private double thresh_eigval_sb = 0;
        public double update_eigval_sb = 0;
        public double remain_eigvec = 0;
        public int sample_num = trainData;
        public int class_num = 0;
        private double[] mean_i = new double[width * height];
        //private Array mean_i = Array.CreateInstance(typeof(double), height * width);
        private double[,] mean_c = new double[width * height, noOfSuspects];
        //private Array mean_c = Array.CreateInstance(typeof(double), height * width, noOfSuspects);
        //private int m_b;
        private double[,] y;
        private static double[] eDist;
        private double[,] DFLD_Trans;
        double[,] ifeature;
        public struct stRegParm
        {
            public double Eta_Sw;
            public double Threshold_EigVal_Sb;
            public double Update_EigVal_Sb;
            public double RemainEigVec;

        }
        stRegParm struct_var = new stRegParm();        
        public RLda(int td, int nos)
        {
            height = 101;
            width = 76;
            trainData = td;
            images = new int[height * width, trainData];            
            noOfSuspects = nos;
            noOfImages = td;
            imagePerClass = new int[noOfSuspects];
        }
        public static void setFunction(int noOfFaces, int noOfPersons)
        {
            trainData = noOfFaces;
            noOfSuspects = noOfPersons;
        }
        public void readImages()
        {
            string Location = "C:\\major\\";
            MessageBox.Show(Convert.ToString(trainData));
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
                        images[j, i - 1] = p[0];
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
        public double[,] readImage(Bitmap fileloc)
        {
            //string filename;

            double[,] imgR;
            //try
            {
                //filename = fileloc;
                //Bitmap imgtrec = (Bitmap)Image.FromFile(filename);
                Bitmap imgtrec = fileloc;
                ImageProcessingUtilities.hist_equalize(imgtrec);
                if (imgtrec.PixelFormat == PixelFormat.Format24bppRgb)
                {
                    imgtrec = ImageProcessingUtilities.MakeGrayscale3(imgtrec);
                }
                if (imgtrec.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    imgR = new double[1, imgtrec.Height * imgtrec.Width];
                    BitmapData bmData = imgtrec.LockBits(new Rectangle(0, 0, imgtrec.Width, imgtrec.Height), ImageLockMode.ReadWrite, imgtrec.PixelFormat);
                    //try
                    {
                        unsafe
                        {
                            int j = 0;
                            byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                            int stopAddress = (int)p + bmData.Stride * bmData.Height;
                            //while ((int)p != stopAddress)
                            while (j != imgR.GetLength(0) * imgR.GetLength(1))
                            {
                                // if (i==3) continue;
                                imgR[0, j] = p[0];
                                //images.SetValue(p[0], j, i - 1);
                                j++;
                                p++;
                            }
                            p = null;
                            j = 0;
                        }
                        imgtrec.UnlockBits(bmData);
                        double[,] itemp = new double[imgR.GetLength(1), imgR.GetLength(0)];
                        ifeature = new double[DFLD_Trans.GetLength(0), itemp.GetLength(1)];
                        transpose(ref imgR, ref itemp);
                        matrix_multiply(ref DFLD_Trans, ref itemp, ref ifeature);
                        itemp = new double[ifeature.GetLength(1), ifeature.GetLength(0)];
                        //transpose(ref ifeature, ref itemp);
                        compute_ED(y, ifeature);
                    }
                    //catch
                    {
                        //MessageBox.Show("Error: Load 8 bit image");
                    }

                }


            }
            // catch
            {

                //MessageBox.Show("Error opening image", "Face Recongition", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ifeature;

        }
        public int isearch()
        {
            double min;
            int ind;
            min = eDist[0];
            ind = 0;
            for (int i = 1; i < eDist.GetLength(0); i++)
            {
                if (eDist[i] < min)
                {
                    min = eDist[i];
                    ind = i;
                }
            }
            return ind;
        }
        public bool intialize_each_class()
        {

            int[] bi = new int[noOfSuspects];
            //Array bi = Array.CreateInstance(typeof(int),noOfSuspects);
            int add_imagePerClass = 0;
            for (int i = 0; i < noOfSuspects; i++)
            {
                imagePerClass[i] = 10;//we have used 10 images person in each class;
                //imagePerClass.SetValue(10,i);
                add_imagePerClass = add_imagePerClass + imagePerClass[i];
                //add_imagePerClass = add_imagePerClass + (int)imagePerClass.GetValue(i);
            }
            this.a_find(ref imagePerClass, 2, ref bi);
            for (int i = 0; i < noOfSuspects; i++)
            {
                //SSS_Rate=SSS_Rate+(bi[i]/add_imagePerClass);
                SSS_Rate = SSS_Rate + ((int)bi.GetValue(i) / add_imagePerClass);
            }

            if (SSS_Rate > 0.5)
            {
                struct_var.Eta_Sw = 1;
                struct_var.Threshold_EigVal_Sb = 0.02;
                struct_var.Update_EigVal_Sb = 0.05;
                struct_var.RemainEigVec = 1;
            }
            else
            {
                struct_var.Eta_Sw = Math.Pow(10, -3);
                struct_var.Threshold_EigVal_Sb = 0.02;
                struct_var.Update_EigVal_Sb = 0.2;
                struct_var.RemainEigVec = 0.8;
            }
            eta_sw = struct_var.Eta_Sw;
            thresh_eigval_sb = struct_var.Threshold_EigVal_Sb;
            remain_eigvec = struct_var.RemainEigVec;

            class_num = imagePerClass.Length;
            return false;

        }
        public void a_find(ref int[] a, int b, ref int[] bi)
        //public void a_find(ref Array a, int b, ref Array bi)
        {
            for (int i = 0; i < noOfSuspects; i++)
            {
                if (a[i] <= b)
                    bi[i] = a[i];
                else
                    bi[i] = 0;
                /*  if ((int)a.GetValue(i) <= b)
                      bi.SetValue(a.GetValue(i),i)  ;
                  else
                      bi.SetValue(0,i);*/
            }

        }


        public void total_no_suspect()
        {
            int noi = 0;
            for (int i = 0; i < noOfSuspects; i++)
            {
                for (int j = 0; j < imagePerClass[i]; j++)
                //for (int j = 0; j < (int)imagePerClass.GetValue(i); j++)
                {
                    noi++;
                }
            }
            noOfImages = noi;
        }
        public void calc_mean()
        {
            //int person=0;
            total_no_suspect();
            double[] mean = new double[height * width];

            //for (int i = 0; i < noOfImages; i++)
            for (int k = 0; k < height * width; k++)
            {
                // for (int j = 0; j < imagePerClass[i]; j++)

                //for (int j = 0; j < (int)imagePerClass.GetValue(i); j++)
                {
                    mean[k] = 0;
                    for (int i = 0; i < noOfImages; i++)
                    //for (int k = 0; k < height * width; k++)
                    {
                        mean[k] = mean[k] + (double)images[k, i] / (double)noOfImages;
                        // mean[k] = mean[k] + (int)images.GetValue(k, person) / (double)noOfImages;
                        //mean[k] = mean[k] + (int)images.GetValue(k, i)/(double)noOfImages;
                    }
                    //person = person + 1; 
                }

            }

            mean_i = (double[])mean.Clone();


        }
        public void class_mean()
        {
            int person = 0;
            //int class_i=0;
            int person_i = 0;
            total_no_suspect();

            double[,] meanc = new double[height * width, noOfSuspects];

            for (int j = 0; j < height * width; j++)
            {
                for (int i = 0; i < noOfImages; i++)
                {
                    meanc[j, person] = meanc[j, person] + (int)images.GetValue(j, i) / (double)(int)imagePerClass.GetValue(person);
                    person_i++;
                    if (person_i >= imagePerClass[person])
                    //if(person_i>=(int)imagePerClass.GetValue(person))
                    {
                        person++;
                        person_i = 0;
                    }
                }
                person = 0;
                person_i = 0;

            }






            mean_c = (double[,])meanc.Clone();

        }

        public static void k_t_p(ref  double[,] a, ref  double[,] b, ref double[,] nm)
        {
            // for(int i=0;i<a.)
            //for(int )
            //double[,] nm = new double[a.GetLength(0)*b.GetLength(0),a.GetLength(1)*b.GetLength(1)]; 
            //nm = new double[a.GetLength(0) * b.GetLength(0), a.GetLength(1) * b.GetLength(1)]; 
            int column = 0, row = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(0); j++)
                {
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        for (int l = 0; l < b.GetLength(1); l++)
                        {
                            // nm[row][column]=a[i][k]*b[j][l];
                            nm[row, column] = a[i, k] * b[j, l];
                            column++;

                        }
                    }
                    column = 0;
                    row++;
                }
            }
            /*string n="",n1="";
            for (int i = 0; i < nm.GetLength(0); i++)
            {
                for (int j = 0; j < nm.GetLength(1); j++)
                {
                    n = string.Concat(n1,":",nm[i,j]);
                    n1 = n;
                }
            }
            MessageBox.Show(n);
              */

        }
        private static int breadth;
        public void execute()
        {
            double[,] nm;
            int m_b;// = noOfSuspects - 1;
            double[,] Phi_w = new double[height * width, noOfImages];
            int[,] t;
            double[,] one;
            double[,] mc;
            double[,] res;
            double[,] Phi_b;
            int person = 0;
            double[] eigenval;
            double[,] eigenvtr;
            double[] eigenval_sbt;
            double[,] eigenvtr_sbt;
            int[] index;
            double[] aa;
            double[] bb;
            double[] tmp;
            double[,] D_b;
            double[,] mU_Sw_U;
            double[] evl;
            double[,] evr;
            double[,] A;
            double[] D_w;

            //int m_b;
            //int Sb_t;

            //static int l=height*width;
            //static int b=
            for (int i = 0; i < noOfSuspects; i++)
            {
                breadth = imagePerClass[i];
                t = new int[height * width, breadth];
                one = new double[1, breadth];
                for (int j = 0; j < breadth; j++)
                {
                    one[0, j] = 1;
                }

                mc = new double[height * width, 1];
                for (int j = 0; j < height * width; j++)
                {
                    mc[j, 0] = mean_c[j, i];
                    for (int k = 0; k < imagePerClass[i]; k++)
                    {
                        t[j, k] = images[j, person + k];
                    }
                }
                nm = new double[mc.GetLength(0) * one.GetLength(0), mc.GetLength(1) * one.GetLength(1)];
                k_t_p(ref mc, ref one, ref nm);
                res = new double[nm.GetLength(0), nm.GetLength(1)];

                for (int j = 0; j < nm.GetLength(0); j++)
                {
                    for (int k = 0; k < nm.GetLength(1); k++)
                    {
                        res[j, k] = t[j, k] - nm[j, k];
                    }
                }
                for (int j = 0; j < height * width; j++)
                {
                    for (int k = person; k < person + imagePerClass[i]; k++)
                    {
                        Phi_w[j, k] = res[j, k - person];
                    }
                }
                person = person + imagePerClass[i];


            }

            //int oo = 0;
            for (int j = 0; j < Phi_w.GetLength(0); j++)
            {
                for (int k = 0; k < Phi_w.GetLength(1); k++)
                {
                    Phi_w[j, k] = Phi_w[j, k] / Math.Sqrt(noOfImages);
                }
            }
            one = new double[1, noOfSuspects];
            for (int j = 0; j < noOfSuspects; j++)
            {
                one[0, j] = 1;
            }
            nm = new double[mean_i.GetLength(0) * one.GetLength(0), mean_c.GetLength(1) * one.GetLength(1)];
            double[,] mi = new double[height * width, 1];
            for (int j = 0; j < mi.GetLength(0); j++)
            {
                mi[j, 0] = mean_i[j];
            }
            k_t_p(ref mi, ref one, ref nm);
            Phi_b = new double[mean_c.GetLength(0), mean_c.GetLength(1)];
            for (int j = 0; j < mean_c.GetLength(0); j++)
            {
                for (int k = 0; k < mean_c.GetLength(1); k++)
                {
                    Phi_b[j, k] = mean_c[j, k] - nm[j, k];
                }

            }

            for (int i = 0; i < noOfSuspects; i++)
            {
                for (int j = 0; j < Phi_b.GetLength(0); j++)
                {
                    Phi_b[j, i] = Phi_b[j, i] * Math.Sqrt((double)imagePerClass[i] / (double)noOfImages);
                }
            }
            nm = new double[Phi_b.GetLength(1), Phi_b.GetLength(0)];
            res = new double[nm.GetLength(0), Phi_b.GetLength(1)];
            transpose(ref Phi_b, ref nm);
            matrix_multiply(ref nm, ref Phi_b, ref res);

            ///calculation of Eigenvector of
            MWArray c = null;
            Eutilityclass Ev = new Eutilityclass();
            c = Ev.Eigenvtr1((MWNumericArray)res);
            MWNumericArray D = (MWNumericArray)c;
            Array pA = D.ToVector(MWArrayComponent.Real);
            double[] doubleArray1 = (double[])pA;
            int icount = 0;
            nm = new double[res.GetLength(0), res.GetLength(1)];//eigenvector
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    nm[j, i] = doubleArray1[icount];
                    icount++;
                }
            }
            c = Ev.Eigenvlu1((MWNumericArray)res);
            eigenval = new double[res.GetLength(0)];

            D = (MWNumericArray)c;
            pA = D.ToVector(MWArrayComponent.Real);
            doubleArray1 = (double[])pA;
            icount = 0;
            int count = 0;
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        eigenval[count] = Math.Abs(doubleArray1[icount]);
                        count++;
                    }
                    icount++;
                }
            }
            eigenval_sbt = new double[res.GetLength(1)];
            eigenval_sbt = (double[])eigenval.Clone();
            Array.Sort(eigenval);
            index = new int[res.GetLength(0)];

            for (int i = 0; i < eigenval_sbt.GetLength(0); i++)
            {
                index[i] = eigenval_sbt.GetLength(0) - 1 - Array.IndexOf(eigenval, eigenval[i]);
                eigenval_sbt[i] = eigenval[eigenval_sbt.GetLength(0) - i - 1];
            }
            aa = new double[res.GetLength(0)];
            eigenvtr_sbt = new double[res.GetLength(0), res.GetLength(1)];
            count = 0;

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    eigenvtr_sbt[j, (int)index[i]] = nm[j, i];
                }
                aa[i] = eigenval_sbt[i] / eigenval_sbt[0];
                if (aa[i] < thresh_eigval_sb)
                {
                    count++;
                }
            }
            bb = new double[count];
            m_b = (int)((Math.Round(((double)(noOfSuspects - 1)) * remain_eigvec)));
            count = 0;
            //double temp;
            for (int i = 0; i < eigenval_sbt.GetLength(0); i++)
            {
                if (aa[i] < thresh_eigval_sb)
                {
                    bb[count] = i;
                    count++;
                }
                //temp=ei
            }
            //MessageBox.Show(""+m_b);
            eigenvtr = new double[eigenvtr_sbt.GetLength(0), m_b];
            eigenval = new double[m_b];
            D_b = new double[m_b, m_b];
            for (int j = 0; j < m_b; j++)
            {
                for (int i = 0; i < eigenvtr_sbt.GetLength(0); i++)
                {
                    eigenvtr[i, j] = eigenvtr_sbt[i, j];
                    if (i == j)
                    {
                        D_b[i, j] = Math.Pow(eigenval_sbt[j], -1);
                    }
                }
                eigenval[j] = eigenval_sbt[j];

            }
            eigenvtr_sbt = new double[Phi_b.GetLength(0), eigenvtr.GetLength(1)];
            matrix_multiply(ref Phi_b, ref eigenvtr, ref eigenvtr_sbt);
            nm = new double[eigenvtr_sbt.GetLength(0), D_b.GetLength(0)];///Z
            matrix_multiply(ref eigenvtr_sbt, ref D_b, ref(nm));
            res = new double[nm.GetLength(1), nm.GetLength(0)];//Z'
            transpose(ref nm, ref res);
            mc = new double[res.GetLength(0), Phi_w.GetLength(1)];//mT
            matrix_multiply(ref res, ref Phi_w, ref mc);

            mU_Sw_U = new double[mc.GetLength(0), mc.GetLength(0)];
            res = new double[mc.GetLength(1), mc.GetLength(0)];//mT'
            transpose(ref mc, ref res);
            matrix_multiply(ref mc, ref res, ref mU_Sw_U);
            Phi_w = null;
            Phi_b = null;
            D_b = null;
            eigenvtr = null;
            eigenvtr_sbt = null;


            icount = 0;
            c = Ev.Eigenvlu1((MWNumericArray)mU_Sw_U);
            evl = new double[mU_Sw_U.GetLength(1)];
            D = (MWNumericArray)c;
            pA = D.ToVector(MWArrayComponent.Real);
            doubleArray1 = (double[])pA;
            for (int i = 0; i < mU_Sw_U.GetLength(0); i++)
            {
                for (int j = 0; j < mU_Sw_U.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        evl[j] = Math.Abs(doubleArray1[icount]);
                    }
                    icount++;
                }
            }

            c = Ev.Eigenvtr1((MWNumericArray)mU_Sw_U);
            evr = new double[mU_Sw_U.GetLength(0), mU_Sw_U.GetLength(1)];
            D = (MWNumericArray)c;
            pA = D.ToVector(MWArrayComponent.Real);
            doubleArray1 = (double[])pA;
            count = 0;
            for (int i = 0; i < (mU_Sw_U.GetLength(0)); i++)
            {
                for (int j = 0; j < (mU_Sw_U.GetLength(1)); j++)
                {

                    evr[j, i] = (doubleArray1[count]);
                    count++;
                }
            }
            tmp = new double[evl.GetLength(0)];
            Array.Sort(evl);
            index = new int[evl.GetLength(0)];

            for (int i = 0; i < evl.GetLength(0); i++)
            {
                index[i] = Array.IndexOf(evl, evl[i]);
                //tmp[i] = evl[evl.GetLength(0) - i-1];
            }
            //evl = (double[])tmp.Clone();
            eigenvtr = new double[evr.GetLength(0), evr.GetLength(1)];//U_Vec
            for (int i = 0; i < evr.GetLength(0); i++)
            {
                for (int j = 0; j < evr.GetLength(1); j++)
                {
                    eigenvtr[j, (int)index[i]] = evr[j, i];

                }

            }
            res = new double[nm.GetLength(0), eigenvtr.GetLength(1)];
            matrix_multiply(ref nm, ref eigenvtr, ref res);
            nm = null;
            A = new double[res.GetLength(1), res.GetLength(0)];
            transpose(ref res, ref A);
            res = null;
            evr = null;
            eigenvtr = null;

            D_w = new double[evl.GetLength(0)];

            for (int i = 0; i < D_w.GetLength(0); i++)
            {
                //D_w[i]=eta_sw+evl[i];
                D_w[i] = Math.Pow(eta_sw + evl[i], -(1.0 / 2.0));
            }
            res = new double[D_w.GetLength(0), D_w.GetLength(0)];
            for (int i = 0; i < D_w.GetLength(0); i++)
            {
                res[i, i] = D_w[i];
            }
            D_b = null;
            D_w = null;
            DFLD_Trans = new double[res.GetLength(0), A.GetLength(1)];
            matrix_multiply(ref res, ref A, ref DFLD_Trans);
            res = null;
            A = null;

            y = new double[DFLD_Trans.GetLength(0), mean_c.GetLength(1)];
            matrix_multiply(ref DFLD_Trans, ref mean_c, ref y);
            //int aaaa;
        }
        public static void matrix_multiply(ref  double[,] a, ref  double[,] b, ref double[,] c)
        {
            //string c2="";
            //string c1 = "";
            if (a.GetLength(1) == b.GetLength(0))
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        for (int k = 0; k < b.GetLength(0); k++)
                        {
                            c[i, j] = c[i, j] + a[i, k] * b[k, j];
                        }
                        //c1 = c1 + " " + c[i, j];
                    }
                    //c1 = c1 + '\n';
                }
            }
            else
            {
                MessageBox.Show("matrix multiplication not possible");
            }
            //MessageBox.Show(c1);
        }
        public static void transpose(ref double[,] a, ref double[,] b)
        {
            //string c1 = "";
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    b[i, j] = a[j, i];
                    //c1 = c1 + " " + b[i, j];

                }
                // c1 = c1 + '\n';
            }
            //MessageBox.Show("");

        }
        public double[,] return_Features()
        {
            return y;
        }
        public static void compute_ED(double[,] a, double[,] b)
        {
            eDist = new double[a.GetLength(1)];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    eDist[i] = eDist[i] + Math.Pow((a[j, i] - b[j, 0]), 2);
                }
                eDist[i] = Math.Sqrt(eDist[i]);
            }
        }
        public void write_xml()
        {
            string s1, s2;
            int i = 0, j = 0;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\r\n";
            XmlWriter xmlWriter = XmlWriter.Create("C:\\major\\XMLFeature.xml", settings);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("FaceRecognition");

            xmlWriter.WriteElementString("noOfSuspects", Convert.ToString(noOfSuspects));
            //xmlWriter.WriteString(Convert.ToString(noOfSuspects));
            //xmlWriter.WriteEndElement();


            xmlWriter.WriteElementString("noOfImages", Convert.ToString(noOfImages));
            //xmlWriter.WriteString(Convert.ToString(noOfImages));
            //xmlWriter.WriteEndElement();

            xmlWriter.WriteElementString("ImgHeight", Convert.ToString(height));
            //xmlWriter.WriteString(Convert.ToString(height));
            //xmlWriter.WriteEndElement();

            xmlWriter.WriteElementString("ImgWidth", Convert.ToString(width));
            //xmlWriter.WriteString(Convert.ToString(width));
            //xmlWriter.WriteEndElement();

            xmlWriter.WriteElementString("featuresX", Convert.ToString(y.GetLength(0)));
            //xmlWriter.WriteString(Convert.ToString(y.GetLength(0)));
            //xmlWriter.WriteEndElement();

            xmlWriter.WriteElementString("featuresY", Convert.ToString(y.GetLength(1)));
            //xmlWriter.WriteString(Convert.ToString(y.GetLength(1)));
            //xmlWriter.WriteEndElement();
            xmlWriter.WriteElementString("DFLDTransX", Convert.ToString(DFLD_Trans.GetLength(0)));
            //xmlWriter.WriteString(Convert.ToString(DFLD_Trans.GetLength(0)));
            // xmlWriter.WriteEndElement();

            xmlWriter.WriteElementString("DFLDTransY", Convert.ToString(DFLD_Trans.GetLength(1)));
            //xmlWriter.WriteString(Convert.ToString(DFLD_Trans.GetLength(1)));
            //xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Class");
            for (i = 0; i < noOfSuspects; i++)
            {
                xmlWriter.WriteElementString(string.Concat("c", Convert.ToString(i)), Convert.ToString(imagePerClass[i]));
                //xmlWriter.WriteString(Convert.ToString(imagePerClass[i]));
                //xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();





            xmlWriter.WriteStartElement("features");
            //while (true)
            {
                for (i = 0; i < y.GetLength(1); i++)
                {
                    for (j = 0; j < y.GetLength(0); j++)
                    {
                        s1 = Convert.ToString(i);
                        s2 = Convert.ToString(j);
                        string s3 = string.Concat(string.Concat(string.Concat("f", s1), "f"), s2);
                        xmlWriter.WriteElementString(s3, Convert.ToString(y[j, i]));
                        //WriteStartElement(string.Concat(string.Concat(string.Concat("f", s1),"f"),s2));
                        //xmlWriter.WriteElementString(string.Concat("f", s2), );
                        //xmlWriter.WriteEndElement();

                    }
                }
            }

            xmlWriter.WriteEndElement();



            xmlWriter.WriteStartElement("DFLDTrans");
            for (i = 0; i < DFLD_Trans.GetLength(0); i++)
            {
                s1 = Convert.ToString(i);
                xmlWriter.WriteStartElement(string.Concat("Dx", s1), "");
                for (j = 0; j < DFLD_Trans.GetLength(1); j++)
                {
                    s2 = Convert.ToString(j);
                    xmlWriter.WriteElementString(string.Concat("Dy", s2), Convert.ToString(DFLD_Trans[i, j]));
                    //xmlWriter.WriteString(Convert.ToString(DFLD_Trans[i, j]));
                    //xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            //xmlWriter.WriteEndDocument();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        public void read_xml()
        {
            XmlReader textreader = XmlReader.Create("C:\\major\\XMLfeature.xml");
            //textReader.Read();
            int i = 0, j = 0;
            string s1, s2;
            while (textreader.ReadToFollowing("FaceRecognition"))
            {

                textreader.ReadToFollowing("noOfSuspects");
                noOfSuspects = Convert.ToInt32(textreader.ReadInnerXml());



                textreader.ReadToFollowing("noOfImages");
                noOfImages = Convert.ToInt32(textreader.ReadInnerXml());
                //noOfImages = textreader.ReadElementContentAsInt();

                textreader.ReadToFollowing("ImgHeight");
                height = Convert.ToInt32(textreader.ReadInnerXml());



                textreader.ReadToFollowing("ImgWidth");
                width = Convert.ToInt32(textreader.ReadInnerXml());




                int fX, fY;
                textreader.ReadToFollowing("featuresX");
                fX = Convert.ToInt32(textreader.ReadInnerXml());


                textreader.ReadToFollowing("featuresY");
                fY = Convert.ToInt32(textreader.ReadInnerXml());

                int dX = 0, dY = 0;
                textreader.ReadToFollowing("DFLDTransX");
                dX = Convert.ToInt32(textreader.ReadInnerXml());


                textreader.ReadToFollowing("DFLDTransY");
                dY = Convert.ToInt32(textreader.ReadInnerXml());

                DFLD_Trans = new double[dX, dY];

                imagePerClass = new int[noOfSuspects];
                //while ()
                {
                    textreader.ReadToFollowing("Class");
                    while (i < imagePerClass.GetLength(0))
                    {
                        textreader.ReadToFollowing(string.Concat("c", i));
                        imagePerClass[i] = Convert.ToInt32(textreader.ReadInnerXml());
                        i++;
                    }
                }

                i = 0;




                y = new double[fX, fY];
                s1 = "p0";
                s2 = "f0";
                //while (textreader.ReadToFollowing("features"))
                {
                    textreader.ReadToFollowing("features");
                    i = 0; j = 0;
                    for (i = 0; i < y.GetLength(1); i++)
                    {
                        for (j = 0; j < y.GetLength(0); j++)
                        {
                            s1 = Convert.ToString(i);
                            s2 = Convert.ToString(j);
                            string s3 = string.Concat(string.Concat(string.Concat("f", s1), "f"), s2);
                            //while (textreader.ReadToFollowing(string.Concat(string.Concat(string.Concat("f", Convert.ToString(i))), "f"), Convert.ToString(j)))
                            {
                                textreader.ReadToFollowing(s3);
                                y[j, i] = Convert.ToDouble(textreader.ReadInnerXml());

                            }
                        }
                    }
                    //reader.ReadToFollowing(s1);
                    /*while (i<y.GetLength(1))
                     //while(textreader.ReadToFollowing(s1))
                     {
                         s1 = string.Concat("p", Convert.ToString(i));
                         textreader.ReadToFollowing(s1);
                        
                         while (j<y.GetLength(0))
                         {
                             textreader.ReadToFollowing(s2);
                             s2 = string.Concat("f", Convert.ToString(j));
                             y[j, i] = Convert.ToDouble(textreader.ReadElementString());
                             j++;
                         }
                        
                         j = 0;
                         i++;
                     }*/
                    i = 0;

                }
                i = 0; j = 0;

                //while (textreader.ReadToFollowing("DFLDTrans"))
                {
                    textreader.ReadToFollowing("DFLDTrans");

                    //reader.ReadToFollowing(s1);
                    //while (textreader.ReadToFollowing(s1))
                    {
                        for (i = 0; i < DFLD_Trans.GetLength(0); i++)
                        {
                            s1 = string.Concat("Dx", Convert.ToString(i));
                            textreader.ReadToFollowing(s1);
                            for (j = 0; j < DFLD_Trans.GetLength(1); j++)
                            {

                                s2 = string.Concat("Dy", Convert.ToString(j));
                                //while (textreader.ReadToFollowing(s2))
                                {
                                    textreader.ReadToFollowing(s2);
                                    DFLD_Trans[i, j] = Convert.ToDouble(textreader.ReadElementString());
                                    //j++;
                                }
                                //j = 0;
                                //i++;
                            }
                        }
                    }
                    textreader.Close();
                    i = 0;
                }
            }
        }
    }
}
