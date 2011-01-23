using System;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV;
using System.Diagnostics;

namespace IKnowYou_v2
{
    class ImageProcessingUtilities
    {
        public static Bitmap Crop(Bitmap originalFrame,Rectangle croppedArea)
        {            
            Bitmap croppedBitmap = originalFrame.Clone(croppedArea, originalFrame.PixelFormat);
            return croppedBitmap;
        }
        public static Bitmap Resize(Bitmap originalFrame, int width,int height)
        {
            return(new Bitmap(originalFrame,new Size(width,height)));
        }
        public static Bitmap emguCVconvert2Grayscale(Bitmap originalImage)
        {
            //Bitmap convertedImg=
            Image<Bgr, Byte> image = new Image<Bgr,byte>(originalImage);
            Image<Gray, Byte> gray = image.Convert<Gray, Byte>();
            Bitmap convertedImg = gray.ToBitmap();
            return convertedImg;
        }
        public static Bitmap convert2GrayScale(Bitmap originalImage)
        {
            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    Color curColor = originalImage.GetPixel(i, j);
                    int ret = (curColor.R + curColor.G + curColor.B) / 3;
                    originalImage.SetPixel(i, j,
                    Color.FromArgb(ret, ret, ret));
                }
            }
            return originalImage;
        }
        public static void hist_equalize(Bitmap img)
        {
            //Bitmap bimg = (Bitmap)pictureBox1.Image;
            Bitmap tbmp = (Bitmap)(Image)img.Clone();
            ulong[] histR = new ulong[256];
            ulong[] histG = new ulong[256];
            ulong[] histB = new ulong[256];
            ulong[] shistR = new ulong[256];
            ulong[] shistG = new ulong[256];
            ulong[] shistB = new ulong[256];
            ulong sumr = 0, sumg = 0, sumb = 0;
            float scalefactor = (float)255 / (float)(img.Width * img.Height);

            for (int i = 0; i < 256; i++)
            {
                histR[i] = 0;
                histG[i] = 0;
                histB[i] = 0;
            }


            BitmapData bmData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, img.PixelFormat);
            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                int stopAddress = (int)p + bmData.Stride * bmData.Height;
                while ((int)p != stopAddress)
                {
                    // if (i==3) continue;
                    if (img.PixelFormat == PixelFormat.Format8bppIndexed)
                    {
                        histR[p[0]]++; ;

                        p++;
                    }
                    else if (img.PixelFormat == PixelFormat.Format24bppRgb)
                    {
                        histR[p[0]]++;
                        histG[p[1]]++;
                        histB[p[2]]++;
                        p = p + 3;
                    }
                    else
                    {
                        tbmp = MakeGrayscale3(img);

                    }


                }
                p = null;

            }
            img.UnlockBits(bmData);
            if (img.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                hist_equalize(img);
            }




            for (int i = 0; i < 256; i++)
            {
                if (PixelFormat.Format8bppIndexed == img.PixelFormat || PixelFormat.Format24bppRgb == img.PixelFormat)
                {
                    sumr += histR[i];
                    shistR[i] = (ulong)(sumr * scalefactor) + (ulong)0.5;
                    if (img.PixelFormat == PixelFormat.Format24bppRgb)
                    {
                        sumg += histG[i];

                        shistG[i] = (ulong)(sumg * scalefactor) + (ulong)0.5;
                        sumb += histB[i];
                        shistB[i] = (ulong)(sumb * scalefactor) + (ulong)0.5;
                    }
                }
            }


            if (img.PixelFormat == PixelFormat.Format8bppIndexed)
            //tbmp.SetPixel(i, j, Color.FromArgb((int)shistR[bimg.GetPixel(i, j).R], (int)shistG[bimg.GetPixel(i, j).G], (int)shistB[bimg.GetPixel(i, j).B]));
            {
                BitmapData jbmData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, img.PixelFormat);
                BitmapData ibmData = tbmp.LockBits(new Rectangle(0, 0, tbmp.Width, tbmp.Height), ImageLockMode.ReadWrite, tbmp.PixelFormat);
                unsafe
                {
                    byte* p = (byte*)(void*)jbmData.Scan0.ToPointer();
                    byte* q = (byte*)(void*)ibmData.Scan0.ToPointer();
                    int stopAddress = (int)p + jbmData.Stride * jbmData.Height;
                    while ((int)p != stopAddress)
                    {
                        // if (i==3) continue;
                        p[0] = (byte)shistR[q[0]];

                        p++;
                        q++;


                    }
                    p = null;

                }
                img.UnlockBits(jbmData);
                tbmp.UnlockBits(ibmData);


            }
            else if (img.PixelFormat == PixelFormat.Format24bppRgb)
            {
                BitmapData jbmData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, img.PixelFormat);
                BitmapData ibmData = tbmp.LockBits(new Rectangle(0, 0, tbmp.Width, tbmp.Height), ImageLockMode.ReadWrite, tbmp.PixelFormat);
                unsafe
                {
                    byte* p = (byte*)(void*)jbmData.Scan0.ToPointer();
                    byte* q = (byte*)(void*)ibmData.Scan0.ToPointer();
                    int stopAddress = (int)p + jbmData.Stride * jbmData.Height;
                    while ((int)p != stopAddress)
                    {
                        // if (i==3) continue;
                        p[0] = (byte)shistR[q[0]];
                        p[1] = (byte)shistG[q[1]];
                        p[2] = (byte)shistB[q[2]];

                        p = p + 3;
                        q = q + 3;


                    }
                    p = null;
                    q = null;

                }
                img.UnlockBits(jbmData);
                tbmp.UnlockBits(ibmData);

            }




        }
        public static Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][] 
                      {
                         new float[] {.3f, .3f, .3f, 0, 0},
                         new float[] {.59f, .59f, .59f, 0, 0},
                         new float[] {.11f, .11f, .11f, 0, 0},
                         new float[] {0, 0, 0, 1, 0},
                         new float[] {0, 0, 0, 0, 1}
                      });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }
        public static Bitmap norm_rgb(Bitmap org)
        {
            Bitmap bmp=new Bitmap(org.Width,org.Height);
            for (int j = 0; j < org.Height; j++)
            {
                for (int i = 0; i < org.Width; i++)
                {
                    //curBitmap.SetPixel(i, j, Color.Red);
                    Color teColor = org.GetPixel(i, j);


                    //double Y = Convert.ToInt32(0.257 * (float)teColor.R + 0.504 * (float)teColor.G + 0.098 * (float)teColor.B);
                    //double cb = 0.148 * (float)teColor.R - 0.291 * (float)teColor.G + 0.439 * (float)teColor.B + 128;
                    //double Crb = 0.439 * (float)teColor.R - 0.368 * (float)teColor.G + 0.071 * (float)teColor.B + 128;

                    //----------------------Normalized RGB method;
                    int R, G, B;
                    double r, g, b, Wr, Yi, I, Q, V, U, ch, th;
                    Color c = org.GetPixel(i, j);
                    R = c.R;
                    G = c.G;
                    B = c.B;

                    //Yi = 0.2990 * R + 0.5870 * G + 0.1440 * B;
                    //U = -0.1471 * R - 0.2888 * G + 0.4359 * B;
                    //V = 0.6148 * R - 0.5148 * G - 0.1 * B;
                    //I = 0.5957 * R - 0.2745 * G - 0.3213 * B;
                    //Q = 0.2115 * R - 0.5226 * G + 0.3111 * B;
                    ///ch = Math.Sqrt(U * U + V * V);
                    //th = Math.Atan(Math.Abs(V) / Math.Abs(U)) * 180.0 / Math.PI;
                    //normalized rgb
                    r = ((((double)R / (double)(R + G + B))))*(double)255;

                    g = (((double)G / (double)(R + G + B))) * (double)255;

                    b = ((((double)B / (double)(R + G + B)))) * (double)255;
                    bmp.SetPixel(i, j, (Color.FromArgb((int)r, (int)g, (int)b)));

                    //Wr = (r - 0.33) * (r - 0.33) + (g - 0.33) * (g - 0.33);
                    //algorithm 1;
                    // g1.DrawImage(capBitmapForDetection, 460, 320, capBitmapForDetection.Width, capBitmapForDetection.Height);
                   
                        //locateFace();
                    }






                }
             return bmp;
            }

        }
    }

