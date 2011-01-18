//*******************************************************************************
//
//***********Major Project: "I Know You v1.2"(the face recognition system)************
//
//***********Group Members:1.Ram Krisna Gubaju (063/BCT/527)*********************
//*************************2.Subodh Shakya     (063/BCT/539)*********************
//*************************3.Swastik Singh     (063/BCT/546)*********************
//
//*******************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Xml;


namespace IKnowYou_v2
{
    public partial class IKYv2FormMain : Form
    {
        //Variables related to database
        
        private static int selected = 1;
        private static BindingSource bsIKYMain = new BindingSource();        
        private static bool bindingOn = false;
        private static DataSet dsIKYMain = new DataSet();
        private static SqlDataAdapter daIKYMain = new SqlDataAdapter();

        private static int totalPersons = 0;


        //-------------------------------------------------------------------------------------------------------


        //********************Variables for LVQ ***************************************
        private const int MAXPATS = 100;
        private const int MAXNEURONSIN = 50;
        private const int MAXNEURONS = 15;
        private const int MAXEPOCHS = 1500;
        private const double ETAMIN = .001;
        private const int RAND_MAX = 100;
        //*****************************************************************************

        const int workingFrameWidth = 640;
        const int workingFrameHeight = 480;
        private static Bitmap rawFrame;//this rawFrame is Bitmap object that stores the frames from webcam.        
        private static Bitmap fDetectedFrames;
        private static Bitmap face01 = null;        
        private static Rectangle faceRect01 = new Rectangle();
        private static Bitmap face02 = null;
        private static Rectangle faceRect02 = new Rectangle();
        private static Bitmap face03 = null;
        private static Rectangle faceRect03 = new Rectangle();
        private static Bitmap face04 = null;
        private static Rectangle faceRect04 = new Rectangle();
        private static int nosFaces = 0;
        private Capture cap;
        private static int face01ID;
        private static int face02ID;
        private static int face03ID;
        private static int face04ID;

        //-----------Database info---
        private static string dBName;
        private static string dBAddress;
        private static string dBContactNo;
        private static string dBemail;

        private static string[] sqlDBName;
        private static int trainData = 100;
        //-------Colors-----------
        Color IKY_Yellow = Color.FromArgb(236, 165, 0);
        Color IKY_Black = Color.FromArgb(22, 22, 22);
        Color IKY_Gray = Color.FromArgb(59, 59, 59);
        //---Used for recognition---

        
        //--------------------------
        private static int interfaceMode = 0;
        private static string[] allFiles = new string[100];
        private static int fileDisplayCounter = 0;
        private static string captureFileLocation = "C:\\major\\capture\\";
        private static Bitmap bitmapFramesInCapture = null;


        /**************************************************
         * Auto webcam display off feature
         */
        private static int webCamDisplayCounter = 0;//COunter
        private static bool displayPreview=true;
        //*************************************************

        private String recogName = "Unknown";
        private int observeFaceNamesCounter = 0;
        private int[] allNamesObserved = new int[50];
        private bool attendancePerformedFlag = false;
        private int statusOfNewFace = 0;
        private int[] statusNote = new int[2000];
        //-------------------------------------------------



        //Employee Authentication and autherization
        private int authenticatedID=-1;

        private SetPasswordForm SetPasFom = new SetPasswordForm();        
        private EnterPassword EntPasFom = new EnterPassword();


        private static int myWidth;
        private static int myHeight;



        public IKYv2FormMain()
        {
            InitializeComponent();
        }

        public static int getMyWidth()
        {
            return myWidth;
        }

        public static int getMyHeight()
        {
            return myHeight;
        }
        private void stWebCam()
        {
            // change the capture time frame
            //this.webCamCapture1.TimeToCapture_milliseconds = (int)this.numCaptureTime.Value;

            // start the video capture. let the control handle the
            // frame numbers.
            //this.webCamCapture1.Start(0);
            facedetectionTimer.Enabled = true;            
        }
        private void pauseWebCam()
        {
            // stop the video capture
            //this.webCamCapture1.Stop();
        }

        private void start_Click(object sender, EventArgs e)
        {
            resetParameters();
            
            this.onWebCam();
            
        }

