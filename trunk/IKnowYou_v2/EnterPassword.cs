using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IKnowYou_v2
{   
    public partial class EnterPassword : Form
    {
        private static String curPass = null;

        public EnterPassword()
        {
            InitializeComponent();
        }

        public static String getConfirmPas()
        {            
            return curPass;
        }

        private void buttonEnterPassword_Click(object sender, EventArgs e)
        {
            curPass = textBoxPassword.Text;
            this.Close();
        }

        public void clearTextBox()
        {
            textBoxPassword.Clear();
        }

        private void EnterPassword_Load(object sender, EventArgs e)
        {            
            this.Left = ((IKYv2FormMain.getMyWidth()) / 2) - (this.Width/2);
            this.Top=((IKYv2FormMain.getMyHeight())/2)-(this.Height/2);
        }
    }
}
