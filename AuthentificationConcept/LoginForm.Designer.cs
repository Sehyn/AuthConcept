namespace AuthentificationConcept
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.AuthGrpBox = new System.Windows.Forms.GroupBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.SaveUsernameChk = new System.Windows.Forms.CheckBox();
            this.SavePasswordChk = new System.Windows.Forms.CheckBox();
            this.AutoLoginChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.AuthGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(6, 26);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(61, 13);
            this.UsernameLbl.TabIndex = 0;
            this.UsernameLbl.Text = "Username :";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(411, 50);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(8, 50);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(59, 13);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Password :";
            // 
            // AuthGrpBox
            // 
            this.AuthGrpBox.Controls.Add(this.LoginBtn);
            this.AuthGrpBox.Controls.Add(this.PasswordTxt);
            this.AuthGrpBox.Controls.Add(this.UsernameTxt);
            this.AuthGrpBox.Controls.Add(this.UsernameLbl);
            this.AuthGrpBox.Controls.Add(this.PasswordLbl);
            this.AuthGrpBox.Location = new System.Drawing.Point(12, 68);
            this.AuthGrpBox.Name = "AuthGrpBox";
            this.AuthGrpBox.Size = new System.Drawing.Size(411, 113);
            this.AuthGrpBox.TabIndex = 3;
            this.AuthGrpBox.TabStop = false;
            this.AuthGrpBox.Text = "Authentication :";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(69, 76);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(331, 23);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(69, 50);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(331, 20);
            this.PasswordTxt.TabIndex = 4;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(69, 24);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(331, 20);
            this.UsernameTxt.TabIndex = 3;
            // 
            // SaveUsernameChk
            // 
            this.SaveUsernameChk.AutoSize = true;
            this.SaveUsernameChk.Location = new System.Drawing.Point(12, 187);
            this.SaveUsernameChk.Name = "SaveUsernameChk";
            this.SaveUsernameChk.Size = new System.Drawing.Size(102, 17);
            this.SaveUsernameChk.TabIndex = 4;
            this.SaveUsernameChk.Text = "Save Username";
            this.SaveUsernameChk.UseVisualStyleBackColor = true;
            // 
            // SavePasswordChk
            // 
            this.SavePasswordChk.AutoSize = true;
            this.SavePasswordChk.Location = new System.Drawing.Point(120, 187);
            this.SavePasswordChk.Name = "SavePasswordChk";
            this.SavePasswordChk.Size = new System.Drawing.Size(100, 17);
            this.SavePasswordChk.TabIndex = 5;
            this.SavePasswordChk.Text = "Save Password";
            this.SavePasswordChk.UseVisualStyleBackColor = true;
            // 
            // AutoLoginChk
            // 
            this.AutoLoginChk.AutoSize = true;
            this.AutoLoginChk.Location = new System.Drawing.Point(226, 187);
            this.AutoLoginChk.Name = "AutoLoginChk";
            this.AutoLoginChk.Size = new System.Drawing.Size(77, 17);
            this.AutoLoginChk.TabIndex = 6;
            this.AutoLoginChk.Text = "Auto Login";
            this.AutoLoginChk.UseVisualStyleBackColor = true;
            this.AutoLoginChk.Click += new System.EventHandler(this.AutoLoginChk_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 212);
            this.Controls.Add(this.AutoLoginChk);
            this.Controls.Add(this.SavePasswordChk);
            this.Controls.Add(this.SaveUsernameChk);
            this.Controls.Add(this.AuthGrpBox);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication - #Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.AuthGrpBox.ResumeLayout(false);
            this.AuthGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.GroupBox AuthGrpBox;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.CheckBox SaveUsernameChk;
        private System.Windows.Forms.CheckBox SavePasswordChk;
        private System.Windows.Forms.CheckBox AutoLoginChk;
    }
}

