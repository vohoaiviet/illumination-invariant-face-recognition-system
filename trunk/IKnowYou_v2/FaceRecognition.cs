using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace IKnowYou_v2
{
    class FaceRecognition
    {
        private static int noOfKnownPatterns ;
        private static int noOfUnknownPatterns ;
        private static int totalNoOfPatterns = noOfKnownPatterns + noOfUnknownPatterns;

        private static int netSizeVCT = 20;
        private static RLda r = new RLda(0, 0);
        private static ICA ic = new ICA(76, 101, 0, 0);
        private static PATTERN InPat = new PATTERN();//@Subodh: PATTERN is class and InPat is an object
        private static PATTERN InPat2 = new PATTERN();
        private static LVQ net;	   //@Subodh: LVQ is class and "net" is an object.
        //private static RLda r =null;
        //private static ICA ic =null;

        //private static RLda r =null;
        //private static ICA ic =null;

        private static double[,] y;
        private static bool i_loadedOrNot = false;
        private static bool i_loadedOrNot_ic = false;
        //private static LoadingXML frmLoading = new LoadingXML();
        private static int[] eudPat = new int[netSizeVCT];



        /***************************************
        * These are constants
        ***************************************/
        private const int MAXPATS = 100;
        private const int MAXNEURONSIN = 50;
        private const int MAXNEURONS = 15;
        private const int MAXEPOCHS = 1500;
        private const double ETAMIN = .001;
        private const int RAND_MAX = 100;
        //**************************************



        public static int searchDetected(Bitmap face)
        {
            string filePath = null;
            int i = -1;
            try
            {
                int t = 0;
                
                t = Environment.TickCount;
                
                if (i_loadedOrNot == false)
                {                    
                    r.read_xml();
                    i_loadedOrNot = true;                                                         
                }                
                r.readImage(face);
                i = r.isearch() * 10 + 1;
                if (i != -1)
                {
                    filePath = "C:\\major\\" + i + ".jpg";
                    //MessageBox.Show("Total processing time of slow grayscale conversion: " + ((int)(Environment.TickCount - t)).ToString() + " miliseconds.");
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                //MessageBox.Show(ex.Message);
                //throw;
            }
            return i;
        }

        public static void writeEudPat(int[] pat)//will be called by ICA class
        {
            eudPat = pat;
        }

        public static int[] getEudPat()//will be called from anywhere
        {
            return eudPat;
        }

        public static double[,] getRLdaFeatures(Bitmap face)
        {
            //string filePath = null;
            double[,] retRLdaFeatures = null;
            int i = -1;
            try
            {
                int t = 0;

                t = Environment.TickCount;

                if (i_loadedOrNot == false)
                {
                    r.read_xml();
                    i_loadedOrNot = true;
                }
                retRLdaFeatures = r.readImage(face);                
                                
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                //MessageBox.Show(ex.Message);
                //throw;
            }
            return retRLdaFeatures;
        }
        public static void initialize()
        {
            int totalPersons = DatabaseManager.GetUserCount();
            //MessageBox.Show("" + totalPersons);
            r = new RLda(totalPersons * 10, totalPersons);
            ic = new ICA(76, 101, totalPersons * 10, totalPersons * 10);
            net = new LVQ(totalPersons, totalPersons);
            noOfKnownPatterns = totalPersons;
            noOfUnknownPatterns = totalPersons;
            totalNoOfPatterns = totalPersons * 2;
            //MessageBox.Show("Constructor called");
        }
        public static int searchDetected_ic(Bitmap face)
        {
            string filePath = null;
            int indel = -1;
            try
            {
                int t = 0;
                
                t = Environment.TickCount;
                if (i_loadedOrNot_ic == false)
                {
                    //MessageBox.Show("Loading Fearures");
                    ic.XMLR();
                    i_loadedOrNot_ic = true;                                        
                }
                indel=ic.recogn(face);
                //indel = ic.recogn(face);
                if (indel != -1)
                {
                    filePath = "C:\\major\\" + indel + ".jpg";
                    //MessageBox.Show("Total processing time of slow grayscale conversion: " + ((int)(Environment.TickCount - t)).ToString() + " miliseconds.");
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                //MessageBox.Show(ex.Message);
                //throw;
            }
            return indel;
        }
        public static void trainRecognitionSystem()
        {           
            r.readImages();
            r.intialize_each_class();
            r.calc_mean();
            r.class_mean();
            r.execute();
            y = (double[,])r.return_Features().Clone();
            r.write_xml();
            i_loadedOrNot = true;
            
            ic.imreadall();
            ic.pca();
            ic.XMLW();
            i_loadedOrNot_ic = true;
            /* This statement will project all the known faces into PCA face space and write the first N min eud distances into XML */
            net.writeFeatureXML();

        }
        public static void loadTestPattern(int[] ProjectedPattern)
        {
            int noPatternsTest = 1;
            int sizVctTest = netSizeVCT;
            int noClassesTest = 2;



            double[,] PMainTest = new double[MAXPATS, MAXNEURONSIN];
            int[] PClassMainTest = new int[MAXPATS];
            //{k}           
            //{u}
            //{u}
            //{k}
            //{u}



            /* These were for the sample patterns. These are the pa
            PMainTest = new double[,]{{-23.822354, 5.568767,3.366701 ,-5.918748 ,-0.149950 ,-1.964589},                                                
                        
                        {-27.851184  , -2.204501,5.308936 ,-1.622889  ,2.583660,2.661420 },
                        
                        { -22.297961 ,-11.698899 , 3.169333, -3.255060 ,3.125650,2.841822},

                        { -26.272963, 10.087778, 1.886150 ,0.830147 ,-4.468987 , 1.192726},

                        { -27.851184 , -2.204501,5.308936 , -1.622889 ,2.583660, 2.661420}

                        };

            PClassMainTest = new int[] { 0, 0, 1, 1, 1 };
             */


            PMainTest = new double[1, netSizeVCT];
            //for (int m = 0; m < ProjectedPattern.GetLength(0); m++)

            for (int m = 0; m < netSizeVCT; m++)
            {
                PMainTest[0, m] =Convert.ToDouble(ProjectedPattern[m]);
            }

            PClassMainTest = new int[] { 0 };

            //-----------------------------------------------

            
            InPat2.GetPatterns(noPatternsTest, sizVctTest, noClassesTest, PMainTest, PClassMainTest);
            net.SetPattern(InPat2);
        }
        public static void loadNetwork()
        {
            //-----------------------------------------------
            double[,] PMain = new double[MAXPATS, MAXNEURONSIN];

            int[] PClassMain = new int[MAXPATS];


            //int totalNoOfPatterns = 15;
            int sizVct = netSizeVCT;
            int noClasses = 2;









            //First 10 patterns are for known face and later 5 are for unknown faces

            /*
            PMain = new double[,]{{-34.343893,8.094488 , 3.968100, 3.045380, -7.269270, 1.443817 },
                        
                                {-31.059496,7.242294 , 5.421005,4.110571 ,-3.988898 , 2.907260},
                                                                                                                                                                                                                                                                                                                                                    
                                {-31.561112,8.548724 ,8.567595 , 6.621193,-1.306165 ,2.271074  },
                                
                                {-34.689996,5.689937 ,5.254726  ,5.033862 , -3.955592, 1.439173},
                                
                                { -26.738242,7.655457 ,-1.150949 ,0.125031 ,-1.154293 ,0.457124},
                                
                                { -28.391232,5.648331 ,-6.961994 ,3.455556 , -0.605938,-2.826946},
                                
                                { -29.122389, 8.408293, -0.345115, -5.241427 ,-0.884164 ,-0.797609},
                                
                                {-29.617417 , 5.759380,-2.683569 , -0.284353, -2.470025,-3.619862},

                                {-27.496802 ,-2.412461 , -2.511118, -3.616672, -1.554588 ,1.038868},

                                { -28.702483, 9.889178, -12.715754,4.955846 , -6.532904, 3.333166},
                                           
                                { -29.797715,-9.787343 ,-0.562956 ,  -5.747552,-0.005083 ,-0.763473},

                                {-30.848025  , -5.985676,5.408539 , -3.647051, 2.881709 ,1.137439},

                                { -29.797715, -9.787343, -0.562956,  -5.747552,-0.005083 ,-0.763473},

                                { -29.496174, 0.114694, -4.809610, -6.867701, 3.702615,-4.079926},

                                { -30.848025,-5.985676 , 5.408539,-3.647051 ,2.881709 ,1.137439}};

            PClassMain = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };
             */




            PMain = net.readFeatureXML();
            PClassMain = new int[totalNoOfPatterns];




            for (int i = 0; i < noOfKnownPatterns; i++)
            {
                PClassMain[i] = 0;
            }

            for (int i = 0; i < noOfUnknownPatterns; i++)
            {
                PClassMain[i + noOfKnownPatterns] = 1;
            }





            //if (PMain == null)
            //Console.Out.WriteLine("null");

            //MessageBox.Show("no of patterns:" + totalNoOfPatterns);
            InPat.GetPatterns(totalNoOfPatterns, sizVct, noClasses, PMain, PClassMain);

            net.SetPattern(InPat);
            //net.SetParms(2, 0.2500);
            net.SetParms(2, 0.100);
        }
        public static void trainNetwork()
        {
            net.RunTrn();
        }

        public static int runNetwork()
        {
            int statusOfFace=net.Run();
            return statusOfFace;
        }
    }
}
