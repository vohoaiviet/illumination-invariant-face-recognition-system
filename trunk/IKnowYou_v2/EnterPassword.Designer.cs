namespace IKnowYou_v2
{
    partial class EnterPassword
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
            System.Windows.Forms.Label labelPassword;
            System.Windows.Forms.Button buttonEnterPassword;
            System.Windows.Forms.Label label1;
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            labelPassword = new System.Windows.Forms.Label();
            buttonEnterPassword = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            labelPassword.Location = new System.Drawing.Point(32, 19);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(99, 13);
            labelPassword.TabIndex = 69;
            labelPassword.Text = "Enter Password:";
            // 
            // buttonEnterPassword
            // 
            buttonEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            buttonEnterPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonEnterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            buttonEnterPassword.Location = new System.Drawing.Point(35, 61);
            buttonEnterPassword.Name = "buttonEnterPassword";
            buttonEnterPassword.Size = new System.Drawing.Size(107, 38);
            buttonEnterPassword.TabIndex = 71;
            buttonEnterPassword.Text = "OK";
            buttonEnterPassword.UseVisualStyleBackColor = false;
            buttonEnterPassword.Click += new System.EventHandler(this.buttonEnterPassword_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            label1.Location = new System.Drawing.Point(35, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 13);
            label1.TabIndex = 69;
            label1.Text = "Enter Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.textBoxPassword.Location = new System.Drawing.Point(35, 35);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = 'X';
            this.textBoxPassword.Size = new System.Drawing.Size(107, 20);
            this.textBoxPassword.TabIndex = 70;
            // 
            // EnterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(190, 131);
            this.ControlBox = false;
            this.Controls.Add(buttonEnterPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(label1);
            this.Controls.Add(labelPassword);
            this.Location = new System.Drawing.Point(600, 600);
            this.MinimizeBox = false;
            this.Name = "EnterPassword";
            this.Text = "Enter Password";
            this.Load += new System.EventHandler(this.EnterPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
    }
}