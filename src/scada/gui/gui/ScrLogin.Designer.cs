namespace final_ui
{
    partial class ScrLogin
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
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.ptbUser = new System.Windows.Forms.PictureBox();
            this.ptbPassword = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bttLogin = new System.Windows.Forms.Button();
            this.bttClrF = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::final_ui.Properties.Resources._694px_Logo_Hust;
            this.ptbLogo.Location = new System.Drawing.Point(123, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(124, 172);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 12;
            this.ptbLogo.TabStop = false;
            // 
            // ptbUser
            // 
            this.ptbUser.Image = global::final_ui.Properties.Resources._950771;
            this.ptbUser.Location = new System.Drawing.Point(12, 289);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(30, 30);
            this.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUser.TabIndex = 11;
            this.ptbUser.TabStop = false;
            // 
            // ptbPassword
            // 
            this.ptbPassword.Image = global::final_ui.Properties.Resources.password_icon_png_28;
            this.ptbPassword.Location = new System.Drawing.Point(12, 325);
            this.ptbPassword.Name = "ptbPassword";
            this.ptbPassword.Size = new System.Drawing.Size(30, 30);
            this.ptbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPassword.TabIndex = 10;
            this.ptbPassword.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(57, 289);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 30);
            this.txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(57, 325);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 30);
            this.txtPassword.TabIndex = 14;
            // 
            // bttLogin
            // 
            this.bttLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttLogin.Location = new System.Drawing.Point(12, 361);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(345, 49);
            this.bttLogin.TabIndex = 15;
            this.bttLogin.Text = "LOGIN";
            this.bttLogin.UseVisualStyleBackColor = false;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // bttClrF
            // 
            this.bttClrF.BackColor = System.Drawing.SystemColors.Control;
            this.bttClrF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClrF.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bttClrF.Location = new System.Drawing.Point(241, 416);
            this.bttClrF.Name = "bttClrF";
            this.bttClrF.Size = new System.Drawing.Size(116, 34);
            this.bttClrF.TabIndex = 16;
            this.bttClrF.Text = "Clear Fields";
            this.bttClrF.UseVisualStyleBackColor = false;
            this.bttClrF.Click += new System.EventHandler(this.bttClrF_Click);
            // 
            // bttExit
            // 
            this.bttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttExit.Location = new System.Drawing.Point(12, 416);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(89, 34);
            this.bttExit.TabIndex = 17;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(127, 208);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(110, 32);
            this.lblSignIn.TabIndex = 18;
            this.lblSignIn.Text = "Sign In";
            // 
            // txtRole
            // 
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "admin",
            "operator",
            "guest"});
            this.txtRole.Location = new System.Drawing.Point(241, 259);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(116, 24);
            this.txtRole.TabIndex = 29;
            // 
            // scrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 462);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttClrF);
            this.Controls.Add(this.bttLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.ptbUser);
            this.Controls.Add(this.ptbPassword);
            this.Name = "scrLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.scrLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbUser;
        private System.Windows.Forms.PictureBox ptbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.Button bttClrF;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.ComboBox txtRole;
    }
}