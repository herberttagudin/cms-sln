namespace CMS.Loan_Management.Transaction.View
{
    partial class ShareCapitalContribution
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbAccountNo = new System.Windows.Forms.TextBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.rbAcctName = new System.Windows.Forms.RadioButton();
            this.rbAcctNo = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbDeposit = new System.Windows.Forms.GroupBox();
            this.tbNewBal = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tbDepAmt = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridShare = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.gbDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShare)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.tbAccountNo);
            this.groupBox4.Controls.Add(this.tbAccountName);
            this.groupBox4.Controls.Add(this.rbAcctName);
            this.groupBox4.Controls.Add(this.rbAcctNo);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(680, 109);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Member";
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAccountNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNo.Location = new System.Drawing.Point(161, 33);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(425, 27);
            this.tbAccountNo.TabIndex = 32;
            this.tbAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            // 
            // tbAccountName
            // 
            this.tbAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAccountName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountName.Location = new System.Drawing.Point(161, 66);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(425, 27);
            this.tbAccountName.TabIndex = 33;
            this.tbAccountName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            // 
            // rbAcctName
            // 
            this.rbAcctName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAcctName.AutoSize = true;
            this.rbAcctName.Location = new System.Drawing.Point(13, 67);
            this.rbAcctName.Name = "rbAcctName";
            this.rbAcctName.Size = new System.Drawing.Size(130, 24);
            this.rbAcctName.TabIndex = 31;
            this.rbAcctName.TabStop = true;
            this.rbAcctName.Text = "Member Name:";
            this.rbAcctName.UseVisualStyleBackColor = true;
            this.rbAcctName.CheckedChanged += new System.EventHandler(this.rbAcctName_CheckedChanged);
            // 
            // rbAcctNo
            // 
            this.rbAcctNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAcctNo.AutoSize = true;
            this.rbAcctNo.Location = new System.Drawing.Point(13, 33);
            this.rbAcctNo.Name = "rbAcctNo";
            this.rbAcctNo.Size = new System.Drawing.Size(142, 24);
            this.rbAcctNo.TabIndex = 31;
            this.rbAcctNo.TabStop = true;
            this.rbAcctNo.Text = "Account Number:";
            this.rbAcctNo.UseVisualStyleBackColor = true;
            this.rbAcctNo.CheckedChanged += new System.EventHandler(this.rbAcctNo_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(592, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 34);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(594, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbDeposit
            // 
            this.gbDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDeposit.Controls.Add(this.tbNewBal);
            this.gbDeposit.Controls.Add(this.lblBalance);
            this.gbDeposit.Controls.Add(this.tbDepAmt);
            this.gbDeposit.Controls.Add(this.lblAmt);
            this.gbDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeposit.Location = new System.Drawing.Point(12, 314);
            this.gbDeposit.Name = "gbDeposit";
            this.gbDeposit.Size = new System.Drawing.Size(680, 109);
            this.gbDeposit.TabIndex = 64;
            this.gbDeposit.TabStop = false;
            this.gbDeposit.Text = "Capital Contribution";
            // 
            // tbNewBal
            // 
            this.tbNewBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewBal.ContextMenuStrip = this.contextMenuBlank;
            this.tbNewBal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbNewBal.Location = new System.Drawing.Point(463, 65);
            this.tbNewBal.Name = "tbNewBal";
            this.tbNewBal.Size = new System.Drawing.Size(210, 35);
            this.tbNewBal.TabIndex = 23;
            this.tbNewBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(277, 71);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(180, 21);
            this.lblBalance.TabIndex = 20;
            this.lblBalance.Text = "New Account Balance:";
            // 
            // tbDepAmt
            // 
            this.tbDepAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDepAmt.ContextMenuStrip = this.contextMenuBlank;
            this.tbDepAmt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepAmt.Location = new System.Drawing.Point(463, 19);
            this.tbDepAmt.Name = "tbDepAmt";
            this.tbDepAmt.Size = new System.Drawing.Size(211, 29);
            this.tbDepAmt.TabIndex = 22;
            this.tbDepAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDepAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            this.tbDepAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDepAmt_KeyPress);
            // 
            // lblAmt
            // 
            this.lblAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmt.Location = new System.Drawing.Point(388, 22);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(69, 21);
            this.lblAmt.TabIndex = 21;
            this.lblAmt.Text = "Amount:";
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridShare
            // 
            this.dataGridShare.AllowUserToAddRows = false;
            this.dataGridShare.AllowUserToDeleteRows = false;
            this.dataGridShare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridShare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridShare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShare.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridShare.Location = new System.Drawing.Point(12, 127);
            this.dataGridShare.Name = "dataGridShare";
            this.dataGridShare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridShare.Size = new System.Drawing.Size(674, 181);
            this.dataGridShare.TabIndex = 67;
            this.dataGridShare.SelectionChanged += new System.EventHandler(this.dataGridShare_SelectionChanged);
            // 
            // ShareCapitalContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.dataGridShare);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbDeposit);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "ShareCapitalContribution";
            this.Text = "Share Capital Contribution";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDeposit.ResumeLayout(false);
            this.gbDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbAccountNo;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.RadioButton rbAcctName;
        private System.Windows.Forms.RadioButton rbAcctNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbDeposit;
        private System.Windows.Forms.TextBox tbNewBal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox tbDepAmt;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.DataGridView dataGridShare;
    }
}