namespace CMS.Savings.Transaction.View
{
    partial class TimeDepositWithdrawal
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
            this.dataTimeDeposit = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.txtCertificateNo = new System.Windows.Forms.TextBox();
            this.radioCertificateNo = new System.Windows.Forms.RadioButton();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.radioMemberName = new System.Windows.Forms.RadioButton();
            this.radioAccountNo = new System.Windows.Forms.RadioButton();
            this.groupBreakdown = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimeDeposit)).BeginInit();
            this.groupSearch.SuspendLayout();
            this.groupBreakdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTimeDeposit
            // 
            this.dataTimeDeposit.AllowUserToAddRows = false;
            this.dataTimeDeposit.AllowUserToDeleteRows = false;
            this.dataTimeDeposit.AllowUserToResizeRows = false;
            this.dataTimeDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTimeDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTimeDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimeDeposit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTimeDeposit.Location = new System.Drawing.Point(12, 144);
            this.dataTimeDeposit.MultiSelect = false;
            this.dataTimeDeposit.Name = "dataTimeDeposit";
            this.dataTimeDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTimeDeposit.Size = new System.Drawing.Size(680, 185);
            this.dataTimeDeposit.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(600, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupSearch
            // 
            this.groupSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupSearch.Controls.Add(this.txtCertificateNo);
            this.groupSearch.Controls.Add(this.radioCertificateNo);
            this.groupSearch.Controls.Add(this.txtAccountNo);
            this.groupSearch.Controls.Add(this.txtMemberName);
            this.groupSearch.Controls.Add(this.radioMemberName);
            this.groupSearch.Controls.Add(this.radioAccountNo);
            this.groupSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.Location = new System.Drawing.Point(60, 12);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(580, 126);
            this.groupSearch.TabIndex = 1;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search Member";
            // 
            // txtCertificateNo
            // 
            this.txtCertificateNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCertificateNo.Location = new System.Drawing.Point(161, 92);
            this.txtCertificateNo.Name = "txtCertificateNo";
            this.txtCertificateNo.Size = new System.Drawing.Size(407, 27);
            this.txtCertificateNo.TabIndex = 7;
            // 
            // radioCertificateNo
            // 
            this.radioCertificateNo.AutoSize = true;
            this.radioCertificateNo.Location = new System.Drawing.Point(13, 93);
            this.radioCertificateNo.Name = "radioCertificateNo";
            this.radioCertificateNo.Size = new System.Drawing.Size(122, 24);
            this.radioCertificateNo.TabIndex = 6;
            this.radioCertificateNo.TabStop = true;
            this.radioCertificateNo.Text = "Certificate No:";
            this.radioCertificateNo.UseVisualStyleBackColor = true;
            this.radioCertificateNo.CheckedChanged += new System.EventHandler(this.radioCertificateNo_CheckedChanged);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(161, 26);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(407, 27);
            this.txtAccountNo.TabIndex = 3;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(161, 59);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(407, 27);
            this.txtMemberName.TabIndex = 5;
            // 
            // radioMemberName
            // 
            this.radioMemberName.AutoSize = true;
            this.radioMemberName.Location = new System.Drawing.Point(13, 60);
            this.radioMemberName.Name = "radioMemberName";
            this.radioMemberName.Size = new System.Drawing.Size(130, 24);
            this.radioMemberName.TabIndex = 4;
            this.radioMemberName.TabStop = true;
            this.radioMemberName.Text = "Member Name:";
            this.radioMemberName.UseVisualStyleBackColor = true;
            this.radioMemberName.CheckedChanged += new System.EventHandler(this.radioMemberName_CheckedChanged);
            // 
            // radioAccountNo
            // 
            this.radioAccountNo.AutoSize = true;
            this.radioAccountNo.Location = new System.Drawing.Point(13, 27);
            this.radioAccountNo.Name = "radioAccountNo";
            this.radioAccountNo.Size = new System.Drawing.Size(142, 24);
            this.radioAccountNo.TabIndex = 2;
            this.radioAccountNo.Text = "Account Number:";
            this.radioAccountNo.UseVisualStyleBackColor = true;
            this.radioAccountNo.CheckedChanged += new System.EventHandler(this.radioAccountNo_CheckedChanged);
            // 
            // groupBreakdown
            // 
            this.groupBreakdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBreakdown.Controls.Add(this.lblTotal);
            this.groupBreakdown.Controls.Add(this.lblPenalty);
            this.groupBreakdown.Controls.Add(this.lblGross);
            this.groupBreakdown.Controls.Add(this.txtTotal);
            this.groupBreakdown.Controls.Add(this.txtGross);
            this.groupBreakdown.Controls.Add(this.txtPenalty);
            this.groupBreakdown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBreakdown.Location = new System.Drawing.Point(34, 335);
            this.groupBreakdown.Name = "groupBreakdown";
            this.groupBreakdown.Size = new System.Drawing.Size(403, 126);
            this.groupBreakdown.TabIndex = 9;
            this.groupBreakdown.TabStop = false;
            this.groupBreakdown.Text = "Withdrawable Amount Breakdown";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(9, 95);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(163, 20);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Withdrawable Amount";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.Location = new System.Drawing.Point(9, 62);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(211, 20);
            this.lblPenalty.TabIndex = 12;
            this.lblPenalty.Text = "less: Early Withdrawal Penalties";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(9, 29);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(102, 20);
            this.lblGross.TabIndex = 10;
            this.lblGross.Text = "Gross Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(230, 92);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 27);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGross
            // 
            this.txtGross.Enabled = false;
            this.txtGross.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross.Location = new System.Drawing.Point(230, 26);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(160, 27);
            this.txtGross.TabIndex = 11;
            this.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPenalty
            // 
            this.txtPenalty.Enabled = false;
            this.txtPenalty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenalty.Location = new System.Drawing.Point(230, 59);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(160, 27);
            this.txtPenalty.TabIndex = 13;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(502, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 32);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // TimeDepositWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBreakdown);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataTimeDeposit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "TimeDepositWithdrawal";
            this.Text = "Time Deposit Withdrawal";
            ((System.ComponentModel.ISupportInitialize)(this.dataTimeDeposit)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            this.groupBreakdown.ResumeLayout(false);
            this.groupBreakdown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTimeDeposit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.TextBox txtCertificateNo;
        private System.Windows.Forms.RadioButton radioCertificateNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton radioMemberName;
        private System.Windows.Forms.RadioButton radioAccountNo;
        private System.Windows.Forms.GroupBox groupBreakdown;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Button btnClear;
    }
}