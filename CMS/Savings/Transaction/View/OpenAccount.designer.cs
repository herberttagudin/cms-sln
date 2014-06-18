namespace CMS.Savings.Transaction.View
{
    partial class OpenAccount
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
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.dataDepositor = new System.Windows.Forms.DataGridView();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.lblDepositor = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupWithdrawMode = new System.Windows.Forms.GroupBox();
            this.radioOr = new System.Windows.Forms.RadioButton();
            this.radioAnd = new System.Windows.Forms.RadioButton();
            this.txtPassbook = new System.Windows.Forms.TextBox();
            this.lblPassbook = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataDepositor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            this.groupWithdrawMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboAccountType
            // 
            this.comboAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(484, 14);
            this.comboAccountType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(145, 28);
            this.comboAccountType.TabIndex = 4;
            // 
            // dataDepositor
            // 
            this.dataDepositor.AllowUserToAddRows = false;
            this.dataDepositor.AllowUserToDeleteRows = false;
            this.dataDepositor.AllowUserToResizeRows = false;
            this.dataDepositor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataDepositor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDepositor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDepositor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataDepositor.Location = new System.Drawing.Point(378, 139);
            this.dataDepositor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataDepositor.MultiSelect = false;
            this.dataDepositor.Name = "dataDepositor";
            this.dataDepositor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDepositor.Size = new System.Drawing.Size(313, 138);
            this.dataDepositor.TabIndex = 13;
            // 
            // btnBackward
            // 
            this.btnBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackward.Location = new System.Drawing.Point(333, 223);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(37, 36);
            this.btnBackward.TabIndex = 11;
            this.btnBackward.Text = "<";
            this.btnBackward.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.Location = new System.Drawing.Point(333, 177);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(37, 36);
            this.btnForward.TabIndex = 10;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // dataMember
            // 
            this.dataMember.AllowUserToAddRows = false;
            this.dataMember.AllowUserToDeleteRows = false;
            this.dataMember.AllowUserToResizeRows = false;
            this.dataMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMember.Location = new System.Drawing.Point(12, 51);
            this.dataMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(313, 408);
            this.dataMember.TabIndex = 9;
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInitialDeposit.ContextMenuStrip = this.contextMenuBlank;
            this.txtInitialDeposit.Location = new System.Drawing.Point(520, 287);
            this.txtInitialDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(172, 27);
            this.txtInitialDeposit.TabIndex = 15;
            this.txtInitialDeposit.Text = "0";
            this.txtInitialDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Location = new System.Drawing.Point(374, 290);
            this.lblInitialDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(138, 20);
            this.lblInitialDeposit.TabIndex = 14;
            this.lblInitialDeposit.Text = "Initial Deposit:  Php";
            // 
            // lblDepositor
            // 
            this.lblDepositor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepositor.AutoSize = true;
            this.lblDepositor.Location = new System.Drawing.Point(374, 114);
            this.lblDepositor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositor.Name = "lblDepositor";
            this.lblDepositor.Size = new System.Drawing.Size(146, 20);
            this.lblDepositor.TabIndex = 12;
            this.lblDepositor.Text = "Depositing Party/ies:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(374, 17);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(102, 20);
            this.lblAccountType.TabIndex = 3;
            this.lblAccountType.Text = "Account Type:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(128, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Location = new System.Drawing.Point(573, 47);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(119, 20);
            this.lblAccountHolder.TabIndex = 6;
            this.lblAccountHolder.Text = "Account Holders";
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountHolder.Enabled = false;
            this.txtAccountHolder.Location = new System.Drawing.Point(636, 15);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.Size = new System.Drawing.Size(56, 27);
            this.txtAccountHolder.TabIndex = 5;
            this.txtAccountHolder.Text = "0";
            this.txtAccountHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(599, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupWithdrawMode
            // 
            this.groupWithdrawMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupWithdrawMode.Controls.Add(this.radioOr);
            this.groupWithdrawMode.Controls.Add(this.radioAnd);
            this.groupWithdrawMode.Enabled = false;
            this.groupWithdrawMode.Location = new System.Drawing.Point(378, 359);
            this.groupWithdrawMode.Name = "groupWithdrawMode";
            this.groupWithdrawMode.Size = new System.Drawing.Size(200, 56);
            this.groupWithdrawMode.TabIndex = 18;
            this.groupWithdrawMode.TabStop = false;
            this.groupWithdrawMode.Text = "Mode of Withdrawal";
            // 
            // radioOr
            // 
            this.radioOr.AutoSize = true;
            this.radioOr.Location = new System.Drawing.Point(124, 26);
            this.radioOr.Name = "radioOr";
            this.radioOr.Size = new System.Drawing.Size(43, 24);
            this.radioOr.TabIndex = 20;
            this.radioOr.TabStop = true;
            this.radioOr.Text = "Or";
            this.radioOr.UseVisualStyleBackColor = true;
            // 
            // radioAnd
            // 
            this.radioAnd.AutoSize = true;
            this.radioAnd.Location = new System.Drawing.Point(35, 26);
            this.radioAnd.Name = "radioAnd";
            this.radioAnd.Size = new System.Drawing.Size(54, 24);
            this.radioAnd.TabIndex = 19;
            this.radioAnd.TabStop = true;
            this.radioAnd.Text = "And";
            this.radioAnd.UseVisualStyleBackColor = true;
            // 
            // txtPassbook
            // 
            this.txtPassbook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassbook.Enabled = false;
            this.txtPassbook.Location = new System.Drawing.Point(520, 324);
            this.txtPassbook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassbook.Name = "txtPassbook";
            this.txtPassbook.Size = new System.Drawing.Size(172, 27);
            this.txtPassbook.TabIndex = 17;
            this.txtPassbook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPassbook
            // 
            this.lblPassbook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassbook.AutoSize = true;
            this.lblPassbook.Location = new System.Drawing.Point(374, 327);
            this.lblPassbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassbook.Name = "lblPassbook";
            this.lblPassbook.Size = new System.Drawing.Size(95, 20);
            this.lblPassbook.TabIndex = 16;
            this.lblPassbook.Text = "Passbook No";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Location = new System.Drawing.Point(520, 72);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(172, 27);
            this.txtAccountNo.TabIndex = 8;
            this.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(374, 75);
            this.lblAccountNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(141, 20);
            this.lblAccountNo.TabIndex = 7;
            this.lblAccountNo.Text = "Savings Account No";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(501, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 32);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblMemberName
            // 
            this.lblMemberName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(12, 17);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(109, 20);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Member Name";
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // OpenAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.txtPassbook);
            this.Controls.Add(this.lblPassbook);
            this.Controls.Add(this.groupWithdrawMode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAccountHolder);
            this.Controls.Add(this.lblAccountHolder);
            this.Controls.Add(this.comboAccountType);
            this.Controls.Add(this.dataDepositor);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.dataMember);
            this.Controls.Add(this.txtInitialDeposit);
            this.Controls.Add(this.lblInitialDeposit);
            this.Controls.Add(this.lblDepositor);
            this.Controls.Add(this.lblAccountType);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "OpenAccount";
            this.Text = "Open Account";
            ((System.ComponentModel.ISupportInitialize)(this.dataDepositor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.groupWithdrawMode.ResumeLayout(false);
            this.groupWithdrawMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.DataGridView dataDepositor;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.Label lblInitialDeposit;
        private System.Windows.Forms.Label lblDepositor;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupWithdrawMode;
        private System.Windows.Forms.RadioButton radioOr;
        private System.Windows.Forms.RadioButton radioAnd;
        private System.Windows.Forms.TextBox txtPassbook;
        private System.Windows.Forms.Label lblPassbook;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
    }
}