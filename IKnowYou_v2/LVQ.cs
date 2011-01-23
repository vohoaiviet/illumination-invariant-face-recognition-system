using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace IKnowYou_v2
{
    class LVQ
    {
        private int noOfKnownPatterns ;
        private int noOfUnknownPatterns ;
        private int totalNoOfPatterns ;
        private int netSizeVCT = 20;

        /***************************************
        * These are constants
        ***************************************/
        private const int MAXPATS =  100;
        private const int MAXNEURONSIN=50;
        private const int MAXNEURONS=15;
        private const int MAXEPOCHS=35000;
        private const double ETAMIN=.001;
        private const int RAND_MAX = 100;
        //**************************************
        private double[,] W=new double[MAXNEURONSIN,MAXNEURONS];  //The weight matrix
        private int[] zClass=new int[MAXNEURONS];           //Class assinment for each neuron
        private double[] Yout=new double[MAXNEURONS];             //The output layer neurons
        private double[]  Yin=new double[MAXNEURONSIN];            //The input layer neurons
        private int YinSize;                      //input layer dimensions
        private int     YoutSize;                     //outlayer dimensions (Must match NumClasses)

        private int     epoch;
        private double  eta;                          //The learning rate
        private double  delta_eta;                    //Amount to change l.r. each epoch
        private int     StochFlg;                     //Present vectors in rand order if 1
        PATTERN Pattern;

        public LVQ(int noOfKnPat,int noOfUnKnPat) {
            StochFlg = 0;
            noOfKnownPatterns = noOfKnPat;
            noOfUnknownPatterns = noOfUnKnPat;
            totalNoOfPatterns = noOfKnPat + noOfUnKnPat;
        }

        public void SetPattern(PATTERN p) {	//@Subodh: *p is pointer to the object of type TPATTERN. The object is passed by reference.
            Pattern=p;						//@Subodh: Pattern is pointer of type TPATTERN that is defined as private variable in class LVQ.
            YinSize=p.getSizeVector();			//@Subodh: YinSize is input layer dimension. This is also stored inside file.
									//			YinSize is of type LVQ.
        }

        public void SetParms(int X, double LR)
        {
            int i, k, m;
            YoutSize = X;  //This is No of output layer in the network.
            eta = LR;		//This is learning rate of the n/w. LR=0.2500 is passed from main
            delta_eta = 0.002;	//This is difference that is made with each epoch.
            for (i = 0; i < YoutSize; i++)
            {
                for (k = 0; k < YinSize; k++)
                {
                    Random r1 = new Random();                    
                    W[k,i] = (double)(r1.Next(RAND_MAX))/(10.0*(double)RAND_MAX);	//This is weight matrix required for training.
                    //IN this step, weights are randomly assigned.
                } /* endfor */
                //MessageBox.Show("" + Pattern.getNumClasses());
                m = YoutSize / Pattern.getNumClasses();// NumClasses is no of classes and the documentation above says
                // it must match with YoutSize.
                zClass[i] = i / m;				//Class assignment for each neurons
            } /* endfor */
        }

        private int LoadInLayer(int P){
                int i;
                for (i=0; i<YinSize; i++){
                if (StochFlg==1)
                {// if StochFlg==1 then presented vector is in random order.
                    Yin[i]=Pattern.QueryR(P,i);//Query in random    
                    
                }
                else 
                {
                    Yin[i]=Pattern.Query(P,i);//Pth pattern ko i th  column
                }
            }
            return 1;
        }

        private void AdaptParms()
        {
            eta = eta - delta_eta;
            if (eta == 0.002)
                MessageBox.Show("learning rate less to 0.002");
            if (eta < ETAMIN)
                eta = ETAMIN;
        }        

        public void RunTrn()
        {//This function trains the network.
            int pat, np;
            int k, z;
            int Winner;
            epoch = 0;
            np = Pattern.getNumPatterns();//np is no of patterns
            while (epoch <= MAXEPOCHS)            
            {// MAXEPOCHS=1500
                //if (eta > 0.02 && eta < 0.05)
                    //MessageBox.Show("wow");
                if ((epoch <= 50) || (25 * (epoch / 25) == epoch))
                {        //output control
                    //Console.Out.WriteLine("EPOCH="+epoch);
                    //Console.Out.WriteLine("eta="+ eta);
                }
                for (pat = 0; pat < np; pat++)
                {     //Traverse all patterns np is 8 because there are 8 types
                    LoadInLayer(pat);//pat_th row lai input layer ma load garcha.
                    Winner = FindWinner();
                    if ((epoch <= 50) || (25 * (epoch / 25) == epoch))
                    {        //output control
                        
                        //Console.Out.WriteLine("winner="+Convert.ToString(Winner)+"Pattern"+Convert.ToString(pat));
                        //Console.Out.WriteLine("winner class= "+Convert.ToString(zClass[Winner])+"Pattern Class="+ Convert.ToString(Pattern.QueryClass(pat)));
                    }
                    Train(Winner, pat);
                    if ((epoch <= 50) || (25 * (epoch / 25) == epoch))
                    {        //output control
                        //Console.Out.WriteLine("W["+Winner+"]=");
                        z = 1;
                        for (k = 0; k < YinSize; k++)
                        {
                            //Console.Out.WriteLine(""+W[k,Winner]);
                            if (z > 4)
                            {
                                //Console.Out.WriteLine(" ");
                                z = 1;
                            }
                            else
                                z++;
                        } /* endfor */
                        //Console.Out.WriteLine(" ");
                        //Console.Out.WriteLine(" ");
                    }
                }
                epoch++;                       //keep track of epochs
                if (StochFlg==1)                  // if desired
                    Pattern.ReShuffle(np);      //   reorder training patterns
                AdaptParms();                  //Adjust the learning rate
            }
        }

        public int Run()
        {
            int statusOfFace = 0;
            int pat, np, i;
            int Winner;
            //Console.Out.WriteLine("\n");
            np = Pattern.getNumPatterns();
            /*
            for (pat = 0; pat < np; pat++)
            {     //Traverse all patterns
                LoadInLayer(pat);//pat_th row lai input layer ma load garcha.
                Winner = FindWinner();
                MessageBox.Show("Responding neuron " + Winner + " is of class " + zClass[Winner]);
                MessageBox.Show("The desired class for pattern " + pat + " is: " + Pattern.QueryClass(pat));
                MessageBox.Show("The distances to each of the output layer neurons are:\n");
                for (i = 0; i < YoutSize; i++)
                {
                    MessageBox.Show("distance from pattern " + pat + " to neuron " + i + " is: " + EucNorm(i));
                    //Console.Out.WriteLine("distance from pattern " + pat+ " to neuron "+i+" is: "+ EucNorm(i));
                } // endfor 
                Console.Out.WriteLine("\n");
                
            }
             */
            //for (pat = 0; pat < np; pat++)
            //{
                LoadInLayer(0);//pat_th row lai input layer ma load garcha.
                Winner = FindWinner();
                double distanceKnown = EucNorm(0);
                double distanceUnknown = EucNorm(1);
                if (distanceKnown < distanceUnknown)
                {
                    //MessageBox.Show("Known");
                    statusOfFace = 1;
                }
                else
                {
                    //MessageBox.Show("Unknown");
                    statusOfFace = 0;
                }
            //}
                return statusOfFace;
        
        }

        private void Train(int Winner, int pat)
        {
            int c, k;
            c = Pattern.QueryClass(pat);
            if (c == zClass[Winner])
            {
                for (k = 0; k < YinSize; k++)
                {
                    W[k,Winner] = W[k,Winner] + eta * (Yin[k] - W[k,Winner]);
                } /*endfor*/
            }
            else
            {
                for (k = 0; k < YinSize; k++)
                {
                    W[k,Winner] = W[k,Winner] - eta * (Yin[k] - W[k,Winner]);
                } /*endfor*/
            } /* endif */
        }

        private int FindWinner()
        {
            int i;
            double d, best;
            int Winner;
            best = 1.0e99;
            Winner = -1;
            for (i = 0; i < YoutSize; i++)
            {
                d = EucNorm(i);
                if (d < best)
                {
                    best = d;
                    Winner = i;
                } // endif
            } // endfor
            return Winner;
        }

        private double EucNorm(int x)
        {   // Calc Euclidean norm of vector dif
            int i;
            double dist;
            dist = 0;
            for (i = 0; i < YinSize; i++)
            {
                dist += (W[i,x] - Yin[i]) * (W[i,x] - Yin[i]);
            } /* endfor */
            dist = Math.Sqrt(dist);
            return dist;
        }

        public void writeFeatureXML()
        {
            
            
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\r\n";
            System.Xml.XmlWriter xmlWriter = System.Xml.XmlWriter.Create("C:\\major\\ProjectedPatterns.xml", settings);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Pattens");
            /*
            for(int u=1;u<=5;u++)
            {
                xmlWriter.WriteElementString("TotalPatterns"+u, Convert.ToString(5));
            }
            xmlWriter.WriteElementString("TotalPatterns11", Convert.ToString(5));
            
            int[] patOfFace = new int[10];
            try
            {
                Bitmap faceToProject = (Bitmap)Image.FromFile("C:\\major\\knownfaces\\1.jpg");
                FaceRecognition.searchDetected_ic(faceToProject);
                int[] patttt = FaceRecognition.getEudPat();
                for (int u = 1; u <= 10; u++)
                {
                    xmlWriter.WriteElementString("TotalPatterns" + u, Convert.ToString(patttt[u - 1]));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             */
            
            
            //--------------------------------Known-----------------------------
            string faceFileLocationKnown = "C:\\major\\knownfaces\\";
            xmlWriter.WriteStartElement("KnownPatterns");
            for (int j = 1; j <= noOfKnownPatterns; j++)
            {
                string wrtStr = "KnownPattern" + Convert.ToString(j);
                xmlWriter.WriteStartElement(wrtStr);
                Bitmap faceToProject = (Bitmap)Image.FromFile(faceFileLocationKnown + "k" + j + ".jpg");

                //*********This will return first 10 minimum euclidian distances of the face stored in faceToProject****
                FaceRecognition.searchDetected_ic(faceToProject);
                int[] patOfFace = FaceRecognition.getEudPat();
                //*********

                //double[,] projectedFeatureRLDA = FaceRecognition.getRLdaFeatures(faceToProject);
                //for (int i = 0; i < projectedFeatureRLDA.GetLength(0); i++)
                //for (int i = 0; i < netSizeVCT; i++)//netSizeVCT is no of element in each pattern
                for (int i = 0; i < netSizeVCT; i++)//netSizeVCT is no of element in each pattern
                {
                    string s3 = "KnownPatternElement" + i;
                    string feature = Convert.ToString(patOfFace[i]);
                    xmlWriter.WriteElementString(s3, feature);
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            //---------------------------------------------------------------------
            


            
            //--------------------------------Unknown-----------------------------
            string faceFileLocationUnknown = "C:\\major\\unknownfaces\\";
            xmlWriter.WriteStartElement("UnknownPatterns");
            for (int j = 1; j <= noOfUnknownPatterns; j++)
            {
                string wrtStr = "UnknownPattern" + Convert.ToString(j);
                xmlWriter.WriteStartElement(wrtStr);
                Bitmap faceToProject = (Bitmap)Image.FromFile(faceFileLocationUnknown + "NiD (" + j + ").jpg");

                //*********This will return first 10 minimum euclidian distances of the face stored in faceToProject****
                FaceRecognition.searchDetected_ic(faceToProject);
                int[] patOfFace = FaceRecognition.getEudPat();
                //*********

                //double[,] projectedFeatureRLDA = FaceRecognition.getRLdaFeatures(faceToProject);
                //for (int i = 0; i < projectedFeatureRLDA.GetLength(0); i++)
                for (int i = 0; i < netSizeVCT; i++)
                {
                    string s3 = "UnknownPatternElement" + i;
                    string feature = Convert.ToString(patOfFace[i]);
                    xmlWriter.WriteElementString(s3, feature);
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            //---------------------------------------------------------------------
            

            xmlWriter.WriteEndElement();

            
            
            xmlWriter.Close();
        }


        public double[,] readFeatureXML()
        {
            XmlReader textreader = XmlReader.Create("C:\\major\\ProjectedPatterns.xml");
            double[,] inputLayerFeatures = new double[totalNoOfPatterns, netSizeVCT];

            textreader.ReadToFollowing("KnownPatterns");
            for (int i = 1; i <= noOfKnownPatterns; i++)
            {
                string s1 = "KnownPattern" + Convert.ToString(i);
                textreader.ReadToFollowing(s1);
                for (int j = 0; j < netSizeVCT; j++)
                {
                    string s2 = "KnownPatternElement" + Convert.ToString(j);
                    textreader.ReadToFollowing(s2);
                    inputLayerFeatures[i-1, j] = Convert.ToDouble(textreader.ReadInnerXml());
                }
            }


            textreader.ReadToFollowing("UnknownPatterns");
            for (int i = (noOfKnownPatterns+1); i <=totalNoOfPatterns; i++)
            {
                string s1 = "UnknownPattern" + Convert.ToString(i - noOfKnownPatterns);
                textreader.ReadToFollowing(s1);
                for (int j = 0; j < netSizeVCT; j++)
                {
                    string s2 = "UnknownPatternElement" + Convert.ToString(j);
                    textreader.ReadToFollowing(s2);
                    inputLayerFeatures[i-1, j] = Convert.ToDouble(textreader.ReadInnerXml());
                }
            }
            //textreader = XmlReader.Create("C:\\major\\ProjectedPatterns.xml");
            
            return inputLayerFeatures;
        }


    }
}
