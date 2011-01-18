namespace IKnowYou_v2
{
    partial class SetPasswordForm
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
            System.Windows.Forms.Label labelConfirmPassword;
            System.Windows.Forms.Label labelPassword;
            System.Windows.Forms.Label labelPasswordInfo;
            System.Windows.Forms.Button buttonSavePassword;
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            labelConfirmPassword = new System.Windows.Forms.Label();
            labelPassword = new System.Windows.Forms.Label();
            labelPasswordInfo = new System.Windows.Forms.Label();
            buttonSavePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelConfirmPassword.Location = new System.Drawing.Point(23, 95);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new System.Drawing.Size(111, 13);
            labelConfirmPassword.TabIndex = 65;
            labelConfirmPassword.Text = "Confirm Password:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelPassword.Location = new System.Drawing.Point(23, 44);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(99, 13);
            labelPassword.TabIndex = 64;
            labelPassword.Text = "Enter Password:";
            // 
            // labelPasswordInfo
            // 
            labelPasswordInfo.AutoSize = true;
            labelPasswordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPasswordInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelPasswordInfo.Location = new System.Drawing.Point(23, 9);
            labelPasswordInfo.Name = "labelPasswordInfo";
            labelPasswordInfo.Size = new System.Drawing.Size(259, 17);
            labelPasswordInfo.TabIndex = 68;
            labelPasswordInfo.Text = "Set Administrator Password Below:";
            // 
            // buttonSavePassword
            // 
            buttonSavePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonSavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSavePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonSavePassword.Location = new System.Drawing.Point(26, 148);
            buttonSavePassword.Name = "buttonSavePassword";
            buttonSavePassword.Size = new System.Drawing.Size(107, 38);
            buttonSavePassword.TabIndex = 69;
            buttonSavePassword.Text = "Save";
            buttonSavePassword.UseVisualStyleBackColor = false;
            buttonSavePassword.Click += new System.EventHandler(this.buttonSavePassword_Click);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(26, 111);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = 'X';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(107, 20);
            this.textBoxConfirmPassword.TabIndex = 67;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxPassword.Location = new System.Drawing.Point(26, 60);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = 'X';
            this.textBoxPassword.Size = new System.Drawing.Size(107, 20);
            this.textBoxPassword.TabIndex = 66;
            // 
            // SetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(292, 242);
            this.ControlBox = false;
            this.Controls.Add(buttonSavePassword);
            this.Controls.Add(labelPasswordInfo);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(labelConfirmPassword);
            this.Controls.Add(labelPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SetPasswordForm";
            this.Text = "Set Password";
            this.Load += new System.EventHandler(this.SetPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}