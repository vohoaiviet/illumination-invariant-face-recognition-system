namespace IKnowYou_v2
{
    partial class IKYv2FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button start;
            System.Windows.Forms.Button buttonCrop;
            System.Windows.Forms.Button buttonDetectFace;
            System.Windows.Forms.Button buttonLoadFrame;
            System.Windows.Forms.Button buttonSave;
            System.Windows.Forms.Button buttonSearch;
            System.Windows.Forms.Button buttonTrain;
            System.Windows.Forms.Button buttonLoadFace;
            System.Windows.Forms.Label personIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactNoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Button buttonDBUpdate;
            System.Windows.Forms.Button buttonDBInsert;
            System.Windows.Forms.Button buttonDelete;
            System.Windows.Forms.Button buttonNext;
            System.Windows.Forms.Button buttonPrevious;
            System.Windows.Forms.Button buttonDisplay;
            System.Windows.Forms.Label labelFace01;
            System.Windows.Forms.Label labelFace02;
            System.Windows.Forms.Label labelFace03;
            System.Windows.Forms.Label labelFace04;
            System.Windows.Forms.Label labelFace05;
            System.Windows.Forms.Label labelFace08;
            System.Windows.Forms.Label labelFace06;
            System.Windows.Forms.Label labelFace07;
            System.Windows.Forms.Label labelFace09;
            System.Windows.Forms.Label labelFace10;
            System.Windows.Forms.Button buttonLoadToDisk;
            System.Windows.Forms.Button buttonDisplayFeatures;
            System.Windows.Forms.Button startBack;
            System.Windows.Forms.Button buttonPreviousFrame;
            System.Windows.Forms.Button startCaptureUpdate;
            System.Windows.Forms.Button stopCaptureUpdate;
            System.Windows.Forms.Label labelCapture;
            System.Windows.Forms.Label labelPhIndex;
            System.Windows.Forms.Button buttonSaveTest;
            System.Windows.Forms.Label labelAuthName;
            System.Windows.Forms.Label labelAuthID;
            System.Windows.Forms.Label labelAuthPhoto;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label labelProceed;
            System.Windows.Forms.Label labelAttInfo;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label labelAddressPersonalInfo;
            System.Windows.Forms.Label labelContactNoPersonalInfo;
            System.Windows.Forms.Label labelemailPersonalInfo;
            this.webCamDisplayBack = new System.Windows.Forms.PictureBox();
            this.webCamDisplay = new System.Windows.Forms.PictureBox();
            this.numCaptureTime = new System.Windows.Forms.NumericUpDown();
            this.stop = new System.Windows.Forms.Button();
            this.pictureBoxFace01 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxMinEud = new System.Windows.Forms.TextBox();
            this.labeTotalFace = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxFacedetection = new System.Windows.Forms.CheckBox();
            this.checkBoxContinuousRecognition = new System.Windows.Forms.CheckBox();
            this.panelRecognition = new System.Windows.Forms.Panel();
            this.pictureBoxMatch04 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatch03 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatch02 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatch01 = new System.Windows.Forms.PictureBox();
            this.panelDetection = new System.Windows.Forms.Panel();
            this.pictureBoxFace04 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFace03 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFace02 = new System.Windows.Forms.PictureBox();
            this.labelWebCamInfo = new System.Windows.Forms.Label();
            this.labelRecognitionResult = new System.Windows.Forms.Label();
            this.labelDetectionBox = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.panelIKYMain = new System.Windows.Forms.Panel();
            this.labelIKYInterface = new System.Windows.Forms.Label();
            this.menuStripIKY = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iKYInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableRejectionOfUnknownFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useRLDAOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUpdateDatabase = new System.Windows.Forms.Panel();
            this.labelUpdateDatabase = new System.Windows.Forms.Label();
            this.panelOperationMode = new System.Windows.Forms.Panel();
            this.labelOperation = new System.Windows.Forms.Label();
            this.panelUpdateMain = new System.Windows.Forms.Panel();
            this.pictureBoxProfileFace = new System.Windows.Forms.PictureBox();
            this.checkBoxLoadFacesFromFrame = new System.Windows.Forms.CheckBox();
            this.textBoxPhotoIndex = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNextFrame = new System.Windows.Forms.Button();
            this.labelWebCamInfoUpdate = new System.Windows.Forms.Label();
            this.stopBack = new System.Windows.Forms.Button();
            this.WebCamDisplayUpdate = new System.Windows.Forms.PictureBox();
            this.WebCamDisplayUpdateBack = new System.Windows.Forms.PictureBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewIKY = new System.Windows.Forms.DataGridView();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iKYDataBaseDataSet = new IKnowYou_v2.IKYDataBaseDataSet();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.textBoxDBemail = new System.Windows.Forms.TextBox();
            this.textBoxDBContactNo = new System.Windows.Forms.TextBox();
            this.textBoxDBAddress = new System.Windows.Forms.TextBox();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.textBoxTotalFaces = new System.Windows.Forms.TextBox();
            this.labelTotalFaces = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.facedetectionTimer = new System.Windows.Forms.Timer(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceIKY = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new IKnowYou_v2.IKYDataBaseDataSetTableAdapters.PersonTableAdapter();
            this.tableAdapterManager = new IKnowYou_v2.IKYDataBaseDataSetTableAdapters.TableAdapterManager();
            this.infoTableAdapter = new IKnowYou_v2.IKYDataBaseDataSetTableAdapters.InfoTableAdapter();
            this.timerCapture = new System.Windows.Forms.Timer(this.components);
            this.panelOperation = new System.Windows.Forms.Panel();
            this.panelUnknownAuthenticationResult = new System.Windows.Forms.Panel();
            this.panelAttendancePerformed = new System.Windows.Forms.Panel();
            this.panelAuthentication = new System.Windows.Forms.Panel();
            this.textBoxAuthID = new System.Windows.Forms.TextBox();
            this.textBoxAuthName = new System.Windows.Forms.TextBox();
            this.pictureBoxAuthPhoto = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelAttendanceAlreadyPerformed = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxStartOperation = new System.Windows.Forms.CheckBox();
            this.labelWebCamOperation = new System.Windows.Forms.Label();
            this.pictureBoxWebCamOperation = new System.Windows.Forms.PictureBox();
            this.pictureBoxWebCamOperationBack = new System.Windows.Forms.PictureBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelAttendanceInfo = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEmailPersonalInfo = new System.Windows.Forms.TextBox();
            this.textBoxContactNoPersonalInfo = new System.Windows.Forms.TextBox();
            this.textBoxAddressPersonalInfo = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeIDPersonalInfo = new System.Windows.Forms.TextBox();
            this.textBoxNamePersonalInfo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBoxPersonalInfo = new System.Windows.Forms.PictureBox();
            this.buttonStatusShowDetails = new System.Windows.Forms.Button();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.timerAutoWebCamDisplayOff = new System.Windows.Forms.Timer(this.components);
            this.timerOperationMode = new System.Windows.Forms.Timer(this.components);
            this.timerObserveFace = new System.Windows.Forms.Timer(this.components);
            this.timerPerformAttendance = new System.Windows.Forms.Timer(this.components);
            start = new System.Windows.Forms.Button();
            buttonCrop = new System.Windows.Forms.Button();
            buttonDetectFace = new System.Windows.Forms.Button();
            buttonLoadFrame = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonSearch = new System.Windows.Forms.Button();
            buttonTrain = new System.Windows.Forms.Button();
            buttonLoadFace = new System.Windows.Forms.Button();
            personIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contactNoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            buttonDBUpdate = new System.Windows.Forms.Button();
            buttonDBInsert = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonNext = new System.Windows.Forms.Button();
            buttonPrevious = new System.Windows.Forms.Button();
            buttonDisplay = new System.Windows.Forms.Button();
            labelFace01 = new System.Windows.Forms.Label();
            labelFace02 = new System.Windows.Forms.Label();
            labelFace03 = new System.Windows.Forms.Label();
            labelFace04 = new System.Windows.Forms.Label();
            labelFace05 = new System.Windows.Forms.Label();
            labelFace08 = new System.Windows.Forms.Label();
            labelFace06 = new System.Windows.Forms.Label();
            labelFace07 = new System.Windows.Forms.Label();
            labelFace09 = new System.Windows.Forms.Label();
            labelFace10 = new System.Windows.Forms.Label();
            buttonLoadToDisk = new System.Windows.Forms.Button();
            buttonDisplayFeatures = new System.Windows.Forms.Button();
            startBack = new System.Windows.Forms.Button();
            buttonPreviousFrame = new System.Windows.Forms.Button();
            startCaptureUpdate = new System.Windows.Forms.Button();
            stopCaptureUpdate = new System.Windows.Forms.Button();
            labelCapture = new System.Windows.Forms.Label();
            labelPhIndex = new System.Windows.Forms.Label();
            buttonSaveTest = new System.Windows.Forms.Button();
            labelAuthName = new System.Windows.Forms.Label();
            labelAuthID = new System.Windows.Forms.Label();
            labelAuthPhoto = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            labelProceed = new System.Windows.Forms.Label();
            labelAttInfo = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            labelAddressPersonalInfo = new System.Windows.Forms.Label();
            labelContactNoPersonalInfo = new System.Windows.Forms.Label();
            labelemailPersonalInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webCamDisplayBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webCamDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaptureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace01)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRecognition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch01)).BeginInit();
            this.panelDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace02)).BeginInit();
            this.panelIKYMain.SuspendLayout();
            this.menuStripIKY.SuspendLayout();
            this.panelUpdateDatabase.SuspendLayout();
            this.panelOperationMode.SuspendLayout();
            this.panelUpdateMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamDisplayUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamDisplayUpdateBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKYDataBaseDataSet)).BeginInit();
            this.panelStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIKY)).BeginInit();
            this.panelOperation.SuspendLayout();
            this.panelUnknownAuthenticationResult.SuspendLayout();
            this.panelAttendancePerformed.SuspendLayout();
            this.panelAuthentication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthPhoto)).BeginInit();
            this.panelAttendanceAlreadyPerformed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCamOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCamOperationBack)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.panelAttendanceInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            start.Anchor = System.Windows.Forms.AnchorStyles.None;
            start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            start.Location = new System.Drawing.Point(132, 408);
            start.Name = "start";
            start.Size = new System.Drawing.Size(75, 23);
            start.TabIndex = 19;
            start.Text = "ON";
            start.UseVisualStyleBackColor = false;
            start.Click += new System.EventHandler(this.start_Click);
            // 
            // buttonCrop
            // 
            buttonCrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonCrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonCrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonCrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonCrop.Location = new System.Drawing.Point(18, 153);
            buttonCrop.Name = "buttonCrop";
            buttonCrop.Size = new System.Drawing.Size(100, 50);
            buttonCrop.TabIndex = 33;
            buttonCrop.Text = "Crop";
            buttonCrop.UseVisualStyleBackColor = false;
            buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // buttonDetectFace
            // 
            buttonDetectFace.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonDetectFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonDetectFace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonDetectFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDetectFace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonDetectFace.Location = new System.Drawing.Point(18, 97);
            buttonDetectFace.Name = "buttonDetectFace";
            buttonDetectFace.Size = new System.Drawing.Size(100, 50);
            buttonDetectFace.TabIndex = 35;
            buttonDetectFace.Text = "Detect";
            buttonDetectFace.UseVisualStyleBackColor = false;
            buttonDetectFace.Click += new System.EventHandler(this.buttonDetectFace_Click);
            // 
            // buttonLoadFrame
            // 
            buttonLoadFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonLoadFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonLoadFrame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonLoadFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonLoadFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonLoadFrame.Location = new System.Drawing.Point(18, 209);
            buttonLoadFrame.Name = "buttonLoadFrame";
            buttonLoadFrame.Size = new System.Drawing.Size(100, 50);
            buttonLoadFrame.TabIndex = 36;
            buttonLoadFrame.Text = "Load";
            buttonLoadFrame.UseVisualStyleBackColor = false;
            buttonLoadFrame.Click += new System.EventHandler(this.buttonLoadFrame_Click);
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonSave.Location = new System.Drawing.Point(18, 265);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(100, 50);
            buttonSave.TabIndex = 37;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonSearch.Location = new System.Drawing.Point(682, 98);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(100, 50);
            buttonSearch.TabIndex = 40;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonTrain
            // 
            buttonTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonTrain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonTrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonTrain.Location = new System.Drawing.Point(682, 154);
            buttonTrain.Name = "buttonTrain";
            buttonTrain.Size = new System.Drawing.Size(100, 50);
            buttonTrain.TabIndex = 41;
            buttonTrain.Text = "Train";
            buttonTrain.UseVisualStyleBackColor = false;
            buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonLoadFace
            // 
            buttonLoadFace.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonLoadFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonLoadFace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonLoadFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonLoadFace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonLoadFace.Location = new System.Drawing.Point(682, 210);
            buttonLoadFace.Name = "buttonLoadFace";
            buttonLoadFace.Size = new System.Drawing.Size(100, 50);
            buttonLoadFace.TabIndex = 42;
            buttonLoadFace.Text = "Load Face";
            buttonLoadFace.UseVisualStyleBackColor = false;
            buttonLoadFace.Click += new System.EventHandler(this.buttonLoadFace_Click);
            // 
            // personIDLabel
            // 
            personIDLabel.AutoSize = true;
            personIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            personIDLabel.Location = new System.Drawing.Point(447, 20);
            personIDLabel.Name = "personIDLabel";
            personIDLabel.Size = new System.Drawing.Size(67, 13);
            personIDLabel.TabIndex = 49;
            personIDLabel.Text = "Person ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            nameLabel.Location = new System.Drawing.Point(447, 46);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(43, 13);
            nameLabel.TabIndex = 51;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            addressLabel.Location = new System.Drawing.Point(447, 72);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(56, 13);
            addressLabel.TabIndex = 53;
            addressLabel.Text = "Address:";
            // 
            // contactNoLabel
            // 
            contactNoLabel.AutoSize = true;
            contactNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            contactNoLabel.Location = new System.Drawing.Point(446, 125);
            contactNoLabel.Name = "contactNoLabel";
            contactNoLabel.Size = new System.Drawing.Size(75, 13);
            contactNoLabel.TabIndex = 55;
            contactNoLabel.Text = "Contact No:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            emailLabel.Location = new System.Drawing.Point(449, 97);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(40, 13);
            emailLabel.TabIndex = 57;
            emailLabel.Text = "email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label1.Location = new System.Drawing.Point(4, 217);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 13);
            label1.TabIndex = 61;
            label1.Text = "email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label2.Location = new System.Drawing.Point(3, 191);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 13);
            label2.TabIndex = 60;
            label2.Text = "Cell no.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label3.Location = new System.Drawing.Point(3, 165);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 13);
            label3.TabIndex = 59;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label4.Location = new System.Drawing.Point(3, 139);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 13);
            label4.TabIndex = 58;
            label4.Text = "Name:";
            // 
            // buttonDBUpdate
            // 
            buttonDBUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonDBUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonDBUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonDBUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDBUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonDBUpdate.Location = new System.Drawing.Point(585, 270);
            buttonDBUpdate.Name = "buttonDBUpdate";
            buttonDBUpdate.Size = new System.Drawing.Size(100, 50);
            buttonDBUpdate.TabIndex = 96;
            buttonDBUpdate.Text = "Update";
            buttonDBUpdate.UseVisualStyleBackColor = false;
            buttonDBUpdate.Click += new System.EventHandler(this.buttonDBUpdate_Click);
            // 
            // buttonDBInsert
            // 
            buttonDBInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonDBInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonDBInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonDBInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDBInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonDBInsert.Location = new System.Drawing.Point(476, 153);
            buttonDBInsert.Name = "buttonDBInsert";
            buttonDBInsert.Size = new System.Drawing.Size(100, 50);
            buttonDBInsert.TabIndex = 107;
            buttonDBInsert.Text = "Insert";
            buttonDBInsert.UseVisualStyleBackColor = false;
            buttonDBInsert.Click += new System.EventHandler(this.buttonDBInsert_Click);
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonDelete.Location = new System.Drawing.Point(585, 153);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(100, 50);
            buttonDelete.TabIndex = 108;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNext
            // 
            buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonNext.Location = new System.Drawing.Point(694, 210);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new System.Drawing.Size(100, 50);
            buttonNext.TabIndex = 112;
            buttonNext.Text = "Next >>";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonPrevious.Location = new System.Drawing.Point(476, 210);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new System.Drawing.Size(100, 50);
            buttonPrevious.TabIndex = 111;
            buttonPrevious.Text = "<< Previous";
            buttonPrevious.UseVisualStyleBackColor = false;
            buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonDisplay
            // 
            buttonDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonDisplay.Location = new System.Drawing.Point(585, 210);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new System.Drawing.Size(100, 50);
            buttonDisplay.TabIndex = 110;
            buttonDisplay.Text = "Display";
            buttonDisplay.UseVisualStyleBackColor = false;
            buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // labelFace01
            // 
            labelFace01.AutoSize = true;
            labelFace01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace01.Location = new System.Drawing.Point(26, 443);
            labelFace01.Name = "labelFace01";
            labelFace01.Size = new System.Drawing.Size(53, 13);
            labelFace01.TabIndex = 115;
            labelFace01.Text = "Face 01";
            // 
            // labelFace02
            // 
            labelFace02.AutoSize = true;
            labelFace02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace02.Location = new System.Drawing.Point(113, 443);
            labelFace02.Name = "labelFace02";
            labelFace02.Size = new System.Drawing.Size(53, 13);
            labelFace02.TabIndex = 116;
            labelFace02.Text = "Face 02";
            // 
            // labelFace03
            // 
            labelFace03.AutoSize = true;
            labelFace03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace03.Location = new System.Drawing.Point(200, 443);
            labelFace03.Name = "labelFace03";
            labelFace03.Size = new System.Drawing.Size(53, 13);
            labelFace03.TabIndex = 117;
            labelFace03.Text = "Face 03";
            // 
            // labelFace04
            // 
            labelFace04.AutoSize = true;
            labelFace04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace04.Location = new System.Drawing.Point(287, 443);
            labelFace04.Name = "labelFace04";
            labelFace04.Size = new System.Drawing.Size(53, 13);
            labelFace04.TabIndex = 118;
            labelFace04.Text = "Face 04";
            // 
            // labelFace05
            // 
            labelFace05.AutoSize = true;
            labelFace05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace05.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace05.Location = new System.Drawing.Point(374, 443);
            labelFace05.Name = "labelFace05";
            labelFace05.Size = new System.Drawing.Size(53, 13);
            labelFace05.TabIndex = 119;
            labelFace05.Text = "Face 05";
            // 
            // labelFace08
            // 
            labelFace08.AutoSize = true;
            labelFace08.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace08.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace08.Location = new System.Drawing.Point(200, 567);
            labelFace08.Name = "labelFace08";
            labelFace08.Size = new System.Drawing.Size(53, 13);
            labelFace08.TabIndex = 120;
            labelFace08.Text = "Face 08";
            // 
            // labelFace06
            // 
            labelFace06.AutoSize = true;
            labelFace06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace06.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace06.Location = new System.Drawing.Point(26, 567);
            labelFace06.Name = "labelFace06";
            labelFace06.Size = new System.Drawing.Size(53, 13);
            labelFace06.TabIndex = 120;
            labelFace06.Text = "Face 06";
            // 
            // labelFace07
            // 
            labelFace07.AutoSize = true;
            labelFace07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace07.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace07.Location = new System.Drawing.Point(113, 567);
            labelFace07.Name = "labelFace07";
            labelFace07.Size = new System.Drawing.Size(53, 13);
            labelFace07.TabIndex = 121;
            labelFace07.Text = "Face 07";
            // 
            // labelFace09
            // 
            labelFace09.AutoSize = true;
            labelFace09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace09.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace09.Location = new System.Drawing.Point(287, 567);
            labelFace09.Name = "labelFace09";
            labelFace09.Size = new System.Drawing.Size(53, 13);
            labelFace09.TabIndex = 122;
            labelFace09.Text = "Face 09";
            // 
            // labelFace10
            // 
            labelFace10.AutoSize = true;
            labelFace10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFace10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelFace10.Location = new System.Drawing.Point(374, 567);
            labelFace10.Name = "labelFace10";
            labelFace10.Size = new System.Drawing.Size(53, 13);
            labelFace10.TabIndex = 123;
            labelFace10.Text = "Face 10";
            // 
            // buttonLoadToDisk
            // 
            buttonLoadToDisk.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonLoadToDisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonLoadToDisk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonLoadToDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonLoadToDisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonLoadToDisk.Location = new System.Drawing.Point(694, 153);
            buttonLoadToDisk.Name = "buttonLoadToDisk";
            buttonLoadToDisk.Size = new System.Drawing.Size(100, 50);
            buttonLoadToDisk.TabIndex = 125;
            buttonLoadToDisk.Text = "Load To Disk";
            buttonLoadToDisk.UseVisualStyleBackColor = false;
            buttonLoadToDisk.Click += new System.EventHandler(this.buttonLoadToDisk_Click);
            // 
            // buttonDisplayFeatures
            // 
            buttonDisplayFeatures.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonDisplayFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonDisplayFeatures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonDisplayFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDisplayFeatures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonDisplayFeatures.Location = new System.Drawing.Point(18, 324);
            buttonDisplayFeatures.Name = "buttonDisplayFeatures";
            buttonDisplayFeatures.Size = new System.Drawing.Size(100, 50);
            buttonDisplayFeatures.TabIndex = 55;
            buttonDisplayFeatures.Text = "Commit Absent";
            buttonDisplayFeatures.UseVisualStyleBackColor = false;
            buttonDisplayFeatures.Click += new System.EventHandler(this.buttonDisplayFeatures_Click);
            // 
            // startBack
            // 
            startBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            startBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            startBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            startBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            startBack.Location = new System.Drawing.Point(14, 269);
            startBack.Name = "startBack";
            startBack.Size = new System.Drawing.Size(65, 20);
            startBack.TabIndex = 133;
            startBack.Text = "ON";
            startBack.UseVisualStyleBackColor = false;
            startBack.Click += new System.EventHandler(this.startBack_Click);
            // 
            // buttonPreviousFrame
            // 
            buttonPreviousFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonPreviousFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonPreviousFrame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonPreviousFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonPreviousFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonPreviousFrame.Location = new System.Drawing.Point(156, 269);
            buttonPreviousFrame.Name = "buttonPreviousFrame";
            buttonPreviousFrame.Size = new System.Drawing.Size(65, 20);
            buttonPreviousFrame.TabIndex = 137;
            buttonPreviousFrame.Text = "<<";
            buttonPreviousFrame.UseVisualStyleBackColor = false;
            buttonPreviousFrame.Click += new System.EventHandler(this.buttonPreviousFrame_Click);
            // 
            // startCaptureUpdate
            // 
            startCaptureUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            startCaptureUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            startCaptureUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            startCaptureUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startCaptureUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            startCaptureUpdate.Location = new System.Drawing.Point(85, 295);
            startCaptureUpdate.Name = "startCaptureUpdate";
            startCaptureUpdate.Size = new System.Drawing.Size(65, 20);
            startCaptureUpdate.TabIndex = 139;
            startCaptureUpdate.Text = "Start";
            startCaptureUpdate.UseVisualStyleBackColor = false;
            startCaptureUpdate.Click += new System.EventHandler(this.startCaptureUpdate_Click);
            // 
            // stopCaptureUpdate
            // 
            stopCaptureUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            stopCaptureUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            stopCaptureUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            stopCaptureUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stopCaptureUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            stopCaptureUpdate.Location = new System.Drawing.Point(156, 295);
            stopCaptureUpdate.Name = "stopCaptureUpdate";
            stopCaptureUpdate.Size = new System.Drawing.Size(65, 20);
            stopCaptureUpdate.TabIndex = 140;
            stopCaptureUpdate.Text = "Stop";
            stopCaptureUpdate.UseVisualStyleBackColor = false;
            stopCaptureUpdate.Click += new System.EventHandler(this.stopCaptureUpdate_Click);
            // 
            // labelCapture
            // 
            labelCapture.AutoSize = true;
            labelCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCapture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelCapture.Location = new System.Drawing.Point(13, 296);
            labelCapture.Name = "labelCapture";
            labelCapture.Size = new System.Drawing.Size(70, 17);
            labelCapture.TabIndex = 142;
            labelCapture.Text = "Capture:";
            // 
            // labelPhIndex
            // 
            labelPhIndex.AutoSize = true;
            labelPhIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPhIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelPhIndex.Location = new System.Drawing.Point(222, 300);
            labelPhIndex.Name = "labelPhIndex";
            labelPhIndex.Size = new System.Drawing.Size(79, 13);
            labelPhIndex.TabIndex = 145;
            labelPhIndex.Text = "Photo Index:";
            // 
            // buttonSaveTest
            // 
            buttonSaveTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonSaveTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonSaveTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonSaveTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSaveTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonSaveTest.Location = new System.Drawing.Point(370, 154);
            buttonSaveTest.Name = "buttonSaveTest";
            buttonSaveTest.Size = new System.Drawing.Size(100, 50);
            buttonSaveTest.TabIndex = 147;
            buttonSaveTest.Text = "Save test";
            buttonSaveTest.UseVisualStyleBackColor = false;
            buttonSaveTest.Click += new System.EventHandler(this.buttonSaveTest_Click);
            // 
            // labelAuthName
            // 
            labelAuthName.AutoSize = true;
            labelAuthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAuthName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelAuthName.Location = new System.Drawing.Point(12, 126);
            labelAuthName.Name = "labelAuthName";
            labelAuthName.Size = new System.Drawing.Size(43, 13);
            labelAuthName.TabIndex = 63;
            labelAuthName.Text = "Name:";
            // 
            // labelAuthID
            // 
            labelAuthID.AutoSize = true;
            labelAuthID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAuthID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelAuthID.Location = new System.Drawing.Point(12, 152);
            labelAuthID.Name = "labelAuthID";
            labelAuthID.Size = new System.Drawing.Size(48, 13);
            labelAuthID.TabIndex = 65;
            labelAuthID.Text = "ID No.:";
            // 
            // labelAuthPhoto
            // 
            labelAuthPhoto.AutoSize = true;
            labelAuthPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAuthPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelAuthPhoto.Location = new System.Drawing.Point(12, 22);
            labelAuthPhoto.Name = "labelAuthPhoto";
            labelAuthPhoto.Size = new System.Drawing.Size(44, 13);
            labelAuthPhoto.TabIndex = 67;
            labelAuthPhoto.Text = "Photo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label9.Location = new System.Drawing.Point(183, 61);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(194, 31);
            label9.TabIndex = 68;
            label9.Text = "Authenticated";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label10.Location = new System.Drawing.Point(214, 104);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(128, 25);
            label10.TabIndex = 69;
            label10.Text = "Please Wait";
            // 
            // labelProceed
            // 
            labelProceed.AutoSize = true;
            labelProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelProceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelProceed.Location = new System.Drawing.Point(117, 104);
            labelProceed.Name = "labelProceed";
            labelProceed.Size = new System.Drawing.Size(164, 25);
            labelProceed.TabIndex = 69;
            labelProceed.Text = "Please Proceed";
            // 
            // labelAttInfo
            // 
            labelAttInfo.AutoSize = true;
            labelAttInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAttInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelAttInfo.Location = new System.Drawing.Point(47, 61);
            labelAttInfo.Name = "labelAttInfo";
            labelAttInfo.Size = new System.Drawing.Size(305, 31);
            labelAttInfo.TabIndex = 68;
            labelAttInfo.Text = "Attendance Performed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label6.Location = new System.Drawing.Point(117, 104);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(164, 25);
            label6.TabIndex = 69;
            label6.Text = "Please Proceed";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label7.Location = new System.Drawing.Point(15, 37);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(368, 29);
            label7.TabIndex = 68;
            label7.Text = "Attendance Already Performed";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label8.Location = new System.Drawing.Point(126, 108);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(164, 25);
            label8.TabIndex = 69;
            label8.Text = "Please Proceed";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label11.Location = new System.Drawing.Point(95, 65);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(208, 31);
            label11.TabIndex = 68;
            label11.Text = "Unknown Face";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label14.Location = new System.Drawing.Point(3, 227);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(82, 13);
            label14.TabIndex = 59;
            label14.Text = "Employee ID:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label15.Location = new System.Drawing.Point(3, 201);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(43, 13);
            label15.TabIndex = 58;
            label15.Text = "Name:";
            // 
            // labelAddressPersonalInfo
            // 
            labelAddressPersonalInfo.AutoSize = true;
            labelAddressPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAddressPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelAddressPersonalInfo.Location = new System.Drawing.Point(3, 253);
            labelAddressPersonalInfo.Name = "labelAddressPersonalInfo";
            labelAddressPersonalInfo.Size = new System.Drawing.Size(56, 13);
            labelAddressPersonalInfo.TabIndex = 64;
            labelAddressPersonalInfo.Text = "Address:";
            // 
            // labelContactNoPersonalInfo
            // 
            labelContactNoPersonalInfo.AutoSize = true;
            labelContactNoPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelContactNoPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelContactNoPersonalInfo.Location = new System.Drawing.Point(3, 279);
            labelContactNoPersonalInfo.Name = "labelContactNoPersonalInfo";
            labelContactNoPersonalInfo.Size = new System.Drawing.Size(79, 13);
            labelContactNoPersonalInfo.TabIndex = 66;
            labelContactNoPersonalInfo.Text = "Contact No.:";
            // 
            // labelemailPersonalInfo
            // 
            labelemailPersonalInfo.AutoSize = true;
            labelemailPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelemailPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelemailPersonalInfo.Location = new System.Drawing.Point(3, 305);
            labelemailPersonalInfo.Name = "labelemailPersonalInfo";
            labelemailPersonalInfo.Size = new System.Drawing.Size(41, 13);
            labelemailPersonalInfo.TabIndex = 68;
            labelemailPersonalInfo.Text = "Email:";
            // 
            // webCamDisplayBack
            // 
            this.webCamDisplayBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webCamDisplayBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.webCamDisplayBack.Location = new System.Drawing.Point(133, 17);
            this.webCamDisplayBack.Name = "webCamDisplayBack";
            this.webCamDisplayBack.Size = new System.Drawing.Size(532, 384);
            this.webCamDisplayBack.TabIndex = 18;
            this.webCamDisplayBack.TabStop = false;
            // 
            // webCamDisplay
            // 
            this.webCamDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webCamDisplay.Location = new System.Drawing.Point(149, 22);
            this.webCamDisplay.Name = "webCamDisplay";
            this.webCamDisplay.Size = new System.Drawing.Size(500, 375);
            this.webCamDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.webCamDisplay.TabIndex = 17;
            this.webCamDisplay.TabStop = false;
            // 
            // numCaptureTime
            // 
            this.numCaptureTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numCaptureTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.numCaptureTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCaptureTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.numCaptureTime.Location = new System.Drawing.Point(292, 412);
            this.numCaptureTime.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numCaptureTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCaptureTime.Name = "numCaptureTime";
            this.numCaptureTime.Size = new System.Drawing.Size(52, 16);
            this.numCaptureTime.TabIndex = 20;
            this.numCaptureTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCaptureTime.Visible = false;
            // 
            // stop
            // 
            this.stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.stop.Location = new System.Drawing.Point(213, 408);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 21;
            this.stop.Text = "OFF";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pictureBoxFace01
            // 
            this.pictureBoxFace01.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxFace01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxFace01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFace01.Location = new System.Drawing.Point(7, 4);
            this.pictureBoxFace01.Name = "pictureBoxFace01";
            this.pictureBoxFace01.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxFace01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFace01.TabIndex = 32;
            this.pictureBoxFace01.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(buttonDisplayFeatures);
            this.panelMain.Controls.Add(this.textBoxMinEud);
            this.panelMain.Controls.Add(this.labeTotalFace);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelRecognition);
            this.panelMain.Controls.Add(this.panelDetection);
            this.panelMain.Controls.Add(this.labelWebCamInfo);
            this.panelMain.Controls.Add(this.labelRecognitionResult);
            this.panelMain.Controls.Add(this.labelDetectionBox);
            this.panelMain.Controls.Add(buttonSearch);
            this.panelMain.Controls.Add(this.stop);
            this.panelMain.Controls.Add(this.textBoxTest);
            this.panelMain.Controls.Add(start);
            this.panelMain.Controls.Add(this.numCaptureTime);
            this.panelMain.Controls.Add(buttonLoadFace);
            this.panelMain.Controls.Add(buttonTrain);
            this.panelMain.Controls.Add(buttonSave);
            this.panelMain.Controls.Add(buttonDetectFace);
            this.panelMain.Controls.Add(buttonLoadFrame);
            this.panelMain.Controls.Add(buttonCrop);
            this.panelMain.Controls.Add(this.webCamDisplay);
            this.panelMain.Controls.Add(this.webCamDisplayBack);
            this.panelMain.Location = new System.Drawing.Point(190, 81);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 584);
            this.panelMain.TabIndex = 43;
            // 
            // textBoxMinEud
            // 
            this.textBoxMinEud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMinEud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxMinEud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMinEud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxMinEud.Location = new System.Drawing.Point(407, 411);
            this.textBoxMinEud.Name = "textBoxMinEud";
            this.textBoxMinEud.Size = new System.Drawing.Size(53, 20);
            this.textBoxMinEud.TabIndex = 51;
            this.textBoxMinEud.Visible = false;
            // 
            // labeTotalFace
            // 
            this.labeTotalFace.AutoSize = true;
            this.labeTotalFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTotalFace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labeTotalFace.Location = new System.Drawing.Point(465, 409);
            this.labeTotalFace.Name = "labeTotalFace";
            this.labeTotalFace.Size = new System.Drawing.Size(146, 15);
            this.labeTotalFace.TabIndex = 50;
            this.labeTotalFace.Text = "Total Detected Faces:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxFacedetection);
            this.panel1.Controls.Add(this.checkBoxContinuousRecognition);
            this.panel1.Location = new System.Drawing.Point(682, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 50);
            this.panel1.TabIndex = 49;
            // 
            // checkBoxFacedetection
            // 
            this.checkBoxFacedetection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxFacedetection.AutoSize = true;
            this.checkBoxFacedetection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.checkBoxFacedetection.Location = new System.Drawing.Point(6, 26);
            this.checkBoxFacedetection.Name = "checkBoxFacedetection";
            this.checkBoxFacedetection.Size = new System.Drawing.Size(97, 17);
            this.checkBoxFacedetection.TabIndex = 46;
            this.checkBoxFacedetection.Text = "Face detection";
            this.checkBoxFacedetection.UseVisualStyleBackColor = true;
            // 
            // checkBoxContinuousRecognition
            // 
            this.checkBoxContinuousRecognition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxContinuousRecognition.AutoSize = true;
            this.checkBoxContinuousRecognition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.checkBoxContinuousRecognition.Location = new System.Drawing.Point(6, 7);
            this.checkBoxContinuousRecognition.Name = "checkBoxContinuousRecognition";
            this.checkBoxContinuousRecognition.Size = new System.Drawing.Size(71, 17);
            this.checkBoxContinuousRecognition.TabIndex = 45;
            this.checkBoxContinuousRecognition.Text = "RealTime";
            this.checkBoxContinuousRecognition.UseVisualStyleBackColor = true;
            // 
            // panelRecognition
            // 
            this.panelRecognition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelRecognition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecognition.Controls.Add(this.pictureBoxMatch04);
            this.panelRecognition.Controls.Add(this.pictureBoxMatch03);
            this.panelRecognition.Controls.Add(this.pictureBoxMatch02);
            this.panelRecognition.Controls.Add(this.pictureBoxMatch01);
            this.panelRecognition.Location = new System.Drawing.Point(450, 461);
            this.panelRecognition.Name = "panelRecognition";
            this.panelRecognition.Size = new System.Drawing.Size(333, 110);
            this.panelRecognition.TabIndex = 48;
            // 
            // pictureBoxMatch04
            // 
            this.pictureBoxMatch04.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMatch04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxMatch04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMatch04.Location = new System.Drawing.Point(251, 4);
            this.pictureBoxMatch04.Name = "pictureBoxMatch04";
            this.pictureBoxMatch04.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxMatch04.TabIndex = 3;
            this.pictureBoxMatch04.TabStop = false;
            this.pictureBoxMatch04.Click += new System.EventHandler(this.pictureBoxMatch04_Click);
            // 
            // pictureBoxMatch03
            // 
            this.pictureBoxMatch03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMatch03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxMatch03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMatch03.Location = new System.Drawing.Point(170, 4);
            this.pictureBoxMatch03.Name = "pictureBoxMatch03";
            this.pictureBoxMatch03.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxMatch03.TabIndex = 2;
            this.pictureBoxMatch03.TabStop = false;
            this.pictureBoxMatch03.Click += new System.EventHandler(this.pictureBoxMatch03_Click);
            // 
            // pictureBoxMatch02
            // 
            this.pictureBoxMatch02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMatch02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxMatch02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMatch02.Location = new System.Drawing.Point(89, 4);
            this.pictureBoxMatch02.Name = "pictureBoxMatch02";
            this.pictureBoxMatch02.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxMatch02.TabIndex = 1;
            this.pictureBoxMatch02.TabStop = false;
            this.pictureBoxMatch02.Click += new System.EventHandler(this.pictureBoxMatch02_Click);
            // 
            // pictureBoxMatch01
            // 
            this.pictureBoxMatch01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMatch01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxMatch01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMatch01.Location = new System.Drawing.Point(8, 4);
            this.pictureBoxMatch01.Name = "pictureBoxMatch01";
            this.pictureBoxMatch01.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxMatch01.TabIndex = 0;
            this.pictureBoxMatch01.TabStop = false;
            this.pictureBoxMatch01.Click += new System.EventHandler(this.pictureBoxMatch01_Click);
            // 
            // panelDetection
            // 
            this.panelDetection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelDetection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetection.Controls.Add(this.pictureBoxFace04);
            this.panelDetection.Controls.Add(this.pictureBoxFace03);
            this.panelDetection.Controls.Add(this.pictureBoxFace02);
            this.panelDetection.Controls.Add(this.pictureBoxFace01);
            this.panelDetection.Location = new System.Drawing.Point(16, 461);
            this.panelDetection.Name = "panelDetection";
            this.panelDetection.Size = new System.Drawing.Size(333, 110);
            this.panelDetection.TabIndex = 47;
            // 
            // pictureBoxFace04
            // 
            this.pictureBoxFace04.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxFace04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxFace04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFace04.Location = new System.Drawing.Point(250, 4);
            this.pictureBoxFace04.Name = "pictureBoxFace04";
            this.pictureBoxFace04.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxFace04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFace04.TabIndex = 35;
            this.pictureBoxFace04.TabStop = false;
            // 
            // pictureBoxFace03
            // 
            this.pictureBoxFace03.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxFace03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxFace03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFace03.Location = new System.Drawing.Point(169, 4);
            this.pictureBoxFace03.Name = "pictureBoxFace03";
            this.pictureBoxFace03.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxFace03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFace03.TabIndex = 34;
            this.pictureBoxFace03.TabStop = false;
            // 
            // pictureBoxFace02
            // 
            this.pictureBoxFace02.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxFace02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxFace02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFace02.Location = new System.Drawing.Point(88, 4);
            this.pictureBoxFace02.Name = "pictureBoxFace02";
            this.pictureBoxFace02.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxFace02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFace02.TabIndex = 33;
            this.pictureBoxFace02.TabStop = false;
            // 
            // labelWebCamInfo
            // 
            this.labelWebCamInfo.AutoSize = true;
            this.labelWebCamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebCamInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelWebCamInfo.Location = new System.Drawing.Point(318, 195);
            this.labelWebCamInfo.Name = "labelWebCamInfo";
            this.labelWebCamInfo.Size = new System.Drawing.Size(160, 25);
            this.labelWebCamInfo.TabIndex = 46;
            this.labelWebCamInfo.Text = "Web Cam is off";
            // 
            // labelRecognitionResult
            // 
            this.labelRecognitionResult.AutoSize = true;
            this.labelRecognitionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecognitionResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelRecognitionResult.Location = new System.Drawing.Point(447, 443);
            this.labelRecognitionResult.Name = "labelRecognitionResult";
            this.labelRecognitionResult.Size = new System.Drawing.Size(129, 15);
            this.labelRecognitionResult.TabIndex = 44;
            this.labelRecognitionResult.Text = "Recognition Result";
            // 
            // labelDetectionBox
            // 
            this.labelDetectionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDetectionBox.AutoSize = true;
            this.labelDetectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetectionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelDetectionBox.Location = new System.Drawing.Point(16, 445);
            this.labelDetectionBox.Name = "labelDetectionBox";
            this.labelDetectionBox.Size = new System.Drawing.Size(97, 13);
            this.labelDetectionBox.TabIndex = 43;
            this.labelDetectionBox.Text = "Detected Faces";
            // 
            // textBoxTest
            // 
            this.textBoxTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxTest.Location = new System.Drawing.Point(613, 408);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(53, 20);
            this.textBoxTest.TabIndex = 38;
            // 
            // panelIKYMain
            // 
            this.panelIKYMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelIKYMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelIKYMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIKYMain.Controls.Add(this.labelIKYInterface);
            this.panelIKYMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelIKYMain.Location = new System.Drawing.Point(17, 110);
            this.panelIKYMain.Name = "panelIKYMain";
            this.panelIKYMain.Size = new System.Drawing.Size(176, 57);
            this.panelIKYMain.TabIndex = 44;
            this.panelIKYMain.MouseLeave += new System.EventHandler(this.panelIKYMain_MouseLeave);
            this.panelIKYMain.Click += new System.EventHandler(this.panelIKYMain_Click);
            this.panelIKYMain.MouseEnter += new System.EventHandler(this.panelIKYMain_MouseEnter);
            // 
            // labelIKYInterface
            // 
            this.labelIKYInterface.AutoSize = true;
            this.labelIKYInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIKYInterface.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelIKYInterface.Location = new System.Drawing.Point(21, 15);
            this.labelIKYInterface.Name = "labelIKYInterface";
            this.labelIKYInterface.Size = new System.Drawing.Size(132, 24);
            this.labelIKYInterface.TabIndex = 0;
            this.labelIKYInterface.Text = "Administrator";
            this.labelIKYInterface.Click += new System.EventHandler(this.labelIKYInterface_Click);
            this.labelIKYInterface.MouseEnter += new System.EventHandler(this.labelIKYInterface_MouseEnter);
            // 
            // menuStripIKY
            // 
            this.menuStripIKY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.menuStripIKY.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.securityToolStripMenuItem,
            this.algorithmsToolStripMenuItem});
            this.menuStripIKY.Location = new System.Drawing.Point(0, 0);
            this.menuStripIKY.Name = "menuStripIKY";
            this.menuStripIKY.Size = new System.Drawing.Size(1016, 24);
            this.menuStripIKY.TabIndex = 45;
            this.menuStripIKY.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iKYInterfaceToolStripMenuItem,
            this.updateDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.modeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // iKYInterfaceToolStripMenuItem
            // 
            this.iKYInterfaceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.iKYInterfaceToolStripMenuItem.Name = "iKYInterfaceToolStripMenuItem";
            this.iKYInterfaceToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.iKYInterfaceToolStripMenuItem.Text = "Administrator";
            this.iKYInterfaceToolStripMenuItem.Click += new System.EventHandler(this.iKYInterfaceToolStripMenuItem_Click);
            // 
            // updateDatabaseToolStripMenuItem
            // 
            this.updateDatabaseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.updateDatabaseToolStripMenuItem.Name = "updateDatabaseToolStripMenuItem";
            this.updateDatabaseToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.updateDatabaseToolStripMenuItem.Text = "Operation";
            this.updateDatabaseToolStripMenuItem.Click += new System.EventHandler(this.updateDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPasswordToolStripMenuItem});
            this.securityToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.securityToolStripMenuItem.Text = "Security";
            // 
            // setPasswordToolStripMenuItem
            // 
            this.setPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.setPasswordToolStripMenuItem.Name = "setPasswordToolStripMenuItem";
            this.setPasswordToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.setPasswordToolStripMenuItem.Text = "Set Password";
            this.setPasswordToolStripMenuItem.Click += new System.EventHandler(this.setPasswordToolStripMenuItem_Click);
            // 
            // algorithmsToolStripMenuItem
            // 
            this.algorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableRejectionOfUnknownFaceToolStripMenuItem,
            this.useRLDAOnlyToolStripMenuItem});
            this.algorithmsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.algorithmsToolStripMenuItem.Name = "algorithmsToolStripMenuItem";
            this.algorithmsToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.algorithmsToolStripMenuItem.Text = "Algorithms Selection";
            // 
            // disableRejectionOfUnknownFaceToolStripMenuItem
            // 
            this.disableRejectionOfUnknownFaceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.disableRejectionOfUnknownFaceToolStripMenuItem.Name = "disableRejectionOfUnknownFaceToolStripMenuItem";
            this.disableRejectionOfUnknownFaceToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.disableRejectionOfUnknownFaceToolStripMenuItem.Text = "Disable Rejection of Unknown Face";
            this.disableRejectionOfUnknownFaceToolStripMenuItem.Click += new System.EventHandler(this.disableRejectionOfUnknownFaceToolStripMenuItem_Click);
            // 
            // useRLDAOnlyToolStripMenuItem
            // 
            this.useRLDAOnlyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.useRLDAOnlyToolStripMenuItem.Name = "useRLDAOnlyToolStripMenuItem";
            this.useRLDAOnlyToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.useRLDAOnlyToolStripMenuItem.Text = "Use r-LDA only";
            this.useRLDAOnlyToolStripMenuItem.Click += new System.EventHandler(this.useRLDAOnlyToolStripMenuItem_Click);
            // 
            // panelUpdateDatabase
            // 
            this.panelUpdateDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUpdateDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelUpdateDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateDatabase.Controls.Add(this.labelUpdateDatabase);
            this.panelUpdateDatabase.Location = new System.Drawing.Point(17, 173);
            this.panelUpdateDatabase.Name = "panelUpdateDatabase";
            this.panelUpdateDatabase.Size = new System.Drawing.Size(176, 57);
            this.panelUpdateDatabase.TabIndex = 46;
            this.panelUpdateDatabase.MouseLeave += new System.EventHandler(this.panelUpdateDatabase_MouseLeave);
            this.panelUpdateDatabase.Click += new System.EventHandler(this.panelUpdateDatabase_Click);
            this.panelUpdateDatabase.MouseEnter += new System.EventHandler(this.panelUpdateDatabase_MouseEnter);
            // 
            // labelUpdateDatabase
            // 
            this.labelUpdateDatabase.AutoSize = true;
            this.labelUpdateDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelUpdateDatabase.Location = new System.Drawing.Point(49, 15);
            this.labelUpdateDatabase.Name = "labelUpdateDatabase";
            this.labelUpdateDatabase.Size = new System.Drawing.Size(76, 24);
            this.labelUpdateDatabase.TabIndex = 1;
            this.labelUpdateDatabase.Text = "Update";
            this.labelUpdateDatabase.Click += new System.EventHandler(this.labelUpdateDatabase_Click);
            this.labelUpdateDatabase.MouseEnter += new System.EventHandler(this.labelUpdateDatabase_MouseEnter);
            // 
            // panelOperationMode
            // 
            this.panelOperationMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelOperationMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelOperationMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOperationMode.Controls.Add(this.labelOperation);
            this.panelOperationMode.Location = new System.Drawing.Point(17, 236);
            this.panelOperationMode.Name = "panelOperationMode";
            this.panelOperationMode.Size = new System.Drawing.Size(176, 57);
            this.panelOperationMode.TabIndex = 47;
            this.panelOperationMode.MouseLeave += new System.EventHandler(this.panelExit_MouseLeave);
            this.panelOperationMode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelOperationMode_MouseClick);
            this.panelOperationMode.MouseEnter += new System.EventHandler(this.panelExit_MouseEnter);
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelOperation.Location = new System.Drawing.Point(7, 15);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(161, 24);
            this.labelOperation.TabIndex = 2;
            this.labelOperation.Text = "Operation Mode";
            this.labelOperation.Click += new System.EventHandler(this.labelOperation_Click);
            this.labelOperation.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            // 
            // panelUpdateMain
            // 
            this.panelUpdateMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUpdateMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelUpdateMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateMain.Controls.Add(this.pictureBoxProfileFace);
            this.panelUpdateMain.Controls.Add(buttonSaveTest);
            this.panelUpdateMain.Controls.Add(this.checkBoxLoadFacesFromFrame);
            this.panelUpdateMain.Controls.Add(this.textBoxPhotoIndex);
            this.panelUpdateMain.Controls.Add(this.buttonRefresh);
            this.panelUpdateMain.Controls.Add(stopCaptureUpdate);
            this.panelUpdateMain.Controls.Add(startCaptureUpdate);
            this.panelUpdateMain.Controls.Add(this.buttonNextFrame);
            this.panelUpdateMain.Controls.Add(buttonPreviousFrame);
            this.panelUpdateMain.Controls.Add(this.labelWebCamInfoUpdate);
            this.panelUpdateMain.Controls.Add(this.stopBack);
            this.panelUpdateMain.Controls.Add(startBack);
            this.panelUpdateMain.Controls.Add(this.WebCamDisplayUpdate);
            this.panelUpdateMain.Controls.Add(this.WebCamDisplayUpdateBack);
            this.panelUpdateMain.Controls.Add(this.contactNoTextBox);
            this.panelUpdateMain.Controls.Add(this.emailTextBox);
            this.panelUpdateMain.Controls.Add(this.addressTextBox);
            this.panelUpdateMain.Controls.Add(this.nameTextBox);
            this.panelUpdateMain.Controls.Add(this.iDTextBox);
            this.panelUpdateMain.Controls.Add(buttonLoadToDisk);
            this.panelUpdateMain.Controls.Add(labelFace10);
            this.panelUpdateMain.Controls.Add(labelFace09);
            this.panelUpdateMain.Controls.Add(labelFace07);
            this.panelUpdateMain.Controls.Add(labelFace06);
            this.panelUpdateMain.Controls.Add(labelFace08);
            this.panelUpdateMain.Controls.Add(labelFace05);
            this.panelUpdateMain.Controls.Add(labelFace04);
            this.panelUpdateMain.Controls.Add(labelFace03);
            this.panelUpdateMain.Controls.Add(labelFace02);
            this.panelUpdateMain.Controls.Add(labelFace01);
            this.panelUpdateMain.Controls.Add(buttonNext);
            this.panelUpdateMain.Controls.Add(buttonPrevious);
            this.panelUpdateMain.Controls.Add(buttonDisplay);
            this.panelUpdateMain.Controls.Add(this.dataGridViewIKY);
            this.panelUpdateMain.Controls.Add(buttonDelete);
            this.panelUpdateMain.Controls.Add(buttonDBInsert);
            this.panelUpdateMain.Controls.Add(this.pictureBox10);
            this.panelUpdateMain.Controls.Add(this.pictureBox9);
            this.panelUpdateMain.Controls.Add(this.pictureBox8);
            this.panelUpdateMain.Controls.Add(this.pictureBox7);
            this.panelUpdateMain.Controls.Add(this.pictureBox6);
            this.panelUpdateMain.Controls.Add(this.pictureBox5);
            this.panelUpdateMain.Controls.Add(this.pictureBox4);
            this.panelUpdateMain.Controls.Add(this.pictureBox3);
            this.panelUpdateMain.Controls.Add(this.pictureBox2);
            this.panelUpdateMain.Controls.Add(this.pictureBox1);
            this.panelUpdateMain.Controls.Add(buttonDBUpdate);
            this.panelUpdateMain.Controls.Add(personIDLabel);
            this.panelUpdateMain.Controls.Add(emailLabel);
            this.panelUpdateMain.Controls.Add(contactNoLabel);
            this.panelUpdateMain.Controls.Add(addressLabel);
            this.panelUpdateMain.Controls.Add(nameLabel);
            this.panelUpdateMain.Controls.Add(labelCapture);
            this.panelUpdateMain.Controls.Add(labelPhIndex);
            this.panelUpdateMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.panelUpdateMain.Location = new System.Drawing.Point(191, 81);
            this.panelUpdateMain.Name = "panelUpdateMain";
            this.panelUpdateMain.Size = new System.Drawing.Size(800, 584);
            this.panelUpdateMain.TabIndex = 48;
            // 
            // pictureBoxProfileFace
            // 
            this.pictureBoxProfileFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBoxProfileFace.Location = new System.Drawing.Point(377, 219);
            this.pictureBoxProfileFace.Name = "pictureBoxProfileFace";
            this.pictureBoxProfileFace.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxProfileFace.TabIndex = 148;
            this.pictureBoxProfileFace.TabStop = false;
            this.pictureBoxProfileFace.Click += new System.EventHandler(this.pictureBoxProfileFace_Click);
            // 
            // checkBoxLoadFacesFromFrame
            // 
            this.checkBoxLoadFacesFromFrame.AutoSize = true;
            this.checkBoxLoadFacesFromFrame.Location = new System.Drawing.Point(17, 319);
            this.checkBoxLoadFacesFromFrame.Name = "checkBoxLoadFacesFromFrame";
            this.checkBoxLoadFacesFromFrame.Size = new System.Drawing.Size(106, 17);
            this.checkBoxLoadFacesFromFrame.TabIndex = 146;
            this.checkBoxLoadFacesFromFrame.Text = "Crop From Frame";
            this.checkBoxLoadFacesFromFrame.UseVisualStyleBackColor = true;
            // 
            // textBoxPhotoIndex
            // 
            this.textBoxPhotoIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxPhotoIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhotoIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhotoIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxPhotoIndex.Location = new System.Drawing.Point(298, 296);
            this.textBoxPhotoIndex.Name = "textBoxPhotoIndex";
            this.textBoxPhotoIndex.Size = new System.Drawing.Size(66, 23);
            this.textBoxPhotoIndex.TabIndex = 144;
            this.textBoxPhotoIndex.Text = "0";
            this.textBoxPhotoIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.buttonRefresh.Location = new System.Drawing.Point(298, 269);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(65, 20);
            this.buttonRefresh.TabIndex = 143;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonNextFrame
            // 
            this.buttonNextFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.buttonNextFrame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNextFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.buttonNextFrame.Location = new System.Drawing.Point(227, 269);
            this.buttonNextFrame.Name = "buttonNextFrame";
            this.buttonNextFrame.Size = new System.Drawing.Size(65, 20);
            this.buttonNextFrame.TabIndex = 138;
            this.buttonNextFrame.Text = ">>";
            this.buttonNextFrame.UseVisualStyleBackColor = false;
            this.buttonNextFrame.Click += new System.EventHandler(this.buttonNextFrame_Click);
            // 
            // labelWebCamInfoUpdate
            // 
            this.labelWebCamInfoUpdate.AutoSize = true;
            this.labelWebCamInfoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebCamInfoUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelWebCamInfoUpdate.Location = new System.Drawing.Point(128, 131);
            this.labelWebCamInfoUpdate.Name = "labelWebCamInfoUpdate";
            this.labelWebCamInfoUpdate.Size = new System.Drawing.Size(117, 17);
            this.labelWebCamInfoUpdate.TabIndex = 136;
            this.labelWebCamInfoUpdate.Text = "Web Cam is off";
            // 
            // stopBack
            // 
            this.stopBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.stopBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.stopBack.Location = new System.Drawing.Point(85, 269);
            this.stopBack.Name = "stopBack";
            this.stopBack.Size = new System.Drawing.Size(65, 20);
            this.stopBack.TabIndex = 135;
            this.stopBack.Text = "OFF";
            this.stopBack.UseVisualStyleBackColor = false;
            this.stopBack.Click += new System.EventHandler(this.stopBack_Click);
            // 
            // WebCamDisplayUpdate
            // 
            this.WebCamDisplayUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WebCamDisplayUpdate.Location = new System.Drawing.Point(29, 18);
            this.WebCamDisplayUpdate.Name = "WebCamDisplayUpdate";
            this.WebCamDisplayUpdate.Size = new System.Drawing.Size(320, 240);
            this.WebCamDisplayUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WebCamDisplayUpdate.TabIndex = 131;
            this.WebCamDisplayUpdate.TabStop = false;
            // 
            // WebCamDisplayUpdateBack
            // 
            this.WebCamDisplayUpdateBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WebCamDisplayUpdateBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.WebCamDisplayUpdateBack.Location = new System.Drawing.Point(13, 12);
            this.WebCamDisplayUpdateBack.Name = "WebCamDisplayUpdateBack";
            this.WebCamDisplayUpdateBack.Size = new System.Drawing.Size(351, 251);
            this.WebCamDisplayUpdateBack.TabIndex = 132;
            this.WebCamDisplayUpdateBack.TabStop = false;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.contactNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactNoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.contactNoTextBox.Location = new System.Drawing.Point(521, 122);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(274, 20);
            this.contactNoTextBox.TabIndex = 130;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.emailTextBox.Location = new System.Drawing.Point(521, 96);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(274, 20);
            this.emailTextBox.TabIndex = 129;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.addressTextBox.Location = new System.Drawing.Point(521, 70);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(274, 20);
            this.addressTextBox.TabIndex = 128;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.nameTextBox.Location = new System.Drawing.Point(521, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(274, 20);
            this.nameTextBox.TabIndex = 127;
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.iDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.iDTextBox.Location = new System.Drawing.Point(521, 18);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(274, 20);
            this.iDTextBox.TabIndex = 126;
            // 
            // dataGridViewIKY
            // 
            this.dataGridViewIKY.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewIKY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIKY.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewIKY.Location = new System.Drawing.Point(456, 337);
            this.dataGridViewIKY.Name = "dataGridViewIKY";
            this.dataGridViewIKY.Size = new System.Drawing.Size(332, 234);
            this.dataGridViewIKY.TabIndex = 109;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox10.Location = new System.Drawing.Point(363, 460);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(75, 100);
            this.pictureBox10.TabIndex = 106;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox9.Location = new System.Drawing.Point(276, 460);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 100);
            this.pictureBox9.TabIndex = 105;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox8.Location = new System.Drawing.Point(189, 460);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(75, 100);
            this.pictureBox8.TabIndex = 104;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox7.Location = new System.Drawing.Point(102, 460);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 100);
            this.pictureBox7.TabIndex = 103;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox6.Location = new System.Drawing.Point(15, 460);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 100);
            this.pictureBox6.TabIndex = 102;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox5.Location = new System.Drawing.Point(363, 338);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 100);
            this.pictureBox5.TabIndex = 101;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox4.Location = new System.Drawing.Point(276, 338);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 100);
            this.pictureBox4.TabIndex = 100;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox3.Location = new System.Drawing.Point(189, 338);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 100);
            this.pictureBox3.TabIndex = 99;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox2.Location = new System.Drawing.Point(102, 338);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 100);
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox1.Location = new System.Drawing.Point(15, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 100);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "Info";
            this.infoBindingSource.DataSource = this.iKYDataBaseDataSet;
            // 
            // iKYDataBaseDataSet
            // 
            this.iKYDataBaseDataSet.DataSetName = "IKYDataBaseDataSet";
            this.iKYDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelStatistics
            // 
            this.panelStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatistics.Controls.Add(this.textBoxDBemail);
            this.panelStatistics.Controls.Add(this.textBoxDBContactNo);
            this.panelStatistics.Controls.Add(this.textBoxDBAddress);
            this.panelStatistics.Controls.Add(this.textBoxDBName);
            this.panelStatistics.Controls.Add(label1);
            this.panelStatistics.Controls.Add(label2);
            this.panelStatistics.Controls.Add(label3);
            this.panelStatistics.Controls.Add(label4);
            this.panelStatistics.Controls.Add(this.pictureBoxDetails);
            this.panelStatistics.Controls.Add(this.textBoxTotalFaces);
            this.panelStatistics.Controls.Add(this.labelTotalFaces);
            this.panelStatistics.Controls.Add(this.labelDetails);
            this.panelStatistics.Location = new System.Drawing.Point(17, 362);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(176, 272);
            this.panelStatistics.TabIndex = 49;
            // 
            // textBoxDBemail
            // 
            this.textBoxDBemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDBemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxDBemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDBemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxDBemail.Location = new System.Drawing.Point(59, 214);
            this.textBoxDBemail.Name = "textBoxDBemail";
            this.textBoxDBemail.Size = new System.Drawing.Size(107, 20);
            this.textBoxDBemail.TabIndex = 65;
            // 
            // textBoxDBContactNo
            // 
            this.textBoxDBContactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDBContactNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxDBContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDBContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxDBContactNo.Location = new System.Drawing.Point(59, 188);
            this.textBoxDBContactNo.Name = "textBoxDBContactNo";
            this.textBoxDBContactNo.Size = new System.Drawing.Size(107, 20);
            this.textBoxDBContactNo.TabIndex = 64;
            // 
            // textBoxDBAddress
            // 
            this.textBoxDBAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDBAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxDBAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDBAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxDBAddress.Location = new System.Drawing.Point(59, 162);
            this.textBoxDBAddress.Name = "textBoxDBAddress";
            this.textBoxDBAddress.Size = new System.Drawing.Size(107, 20);
            this.textBoxDBAddress.TabIndex = 63;
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxDBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxDBName.Location = new System.Drawing.Point(59, 136);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(107, 20);
            this.textBoxDBName.TabIndex = 62;
            // 
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetails.Location = new System.Drawing.Point(47, 27);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetails.TabIndex = 47;
            this.pictureBoxDetails.TabStop = false;
            // 
            // textBoxTotalFaces
            // 
            this.textBoxTotalFaces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTotalFaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxTotalFaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotalFaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxTotalFaces.Location = new System.Drawing.Point(120, 241);
            this.textBoxTotalFaces.Name = "textBoxTotalFaces";
            this.textBoxTotalFaces.Size = new System.Drawing.Size(45, 20);
            this.textBoxTotalFaces.TabIndex = 46;
            // 
            // labelTotalFaces
            // 
            this.labelTotalFaces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalFaces.AutoSize = true;
            this.labelTotalFaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelTotalFaces.Location = new System.Drawing.Point(34, 245);
            this.labelTotalFaces.Name = "labelTotalFaces";
            this.labelTotalFaces.Size = new System.Drawing.Size(82, 13);
            this.labelTotalFaces.TabIndex = 44;
            this.labelTotalFaces.Text = "Total Faces :";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelDetails.Location = new System.Drawing.Point(49, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(78, 24);
            this.labelDetails.TabIndex = 1;
            this.labelDetails.Text = "Details:";
            // 
            // facedetectionTimer
            // 
            this.facedetectionTimer.Interval = 20;
            this.facedetectionTimer.Tick += new System.EventHandler(this.facedetectionTimer_Tick);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.iKYDataBaseDataSet;
            // 
            // bindingSourceIKY
            // 
            this.bindingSourceIKY.DataSource = this.iKYDataBaseDataSet;
            this.bindingSourceIKY.Position = 0;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InfoTableAdapter = this.infoTableAdapter;
            this.tableAdapterManager.PersonTableAdapter = this.personTableAdapter;
            this.tableAdapterManager.UpdateOrder = IKnowYou_v2.IKYDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // timerCapture
            // 
            this.timerCapture.Interval = 1000;
            this.timerCapture.Tick += new System.EventHandler(this.timerCapture_Tick);
            // 
            // panelOperation
            // 
            this.panelOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOperation.Controls.Add(this.panelUnknownAuthenticationResult);
            this.panelOperation.Controls.Add(this.panelAttendancePerformed);
            this.panelOperation.Controls.Add(this.panelAuthentication);
            this.panelOperation.Controls.Add(this.labelDate);
            this.panelOperation.Controls.Add(this.panelAttendanceAlreadyPerformed);
            this.panelOperation.Controls.Add(this.label5);
            this.panelOperation.Controls.Add(this.checkBoxStartOperation);
            this.panelOperation.Controls.Add(this.labelWebCamOperation);
            this.panelOperation.Controls.Add(this.pictureBoxWebCamOperation);
            this.panelOperation.Controls.Add(this.pictureBoxWebCamOperationBack);
            this.panelOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.panelOperation.Location = new System.Drawing.Point(189, 81);
            this.panelOperation.Name = "panelOperation";
            this.panelOperation.Size = new System.Drawing.Size(800, 584);
            this.panelOperation.TabIndex = 50;
            // 
            // panelUnknownAuthenticationResult
            // 
            this.panelUnknownAuthenticationResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUnknownAuthenticationResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelUnknownAuthenticationResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUnknownAuthenticationResult.Controls.Add(label8);
            this.panelUnknownAuthenticationResult.Controls.Add(label11);
            this.panelUnknownAuthenticationResult.Location = new System.Drawing.Point(199, 191);
            this.panelUnknownAuthenticationResult.Name = "panelUnknownAuthenticationResult";
            this.panelUnknownAuthenticationResult.Size = new System.Drawing.Size(400, 200);
            this.panelUnknownAuthenticationResult.TabIndex = 72;
            this.panelUnknownAuthenticationResult.Visible = false;
            // 
            // panelAttendancePerformed
            // 
            this.panelAttendancePerformed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAttendancePerformed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelAttendancePerformed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttendancePerformed.Controls.Add(labelProceed);
            this.panelAttendancePerformed.Controls.Add(labelAttInfo);
            this.panelAttendancePerformed.Location = new System.Drawing.Point(199, 191);
            this.panelAttendancePerformed.Name = "panelAttendancePerformed";
            this.panelAttendancePerformed.Size = new System.Drawing.Size(400, 200);
            this.panelAttendancePerformed.TabIndex = 70;
            this.panelAttendancePerformed.Visible = false;
            // 
            // panelAuthentication
            // 
            this.panelAuthentication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAuthentication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelAuthentication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAuthentication.Controls.Add(label10);
            this.panelAuthentication.Controls.Add(label9);
            this.panelAuthentication.Controls.Add(labelAuthPhoto);
            this.panelAuthentication.Controls.Add(this.textBoxAuthID);
            this.panelAuthentication.Controls.Add(labelAuthID);
            this.panelAuthentication.Controls.Add(this.textBoxAuthName);
            this.panelAuthentication.Controls.Add(labelAuthName);
            this.panelAuthentication.Controls.Add(this.pictureBoxAuthPhoto);
            this.panelAuthentication.Location = new System.Drawing.Point(199, 191);
            this.panelAuthentication.Name = "panelAuthentication";
            this.panelAuthentication.Size = new System.Drawing.Size(400, 200);
            this.panelAuthentication.TabIndex = 60;
            this.panelAuthentication.Visible = false;
            // 
            // textBoxAuthID
            // 
            this.textBoxAuthID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAuthID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxAuthID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAuthID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxAuthID.Location = new System.Drawing.Point(59, 150);
            this.textBoxAuthID.Name = "textBoxAuthID";
            this.textBoxAuthID.Size = new System.Drawing.Size(107, 20);
            this.textBoxAuthID.TabIndex = 66;
            // 
            // textBoxAuthName
            // 
            this.textBoxAuthName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAuthName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxAuthName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAuthName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxAuthName.Location = new System.Drawing.Point(59, 124);
            this.textBoxAuthName.Name = "textBoxAuthName";
            this.textBoxAuthName.Size = new System.Drawing.Size(107, 20);
            this.textBoxAuthName.TabIndex = 64;
            // 
            // pictureBoxAuthPhoto
            // 
            this.pictureBoxAuthPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxAuthPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxAuthPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAuthPhoto.Location = new System.Drawing.Point(76, 17);
            this.pictureBoxAuthPhoto.Name = "pictureBoxAuthPhoto";
            this.pictureBoxAuthPhoto.Size = new System.Drawing.Size(75, 100);
            this.pictureBoxAuthPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAuthPhoto.TabIndex = 48;
            this.pictureBoxAuthPhoto.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(56, 528);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 17);
            this.labelDate.TabIndex = 71;
            this.labelDate.Text = "Date:";
            // 
            // panelAttendanceAlreadyPerformed
            // 
            this.panelAttendanceAlreadyPerformed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAttendanceAlreadyPerformed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelAttendanceAlreadyPerformed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttendanceAlreadyPerformed.Controls.Add(label6);
            this.panelAttendanceAlreadyPerformed.Controls.Add(label7);
            this.panelAttendanceAlreadyPerformed.Location = new System.Drawing.Point(199, 191);
            this.panelAttendanceAlreadyPerformed.Name = "panelAttendanceAlreadyPerformed";
            this.panelAttendanceAlreadyPerformed.Size = new System.Drawing.Size(400, 200);
            this.panelAttendanceAlreadyPerformed.TabIndex = 71;
            this.panelAttendanceAlreadyPerformed.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // checkBoxStartOperation
            // 
            this.checkBoxStartOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxStartOperation.AutoSize = true;
            this.checkBoxStartOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.checkBoxStartOperation.Location = new System.Drawing.Point(627, 531);
            this.checkBoxStartOperation.Name = "checkBoxStartOperation";
            this.checkBoxStartOperation.Size = new System.Drawing.Size(112, 17);
            this.checkBoxStartOperation.TabIndex = 64;
            this.checkBoxStartOperation.Text = "Start Operation";
            this.checkBoxStartOperation.UseVisualStyleBackColor = true;
            this.checkBoxStartOperation.CheckedChanged += new System.EventHandler(this.checkBoxStartOperation_CheckedChanged);
            // 
            // labelWebCamOperation
            // 
            this.labelWebCamOperation.AutoSize = true;
            this.labelWebCamOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebCamOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelWebCamOperation.Location = new System.Drawing.Point(327, 260);
            this.labelWebCamOperation.Name = "labelWebCamOperation";
            this.labelWebCamOperation.Size = new System.Drawing.Size(160, 25);
            this.labelWebCamOperation.TabIndex = 61;
            this.labelWebCamOperation.Text = "Web Cam is off";
            // 
            // pictureBoxWebCamOperation
            // 
            this.pictureBoxWebCamOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWebCamOperation.Location = new System.Drawing.Point(79, 41);
            this.pictureBoxWebCamOperation.Name = "pictureBoxWebCamOperation";
            this.pictureBoxWebCamOperation.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxWebCamOperation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWebCamOperation.TabIndex = 59;
            this.pictureBoxWebCamOperation.TabStop = false;
            // 
            // pictureBoxWebCamOperationBack
            // 
            this.pictureBoxWebCamOperationBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWebCamOperationBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.pictureBoxWebCamOperationBack.Location = new System.Drawing.Point(59, 36);
            this.pictureBoxWebCamOperationBack.Name = "pictureBoxWebCamOperationBack";
            this.pictureBoxWebCamOperationBack.Size = new System.Drawing.Size(680, 490);
            this.pictureBoxWebCamOperationBack.TabIndex = 60;
            this.pictureBoxWebCamOperationBack.TabStop = false;
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Location = new System.Drawing.Point(17, 299);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(176, 57);
            this.panelStatus.TabIndex = 52;
            this.panelStatus.MouseLeave += new System.EventHandler(this.panelStatus_MouseLeave);
            this.panelStatus.Click += new System.EventHandler(this.panelStatus_Click);
            this.panelStatus.MouseEnter += new System.EventHandler(this.panelStatus_MouseEnter);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.labelStatus.Location = new System.Drawing.Point(54, 15);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 24);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // panelAttendanceInfo
            // 
            this.panelAttendanceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAttendanceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelAttendanceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttendanceInfo.Controls.Add(this.label13);
            this.panelAttendanceInfo.Controls.Add(this.label12);
            this.panelAttendanceInfo.Controls.Add(this.panel2);
            this.panelAttendanceInfo.Controls.Add(this.buttonStatusShowDetails);
            this.panelAttendanceInfo.Controls.Add(this.dataGridViewAttendance);
            this.panelAttendanceInfo.Location = new System.Drawing.Point(189, 80);
            this.panelAttendanceInfo.Name = "panelAttendanceInfo";
            this.panelAttendanceInfo.Size = new System.Drawing.Size(800, 584);
            this.panelAttendanceInfo.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(407, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 68;
            this.label13.Text = "Attendance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(89, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 20);
            this.label12.TabIndex = 67;
            this.label12.Text = "Personal Information";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxEmailPersonalInfo);
            this.panel2.Controls.Add(labelemailPersonalInfo);
            this.panel2.Controls.Add(this.textBoxContactNoPersonalInfo);
            this.panel2.Controls.Add(labelContactNoPersonalInfo);
            this.panel2.Controls.Add(this.textBoxAddressPersonalInfo);
            this.panel2.Controls.Add(labelAddressPersonalInfo);
            this.panel2.Controls.Add(this.textBoxEmployeeIDPersonalInfo);
            this.panel2.Controls.Add(this.textBoxNamePersonalInfo);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(label14);
            this.panel2.Controls.Add(label15);
            this.panel2.Controls.Add(this.pictureBoxPersonalInfo);
            this.panel2.Location = new System.Drawing.Point(93, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 349);
            this.panel2.TabIndex = 66;
            // 
            // textBoxEmailPersonalInfo
            // 
            this.textBoxEmailPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxEmailPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmailPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxEmailPersonalInfo.Location = new System.Drawing.Point(97, 303);
            this.textBoxEmailPersonalInfo.Name = "textBoxEmailPersonalInfo";
            this.textBoxEmailPersonalInfo.Size = new System.Drawing.Size(172, 20);
            this.textBoxEmailPersonalInfo.TabIndex = 69;
            // 
            // textBoxContactNoPersonalInfo
            // 
            this.textBoxContactNoPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxContactNoPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContactNoPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxContactNoPersonalInfo.Location = new System.Drawing.Point(97, 277);
            this.textBoxContactNoPersonalInfo.Name = "textBoxContactNoPersonalInfo";
            this.textBoxContactNoPersonalInfo.Size = new System.Drawing.Size(172, 20);
            this.textBoxContactNoPersonalInfo.TabIndex = 67;
            // 
            // textBoxAddressPersonalInfo
            // 
            this.textBoxAddressPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxAddressPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddressPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxAddressPersonalInfo.Location = new System.Drawing.Point(97, 251);
            this.textBoxAddressPersonalInfo.Name = "textBoxAddressPersonalInfo";
            this.textBoxAddressPersonalInfo.Size = new System.Drawing.Size(172, 20);
            this.textBoxAddressPersonalInfo.TabIndex = 65;
            // 
            // textBoxEmployeeIDPersonalInfo
            // 
            this.textBoxEmployeeIDPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxEmployeeIDPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmployeeIDPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxEmployeeIDPersonalInfo.Location = new System.Drawing.Point(97, 225);
            this.textBoxEmployeeIDPersonalInfo.Name = "textBoxEmployeeIDPersonalInfo";
            this.textBoxEmployeeIDPersonalInfo.Size = new System.Drawing.Size(172, 20);
            this.textBoxEmployeeIDPersonalInfo.TabIndex = 63;
            // 
            // textBoxNamePersonalInfo
            // 
            this.textBoxNamePersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxNamePersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNamePersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxNamePersonalInfo.Location = new System.Drawing.Point(97, 199);
            this.textBoxNamePersonalInfo.Name = "textBoxNamePersonalInfo";
            this.textBoxNamePersonalInfo.Size = new System.Drawing.Size(172, 20);
            this.textBoxNamePersonalInfo.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(3, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Photos:";
            // 
            // pictureBoxPersonalInfo
            // 
            this.pictureBoxPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBoxPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPersonalInfo.Location = new System.Drawing.Point(100, 26);
            this.pictureBoxPersonalInfo.Name = "pictureBoxPersonalInfo";
            this.pictureBoxPersonalInfo.Size = new System.Drawing.Size(112, 150);
            this.pictureBoxPersonalInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPersonalInfo.TabIndex = 47;
            this.pictureBoxPersonalInfo.TabStop = false;
            // 
            // buttonStatusShowDetails
            // 
            this.buttonStatusShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.buttonStatusShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatusShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusShowDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.buttonStatusShowDetails.Location = new System.Drawing.Point(99, 437);
            this.buttonStatusShowDetails.Name = "buttonStatusShowDetails";
            this.buttonStatusShowDetails.Size = new System.Drawing.Size(282, 65);
            this.buttonStatusShowDetails.TabIndex = 65;
            this.buttonStatusShowDetails.Text = "Show Details";
            this.buttonStatusShowDetails.UseVisualStyleBackColor = false;
            this.buttonStatusShowDetails.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(408, 66);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.Size = new System.Drawing.Size(302, 485);
            this.dataGridViewAttendance.TabIndex = 64;
            // 
            // timerAutoWebCamDisplayOff
            // 
            this.timerAutoWebCamDisplayOff.Tick += new System.EventHandler(this.timerAutoWebCamDisplayOff_Tick);
            // 
            // timerOperationMode
            // 
            this.timerOperationMode.Tick += new System.EventHandler(this.timerOperationMode_Tick);
            // 
            // timerObserveFace
            // 
            this.timerObserveFace.Tick += new System.EventHandler(this.timerObserveFace_Tick);
            // 
            // timerPerformAttendance
            // 
            this.timerPerformAttendance.Interval = 3000;
            this.timerPerformAttendance.Tick += new System.EventHandler(this.timerPerformAttendance_Tick);
            // 
            // IKYv2FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1016, 746);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.menuStripIKY);
            this.Controls.Add(this.panelIKYMain);
            this.Controls.Add(this.panelUpdateDatabase);
            this.Controls.Add(this.panelOperationMode);
            this.Controls.Add(this.panelStatistics);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelOperation);
            this.Controls.Add(this.panelUpdateMain);
            this.Controls.Add(this.panelAttendanceInfo);
            this.MainMenuStrip = this.menuStripIKY;
            this.Name = "IKYv2FormMain";
            this.Text = " I Know You Ver 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IKYv2FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webCamDisplayBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webCamDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaptureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace01)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRecognition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch01)).EndInit();
            this.panelDetection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace02)).EndInit();
            this.panelIKYMain.ResumeLayout(false);
            this.panelIKYMain.PerformLayout();
            this.menuStripIKY.ResumeLayout(false);
            this.menuStripIKY.PerformLayout();
            this.panelUpdateDatabase.ResumeLayout(false);
            this.panelUpdateDatabase.PerformLayout();
            this.panelOperationMode.ResumeLayout(false);
            this.panelOperationMode.PerformLayout();
            this.panelUpdateMain.ResumeLayout(false);
            this.panelUpdateMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamDisplayUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamDisplayUpdateBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKYDataBaseDataSet)).EndInit();
            this.panelStatistics.ResumeLayout(false);
            this.panelStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIKY)).EndInit();
            this.panelOperation.ResumeLayout(false);
            this.panelOperation.PerformLayout();
            this.panelUnknownAuthenticationResult.ResumeLayout(false);
            this.panelUnknownAuthenticationResult.PerformLayout();
            this.panelAttendancePerformed.ResumeLayout(false);
            this.panelAttendancePerformed.PerformLayout();
            this.panelAuthentication.ResumeLayout(false);
            this.panelAuthentication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthPhoto)).EndInit();
            this.panelAttendanceAlreadyPerformed.ResumeLayout(false);
            this.panelAttendanceAlreadyPerformed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCamOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCamOperationBack)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelAttendanceInfo.ResumeLayout(false);
            this.panelAttendanceInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox webCamDisplayBack;
        private System.Windows.Forms.PictureBox webCamDisplay;
        private System.Windows.Forms.NumericUpDown numCaptureTime;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.PictureBox pictureBoxFace01;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelIKYMain;
        private System.Windows.Forms.MenuStrip menuStripIKY;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iKYInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelUpdateDatabase;
        private System.Windows.Forms.Panel panelOperationMode;
        private System.Windows.Forms.Label labelIKYInterface;
        private System.Windows.Forms.Label labelUpdateDatabase;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Panel panelUpdateMain;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelDetectionBox;
        private System.Windows.Forms.Label labelRecognitionResult;
        private System.Windows.Forms.CheckBox checkBoxContinuousRecognition;
        private System.Windows.Forms.Label labelTotalFaces;
        private System.Windows.Forms.TextBox textBoxTotalFaces;
        private System.Windows.Forms.Label labelWebCamInfo;
        private System.Windows.Forms.Timer facedetectionTimer;
        private System.Windows.Forms.PictureBox pictureBoxMatch01;
        private System.Windows.Forms.Panel panelDetection;
        private System.Windows.Forms.Panel panelRecognition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxFacedetection;
        private System.Windows.Forms.PictureBox pictureBoxFace04;
        private System.Windows.Forms.PictureBox pictureBoxFace03;
        private System.Windows.Forms.PictureBox pictureBoxFace02;
        private System.Windows.Forms.PictureBox pictureBoxMatch04;
        private System.Windows.Forms.PictureBox pictureBoxMatch03;
        private System.Windows.Forms.PictureBox pictureBoxMatch02;
        private System.Windows.Forms.BindingSource bindingSourceIKY;
        private IKYDataBaseDataSet iKYDataBaseDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private IKnowYou_v2.IKYDataBaseDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private IKnowYou_v2.IKYDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBoxDetails;
        private System.Windows.Forms.TextBox textBoxDBemail;
        private System.Windows.Forms.TextBox textBoxDBContactNo;
        private System.Windows.Forms.TextBox textBoxDBAddress;
        private System.Windows.Forms.TextBox textBoxDBName;
        private IKnowYou_v2.IKYDataBaseDataSetTableAdapters.InfoTableAdapter infoTableAdapter;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Label labeTotalFace;
        private System.Windows.Forms.TextBox textBoxMinEud;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.DataGridView dataGridViewIKY;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Label labelWebCamInfoUpdate;
        private System.Windows.Forms.Button stopBack;
        private System.Windows.Forms.PictureBox WebCamDisplayUpdate;
        private System.Windows.Forms.PictureBox WebCamDisplayUpdateBack;
        private System.Windows.Forms.Button buttonNextFrame;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxPhotoIndex;
        private System.Windows.Forms.Timer timerCapture;
        private System.Windows.Forms.CheckBox checkBoxLoadFacesFromFrame;
        private System.Windows.Forms.Panel panelOperation;
        private System.Windows.Forms.Label labelWebCamOperation;
        private System.Windows.Forms.PictureBox pictureBoxWebCamOperation;
        private System.Windows.Forms.PictureBox pictureBoxWebCamOperationBack;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBoxProfileFace;
        private System.Windows.Forms.Panel panelAttendanceInfo;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.Button buttonStatusShowDetails;
        private System.Windows.Forms.Timer timerAutoWebCamDisplayOff;
        private System.Windows.Forms.CheckBox checkBoxStartOperation;
        private System.Windows.Forms.Timer timerOperationMode;
        private System.Windows.Forms.Timer timerObserveFace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelAuthentication;
        private System.Windows.Forms.PictureBox pictureBoxAuthPhoto;
        private System.Windows.Forms.TextBox textBoxAuthName;
        private System.Windows.Forms.TextBox textBoxAuthID;
        private System.Windows.Forms.Panel panelAttendancePerformed;
        private System.Windows.Forms.Timer timerPerformAttendance;
        private System.Windows.Forms.Panel panelAttendanceAlreadyPerformed;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panelUnknownAuthenticationResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxEmployeeIDPersonalInfo;
        private System.Windows.Forms.TextBox textBoxNamePersonalInfo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBoxPersonalInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEmailPersonalInfo;
        private System.Windows.Forms.TextBox textBoxContactNoPersonalInfo;
        private System.Windows.Forms.TextBox textBoxAddressPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableRejectionOfUnknownFaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useRLDAOnlyToolStripMenuItem;
    }
}

