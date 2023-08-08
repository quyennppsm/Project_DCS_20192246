namespace final_ui
{
    partial class ScrAdmin
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
            this.dbvUser = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.bttClrF = new System.Windows.Forms.Button();
            this.btnVRP = new System.Windows.Forms.Button();
            this.bttSignout = new System.Windows.Forms.Button();
            this.btnWRP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dbvUser
            // 
            this.dbvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbvUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dbvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvUser.Location = new System.Drawing.Point(277, 11);
            this.dbvUser.Margin = new System.Windows.Forms.Padding(2);
            this.dbvUser.Name = "dbvUser";
            this.dbvUser.ReadOnly = true;
            this.dbvUser.RowTemplate.Height = 24;
            this.dbvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbvUser.Size = new System.Drawing.Size(759, 319);
            this.dbvUser.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(12, 71);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(59, 17);
            this.lblAccount.TabIndex = 12;
            this.lblAccount.Text = "Account";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(87, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 22);
            this.txtId.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 22);
            this.txtName.TabIndex = 19;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(87, 68);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(185, 22);
            this.txtAccount.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 22);
            this.txtPassword.TabIndex = 21;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(12, 127);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 17);
            this.lblRole.TabIndex = 25;
            this.lblRole.Text = "Role";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(197, 152);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 39);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 152);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 39);
            this.btnChange.TabIndex = 27;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtRole
            // 
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "admin",
            "operator",
            "guest"});
            this.txtRole.Location = new System.Drawing.Point(87, 124);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(185, 24);
            this.txtRole.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(104, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bttExit
            // 
            this.bttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttExit.Location = new System.Drawing.Point(12, 295);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(72, 34);
            this.bttExit.TabIndex = 30;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttClrF
            // 
            this.bttClrF.BackColor = System.Drawing.SystemColors.Control;
            this.bttClrF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClrF.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bttClrF.Location = new System.Drawing.Point(197, 197);
            this.bttClrF.Name = "bttClrF";
            this.bttClrF.Size = new System.Drawing.Size(75, 34);
            this.bttClrF.TabIndex = 31;
            this.bttClrF.Text = "Clear";
            this.bttClrF.UseVisualStyleBackColor = false;
            this.bttClrF.Click += new System.EventHandler(this.bttClrF_Click);
            // 
            // btnVRP
            // 
            this.btnVRP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVRP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVRP.Location = new System.Drawing.Point(12, 215);
            this.btnVRP.Name = "btnVRP";
            this.btnVRP.Size = new System.Drawing.Size(167, 34);
            this.btnVRP.TabIndex = 32;
            this.btnVRP.Text = "View Logs";
            this.btnVRP.UseVisualStyleBackColor = false;
            this.btnVRP.Click += new System.EventHandler(this.btnVRP_Click);
            // 
            // bttSignout
            // 
            this.bttSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSignout.ForeColor = System.Drawing.Color.Red;
            this.bttSignout.Location = new System.Drawing.Point(169, 295);
            this.bttSignout.Name = "bttSignout";
            this.bttSignout.Size = new System.Drawing.Size(103, 34);
            this.bttSignout.TabIndex = 246;
            this.bttSignout.Text = "Sign Out";
            this.bttSignout.UseVisualStyleBackColor = true;
            this.bttSignout.Click += new System.EventHandler(this.bttSignout_Click);
            // 
            // btnWRP
            // 
            this.btnWRP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWRP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWRP.Location = new System.Drawing.Point(15, 255);
            this.btnWRP.Name = "btnWRP";
            this.btnWRP.Size = new System.Drawing.Size(257, 34);
            this.btnWRP.TabIndex = 247;
            this.btnWRP.Text = "Write Today Report";
            this.btnWRP.UseVisualStyleBackColor = false;
            this.btnWRP.Click += new System.EventHandler(this.btnWRP_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(76, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 248;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScrAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWRP);
            this.Controls.Add(this.bttSignout);
            this.Controls.Add(this.btnVRP);
            this.Controls.Add(this.bttClrF);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dbvUser);
            this.Name = "ScrAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.scrAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbvUser;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox txtRole;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Button bttClrF;
        private System.Windows.Forms.Button btnVRP;
        private System.Windows.Forms.Button bttSignout;
        private System.Windows.Forms.Button btnWRP;
        private System.Windows.Forms.Button button1;
    }
}

