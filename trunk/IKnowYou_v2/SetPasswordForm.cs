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
    public partial class SetPasswordForm : Form
    {
        public SetPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            String pasOriginal = textBoxPassword.Text;
            String pasConfirm = textBoxConfirmPassword.Text;
            if (pasOriginal == pasConfirm)
            {
                DatabaseManager.deletePassword();
                DatabaseManager.savePassword(pasOriginal);
            }

            else
            {
                MessageBox.Show("Confirmed Password doesn't match with original !");
            }
            
            String retPas = DatabaseManager.accessPassword();
            //MessageBox.Show(retPas);
            this.Close();
        }

        public void clearTextBox()
        {
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
        }

        private void SetPasswordForm_Load(object sender, EventArgs e)
        {
            this.Left = ((IKYv2FormMain.getMyWidth()) / 2) - (this.Width / 2);
            this.Top = ((IKYv2FormMain.getMyHeight()) / 2) - (this.Height / 2);
        }
    }
}
