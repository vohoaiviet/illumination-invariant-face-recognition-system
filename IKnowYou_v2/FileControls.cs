using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IKnowYou_v2
{
    public partial class FileControls : Form
    {
        //public static string filename = null;
        public static string oFilename = null;
        public static string sFilename = null;
        public FileControls()
        {
            InitializeComponent();
        }
        public Bitmap openFile()
        {
            Bitmap rawFrame=null;
            oFileDialog.FileName = oFilename;
            oFileDialog.CheckFileExists = true;
            oFileDialog.CheckPathExists = true;
            oFileDialog.Title = "Face Recognition";
            oFileDialog.ValidateNames = true;
            oFileDialog.Filter = "jpg files(*.jpg)|*.jpg|Windows Bitmap(*.bmp)|*.BMP";
            if (oFileDialog.ShowDialog() == DialogResult.OK)
                rawFrame = (Bitmap)(Image.FromFile(oFileDialog.FileName));
            oFilename = oFileDialog.FileName;
            return rawFrame;
        }
        public void saveFile(Bitmap saveBitmapItem)
        {
            sFileDialog.FileName = sFilename;
            sFileDialog.Title="Save Face";
            sFileDialog.Filter="jpg files(*.jpg)|*.jpg|Windows Bitmap(*.bmp)|*.BMP";
            sFileDialog.OverwritePrompt = true;
            sFileDialog.CheckPathExists = true;
            if (sFileDialog.ShowDialog() == DialogResult.OK)
            {
                sFilename=sFileDialog.FileName;
                saveBitmapItem.Save(sFilename,System.Drawing.Imaging.ImageFormat.Jpeg);                
                //saveBitmapItem.Save(sFilename);
            }
        }
    }
}