        private void onWebCam()
        {
            labelWebCamInfo.Hide();
            labelWebCamInfoUpdate.Hide();
            try
            {
                this.stWebCam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onWebCamInOperationMode()
        {
            interfaceMode = 2;
            labelWebCamOperation.Hide();
            checkBoxContinuousRecognition.Checked = true;
            try
            {
                this.stWebCam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void offWebCamInOperationMode()
        {
            labelWebCamOperation.Show();
            facedetectionTimer.Enabled = false;
            pictureBoxWebCamOperation.Image = null;
        }
        
        private void displayWebCam()
        {
            try
            {
                if (interfaceMode==0)
                {
                    this.webCamDisplay.Image = fDetectedFrames; //To display frames with facedetection      
                    //this.webCamDisplay.Image = rawFrame;      //To display frames without facedetection  
                }
                else if (interfaceMode == 1)
                {
                    this.WebCamDisplayUpdate.Image = fDetectedFrames;
                }
                else
                {
                    if (displayPreview == true)
                    {
                        this.pictureBoxWebCamOperation.Image = fDetectedFrames;
                    }
                }
                
            }
            catch (Exception e)
            {
                String msg = e.Message;
            }
            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            
            this.offWebCam();
            
        }

        private void offWebCam()
        {
            labelWebCamInfo.Show();
            labelWebCamInfoUpdate.Show();
            try
            {
                facedetectionTimer.Enabled = false;
                webCamDisplay.Image = null;
                WebCamDisplayUpdate.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IKYv2FormMain_Load(object sender, EventArgs e)
        {                        
            

            myHeight = this.Height;
            myWidth = this.Width;
            
            // TODO: This line of code loads data into the 'iKYDataBaseDataSet.Info' table. You can move, or remove it, as needed.
            this.infoTableAdapter.Fill(this.iKYDataBaseDataSet.Info);
            // TODO: This line of code loads data into the 'iKYDataBaseDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.iKYDataBaseDataSet.Person);
            cap = new Capture(0);
            //this.webCamCapture1.CaptureHeight = 240;
            //this.webCamCapture1.CaptureWidth = 320;
            //panelInfoBack.Visible = false;            
            cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS,25);            
            cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 640);
            cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT,480);
            String dateToday=Convert.ToString(DateTime.Today);
            int concStop = dateToday.IndexOf(" ");
            String concatenatedDate = dateToday.Substring(0, concStop);
            labelDate.Text = "Date:"+concatenatedDate;
            try
            {
                Directory.CreateDirectory("C:\\major\\capture");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //FaceRecognition.initialize();
                loadDatabase();
                //MessageBox.Show("in try block");
                //FaceRecognition.setUser(loadDatabase());
                //FaceRecognition.load_XML();
                totalPersons = DatabaseManager.GetUserCount();
                textBoxTotalFaces.Text = Convert.ToString(totalPersons);
                //MessageBox.Show("Total Persons"+Convert.ToString(totalPersons));
                RLda.setFunction(totalPersons * 10, totalPersons);
                ICA.setFunction(totalPersons * 10, totalPersons * 10);

                FaceRecognition.initialize();

                /* These statements will train the network with the features from XML file*/
                FaceRecognition.loadNetwork();
                FaceRecognition.trainNetwork();
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                MessageBox.Show(errMsg);
            }
            finally
            {
            }
             
        }

        public static int getTotalPersons()
        {
            return totalPersons;
        }

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            nosFaces = FaceDetection.getNoOfFaces();            
            face01 = FaceDetection.getCroppedFace(rawFrame,faceRect01);
            face02 = FaceDetection.getCroppedFace(rawFrame, faceRect02);
            face03 = FaceDetection.getCroppedFace(rawFrame, faceRect03);
            face04 = FaceDetection.getCroppedFace(rawFrame, faceRect04);
            if(nosFaces==1)
                pictureBoxFace01.Image = (Image)face01;
            if (nosFaces == 2)
            {
                pictureBoxFace01.Image = (Image)face01;
                pictureBoxFace02.Image = (Image)face02;
            }
            if (nosFaces == 3)
            {
                pictureBoxFace01.Image = (Image)face01;
                pictureBoxFace02.Image = (Image)face02;
                pictureBoxFace03.Image = (Image)face03;
            }
            if (nosFaces == 4)
            {
                pictureBoxFace01.Image = (Image)face01;
                pictureBoxFace02.Image = (Image)face02;
                pictureBoxFace03.Image = (Image)face03;
                pictureBoxFace04.Image = (Image)face04;
            }
        }

        private void buttonLoadFrame_Click(object sender, EventArgs e)
        {
            clearAllCroppedFacePictureBox();
            resetParameters();
            labelWebCamInfo.Visible = false;
            try
            {
                FileControls oFile = new FileControls();
                Bitmap rawFrameOriginal = oFile.openFile();
                rawFrame = ImageProcessingUtilities.Resize(rawFrameOriginal, workingFrameWidth, workingFrameHeight);
                if (rawFrame != null)
                    webCamDisplay.Image = (Image)rawFrame;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDetectFace_Click(object sender, EventArgs e)
        {
            try
            {
                fDetectedFrames = FaceDetection.Run(rawFrame);
                faceRect01 = FaceDetection.getFaceRect01();
                faceRect02 = FaceDetection.getFaceRect02();
                faceRect03 = FaceDetection.getFaceRect03();
                faceRect04 = FaceDetection.getFaceRect04();
                webCamDisplay.Image = (Image)fDetectedFrames;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {                
                FileControls sFile = new FileControls();
                sFile.saveFile(new Bitmap(face01));                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void buttonTrain_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Train the System?\nTraining takes long time.","Confirm Training", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DatabaseManager.copyFacesToDisc();
                FaceRecognition.initialize();
                loadDatabase();
                FaceRecognition.trainRecognitionSystem();
                //FaceRecognition.setUser(loadDatabase());
                //FaceRecognition.load_XML();

                /* These statements will train the network with the features from XML file*/
                FaceRecognition.loadNetwork();
                FaceRecognition.trainNetwork();
            }
            else
            {
                MessageBox.Show("Training Cancel.");
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //clearAllMatchPictureBox();
            //pictureBoxMatch01.Image = Image.FromFile(FaceRecognition.searchDetected(face01));    
            startRecognition();



        }

        private void buttonLoadFace_Click(object sender, EventArgs e)
        {
            try
            {
                FileControls oFile = new FileControls();
                face01 =ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());                
                if (face01 != null)
                    pictureBoxFace01.Image = (Image)face01;                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelIKYMain_MouseEnter(object sender, EventArgs e)
        {
            panelIKYMain.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void panelIKYMain_MouseLeave(object sender, EventArgs e)
        {
            panelIKYMain.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void panelUpdateDatabase_MouseEnter(object sender, EventArgs e)
        {
            panelUpdateDatabase.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void panelUpdateDatabase_MouseLeave(object sender, EventArgs e)
        {
            panelUpdateDatabase.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void panelExit_MouseEnter(object sender, EventArgs e)
        {
            panelOperationMode.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void panelExit_MouseLeave(object sender, EventArgs e)
        {
            panelOperationMode.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void labelIKYInterface_MouseEnter(object sender, EventArgs e)
        {
            panelIKYMain.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void labelUpdateDatabase_MouseEnter(object sender, EventArgs e)
        {
            panelUpdateDatabase.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            panelOperationMode.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void labelIKYInterface_Click(object sender, EventArgs e)
        {
            
            EntPasFom.clearTextBox();
            EntPasFom.ShowDialog(this);//Show child form disabling parent
            bool makeOperation = confirmPassword();
            if (makeOperation == true)
            {
                menuStripIKY.Show();
                this.offWebCam();
                panelMain.Visible = true;
                panelUpdateMain.Visible = false;
                //panelMain.Visible = true;
                panelOperation.Visible = false;
                //panelAttendance.Visible = false;
                panelStatus.Visible = false;
                //panelExitOperation.Visible = false;
                panelAttendanceInfo.Visible = false;
                interfaceMode = 0;
            }
        }

        private void labelUpdateDatabase_Click(object sender, EventArgs e)
        {
            
            EntPasFom.clearTextBox();
            EntPasFom.ShowDialog(this);//Show child form disabling parent
            bool makeOperation = confirmPassword();
            if (makeOperation == true)
            {
                menuStripIKY.Show();
                this.offWebCam();
                panelUpdateMain.Visible = true;
                panelMain.Visible = false;
                panelOperation.Visible = false;
                //panelAttendance.Visible = false;
                panelStatus.Visible = false;
                //panelExitOperation.Visible = false;
                panelAttendanceInfo.Visible = false;
                interfaceMode = 1;
            }
        }

        

        public int loadDatabase()
        {
            panelMain.Visible = true;
            panelUpdateMain.Visible = false;
            int countRows = DatabaseManager.GetUserCount();
            MessageBox.Show("Total Persons : " + countRows);
            sqlDBName = new string[countRows];
            for (int i = 1; i <= countRows; i++)
            {
                sqlDBName[i - 1] = DatabaseManager.accessDatabase(i);
                //MessageBox.Show(i + "=" + sqlDBName[i - 1]);
            }
            return countRows;
        }        
        private void panelUpdateDatabase_Click(object sender, EventArgs e)
        {
            EntPasFom.clearTextBox();
            EntPasFom.ShowDialog(this);//Show child form disabling parent
            bool makeOperation = confirmPassword();
            if (makeOperation == true)
            {
                menuStripIKY.Show();
                this.offWebCam();
                panelUpdateMain.Visible = true;
                panelMain.Visible = false;
                panelOperation.Visible = false;
                //panelAttendance.Visible = false;
                panelStatus.Visible = false;
                //panelExitOperation.Visible = false;
                panelAttendanceInfo.Visible = false;
                interfaceMode = 1;
            }
        }





        private void facedetectionTimer_Tick(object sender, EventArgs e)
        {               
            Image nxtFrame = (Image)((cap.QueryFrame()).ToBitmap());            
            rawFrame = (Bitmap)nxtFrame;
            String recognizedName = "";
            
            if (checkBoxFacedetection.Checked == true||interfaceMode==2)
            {
                fDetectedFrames = FaceDetection.Run(rawFrame);
                nosFaces = FaceDetection.getNoOfFaces();
                textBoxTest.Text = (nosFaces).ToString();                
                faceRect01 = FaceDetection.getFaceRect01();      
                faceRect02 = FaceDetection.getFaceRect02();
                faceRect03 = FaceDetection.getFaceRect03();
                faceRect04 = FaceDetection.getFaceRect04();
            }
            else
                fDetectedFrames = rawFrame;                                    
            //if (faceRect01.Width < 75 && faceRect01.Width != 0)
                //MessageBox.Show("Please Come Closer to WebCam, too low resolution for Recognition");
            ThreadStart tsWeb = new ThreadStart(displayWebCam);
            Thread tWeb = new Thread(tsWeb);
            //if (rawFrame != null)                     //uncomment this to see direct(noFace detected) Frames in webCam Preview
            if (fDetectedFrames != null)
                tWeb.Start();

            
            //For continuous search of detected face
            if ((checkBoxContinuousRecognition.Checked == true&&checkBoxFacedetection.Checked==true)||(interfaceMode==2))
            {
                recognizedName=startRecognition();
                recogName = recognizedName;
                //label5.Text = recogName;
            }            
        }

        private String startRecognition()
        {
            Bitmap face01_p = null;
            Bitmap face02_p = null;
            Bitmap face03_p = null;
            Bitmap face04_p = null;
            String recognizedName = "Unknown";
            if (checkBoxContinuousRecognition.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(rawFrame, faceRect01);
                face02 = FaceDetection.getCroppedFace(rawFrame, faceRect02);
                face03 = FaceDetection.getCroppedFace(rawFrame, faceRect03);
                face04 = FaceDetection.getCroppedFace(rawFrame, faceRect04);
            }
            //
            if(face01!=null)
                face01_p = (face01 == null) ? null : (Bitmap)face01.Clone();
            //
            if(face02!=null)
                face02_p = (face02 == null) ? null : (Bitmap)face02.Clone();
            //
            if(face03!=null)
                face03_p = (face03 == null) ? null : (Bitmap)face03.Clone();
            //
            if(face04!=null)
                face04_p = (face04 == null) ? null : (Bitmap)face04.Clone();
            if (nosFaces == 1)
            {
                pictureBoxFace01.Image = (Image)face01;
                pictureBoxFace02.Image = null;
                pictureBoxFace03.Image = null;
                pictureBoxFace04.Image = null;
                pictureBoxMatch02.Image = null;
                pictureBoxMatch03.Image = null;
                pictureBoxMatch04.Image = null;
            }
            else if (nosFaces == 2)
            {
                pictureBoxFace01.Image = (Image)face01;
                pictureBoxFace02.Image = (Image)face02;
                pictureBoxFace03.Image = null;
                pictureBoxFace04.Image = null;
                pictureBoxMatch03.Image = null;
                pictureBoxMatch04.Image = null;
            }
            else if (nosFaces == 3)
            {
                pictureBoxFace01.Image = (Image)face01;
                pictureBoxFace02.Image = (Image)face02;
                pictureBoxFace03.Image = (Image)face03;
                pictureBoxFace04.Image = null;
                pictureBoxMatch04.Image = null;
            }
            else if (nosFaces == 4)
            {
                pictureBoxFace01.Image = (Image)face01;
                pictureBoxFace02.Image = (Image)face02;
                pictureBoxFace03.Image = (Image)face03;
                pictureBoxFace04.Image = (Image)face04;
            }
            else if (nosFaces == 0)
            {
                clearAllCroppedFacePictureBox();
                clearAllMatchPictureBox();
            }
            string filepath;
            int detectedIndex_r, detectedIndex_p;
            Rectangle nullRect = new Rectangle(0, 0, 0, 0);
            //FaceDetection.setName(null, nullRect, 0);
            //FaceDetection.setName(null, nullRect, 1);
            //FaceDetection.setName(null, nullRect, 2);
            //FaceDetection.setName(null, nullRect, 3);
            if (face01 != null && nosFaces == 1)
            {

                detectedIndex_r = FaceRecognition.searchDetected(face01);
                detectedIndex_p = FaceRecognition.searchDetected_ic(face01_p);
                //MessageBox.Show("index of detected face from LDA" + detectedIndex_r);
                //MessageBox.Show("index of detected face from PCA" + detectedIndex_p);
                int minEd = ICA.getMinEudDistance();
                textBoxMinEud.Text =Convert.ToString(minEd);
                /*
                if (minEd > 4500)
                {
                    labelMinEud.Text = "Unknown";
                    clearAllMatchPictureBox();
                    clearDisplayName();
                }
                else
                    labelMinEud.Text = "Known";
                 */
                //detectedIndex_p = 1 + (detectedIndex_p / 10) * 10;


                //This code will fill the list box to evaluate the input vector of the network
                /*
                textBoxShowClass.Text = Convert.ToString(detectedIndex_r);
                listBoxInputVector.Items.Add("----------");
                textBoxInputVector.Text = "----";
                for (int i = 0; i < 6; i++)
                {
                    listBoxInputVector.Items.Add(Convert.ToString(LVQ.getInputVectors(i)));
                    textBoxInputVector.Text += (LVQ.getInputVectors(i)).ToString() + ",";                                    
                }
                
                */                
                //if (detectedIndex_p == detectedIndex_r)


                /* These statements will determine if the cropped faces are known or not*/
                FaceRecognition.searchDetected_ic(face01);
                int[] testttt = FaceRecognition.getEudPat();
                //This statement if disable rejection of unknown face.
                if (disableRejectionOfUnknownFaceToolStripMenuItem.Checked == true)
                {
                    statusOfNewFace = 1;
                }
                else
                {
                    statusOfNewFace = call(testttt);
                }



                if (statusOfNewFace == 1)// Here statusOfFace is 1 when face is known else it is 0
                {
                    //This code in if block executes to use rLDA only
                    if (useRLDAOnlyToolStripMenuItem.Checked == true&&detectedIndex_r != -1)
                    {
                        filepath = "C:\\major\\" + detectedIndex_r.ToString() + ".jpg";
                        pictureBoxMatch01.Image = Image.FromFile(filepath);
                        face01ID = (detectedIndex_r / 10);
                    }
                    //This code in if block executes to use both PCA and rLDA
                    if (useRLDAOnlyToolStripMenuItem.Checked == false && detectedIndex_r != -1 && detectedIndex_p != -1)
                    {
                        if (detectedIndex_p == detectedIndex_r)
                        {
                            filepath = "C:\\major\\" + detectedIndex_r.ToString() + ".jpg";
                            pictureBoxMatch01.Image = Image.FromFile(filepath);
                            face01ID = (detectedIndex_r / 10);
                        }
                        else
                        {
                            FaceDetection.setName("Unknown", faceRect01, 0);
                        }
                    }
                    //FaceDetection.setName(sqlDBName[face01ID], face01ID);
                    //textBoxTest.Text=
                    //MessageBox.Show("" + face01ID);
                    recognizedName = sqlDBName[face01ID].ToString();
                    FaceDetection.setName(recognizedName, faceRect01, 0);
                    FaceDetection.setName(null, nullRect, 1);
                    FaceDetection.setName(null, nullRect, 2);
                    FaceDetection.setName(null, nullRect, 3);
                    //FaceDetection.setName("wow", faceRect01, 0);
                }
                else
                {
                    FaceDetection.setName("Unknown", faceRect01, 0);
                }
            }
            if (face02 != null && nosFaces == 2)
            {
                detectedIndex_r = FaceRecognition.searchDetected(face02);
                detectedIndex_p = FaceRecognition.searchDetected_ic(face02_p);

                detectedIndex_p = 1 + (detectedIndex_p / 10) * 10;
                if (detectedIndex_p == detectedIndex_r)
                {
                    filepath = "C:\\major\\" + detectedIndex_r.ToString() + ".jpg";
                    pictureBoxMatch02.Image = Image.FromFile(filepath);
                    face02ID = detectedIndex_r / 10;
                    FaceDetection.setName(sqlDBName[face02ID].ToString(), faceRect02, 1);
                    FaceDetection.setName(null, nullRect, 2);
                    FaceDetection.setName(null, nullRect, 3);
                }
            }
            if (face03 != null && nosFaces == 3)
            {
                detectedIndex_r = FaceRecognition.searchDetected(face03);
                detectedIndex_p = FaceRecognition.searchDetected_ic(face03_p);

                detectedIndex_p = 1 + (detectedIndex_p / 10) * 10;
                if (detectedIndex_p == detectedIndex_r)
                {
                    filepath = "C:\\major\\" + detectedIndex_r.ToString() + ".jpg";
                    pictureBoxMatch03.Image = Image.FromFile(filepath);
                    face03ID = detectedIndex_r / 10;
                    FaceDetection.setName(sqlDBName[face03ID].ToString(), faceRect03, 2);
                    FaceDetection.setName(null, nullRect, 3);
                }
            }
            if (face04 != null && nosFaces == 4)
            {
                detectedIndex_r = FaceRecognition.searchDetected(face04);
                detectedIndex_p = FaceRecognition.searchDetected_ic(face04_p);

                detectedIndex_p = 1 + (detectedIndex_p / 10) * 10;
                if (detectedIndex_p == detectedIndex_r)
                {
                    filepath = "C:\\major\\" + detectedIndex_r.ToString() + ".jpg";
                    pictureBoxMatch04.Image = Image.FromFile(filepath);
                    face04ID = detectedIndex_r / 10;
                    FaceDetection.setName(sqlDBName[face04ID].ToString(), faceRect04, 3);
                }
            }
            return recognizedName;
        }
        private void clearDisplayName()
        {
            Rectangle nullRect = new Rectangle(0, 0, 0, 0);
            FaceDetection.setName(null, nullRect, 0);
            FaceDetection.setName(null, nullRect, 1);
            FaceDetection.setName(null, nullRect, 2);
            FaceDetection.setName(null, nullRect, 3);
        }
        private void clearAllMatchPictureBox()
        {
            if(pictureBoxMatch01.Image!=null)
                pictureBoxMatch01.Image = null;
            if (pictureBoxMatch02.Image != null)
                pictureBoxMatch02.Image = null;
            if (pictureBoxMatch03.Image != null)
                pictureBoxMatch03.Image = null;
            if (pictureBoxMatch04.Image != null)
                pictureBoxMatch04.Image = null;
        }
        private void clearAllCroppedFacePictureBox()
        {
            if(pictureBoxFace01.Image!=null)
                pictureBoxFace01.Image = null;
            if (pictureBoxFace02.Image != null)
                pictureBoxFace02.Image = null;
            if (pictureBoxFace03.Image != null)
                pictureBoxFace03.Image = null;
            if (pictureBoxFace04.Image != null)
                pictureBoxFace04.Image = null;
        }
        
         
        private void resetParameters()
        {
            Rectangle re = new Rectangle(0, 0, 0, 0);
            faceRect01 = re;
            faceRect02 = re;
            faceRect03 = re;
            faceRect04 = re;
            face01 = null;
            face02 = null;
            face03 = null;
            face04 = null;
            pictureBoxFace01.Image = null;
            pictureBoxFace02.Image = null;
            pictureBoxFace03.Image = null;
            pictureBoxFace04.Image = null;
            nosFaces = 0;
        }

        
        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iKYDataBaseDataSet);
            

        }
        
        private void pictureBoxMatch01_Click(object sender, EventArgs e)
        {
            DatabaseManager.accessDatabase(face01ID+1);
            textBoxDBName.Text = Convert.ToString(DatabaseManager.getDBName(face01ID+1));
            textBoxDBAddress.Text = Convert.ToString(DatabaseManager.getDBAddress(face01ID+1));
            textBoxDBemail.Text = Convert.ToString(DatabaseManager.getDBemail(face01ID+1));
            textBoxDBContactNo.Text = Convert.ToString(DatabaseManager.getDBContactNo(face01ID+1));
            try
            {
                string filepath1 = "C:\\major\\" + (face01ID * 10 + 1).ToString() + ".jpg";
                pictureBoxDetails.Image = Image.FromFile(filepath1);
            }
            catch (Exception ex)
            {
                pictureBoxDetails.Image = null;
            }
        }

        

        

        private void pictureBoxMatch02_Click(object sender, EventArgs e)
        {
            DatabaseManager.accessDatabase(face02ID + 1);
            textBoxDBName.Text = Convert.ToString(dBName);
            textBoxDBAddress.Text = Convert.ToString(dBAddress);
            textBoxDBemail.Text = Convert.ToString(dBemail);
            textBoxDBContactNo.Text = Convert.ToString(dBContactNo);
            try
            {
                string filepath2 = "C:\\major\\" + (face02ID * 10 + 1).ToString() + ".jpg";
                pictureBoxDetails.Image = Image.FromFile(filepath2);
            }
            catch (Exception ex)
            {
                pictureBoxDetails.Image = null;
            }
        }

        private void pictureBoxMatch03_Click(object sender, EventArgs e)
        {
            DatabaseManager.accessDatabase(face03ID + 1);
            textBoxDBName.Text = Convert.ToString(dBName);
            textBoxDBAddress.Text = Convert.ToString(dBAddress);
            textBoxDBemail.Text = Convert.ToString(dBemail);
            textBoxDBContactNo.Text = Convert.ToString(dBContactNo);
            try
            {
                string filepath3 = "C:\\major\\" + (face03ID * 10 + 1).ToString() + ".jpg";
                pictureBoxDetails.Image = Image.FromFile(filepath3);
            }
            catch (Exception ex)
            {
                pictureBoxDetails.Image = null;
            }
        }

        private void pictureBoxMatch04_Click(object sender, EventArgs e)
        {
            DatabaseManager.accessDatabase(face04ID + 1);
            textBoxDBName.Text = Convert.ToString(dBName);
            textBoxDBAddress.Text = Convert.ToString(dBAddress);
            textBoxDBemail.Text = Convert.ToString(dBemail);
            textBoxDBContactNo.Text = Convert.ToString(dBContactNo);
            try
            {
                string filepath4 = "C:\\major\\" + (face04ID * 10 + 1).ToString() + ".jpg";
                pictureBoxDetails.Image = Image.FromFile(filepath4);
            }
            catch (Exception ex)
            {
                pictureBoxDetails.Image = null;
            }
        }

        private void panelIKYMain_Click(object sender, EventArgs e)
        {
            EntPasFom.clearTextBox();
            EntPasFom.ShowDialog(this);//Show child form disabling parent
            bool makeOperation = confirmPassword();
            if (makeOperation == true)
            {
                menuStripIKY.Show();
                this.offWebCam();
                panelMain.Visible = true;
                panelUpdateMain.Visible = false;
                //panelMain.Visible = true;
                panelOperation.Visible = false;
                //panelAttendance.Visible = false;
                panelStatus.Visible = false;
                //panelExitOperation.Visible = false;
                panelAttendanceInfo.Visible = false;
                interfaceMode = 0;
            }
        }

        private void buttonDBUpdate_Click(object sender, EventArgs e)
        {
            /*
            //FaceRecognition.setUser(loadDatabase());
            int totalPersons = DatabaseManager.GetUserCount();
            textBoxTotalFaces.Text = Convert.ToString(totalPersons);
            //totalPersons--;      
            //FaceRecognition.initialize(totalPersons);
            RLda.setFunction(totalPersons * 10, totalPersons);
            ICA.setFunction(totalPersons * 10, totalPersons * 10);
             */
            int idInput = Convert.ToInt32(iDTextBox.Text);
            DatabaseManager.deleteInfoFromDatabase(idInput);


            //int idInput = Convert.ToInt32(iDTextBox.Text);
            String nameInput = nameTextBox.Text;
            String addressInput = addressTextBox.Text;
            String emailInput = emailTextBox.Text;
            String contactNoInput = contactNoTextBox.Text;
            Boolean nullOn = false;
            if (idInput == null || nameInput == null || addressInput == null || emailInput == null || contactNoInput == null || pictureBox1.Image == null || pictureBox2.Image == null || pictureBox3.Image == null || pictureBox4.Image == null || pictureBox5.Image == null || pictureBox6.Image == null || pictureBox7.Image == null || pictureBox8.Image == null || pictureBox9.Image == null || pictureBox10.Image == null || pictureBoxProfileFace.Image == null)
                nullOn = true;
            if (nullOn == false)
                DatabaseManager.insertInfoIntoDB(idInput, nameInput, addressInput, contactNoInput, emailInput, (Image)pictureBox1.Image, (Image)pictureBox2.Image, (Image)pictureBox3.Image, (Image)pictureBox4.Image, (Image)pictureBox5.Image, (Image)pictureBox6.Image, (Image)pictureBox7.Image, (Image)pictureBox8.Image, (Image)pictureBox9.Image, (Image)pictureBox10.Image, (Image)pictureBoxProfileFace.Image);

            //displayDBInfoInDataGrid();
            //DatabaseManager.copyFacesToDisc();
            //saveFacesToDiscToMapDatabase(idInput);
            displayDBInfoInDataGrid();
        }

        
        

        private void buttonDBInsert_Click(object sender, EventArgs e)
        {
            int idInput=Convert.ToInt32(iDTextBox.Text);
            String nameInput=nameTextBox.Text;
            String addressInput=addressTextBox.Text;
            String emailInput=emailTextBox.Text;
            String contactNoInput=contactNoTextBox.Text;
            Boolean nullOn = false;
            if (idInput == null || nameInput == null || addressInput == null || emailInput == null || contactNoInput == null || pictureBox1.Image == null || pictureBox2.Image == null || pictureBox3.Image == null || pictureBox4.Image == null || pictureBox5.Image == null || pictureBox6.Image == null || pictureBox7.Image == null || pictureBox8.Image == null || pictureBox9.Image == null || pictureBox10.Image == null||pictureBoxProfileFace.Image==null)
                nullOn = true;
            if (nullOn == false)
                DatabaseManager.insertInfoIntoDB(idInput, nameInput, addressInput, contactNoInput, emailInput, (Image)pictureBox1.Image, (Image)pictureBox2.Image, (Image)pictureBox3.Image, (Image)pictureBox4.Image, (Image)pictureBox5.Image, (Image)pictureBox6.Image, (Image)pictureBox7.Image, (Image)pictureBox8.Image, (Image)pictureBox9.Image, (Image)pictureBox10.Image,(Image)pictureBoxProfileFace.Image);
            
            //displayDBInfoInDataGrid();
            //DatabaseManager.copyFacesToDisc();
            //saveFacesToDiscToMapDatabase(idInput);
            displayDBInfoInDataGrid();
            
        }

        private void saveFacesToDiscToMapDatabase(int id)
        {
            Bitmap[] faceToDisc = new Bitmap[10];
            faceToDisc[0] = (Bitmap)pictureBox1.Image;
            faceToDisc[1] = (Bitmap)pictureBox2.Image;
            faceToDisc[2] = (Bitmap)pictureBox3.Image;
            faceToDisc[3] = (Bitmap)pictureBox4.Image;
            faceToDisc[4] = (Bitmap)pictureBox5.Image;
            faceToDisc[5] = (Bitmap)pictureBox6.Image;
            faceToDisc[6] = (Bitmap)pictureBox7.Image;
            faceToDisc[7] = (Bitmap)pictureBox8.Image;
            faceToDisc[8] = (Bitmap)pictureBox9.Image;
            faceToDisc[9] = (Bitmap)pictureBox10.Image;
            int fileEndId = id * 10;
            int fileStartId = (fileEndId - 10) + 1;
            foreach (Bitmap b in faceToDisc)
            {
                String fileSaveLocation = "C:\\major\\"+fileStartId.ToString() + ".jpg";
                b.Save(fileSaveLocation);
                fileStartId++;
            }

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            displayDBInfoInDataGrid();
        }

        private void displayDBInfoInDataGrid()
        {
            daIKYMain.SelectCommand = DatabaseManager.selectForGridView();
            dsIKYMain.Clear();            
            daIKYMain.Fill(dsIKYMain);            
            //bsIKYMain.Format += new ConvertEventHandler(FormatImageData);
            dataGridViewIKY.DataSource = dsIKYMain.Tables[0];
            if (bindingOn == false)
            {
                bsIKYMain.DataSource = dsIKYMain.Tables[0];
                iDTextBox.DataBindings.Add(new Binding("Text", bsIKYMain, "PersonID"));
                nameTextBox.DataBindings.Add(new Binding("Text", bsIKYMain, "Name"));
                addressTextBox.DataBindings.Add(new Binding("Text", bsIKYMain, "Address"));
                emailTextBox.DataBindings.Add(new Binding("Text", bsIKYMain, "email"));
                contactNoTextBox.DataBindings.Add(new Binding("Text", bsIKYMain, "ContactNo"));
                //pictureBox1.DataBindings.Add(new Binding("Image", bsIKYMain, "dbFace01"));

                Binding bindPic = new Binding("Image", bsIKYMain, "dbFace01");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox1.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace02");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox2.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace03");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox3.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace04");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox4.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace05");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox5.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace06");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox6.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace07");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox7.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace08");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox8.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace09");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox9.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFace10");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                pictureBox10.DataBindings.Add(bindPic);

                bindPic = new Binding("Image", bsIKYMain, "dbFaceProfile");
                bindPic.Format += new ConvertEventHandler(bindPic_Format);
                //pictureBox10.DataBindings.Add(bindPic);
                pictureBoxProfileFace.DataBindings.Add(bindPic);

                bindingOn = true;
            }

            
        }


        private void bindPic_Format(object sender, ConvertEventArgs e)
        {
            using (MemoryStream stream = new MemoryStream((byte[])e.Value))
            {
                e.Value = Image.FromStream(stream);
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selected = 1;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox1.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
            
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selected = 2;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox2.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selected = 3;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox3.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selected = 4;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox4.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selected = 5;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox5.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selected = 6;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox6.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selected = 7;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox7.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            selected = 8;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox8.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            selected = 9;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox9.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            selected = 10;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                pictureBox10.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }

        

        private void loadFaceForEntry()
        {
            try
            {
                FileControls oFile = new FileControls();
                switch (selected)
                {
                    case 0:
                        pictureBoxProfileFace.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 1:
                        pictureBox1.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 2:
                        pictureBox2.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 3:
                        pictureBox3.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 4:
                        pictureBox4.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 5:
                        pictureBox5.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 6:
                        pictureBox6.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 7:
                        pictureBox7.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 8:
                        pictureBox8.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 9:
                        pictureBox9.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                    case 10:
                        pictureBox10.Image = ImageProcessingUtilities.emguCVconvert2Grayscale(oFile.openFile());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoadToDisk_Click(object sender, EventArgs e)
        {
            DatabaseManager.copyFacesToDisc();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                bsIKYMain.MoveNext();
                dgUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grid is Empty. Please display data first!");
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                bsIKYMain.MovePrevious();
                dgUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grid is Empty. Please display data first!");
            }
        }
        private void dgUpdate()
        {
            dataGridViewIKY.ClearSelection();
            dataGridViewIKY.Rows[bsIKYMain.Position].Selected = true;            
        }



        

        /***************************************************************************************************
         * This function is just temp. After getting the vector from rLda this is not req.
        */
        public static int call(int[] ProjectedPattern)
        {
            //FaceRecognition.loadNetwork();
            //FaceRecognition.trainNetwork();            
            FaceRecognition.loadTestPattern(ProjectedPattern);
            int statusOfFace=FaceRecognition.runNetwork();
            return statusOfFace;
        }

        

        private void buttonDisplayFeatures_Click(object sender, EventArgs e)
        {
            //double[,] returnedFeatures = FaceRecognition.getRLdaFeatures(face01);
            //displays features
            //FaceRecognition.searchDetected_ic(face01);
            //int[] testttt = FaceRecognition.getEudPat();


            //listBoxInputVector.Items.Add("-----");
            //for (int i = 0; i < 10; i++)
            //{
            //    //MessageBox.Show("" + returnedFeatures[i , 0]);
            //    listBoxInputVector.Items.Add(testttt[i].ToString());
            //}            
            autoAbsentCommit();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Are you sure?\n Record once deleted cannot be recovered","Confirm Delete",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int idInput = Convert.ToInt32(iDTextBox.Text);
                DatabaseManager.deleteInfoFromDatabase(idInput);
                displayDBInfoInDataGrid();
            }
            else
            {
                MessageBox.Show("Deletion Cancel");
            }
        }

        private void startBack_Click(object sender, EventArgs e)
        {
            //resetParameters();
            //labelWebCamInfo.Hide();
            
            this.onWebCam();
        }

        private void stopBack_Click(object sender, EventArgs e)
        {                        
            this.offWebCam();
        }

        private void timerCapture_Tick(object sender, EventArgs e)
        {            
            string imageLocation="C:\\major\\capture\\";
            int photoCaptureCounter = Convert.ToInt32(textBoxPhotoIndex.Text);
            
            fDetectedFrames.Save(imageLocation + photoCaptureCounter + ".jpg");
            photoCaptureCounter++;
            textBoxPhotoIndex.Text = Convert.ToString(photoCaptureCounter);
        }

        private void startCaptureUpdate_Click(object sender, EventArgs e)
        {
            this.onWebCam();
            timerCapture.Enabled = true;
        }

        private void stopCaptureUpdate_Click(object sender, EventArgs e)
        {
            timerCapture.Enabled = false;
        }

        private void buttonNextFrame_Click(object sender, EventArgs e)
        {                        
            try
            {
                if (fileDisplayCounter < allFiles.Length)
                {
                    Image framesInCapture = Image.FromFile(captureFileLocation + allFiles[fileDisplayCounter]);
                    bitmapFramesInCapture = ImageProcessingUtilities.Resize((Bitmap)framesInCapture, 640, 480);
                    
                    fDetectedFrames = FaceDetection.Run(bitmapFramesInCapture);
                    WebCamDisplayUpdate.Image = (Image)fDetectedFrames;
                    faceRect01 = FaceDetection.getFaceRect01();
                    fileDisplayCounter++;
                    textBoxPhotoIndex.Text =allFiles[fileDisplayCounter];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Press refresh first");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            labelWebCamInfoUpdate.Hide();
            fileDisplayCounter = 0;
            DirectoryInfo di = new DirectoryInfo(@"C:\major\capture");


            int i = 0;
            foreach (System.IO.FileInfo fi in di.GetFiles())
            {
                i++;
            }
            allFiles = new string[i];
            i = 0;
            foreach (System.IO.FileInfo fi in di.GetFiles())
            {
                string sss = (fi.Name).Substring((fi.Name).Length - 3);
                if (sss == "jpg")
                {
                    allFiles[i] = fi.Name;
                    i++;
                }
            }            
        }

        private void buttonPreviousFrame_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileDisplayCounter >=0 )
                {
                    fileDisplayCounter--;
                    Image framesInCapture = Image.FromFile(captureFileLocation + allFiles[fileDisplayCounter]);
                    bitmapFramesInCapture = ImageProcessingUtilities.Resize((Bitmap)framesInCapture, 640, 480);

                    fDetectedFrames = FaceDetection.Run(bitmapFramesInCapture);
                    WebCamDisplayUpdate.Image = (Image)fDetectedFrames;
                    faceRect01 = FaceDetection.getFaceRect01();
                    
                    textBoxPhotoIndex.Text =allFiles[fileDisplayCounter];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Press refresh first");
            }
        }

        private void buttonSaveTest_Click(object sender, EventArgs e)
        {
            Bitmap i1 = (Bitmap)pictureBox1.Image;
            i1.Save("C:\\test.jpg");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelOperation_Click(object sender, EventArgs e)
        {
            menuStripIKY.Hide();
            
                panelMain.Visible = false;
                panelUpdateMain.Visible = false;
                //panelMain.Visible = true;
                panelOperation.Visible = true;
                //panelAttendance.Visible = true;
                panelStatus.Visible = true;
                //panelExitOperation.Visible = true;
                panelAttendanceInfo.Visible = false;
                interfaceMode = 2;
                resetStatusObjects();
            
        }

        private void panelOperationMode_MouseClick(object sender, MouseEventArgs e)
        {
            menuStripIKY.Hide();

            panelMain.Visible = false;
            panelUpdateMain.Visible = false;
            //panelMain.Visible = true;
            panelOperation.Visible = true;
            //panelAttendance.Visible = true;
            panelStatus.Visible = true;
            //panelExitOperation.Visible = true;
            panelAttendanceInfo.Visible = false;
            interfaceMode = 2;
            resetStatusObjects();
        }

        

        

        

        

        private void pictureBoxProfileFace_Click(object sender, EventArgs e)
        {
            selected = 0;
            if (checkBoxLoadFacesFromFrame.Checked == true)
            {
                face01 = FaceDetection.getCroppedFace(bitmapFramesInCapture, faceRect01);
                //pictureBox1.Image = (Image)face01;
                pictureBoxProfileFace.Image = (Image)face01;
            }
            //textBoxSelected.Text = Convert.ToString(selected);
            else
            {
                loadFaceForEntry();
            }
        }        

        

        private void button3_Click(object sender, EventArgs e)
        {
            daIKYMain.SelectCommand = DatabaseManager.selectForAttendanceInfoView(authenticatedID);
            dsIKYMain.Clear();
            daIKYMain.Fill(dsIKYMain);
            //bsIKYMain.Format += new ConvertEventHandler(FormatImageData);
            //dataGridViewIKY.DataSource = dsIKYMain.Tables[0];
            dataGridViewAttendance.DataSource = dsIKYMain.Tables[0];

            string filepath1 = "C:\\major\\" + (face01ID * 10 + 1).ToString() + ".jpg";
            pictureBoxPersonalInfo.Image = Image.FromFile(filepath1);
            textBoxNamePersonalInfo.Text = DatabaseManager.getDBName(authenticatedID);
            textBoxEmployeeIDPersonalInfo.Text = authenticatedID.ToString();
            textBoxAddressPersonalInfo.Text = DatabaseManager.getDBAddress(authenticatedID);
            textBoxContactNoPersonalInfo.Text = DatabaseManager.getDBContactNo(authenticatedID);
            textBoxEmailPersonalInfo.Text = DatabaseManager.getDBemail(authenticatedID);
        }


        private void resetStatusObjects()
        {
            pictureBoxPersonalInfo.Image = null;
            textBoxNamePersonalInfo.Text = "";
            textBoxEmployeeIDPersonalInfo.Text = "";
            textBoxAddressPersonalInfo.Text = "";
            textBoxContactNoPersonalInfo.Text = "";
            textBoxEmailPersonalInfo.Text = "";
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {
            menuStripIKY.Hide();
            panelMain.Visible = false;
            panelUpdateMain.Visible = false;
            //panelMain.Visible = true;
            panelOperation.Visible = false;
            //panelAttendance.Visible = true;
            panelStatus.Visible = true;
            //panelExitOperation.Visible = true;
            panelAttendanceInfo.Visible = true;
        }

        private void timerAutoWebCamDisplayOff_Tick(object sender, EventArgs e)
        {
            //webCamDisplayCounter += timerAutoWebCamDisplayOff.Interval;



            webCamDisplayCounter += 100;
            if (webCamDisplayCounter == 3000)
            {
                //MessageBox.Show("Time out");
                //this.offWebCamInOperationMode();

                labelWebCamOperation.Show();
                //facedetectionTimer.Enabled = false;
                pictureBoxWebCamOperation.Image = null;
                displayPreview = false;

                timerAutoWebCamDisplayOff.Enabled = false;
                webCamDisplayCounter = 0;
            }
        }

        private void timerOperationMode_Tick(object sender, EventArgs e)
        {
            if (checkBoxStartOperation.Checked == true)
            {



                //This code will trigger timer to auto display off
                if (nosFaces == 0)
                {
                    attendancePerformedFlag = false;
                    timerAutoWebCamDisplayOff.Enabled = true;
                    
                    observeFaceNamesCounter = 0;
                    if (timerObserveFace.Enabled == true)
                    {
                        
                        timerObserveFace.Enabled = false;
                    }
                    if (panelAttendancePerformed.Visible == true)
                    {
                        panelAttendancePerformed.Hide();
                    }

                    if (panelAttendanceAlreadyPerformed.Visible == true)
                    {
                        panelAttendanceAlreadyPerformed.Hide();
                    }

                    if (panelUnknownAuthenticationResult.Visible == true)
                    {
                        panelUnknownAuthenticationResult.Hide();
                    }
                    for(int i=0;i<statusNote.Length;i++)
                    {
                        statusNote[i] = 0;
                    }
                }
                else
                {
                    labelWebCamOperation.Hide();
                    displayPreview = true;

                    
                    timerObserveFace.Enabled = true;
                    //This code disable the preview as there are face in the frames
                    if (timerAutoWebCamDisplayOff.Enabled == true)
                        timerAutoWebCamDisplayOff.Enabled = false;
                    webCamDisplayCounter = 0;
                    
                }
            }
        }

        private void checkBoxStartOperation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartOperation.Checked == true)
            {
                this.onWebCamInOperationMode();
                timerOperationMode.Enabled = true;
            }
            else
            {
                this.offWebCamInOperationMode();
                timerOperationMode.Enabled = false;
                timerPerformAttendance.Enabled = false;
                timerObserveFace.Enabled = false;
                timerAutoWebCamDisplayOff.Enabled = false;
                panelAttendanceAlreadyPerformed.Hide();
                panelAttendancePerformed.Hide();
                panelAuthentication.Hide();
                panelUnknownAuthenticationResult.Hide();
                
            }
        }

        private void timerObserveFace_Tick(object sender, EventArgs e)
        {
            //if (panelAuthentication.Visible == true)
            //    panelAuthentication.Hide();
            observeFaceNamesCounter+=100;
            int statusNoteCount = observeFaceNamesCounter / 100;
            //These statements will fill the statusNote array with 1 if face is known and with 0 if face is unknown
            
            if (statusOfNewFace == 1)
                statusNote[statusNoteCount] = 1;
            else
                statusNote[statusNoteCount] = 0;
            //--------------------------------------------------------------------------------------------------
            if (observeFaceNamesCounter == 2000&&attendancePerformedFlag==false)
            {
                timerObserveFace.Enabled = false;

                int countKnown=0;
                int totalStatusLength = statusNote.Length;
                for (int i = 0; i < totalStatusLength; i++)
                {
                    if (statusNote[i] == 1)
                    {
                        countKnown++;
                    }
                }
                if (countKnown > 2)
                {
                    try
                    {
                        string filepath1 = "C:\\major\\" + (face01ID * 10 + 1).ToString() + ".jpg";
                        pictureBoxAuthPhoto.Image = Image.FromFile(filepath1);

                        //face01ID = (detectedIndex_r / 10);
                        //FaceDetection.setName(sqlDBName[face01ID], face01ID);
                        //textBoxTest.Text=
                        //MessageBox.Show("" + face01ID);
                        String recognizedName = sqlDBName[face01ID].ToString();
                        textBoxAuthName.Text = recognizedName;
                        textBoxAuthID.Text = (face01ID + 1).ToString();
                    }
                    catch (Exception ex)
                    {
                        pictureBoxAuthPhoto.Image = null;
                        textBoxAuthName.Text = "";
                        textBoxAuthID.Text = "";
                    }



                    panelAuthentication.Show();
                    timerPerformAttendance.Enabled = true;

                    attendancePerformedFlag = true;
                }
                else
                {
                    panelUnknownAuthenticationResult.Show();
                }
                observeFaceNamesCounter = 0;
            }
        }

        private void timerPerformAttendance_Tick(object sender, EventArgs e)
        {
            panelAuthentication.Hide();

            


            int ID = face01ID + 1;
            authenticatedID = ID;
            bool attStatus = DatabaseManager.testForAttendancePerformed(ID);
            if (attStatus == true)
            {
                //MessageBox.Show("Attendance Performed");
                panelAttendanceAlreadyPerformed.Show();
            }
            else
            {
                String attID = Convert.ToString(DatabaseManager.determineNewAttendanceID() + 1);
                String perID = ID.ToString();
                DateTime date = DateTime.Today;               
                String status = "P";
                DatabaseManager.makeEntry(attID, perID, date, status);
                panelAttendancePerformed.Show();
            }


            
            timerPerformAttendance.Enabled = false;
        }

        private void autoAbsentCommit()
        {
            int ID = 0;            
            //bool attStatus = DatabaseManager.testForAttendancePerformed(ID);
            bool attStatus;

            for (int i = 1; i <= totalPersons; i++)
            {
                attStatus = DatabaseManager.testForAttendancePerformed(i);
                if (attStatus == false)
                {
                    ID = i;
                    String attID = Convert.ToString(DatabaseManager.determineNewAttendanceID() + 1);
                    String perID = ID.ToString();
                    DateTime date = DateTime.Today;
                    String status = "A";
                    DatabaseManager.makeEntry(attID, perID, date, status);
                    panelAttendancePerformed.Show();
                }
            }            
        }

        private void panelStatus_MouseEnter(object sender, EventArgs e)
        {            
            panelStatus.BackColor = Color.FromArgb(50, 50, 50); 
        }

        private void panelStatus_MouseLeave(object sender, EventArgs e)
        {
            panelStatus.BackColor = Color.FromArgb(40, 40, 40); 
        }

        

        private void setPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetPasFom.Show();
            SetPasFom.clearTextBox();
            SetPasFom.ShowDialog(this);
            /*
             * In above line of code, SetPasFom is child form and this is parent form.
             */
        }

        private bool confirmPassword()
        {
            String presentPassword=EnterPassword.getConfirmPas();
            String DBPassword = DatabaseManager.accessPassword();
            if (presentPassword == DBPassword)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect Password. Cannot Switch to Administrator Panels");
                return false;
            }
        }

        private void iKYInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            EntPasFom.clearTextBox();
            EntPasFom.ShowDialog(this);//Show child form disabling parent
            bool makeOperation = confirmPassword();
            if (makeOperation == true)
            {
                menuStripIKY.Show();
                this.offWebCam();
                panelMain.Visible = true;
                panelUpdateMain.Visible = false;
                //panelMain.Visible = true;
                panelOperation.Visible = false;
                //panelAttendance.Visible = false;
                panelStatus.Visible = false;
                //panelExitOperation.Visible = false;
                panelAttendanceInfo.Visible = false;
                interfaceMode = 0;
            }
        }

        private void updateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripIKY.Hide();

            panelMain.Visible = false;
            panelUpdateMain.Visible = false;
            //panelMain.Visible = true;
            panelOperation.Visible = true;
            //panelAttendance.Visible = true;
            panelStatus.Visible = true;
            //panelExitOperation.Visible = true;
            panelAttendanceInfo.Visible = false;
            interfaceMode = 2;
            resetStatusObjects();
        }

        private void disableRejectionOfUnknownFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disableRejectionOfUnknownFaceToolStripMenuItem.Checked == true)
            {
                disableRejectionOfUnknownFaceToolStripMenuItem.Checked = false;
            }
            else
            {
                disableRejectionOfUnknownFaceToolStripMenuItem.Checked = true;
            }
        }

        private void useRLDAOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (useRLDAOnlyToolStripMenuItem.Checked == true)
            {
                useRLDAOnlyToolStripMenuItem.Checked = false;
            }
            else
            {
                useRLDAOnlyToolStripMenuItem.Checked = true;
            }
        }

        private void panelStatus_Click(object sender, EventArgs e)
        {
            menuStripIKY.Hide();
            panelMain.Visible = false;
            panelUpdateMain.Visible = false;
            //panelMain.Visible = true;
            panelOperation.Visible = false;
            //panelAttendance.Visible = true;
            panelStatus.Visible = true;
            //panelExitOperation.Visible = true;
            panelAttendanceInfo.Visible = true;
        }

               
    }
}
