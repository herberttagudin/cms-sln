namespace CMS.Savings.Maintenance.View
{
    partial class MaintainingBalances
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
            this.dataMaintaningBalance = new System.Windows.Forms.DataGridView();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numChargeDuration = new System.Windows.Forms.NumericUpDown();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboChargeDuration = new System.Windows.Forms.ComboBox();
            this.comboCharge = new System.Windows.Forms.ComboBox();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.txtMaintaningBalance = new System.Windows.Forms.TextBox();
            this.lblMaintainingBalance = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaintaningBalance)).BeginInit();
            this.groupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChargeDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMaintaningBalance
            // 
            this.dataMaintaningBalance.AllowUserToAddRows = false;
            this.dataMaintaningBalance.AllowUserToDeleteRows = false;
            this.dataMaintaningBalance.AllowUserToResizeRows = false;
            this.dataMaintaningBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMaintaningBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMaintaningBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaintaningBalance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMaintaningBalance.Location = new System.Drawing.Point(12, 12);
            this.dataMaintaningBalance.MultiSelect = false;
            this.dataMaintaningBalance.Name = "dataMaintaningBalance";
            this.dataMaintaningBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMaintaningBalance.Size = new System.Drawing.Size(678, 171);
            this.dataMaintaningBalance.TabIndex = 1;
            this.dataMaintaningBalance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataMaintaningBalance_CellFormatting);
            // 
            // groupMain
            // 
            this.groupMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupMain.Controls.Add(this.lblStatus);
            this.groupMain.Controls.Add(this.checkStatus);
            this.groupMain.Controls.Add(this.btnCancel);
            this.groupMain.Controls.Add(this.btnSave);
            this.groupMain.Controls.Add(this.numChargeDuration);
            this.groupMain.Controls.Add(this.comboChargeDuration);
            this.groupMain.Controls.Add(this.comboCharge);
            this.groupMain.Controls.Add(this.comboAccountType);
            this.groupMain.Controls.Add(this.txtCharge);
            this.groupMain.Controls.Add(this.lblAccountType);
            this.groupMain.Controls.Add(this.lblCharge);
            this.groupMain.Controls.Add(this.lblPenalty);
            this.groupMain.Controls.Add(this.txtMaintaningBalance);
            this.groupMain.Controls.Add(this.lblMaintainingBalance);
            this.groupMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMain.Location = new System.Drawing.Point(12, 227);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(678, 234);
            this.groupMain.TabIndex = 5;
            this.groupMain.TabStop = false;
            this.groupMain.Text = "Add/Modify Maintaining Balance";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 202);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Location = new System.Drawing.Point(68, 201);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(69, 24);
            this.checkStatus.TabIndex = 17;
            this.checkStatus.Text = "Active";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(573, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(475, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // numChargeDuration
            // 
            this.numChargeDuration.ContextMenuStrip = this.contextMenuBlank;
            this.numChargeDuration.Location = new System.Drawing.Point(313, 144);
            this.numChargeDuration.Name = "numChargeDuration";
            this.numChargeDuration.Size = new System.Drawing.Size(63, 27);
            this.numChargeDuration.TabIndex = 14;
            this.numChargeDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numChargeDuration_KeyDown);
            this.numChargeDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numChargeDuration_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // comboChargeDuration
            // 
            this.comboChargeDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChargeDuration.FormattingEnabled = true;
            this.comboChargeDuration.Items.AddRange(new object[] {
            "day/s",
            "week/s",
            "month/s",
            "year/s"});
            this.comboChargeDuration.Location = new System.Drawing.Point(382, 143);
            this.comboChargeDuration.Name = "comboChargeDuration";
            this.comboChargeDuration.Size = new System.Drawing.Size(169, 28);
            this.comboChargeDuration.TabIndex = 15;
            // 
            // comboCharge
            // 
            this.comboCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCharge.FormattingEnabled = true;
            this.comboCharge.Items.AddRange(new object[] {
            "Pesos (Php)",
            "% of Current Balance"});
            this.comboCharge.Location = new System.Drawing.Point(382, 109);
            this.comboCharge.Name = "comboCharge";
            this.comboCharge.Size = new System.Drawing.Size(169, 28);
            this.comboCharge.TabIndex = 12;
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(264, 42);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(287, 28);
            this.comboAccountType.TabIndex = 7;
            // 
            // txtCharge
            // 
            this.txtCharge.ContextMenuStrip = this.contextMenuBlank;
            this.txtCharge.Location = new System.Drawing.Point(264, 109);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(112, 27);
            this.txtCharge.TabIndex = 11;
            this.txtCharge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCharge_KeyDown);
            this.txtCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCharge_KeyPress);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(111, 45);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(102, 20);
            this.lblAccountType.TabIndex = 6;
            this.lblAccountType.Text = "Account Type:";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Location = new System.Drawing.Point(121, 146);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(102, 20);
            this.lblCharge.TabIndex = 13;
            this.lblCharge.Text = "charged every";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(111, 112);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(57, 20);
            this.lblPenalty.TabIndex = 10;
            this.lblPenalty.Text = "Penalty";
            // 
            // txtMaintaningBalance
            // 
            this.txtMaintaningBalance.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaintaningBalance.Location = new System.Drawing.Point(264, 76);
            this.txtMaintaningBalance.Name = "txtMaintaningBalance";
            this.txtMaintaningBalance.Size = new System.Drawing.Size(287, 27);
            this.txtMaintaningBalance.TabIndex = 9;
            this.txtMaintaningBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaintaningBalance_KeyDown);
            this.txtMaintaningBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintaningBalance_KeyPress);
            // 
            // lblMaintainingBalance
            // 
            this.lblMaintainingBalance.AutoSize = true;
            this.lblMaintainingBalance.Location = new System.Drawing.Point(111, 79);
            this.lblMaintainingBalance.Name = "lblMaintainingBalance";
            this.lblMaintainingBalance.Size = new System.Drawing.Size(147, 20);
            this.lblMaintainingBalance.TabIndex = 8;
            this.lblMaintainingBalance.Text = "Maintaining Balance:";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(585, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(487, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // MaintainingBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupMain);
            this.Controls.Add(this.dataMaintaningBalance);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "MaintainingBalances";
            this.Text = "Maintaining Balances";
            ((System.ComponentModel.ISupportInitialize)(this.dataMaintaningBalance)).EndInit();
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChargeDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMaintaningBalance;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.NumericUpDown numChargeDuration;
        private System.Windows.Forms.ComboBox comboChargeDuration;
        private System.Windows.Forms.ComboBox comboCharge;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.TextBox txtMaintaningBalance;
        private System.Windows.Forms.Label lblMaintainingBalance;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.CheckBox checkArchived;
    }
}