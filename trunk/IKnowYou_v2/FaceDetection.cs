using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV;
using System.Diagnostics;

namespace IKnowYou_v2
{
    class FaceDetection
    {
        //private static HaarCascade face = new HaarCascade("C:\\major\\haarcascade_frontalface_alt_tree.xml");
        private static HaarCascade face = new HaarCascade("C:\\major\\haarcascade_frontalface_alt_tree.xml");
        private static int noOfFaces = 0;
        private static Rectangle faceRectEmgu01 = new Rectangle();
        private static Rectangle faceRectEmgu02 = new Rectangle();
        private static Rectangle faceRectEmgu03 = new Rectangle();
        private static Rectangle faceRectEmgu04 = new Rectangle();
        public static int scaleFactor = 4;
        private static int countfaces = 0;
        private static string[] faceName=new string[4];
        private static Rectangle []drwFaceRect = new Rectangle[4];
        

        public static Bitmap Run(Bitmap rawFrame)
        {
            //int scaleFactor = 4;
            Bitmap fDetectedFrames;
            Bitmap scaledFrames = new Bitmap(rawFrame, new Size(160, 120));            
            Image<Bgr, Byte> image = null;            
            if (rawFrame != null)
                image = new Image<Bgr, byte>(scaledFrames); //Read the files as an 8-bit Bgr image  
            Image<Gray, Byte> gray = image.Convert<Gray, Byte>(); //Convert it to Grayscale
            Stopwatch watch = Stopwatch.StartNew();            
            gray._EqualizeHist();                       
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
               face,
               1.1,
               10,
               Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
               new Size(20, 20));            
            image = new Image<Bgr, byte>(rawFrame);
            //noOfFaces = facesDetected.Count(); 
            //noOfFaces = facesDetected.Length;
            countfaces = 0;
            foreach (MCvAvgComp f in facesDetected[0])
            {
                if (countfaces == 0)
                {
                    faceRectEmgu01.X = f.rect.Left * scaleFactor;
                    faceRectEmgu01.Y = f.rect.Top * scaleFactor;
                    faceRectEmgu01.Height = f.rect.Height * scaleFactor;
                    faceRectEmgu01.Width = f.rect.Width * scaleFactor;
                }
                if (countfaces == 1)
                {
                    faceRectEmgu02.X = f.rect.Left * scaleFactor;
                    faceRectEmgu02.Y = f.rect.Top * scaleFactor;
                    faceRectEmgu02.Height = f.rect.Height * scaleFactor;
                    faceRectEmgu02.Width = f.rect.Width * scaleFactor;
                }
                if (countfaces == 2)
                {
                    faceRectEmgu03.X = f.rect.Left * scaleFactor;
                    faceRectEmgu03.Y = f.rect.Top * scaleFactor;
                    faceRectEmgu03.Height = f.rect.Height * scaleFactor;
                    faceRectEmgu03.Width = f.rect.Width * scaleFactor;
                }
                if (countfaces == 3)
                {
                    faceRectEmgu04.X = f.rect.Left * scaleFactor;
                    faceRectEmgu04.Y = f.rect.Top * scaleFactor;
                    faceRectEmgu04.Height = f.rect.Height * scaleFactor;
                    faceRectEmgu04.Width = f.rect.Width * scaleFactor;
                }
                Rectangle dFRect = new Rectangle(f.rect.Left * scaleFactor, f.rect.Top * scaleFactor, f.rect.Width * scaleFactor, f.rect.Height * scaleFactor);
                image.Draw(dFRect, new Bgr(Color.Gold), 2);                
                MCvFont f1 = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 1, 1);
                //for (int i = 0; i < 4; i++)
                {
                    if(faceName[0]!=null)
                        image.Draw(faceName[0], ref f1, Point.Round(new PointF((float)drwFaceRect[0].Left, (float)(drwFaceRect[0].Top - 10))), new Bgr(0, 0, 255));
                    if (faceName[1] != null)
                        image.Draw(faceName[1], ref f1, Point.Round(new PointF((float)drwFaceRect[1].Left, (float)(drwFaceRect[1].Top - 10))), new Bgr(0, 0, 255));
                    if (faceName[2] != null)
                        image.Draw(faceName[2], ref f1, Point.Round(new PointF((float)drwFaceRect[2].Left, (float)(drwFaceRect[2].Top - 10))), new Bgr(0, 0, 255));
                    if (faceName[3] != null)
                        image.Draw(faceName[3], ref f1, Point.Round(new PointF((float)drwFaceRect[3].Left, (float)(drwFaceRect[3].Top - 10))), new Bgr(0, 0, 255));

                }
                gray.ROI = f.rect;                
                gray.ROI = Rectangle.Empty;
                countfaces++;
            }
            /*
            for (int i = 0; i < facesDetected.Length; i++)
            {
                facesDetected.ElementAt(i);
            }
             */
            noOfFaces = countfaces;
            watch.Stop();
            fDetectedFrames = image.ToBitmap();
            return fDetectedFrames;
        }
        public static void setName(string name,Rectangle rectFac,int index)
        {
            faceName[index] = name;
            drwFaceRect[index] = rectFac;
        }
        public static Rectangle getFaceRect01()
        {
            return faceRectEmgu01;
        }
        public static Rectangle getFaceRect02()
        {
            return faceRectEmgu02;
        }
        public static Rectangle getFaceRect03()
        {
            return faceRectEmgu03;
        }
        public static Rectangle getFaceRect04()
        {
            return faceRectEmgu04;
        }
        public static int getNoOfFaces()
        {
            return noOfFaces;
        }
        public static Bitmap getCroppedFace(Bitmap rawFrame,Rectangle faceRect)
        {
            int newFHeight = ((faceRect.Width) / 3) * 4;
            int gap = newFHeight - faceRect.Height;
            int top = 0;            
            if ((faceRect.Top - (gap / 2)) > 0)
                top = faceRect.Top - (gap / 2);
            if ((faceRect.Top - (gap / 2) + newFHeight) > 480)
                top = faceRect.Top - gap;

            Rectangle face4isto3 = new Rectangle(faceRect.Left, top, faceRect.Width, newFHeight);
            Bitmap cFace = null;
            try
            {
                if (rawFrame != null)
                {
                    Bitmap face_rgb = ImageProcessingUtilities.Resize((ImageProcessingUtilities.Crop(rawFrame, face4isto3)), 76, 101);
                    //note: calling other grayscale convertion function causes recognition algorithm to stop working
                    //      So we call emguCV inbuild grayscale convertion function in ImageProcessingUtilities class
                    //cFace =ImageProcessingUtilities.norm_rgb(ImageProcessingUtilities.emguCVconvert2Grayscale(face_rgb));
                    //cFace = face_rgb;
                    cFace = ImageProcessingUtilities.emguCVconvert2Grayscale(face_rgb);
                   
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return cFace;
        }
    }
}
