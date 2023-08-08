namespace final_ui
{
    partial class ScrAllLog
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
            this.rptLog = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bttSignout = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptLog
            // 
            this.rptLog.Location = new System.Drawing.Point(12, 12);
            this.rptLog.Name = "rptLog";
            this.rptLog.ServerReport.BearerToken = null;
            this.rptLog.Size = new System.Drawing.Size(888, 793);
            this.rptLog.TabIndex = 0;
            // 
            // bttSignout
            // 
            this.bttSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSignout.ForeColor = System.Drawing.Color.Red;
            this.bttSignout.Location = new System.Drawing.Point(795, 811);
            this.bttSignout.Name = "bttSignout";
            this.bttSignout.Size = new System.Drawing.Size(105, 34);
            this.bttSignout.TabIndex = 247;
            this.bttSignout.Text = "Sign Out";
            this.bttSignout.UseVisualStyleBackColor = true;
            this.bttSignout.Click += new System.EventHandler(this.bttSignout_Click);
            // 
            // bttExit
            // 
            this.bttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttExit.Location = new System.Drawing.Point(12, 811);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(105, 34);
            this.bttExit.TabIndex = 246;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // scrGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 857);
            this.Controls.Add(this.bttSignout);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.rptLog);
            this.Name = "scrGuest";
            this.Text = "All Logs";
            this.Load += new System.EventHandler(this.scrGuest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptLog;
        private System.Windows.Forms.Button bttSignout;
        private System.Windows.Forms.Button bttExit;
    }
}