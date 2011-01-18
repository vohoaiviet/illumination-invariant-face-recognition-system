using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IKnowYou_v2
{
    class Sorter
    {
        private const int netSizeVCT = 20;
        private static int[] sPattern = new int[netSizeVCT];
        public static void BubbleSort(double[,] a)
        {
            for (int pass = 1; pass < a.GetLength(1); pass++)
            {
                for (int i = 0; i < (a.GetLength(1) - 1); i++)
                {
                    if (a[0,i] > a[0,i + 1])
                    {
                        int temp =Convert.ToInt32(a[0,i]);
                        a[0,i] = a[0,i + 1];
                        a[0,i + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < netSizeVCT; i++)
            {
                sPattern[i] = Convert.ToInt32(a[0,i]);
            }
        }
        public static int[] getSortedPatterns()
        {
            return sPattern;
        }
    }
}
