﻿namespace CMS.Savings.Transaction.View
{
    partial class SavingsTransaction
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
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.checkRepresentative = new System.Windows.Forms.CheckBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboTransaction = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtRepresentative = new System.Windows.Forms.TextBox();
            this.groupWithdrawal = new System.Windows.Forms.GroupBox();
            this.groupAccount = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPassbook = new System.Windows.Forms.Button();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.dataAccountHolder = new System.Windows.Forms.DataGridView();
            this.txtSavingsAccountNo = new System.Windows.Forms.TextBox();
            this.lblSavingsAccount = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            this.groupWithdrawal.SuspendLayout();
            this.groupAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSearch
            // 
            this.groupSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupSearch.Controls.Add(this.label1);
            this.groupSearch.Controls.Add(this.txtAccountNo);
            this.groupSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.Location = new System.Drawing.Point(12, 12);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(332, 63);
            this.groupSearch.TabIndex = 1;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account No";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(99, 26);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(227, 27);
            this.txtAccountNo.TabIndex = 3;
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
            this.dataMember.Location = new System.Drawing.Point(12, 81);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(332, 215);
            this.dataMember.TabIndex = 6;
            // 
            // lblTransaction
            // 
            this.lblTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.Location = new System.Drawing.Point(22, 305);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(132, 20);
            this.lblTransaction.TabIndex = 7;
            this.lblTransaction.Text = "Select Transaction:";
            // 
            // checkRepresentative
            // 
            this.checkRepresentative.AutoSize = true;
            this.checkRepresentative.Location = new System.Drawing.Point(13, 61);
            this.checkRepresentative.Name = "checkRepresentative";
            this.checkRepresentative.Size = new System.Drawing.Size(192, 25);
            this.checkRepresentative.TabIndex = 12;
            this.checkRepresentative.Text = "done by Representative";
            this.checkRepresentative.UseVisualStyleBackColor = true;
            this.checkRepresentative.CheckedChanged += new System.EventHandler(this.checkRepresentative_CheckedChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 30);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 21);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(502, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 32);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(600, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // comboTransaction
            // 
            this.comboTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTransaction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTransaction.FormattingEnabled = true;
            this.comboTransaction.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.comboTransaction.Location = new System.Drawing.Point(160, 302);
            this.comboTransaction.Name = "comboTransaction";
            this.comboTransaction.Size = new System.Drawing.Size(167, 28);
            this.comboTransaction.TabIndex = 8;
            this.comboTransaction.SelectedIndexChanged += new System.EventHandler(this.comboTransaction_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(84, 28);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(242, 27);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // txtRepresentative
            // 
            this.txtRepresentative.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepresentative.Location = new System.Drawing.Point(13, 92);
            this.txtRepresentative.Name = "txtRepresentative";
            this.txtRepresentative.Size = new System.Drawing.Size(313, 27);
            this.txtRepresentative.TabIndex = 13;
            // 
            // groupWithdrawal
            // 
            this.groupWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupWithdrawal.Controls.Add(this.txtRepresentative);
            this.groupWithdrawal.Controls.Add(this.txtAmount);
            this.groupWithdrawal.Controls.Add(this.checkRepresentative);
            this.groupWithdrawal.Controls.Add(this.lblAmount);
            this.groupWithdrawal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupWithdrawal.Location = new System.Drawing.Point(12, 336);
            this.groupWithdrawal.Name = "groupWithdrawal";
            this.groupWithdrawal.Size = new System.Drawing.Size(332, 125);
            this.groupWithdrawal.TabIndex = 9;
            this.groupWithdrawal.TabStop = false;
            this.groupWithdrawal.Text = "Transaction";
            // 
            // groupAccount
            // 
            this.groupAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupAccount.Controls.Add(this.txtAccountBalance);
            this.groupAccount.Controls.Add(this.lblAccountBalance);
            this.groupAccount.Controls.Add(this.btnView);
            this.groupAccount.Controls.Add(this.btnPassbook);
            this.groupAccount.Controls.Add(this.lblAccountHolder);
            this.groupAccount.Controls.Add(this.dataAccountHolder);
            this.groupAccount.Controls.Add(this.txtSavingsAccountNo);
            this.groupAccount.Controls.Add(this.lblSavingsAccount);
            this.groupAccount.Location = new System.Drawing.Point(364, 29);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Size = new System.Drawing.Size(328, 301);
            this.groupAccount.TabIndex = 14;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "Account Details";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(39, 244);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(115, 51);
            this.btnView.TabIndex = 21;
            this.btnView.Text = "&View Signature Card";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnPassbook
            // 
            this.btnPassbook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassbook.Location = new System.Drawing.Point(186, 244);
            this.btnPassbook.Name = "btnPassbook";
            this.btnPassbook.Size = new System.Drawing.Size(115, 51);
            this.btnPassbook.TabIndex = 22;
            this.btnPassbook.Text = "Passbook Re&issuance";
            this.btnPassbook.UseVisualStyleBackColor = true;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Location = new System.Drawing.Point(15, 105);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(130, 21);
            this.lblAccountHolder.TabIndex = 19;
            this.lblAccountHolder.Text = "Account Holder/s";
            // 
            // dataAccountHolder
            // 
            this.dataAccountHolder.AllowUserToAddRows = false;
            this.dataAccountHolder.AllowUserToDeleteRows = false;
            this.dataAccountHolder.AllowUserToResizeRows = false;
            this.dataAccountHolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAccountHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccountHolder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAccountHolder.Location = new System.Drawing.Point(6, 134);
            this.dataAccountHolder.MultiSelect = false;
            this.dataAccountHolder.Name = "dataAccountHolder";
            this.dataAccountHolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAccountHolder.Size = new System.Drawing.Size(316, 95);
            this.dataAccountHolder.TabIndex = 20;
            // 
            // txtSavingsAccountNo
            // 
            this.txtSavingsAccountNo.Enabled = false;
            this.txtSavingsAccountNo.Location = new System.Drawing.Point(170, 28);
            this.txtSavingsAccountNo.Name = "txtSavingsAccountNo";
            this.txtSavingsAccountNo.Size = new System.Drawing.Size(152, 29);
            this.txtSavingsAccountNo.TabIndex = 16;
            // 
            // lblSavingsAccount
            // 
            this.lblSavingsAccount.AutoSize = true;
            this.lblSavingsAccount.Location = new System.Drawing.Point(15, 31);
            this.lblSavingsAccount.Name = "lblSavingsAccount";
            this.lblSavingsAccount.Size = new System.Drawing.Size(149, 21);
            this.lblSavingsAccount.TabIndex = 15;
            this.lblSavingsAccount.Text = "Savings Account No";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Enabled = false;
            this.txtAccountBalance.Location = new System.Drawing.Point(170, 63);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(152, 29);
            this.txtAccountBalance.TabIndex = 18;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(15, 66);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(123, 21);
            this.lblAccountBalance.TabIndex = 17;
            this.lblAccountBalance.Text = "Account Balance";
            // 
            // SavingsTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.groupAccount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboTransaction);
            this.Controls.Add(this.groupWithdrawal);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.dataMember);
            this.Controls.Add(this.groupSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "SavingsTransaction";
            this.Text = "Savings Transaction";
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.groupWithdrawal.ResumeLayout(false);
            this.groupWithdrawal.PerformLayout();
            this.groupAccount.ResumeLayout(false);
            this.groupAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.CheckBox checkRepresentative;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboTransaction;
        private System.Windows.Forms.TextBox txtRepresentative;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupWithdrawal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupAccount;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.DataGridView dataAccountHolder;
        private System.Windows.Forms.TextBox txtSavingsAccountNo;
        private System.Windows.Forms.Label lblSavingsAccount;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPassbook;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.Label lblAccountBalance;
    }
}