using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IKnowYou_v2
{
    class PATTERN
    {
        /***************************************
        * These are constants
        ***************************************/
        private const int MAXPATS =  100;
        private const int MAXNEURONSIN=50;
        private const int MAXNEURONS=15;
        private const int MAXEPOCHS=1500;
        private const double ETAMIN=.001;
        //**************************************
        
        private double[,]  P=new double [MAXPATS,MAXNEURONSIN];	//@Subodh: Maxneyrosin is no of elements along the column. i.e. elements of pattern
        private int[] PClass=new int[MAXPATS];			//@Subodh: PClass is C vector in matlab file. This vector will store the targeted output of the n/w.
        private int NumPatterns;
        private int NumClasses;
        private int[] Shuffle=new int[MAXPATS];
        private int SizeVector;
        private const int RAND_MAX = 100;
        public int getSizeVector()
        {
            return SizeVector;
        }

        public int getNumPatterns()
        {
            return NumPatterns;
        }

        public int getNumClasses()
        {
            return NumClasses;
        }
        public PATTERN() { }

        public int GetPatterns(int noPatterns,int sizVct,int noClasses,double[,] tP,int[] pClas)//If DetPattern is 0 then input pattern else if 1 then test pattern
        {
            NumPatterns = noPatterns;
            //MessageBox.Show("Num Patterns:" + NumPatterns);
            SizeVector = sizVct;
            NumClasses = noClasses;
            //MessageBox.Show("Num Classes:" + NumClasses);
            /*
            for (i = 0; i < NumPatterns; i++)
            {         // For each vector
                for (j = 0; j < SizeVector; j++)
                {       // create a pattern
                                  // consisting of all elements
                    P[i][j] = x;
                } 
                
                PClass[i] = k;							//@Subodh: This k is like C vector in matlab file. This vector stores output pattern
            }
             */
            P = tP;
            PClass = pClas;
            return 1;

            
        }
        public void ReShuffle(int N) 
        {
            int i,a1,a2,tmp;
            for (i=0; i<N ;i++) {
                a1=Randomizer(NumPatterns);
                a2 = Randomizer(NumPatterns);
                tmp=Shuffle[a1];
                Shuffle[a1]=Shuffle[a2];
                Shuffle[a2]=tmp;
            }
        }

        public double Query(int pat, int j)
        {
            return P[pat,j];
        }

        public double QueryR(int pat, int j)
        {
            return P[Shuffle[pat],j];
        }

        public int QueryClass(int pat) {
            return PClass[pat];
        }

        public static int Randomizer(int N)
        {
            Random r = new Random();
            int genRanNo = (N * r.Next(RAND_MAX)) / RAND_MAX;
            if (genRanNo >= N) genRanNo = N;
            return genRanNo;
        }
    }
}
