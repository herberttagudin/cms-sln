namespace CMS.Savings.Maintenance.View
{
    partial class SavingsAccountType
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkTimeDeposit = new System.Windows.Forms.CheckBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.groupAvailable = new System.Windows.Forms.GroupBox();
            this.checkedMemberTypes = new System.Windows.Forms.CheckedListBox();
            this.txtInitDeposit = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblInitDeposit = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupRequirements = new System.Windows.Forms.GroupBox();
            this.checkMaximumWithdrawal = new System.Windows.Forms.CheckBox();
            this.checkMaintainingBalance = new System.Windows.Forms.CheckBox();
            this.checkInterestRates = new System.Windows.Forms.CheckBox();
            this.checkDormancy = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.numAccountHolder = new System.Windows.Forms.NumericUpDown();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dataAccountType = new System.Windows.Forms.DataGridView();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupAvailable.SuspendLayout();
            this.groupRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(586, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(488, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(390, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.checkTimeDeposit);
            this.groupBox1.Controls.Add(this.btnRetrieve);
            this.groupBox1.Controls.Add(this.groupAvailable);
            this.groupBox1.Controls.Add(this.txtInitDeposit);
            this.groupBox1.Controls.Add(this.lblInitDeposit);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.groupRequirements);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.checkStatus);
            this.groupBox1.Controls.Add(this.numAccountHolder);
            this.groupBox1.Controls.Add(this.lblAccountHolder);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 234);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Modify Savings Account";
            // 
            // checkTimeDeposit
            // 
            this.checkTimeDeposit.AutoSize = true;
            this.checkTimeDeposit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTimeDeposit.Location = new System.Drawing.Point(281, 25);
            this.checkTimeDeposit.Name = "checkTimeDeposit";
            this.checkTimeDeposit.Size = new System.Drawing.Size(117, 24);
            this.checkTimeDeposit.TabIndex = 18;
            this.checkTimeDeposit.Text = "Time Deposit";
            this.checkTimeDeposit.UseVisualStyleBackColor = true;
            this.checkTimeDeposit.CheckedChanged += new System.EventHandler(this.checkTimeDeposit_CheckedChanged);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(163, 196);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(92, 32);
            this.btnRetrieve.TabIndex = 30;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            // 
            // groupAvailable
            // 
            this.groupAvailable.Controls.Add(this.checkedMemberTypes);
            this.groupAvailable.Location = new System.Drawing.Point(462, 26);
            this.groupAvailable.Name = "groupAvailable";
            this.groupAvailable.Size = new System.Drawing.Size(210, 127);
            this.groupAvailable.TabIndex = 26;
            this.groupAvailable.TabStop = false;
            this.groupAvailable.Text = "Available For";
            // 
            // checkedMemberTypes
            // 
            this.checkedMemberTypes.FormattingEnabled = true;
            this.checkedMemberTypes.Location = new System.Drawing.Point(6, 26);
            this.checkedMemberTypes.Name = "checkedMemberTypes";
            this.checkedMemberTypes.Size = new System.Drawing.Size(198, 92);
            this.checkedMemberTypes.TabIndex = 27;
            // 
            // txtInitDeposit
            // 
            this.txtInitDeposit.ContextMenuStrip = this.contextMenuBlank;
            this.txtInitDeposit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitDeposit.Location = new System.Drawing.Point(121, 94);
            this.txtInitDeposit.Name = "txtInitDeposit";
            this.txtInitDeposit.Size = new System.Drawing.Size(143, 27);
            this.txtInitDeposit.TabIndex = 10;
            this.txtInitDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInitDeposit_KeyDown);
            this.txtInitDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInitDeposit_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblInitDeposit
            // 
            this.lblInitDeposit.AutoSize = true;
            this.lblInitDeposit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitDeposit.Location = new System.Drawing.Point(13, 97);
            this.lblInitDeposit.Name = "lblInitDeposit";
            this.lblInitDeposit.Size = new System.Drawing.Size(102, 20);
            this.lblInitDeposit.TabIndex = 9;
            this.lblInitDeposit.Text = "Initial Deposit";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 202);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(574, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupRequirements
            // 
            this.groupRequirements.Controls.Add(this.checkMaximumWithdrawal);
            this.groupRequirements.Controls.Add(this.checkMaintainingBalance);
            this.groupRequirements.Controls.Add(this.checkInterestRates);
            this.groupRequirements.Controls.Add(this.checkDormancy);
            this.groupRequirements.Location = new System.Drawing.Point(275, 59);
            this.groupRequirements.Name = "groupRequirements";
            this.groupRequirements.Size = new System.Drawing.Size(181, 154);
            this.groupRequirements.TabIndex = 19;
            this.groupRequirements.TabStop = false;
            this.groupRequirements.Text = "Requirements";
            // 
            // checkMaximumWithdrawal
            // 
            this.checkMaximumWithdrawal.AutoSize = true;
            this.checkMaximumWithdrawal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaximumWithdrawal.Location = new System.Drawing.Point(6, 56);
            this.checkMaximumWithdrawal.Name = "checkMaximumWithdrawal";
            this.checkMaximumWithdrawal.Size = new System.Drawing.Size(174, 24);
            this.checkMaximumWithdrawal.TabIndex = 21;
            this.checkMaximumWithdrawal.Text = "Maximum Withdrawal";
            this.checkMaximumWithdrawal.UseVisualStyleBackColor = true;
            // 
            // checkMaintainingBalance
            // 
            this.checkMaintainingBalance.AutoSize = true;
            this.checkMaintainingBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaintainingBalance.Location = new System.Drawing.Point(6, 26);
            this.checkMaintainingBalance.Name = "checkMaintainingBalance";
            this.checkMaintainingBalance.Size = new System.Drawing.Size(163, 24);
            this.checkMaintainingBalance.TabIndex = 20;
            this.checkMaintainingBalance.Text = "Maintaining Balance";
            this.checkMaintainingBalance.UseVisualStyleBackColor = true;
            // 
            // checkInterestRates
            // 
            this.checkInterestRates.AutoSize = true;
            this.checkInterestRates.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInterestRates.Location = new System.Drawing.Point(6, 116);
            this.checkInterestRates.Name = "checkInterestRates";
            this.checkInterestRates.Size = new System.Drawing.Size(117, 24);
            this.checkInterestRates.TabIndex = 23;
            this.checkInterestRates.Text = "Interest Rates";
            this.checkInterestRates.UseVisualStyleBackColor = true;
            // 
            // checkDormancy
            // 
            this.checkDormancy.AutoSize = true;
            this.checkDormancy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDormancy.Location = new System.Drawing.Point(6, 86);
            this.checkDormancy.Name = "checkDormancy";
            this.checkDormancy.Size = new System.Drawing.Size(96, 24);
            this.checkDormancy.TabIndex = 22;
            this.checkDormancy.Text = "Dormancy";
            this.checkDormancy.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(476, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Location = new System.Drawing.Point(70, 201);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(69, 24);
            this.checkStatus.TabIndex = 29;
            this.checkStatus.Text = "Active";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // numAccountHolder
            // 
            this.numAccountHolder.ContextMenuStrip = this.contextMenuBlank;
            this.numAccountHolder.Location = new System.Drawing.Point(186, 126);
            this.numAccountHolder.Name = "numAccountHolder";
            this.numAccountHolder.Size = new System.Drawing.Size(53, 27);
            this.numAccountHolder.TabIndex = 25;
            this.numAccountHolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numAccountHolder_KeyDown);
            this.numAccountHolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAccountHolder_KeyPress);
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHolder.Location = new System.Drawing.Point(13, 128);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(167, 20);
            this.lblAccountHolder.TabIndex = 24;
            this.lblAccountHolder.Text = "No. of Account Holders:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(121, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 27);
            this.txtName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // dataAccountType
            // 
            this.dataAccountType.AllowUserToAddRows = false;
            this.dataAccountType.AllowUserToDeleteRows = false;
            this.dataAccountType.AllowUserToResizeRows = false;
            this.dataAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataAccountType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAccountType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccountType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAccountType.Location = new System.Drawing.Point(12, 12);
            this.dataAccountType.MultiSelect = false;
            this.dataAccountType.Name = "dataAccountType";
            this.dataAccountType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAccountType.Size = new System.Drawing.Size(678, 171);
            this.dataAccountType.TabIndex = 1;
            this.dataAccountType.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataAccountType_CellFormatting);
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkArchived.Location = new System.Drawing.Point(12, 194);
            this.checkArchived.Name = "checkArchived";
            this.checkArchived.Size = new System.Drawing.Size(131, 25);
            this.checkArchived.TabIndex = 2;
            this.checkArchived.Text = "Show Archives";
            this.checkArchived.UseVisualStyleBackColor = false;
            // 
            // SavingsAccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.dataAccountType);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "SavingsAccountType";
            this.Text = "Savings Account Type";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAvailable.ResumeLayout(false);
            this.groupRequirements.ResumeLayout(false);
            this.groupRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupRequirements;
        private System.Windows.Forms.CheckBox checkMaintainingBalance;
        private System.Windows.Forms.CheckBox checkInterestRates;
        private System.Windows.Forms.CheckBox checkDormancy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.NumericUpDown numAccountHolder;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkMaximumWithdrawal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtInitDeposit;
        private System.Windows.Forms.Label lblInitDeposit;
        private System.Windows.Forms.GroupBox groupAvailable;
        private System.Windows.Forms.CheckedListBox checkedMemberTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.CheckBox checkArchived;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.DataGridView dataAccountType;
        private System.Windows.Forms.CheckBox checkTimeDeposit;


    }
}