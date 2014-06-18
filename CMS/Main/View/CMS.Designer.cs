namespace CMS.Main.View
{
    partial class CMS
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.linkSignout = new System.Windows.Forms.LinkLabel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLoanManagement = new System.Windows.Forms.Button();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.autoCollapse = new System.Windows.Forms.CheckBox();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelHome = new System.Windows.Forms.Panel();
            this.lblUserWelcome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.statusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.linkSignout);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnLoanManagement);
            this.panelMenu.Controls.Add(this.pictureUser);
            this.panelMenu.Controls.Add(this.lblUser);
            this.panelMenu.Controls.Add(this.btnSavings);
            this.panelMenu.Controls.Add(this.btnPayments);
            this.panelMenu.Controls.Add(this.btnShow);
            this.panelMenu.Controls.Add(this.autoCollapse);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(624, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(160, 561);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.MouseEnter += new System.EventHandler(this.panelMenu_MouseEnter);
            // 
            // linkSignout
            // 
            this.linkSignout.AutoSize = true;
            this.linkSignout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignout.ForeColor = System.Drawing.Color.White;
            this.linkSignout.LinkColor = System.Drawing.Color.DarkGray;
            this.linkSignout.Location = new System.Drawing.Point(90, 100);
            this.linkSignout.Name = "linkSignout";
            this.linkSignout.Size = new System.Drawing.Size(58, 17);
            this.linkSignout.TabIndex = 9;
            this.linkSignout.TabStop = true;
            this.linkSignout.Text = "Sign Out";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(28, 339);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(120, 60);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnLoanManagement
            // 
            this.btnLoanManagement.Location = new System.Drawing.Point(28, 141);
            this.btnLoanManagement.Name = "btnLoanManagement";
            this.btnLoanManagement.Size = new System.Drawing.Size(120, 60);
            this.btnLoanManagement.TabIndex = 5;
            this.btnLoanManagement.Text = "Loan Management";
            this.btnLoanManagement.UseVisualStyleBackColor = true;
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureUser.Location = new System.Drawing.Point(84, 12);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(64, 64);
            this.pictureUser.TabIndex = 7;
            this.pictureUser.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(6, 79);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(142, 21);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User Name";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSavings
            // 
            this.btnSavings.Location = new System.Drawing.Point(28, 207);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(120, 60);
            this.btnSavings.TabIndex = 4;
            this.btnSavings.Text = "Savings";
            this.btnSavings.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(28, 273);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(120, 60);
            this.btnPayments.TabIndex = 2;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow.Location = new System.Drawing.Point(0, 505);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(26, 30);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = ">";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // autoCollapse
            // 
            this.autoCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoCollapse.AutoSize = true;
            this.autoCollapse.Checked = true;
            this.autoCollapse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCollapse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCollapse.ForeColor = System.Drawing.Color.White;
            this.autoCollapse.Location = new System.Drawing.Point(6, 541);
            this.autoCollapse.Name = "autoCollapse";
            this.autoCollapse.Size = new System.Drawing.Size(102, 19);
            this.autoCollapse.TabIndex = 0;
            this.autoCollapse.Text = "Auto-Collapse";
            this.autoCollapse.UseVisualStyleBackColor = true;
            this.autoCollapse.CheckStateChanged += new System.EventHandler(this.autoCollapse_CheckStateChanged);
            // 
            // statusMain
            // 
            this.statusMain.BackColor = System.Drawing.Color.Tomato;
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDateTime});
            this.statusMain.Location = new System.Drawing.Point(0, 539);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(624, 22);
            this.statusMain.TabIndex = 3;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(61, 17);
            this.lblDateTime.Text = "Date Time";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(149, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "(Membership, Savings and Loan Management)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(148, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cooperative Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(146, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Company Name";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelHome);
            this.splitContainer.Panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer.Size = new System.Drawing.Size(624, 539);
            this.splitContainer.SplitterDistance = 141;
            this.splitContainer.TabIndex = 17;
            // 
            // panelHome
            // 
            this.panelHome.AutoScroll = true;
            this.panelHome.Controls.Add(this.lblUserWelcome);
            this.panelHome.Controls.Add(this.label5);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(624, 394);
            this.panelHome.TabIndex = 0;
            // 
            // lblUserWelcome
            // 
            this.lblUserWelcome.AutoSize = true;
            this.lblUserWelcome.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWelcome.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUserWelcome.Location = new System.Drawing.Point(172, 24);
            this.lblUserWelcome.Name = "lblUserWelcome";
            this.lblUserWelcome.Size = new System.Drawing.Size(61, 32);
            this.lblUserWelcome.TabIndex = 16;
            this.lblUserWelcome.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 45);
            this.label5.TabIndex = 15;
            this.label5.Text = "Welcome";
            // 
            // CMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooperative Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLoanManagement;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox autoCollapse;
        private System.Windows.Forms.LinkLabel linkSignout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblUserWelcome;
        private System.Windows.Forms.Label label5;

    }
}