namespace CMS.Savings.Maintenance.View
{
    partial class EarlyWithdrawal
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
            this.Status = new System.Windows.Forms.CheckBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblBalDuration = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPenalty = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkMaximum = new System.Windows.Forms.CheckBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.txtMaxBal = new System.Windows.Forms.TextBox();
            this.txtMinBal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataTimeDeposit = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimeDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(83, 136);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(69, 24);
            this.Status.TabIndex = 22;
            this.Status.Text = "Active";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // numDuration
            // 
            this.numDuration.ContextMenuStrip = this.contextMenuBlank;
            this.numDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDuration.Location = new System.Drawing.Point(138, 61);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(47, 27);
            this.numDuration.TabIndex = 11;
            this.numDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numDuration_KeyDown);
            this.numDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDuration_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // comboDuration
            // 
            this.comboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "day/s",
            "month/s",
            "year/s",
            "% of terms duration"});
            this.comboDuration.Location = new System.Drawing.Point(191, 60);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(165, 28);
            this.comboDuration.TabIndex = 12;
            // 
            // txtPenalty
            // 
            this.txtPenalty.ContextMenuStrip = this.contextMenuBlank;
            this.txtPenalty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenalty.Location = new System.Drawing.Point(138, 94);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(116, 27);
            this.txtPenalty.TabIndex = 14;
            this.txtPenalty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPenalty_KeyDown);
            this.txtPenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalty_KeyPress);
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(138, 26);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(218, 28);
            this.comboAccountType.TabIndex = 9;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.Location = new System.Drawing.Point(6, 97);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(60, 20);
            this.lblPenalty.TabIndex = 13;
            this.lblPenalty.Text = "Penalty:";
            // 
            // lblBalDuration
            // 
            this.lblBalDuration.AutoSize = true;
            this.lblBalDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalDuration.Location = new System.Drawing.Point(6, 63);
            this.lblBalDuration.Name = "lblBalDuration";
            this.lblBalDuration.Size = new System.Drawing.Size(126, 20);
            this.lblBalDuration.TabIndex = 10;
            this.lblBalDuration.Text = "Balance Duration:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(6, 29);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(102, 20);
            this.lblAccountType.TabIndex = 8;
            this.lblAccountType.Text = "Account Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.comboPenalty);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.numDuration);
            this.groupBox1.Controls.Add(this.comboDuration);
            this.groupBox1.Controls.Add(this.txtPenalty);
            this.groupBox1.Controls.Add(this.comboAccountType);
            this.groupBox1.Controls.Add(this.lblPenalty);
            this.groupBox1.Controls.Add(this.lblBalDuration);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 166);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Modify Early Withdrawal";
            // 
            // comboPenalty
            // 
            this.comboPenalty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPenalty.FormattingEnabled = true;
            this.comboPenalty.Items.AddRange(new object[] {
            "Php",
            "%"});
            this.comboPenalty.Location = new System.Drawing.Point(260, 94);
            this.comboPenalty.Name = "comboPenalty";
            this.comboPenalty.Size = new System.Drawing.Size(96, 28);
            this.comboPenalty.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 137);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkMaximum);
            this.groupBox2.Controls.Add(this.lblMinimum);
            this.groupBox2.Controls.Add(this.txtMaxBal);
            this.groupBox2.Controls.Add(this.txtMinBal);
            this.groupBox2.Location = new System.Drawing.Point(362, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 99);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance Range";
            // 
            // checkMaximum
            // 
            this.checkMaximum.AutoSize = true;
            this.checkMaximum.Location = new System.Drawing.Point(17, 62);
            this.checkMaximum.Name = "checkMaximum";
            this.checkMaximum.Size = new System.Drawing.Size(97, 24);
            this.checkMaximum.TabIndex = 19;
            this.checkMaximum.Text = "Maximum:";
            this.checkMaximum.UseVisualStyleBackColor = true;
            this.checkMaximum.CheckedChanged += new System.EventHandler(this.checkMaximum_CheckedChanged);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(34, 30);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(75, 20);
            this.lblMinimum.TabIndex = 17;
            this.lblMinimum.Text = "Minimum:";
            // 
            // txtMaxBal
            // 
            this.txtMaxBal.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaxBal.Enabled = false;
            this.txtMaxBal.Location = new System.Drawing.Point(128, 60);
            this.txtMaxBal.Name = "txtMaxBal";
            this.txtMaxBal.Size = new System.Drawing.Size(161, 27);
            this.txtMaxBal.TabIndex = 20;
            this.txtMaxBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxBal_KeyDown);
            this.txtMaxBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxBal_KeyPress);
            // 
            // txtMinBal
            // 
            this.txtMinBal.ContextMenuStrip = this.contextMenuBlank;
            this.txtMinBal.Location = new System.Drawing.Point(128, 27);
            this.txtMinBal.Name = "txtMinBal";
            this.txtMinBal.Size = new System.Drawing.Size(161, 27);
            this.txtMinBal.TabIndex = 18;
            this.txtMinBal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinBal_KeyDown);
            this.txtMinBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinBal_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(574, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(476, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(586, 250);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(488, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            this.dataTimeDeposit.Location = new System.Drawing.Point(12, 73);
            this.dataTimeDeposit.MultiSelect = false;
            this.dataTimeDeposit.Name = "dataTimeDeposit";
            this.dataTimeDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTimeDeposit.Size = new System.Drawing.Size(678, 171);
            this.dataTimeDeposit.TabIndex = 3;
            this.dataTimeDeposit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataTimeDeposit_CellFormatting);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(33, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(161, 21);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Savings Account Type";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(239, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(424, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkArchived.Location = new System.Drawing.Point(12, 256);
            this.checkArchived.Name = "checkArchived";
            this.checkArchived.Size = new System.Drawing.Size(131, 25);
            this.checkArchived.TabIndex = 4;
            this.checkArchived.Text = "Show Archives";
            this.checkArchived.UseVisualStyleBackColor = false;
            // 
            // EarlyWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataTimeDeposit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "EarlyWithdrawal";
            this.Text = "Early Withdrawal";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimeDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblBalDuration;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkMaximum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox txtMaxBal;
        private System.Windows.Forms.TextBox txtMinBal;
        private System.Windows.Forms.DataGridView dataTimeDeposit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboPenalty;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox checkArchived;
    }
}