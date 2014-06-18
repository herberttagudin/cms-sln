namespace CMS.Loan_Management.Maintenance.View
{
    partial class Penalties
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataPenalties = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbPenalty = new System.Windows.Forms.GroupBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPenaltyName = new System.Windows.Forms.Label();
            this.cbGrace = new System.Windows.Forms.CheckBox();
            this.cbDeduction = new System.Windows.Forms.ComboBox();
            this.cbDurationStatus = new System.Windows.Forms.ComboBox();
            this.cbAmountStatus = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.durationUD = new System.Windows.Forms.NumericUpDown();
            this.gpUD = new System.Windows.Forms.NumericUpDown();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.lblBasis = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPenaltyCharges = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.clbLoanType = new System.Windows.Forms.CheckedListBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPenalties)).BeginInit();
            this.gbPenalty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Penalty Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(581, 241);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(381, 241);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(481, 241);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dataPenalties
            // 
            this.dataPenalties.AllowUserToAddRows = false;
            this.dataPenalties.AllowUserToDeleteRows = false;
            this.dataPenalties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPenalties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPenalties.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPenalties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataPenalties.Location = new System.Drawing.Point(13, 60);
            this.dataPenalties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataPenalties.Name = "dataPenalties";
            this.dataPenalties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPenalties.Size = new System.Drawing.Size(678, 171);
            this.dataPenalties.TabIndex = 40;
            this.dataPenalties.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataPenalties_CellFormatting);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(133, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(556, 27);
            this.txtSearch.TabIndex = 38;
            // 
            // gbPenalty
            // 
            this.gbPenalty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPenalty.Controls.Add(this.btnRetrieve);
            this.gbPenalty.Controls.Add(this.lblStatus);
            this.gbPenalty.Controls.Add(this.chbStatus);
            this.gbPenalty.Controls.Add(this.txtName);
            this.gbPenalty.Controls.Add(this.lblPenaltyName);
            this.gbPenalty.Controls.Add(this.cbGrace);
            this.gbPenalty.Controls.Add(this.cbDeduction);
            this.gbPenalty.Controls.Add(this.cbDurationStatus);
            this.gbPenalty.Controls.Add(this.cbAmountStatus);
            this.gbPenalty.Controls.Add(this.txtAmount);
            this.gbPenalty.Controls.Add(this.durationUD);
            this.gbPenalty.Controls.Add(this.gpUD);
            this.gbPenalty.Controls.Add(this.lblGracePeriod);
            this.gbPenalty.Controls.Add(this.lblBasis);
            this.gbPenalty.Controls.Add(this.lblDuration);
            this.gbPenalty.Controls.Add(this.lblAmount);
            this.gbPenalty.Controls.Add(this.lblPenaltyCharges);
            this.gbPenalty.Controls.Add(this.btnCancel);
            this.gbPenalty.Controls.Add(this.btnSave);
            this.gbPenalty.Controls.Add(this.clbLoanType);
            this.gbPenalty.Controls.Add(this.lblLoanType);
            this.gbPenalty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPenalty.Location = new System.Drawing.Point(15, 273);
            this.gbPenalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPenalty.Name = "gbPenalty";
            this.gbPenalty.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPenalty.Size = new System.Drawing.Size(678, 235);
            this.gbPenalty.TabIndex = 45;
            this.gbPenalty.TabStop = false;
            this.gbPenalty.Text = "Add/Modify Penalty";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(145, 200);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(96, 28);
            this.btnRetrieve.TabIndex = 80;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 204);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 79;
            this.lblStatus.Text = "Status";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Location = new System.Drawing.Point(70, 203);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(69, 24);
            this.chbStatus.TabIndex = 78;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(135, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 27);
            this.txtName.TabIndex = 27;
            // 
            // lblPenaltyName
            // 
            this.lblPenaltyName.AutoSize = true;
            this.lblPenaltyName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyName.Location = new System.Drawing.Point(9, 29);
            this.lblPenaltyName.Name = "lblPenaltyName";
            this.lblPenaltyName.Size = new System.Drawing.Size(104, 20);
            this.lblPenaltyName.TabIndex = 26;
            this.lblPenaltyName.Text = "Penalty Name:";
            // 
            // cbGrace
            // 
            this.cbGrace.AutoSize = true;
            this.cbGrace.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrace.Location = new System.Drawing.Point(13, 69);
            this.cbGrace.Name = "cbGrace";
            this.cbGrace.Size = new System.Drawing.Size(116, 24);
            this.cbGrace.TabIndex = 25;
            this.cbGrace.Text = "Grace Period:";
            this.cbGrace.UseVisualStyleBackColor = true;
            this.cbGrace.CheckedChanged += new System.EventHandler(this.cbGrace_CheckedChanged);
            // 
            // cbDeduction
            // 
            this.cbDeduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeduction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeduction.FormattingEnabled = true;
            this.cbDeduction.Items.AddRange(new object[] {
            "monthly amortization",
            "remaining balance",
            "granted loan amount"});
            this.cbDeduction.Location = new System.Drawing.Point(268, 121);
            this.cbDeduction.Name = "cbDeduction";
            this.cbDeduction.Size = new System.Drawing.Size(142, 28);
            this.cbDeduction.TabIndex = 22;
            // 
            // cbDurationStatus
            // 
            this.cbDurationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurationStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDurationStatus.FormattingEnabled = true;
            this.cbDurationStatus.Items.AddRange(new object[] {
            "day/s",
            "week/s",
            "month/s"});
            this.cbDurationStatus.Location = new System.Drawing.Point(268, 154);
            this.cbDurationStatus.Name = "cbDurationStatus";
            this.cbDurationStatus.Size = new System.Drawing.Size(142, 28);
            this.cbDurationStatus.TabIndex = 23;
            // 
            // cbAmountStatus
            // 
            this.cbAmountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmountStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmountStatus.FormattingEnabled = true;
            this.cbAmountStatus.Items.AddRange(new object[] {
            "%",
            "Php"});
            this.cbAmountStatus.Location = new System.Drawing.Point(155, 121);
            this.cbAmountStatus.Name = "cbAmountStatus";
            this.cbAmountStatus.Size = new System.Drawing.Size(78, 28);
            this.cbAmountStatus.TabIndex = 24;
            this.cbAmountStatus.SelectedIndexChanged += new System.EventHandler(this.cbAmountStatus_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(80, 121);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(69, 27);
            this.txtAmount.TabIndex = 21;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown_1);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress_1);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // durationUD
            // 
            this.durationUD.ContextMenuStrip = this.contextMenuBlank;
            this.durationUD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationUD.Location = new System.Drawing.Point(206, 155);
            this.durationUD.Name = "durationUD";
            this.durationUD.Size = new System.Drawing.Size(56, 27);
            this.durationUD.TabIndex = 19;
            this.durationUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.durationUD_KeyDown_1);
            this.durationUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.durationUD_KeyPress_1);
            // 
            // gpUD
            // 
            this.gpUD.ContextMenuStrip = this.contextMenuBlank;
            this.gpUD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpUD.Location = new System.Drawing.Point(135, 68);
            this.gpUD.Name = "gpUD";
            this.gpUD.Size = new System.Drawing.Size(61, 27);
            this.gpUD.TabIndex = 20;
            this.gpUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gpUD_KeyDown_1);
            this.gpUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gpUD_KeyPress_1);
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGracePeriod.Location = new System.Drawing.Point(202, 59);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(167, 42);
            this.lblGracePeriod.TabIndex = 14;
            this.lblGracePeriod.Text = "days after amortization due date";
            // 
            // lblBasis
            // 
            this.lblBasis.AutoSize = true;
            this.lblBasis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasis.Location = new System.Drawing.Point(239, 124);
            this.lblBasis.Name = "lblBasis";
            this.lblBasis.Size = new System.Drawing.Size(23, 20);
            this.lblBasis.TabIndex = 15;
            this.lblBasis.Text = "of";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(15, 157);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(141, 20);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "to be charged every";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(9, 124);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Amount:";
            // 
            // lblPenaltyCharges
            // 
            this.lblPenaltyCharges.AutoSize = true;
            this.lblPenaltyCharges.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyCharges.Location = new System.Drawing.Point(9, 98);
            this.lblPenaltyCharges.Name = "lblPenaltyCharges";
            this.lblPenaltyCharges.Size = new System.Drawing.Size(117, 20);
            this.lblPenaltyCharges.TabIndex = 18;
            this.lblPenaltyCharges.Text = "Penalty Charges:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(566, 151);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(466, 151);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // clbLoanType
            // 
            this.clbLoanType.FormattingEnabled = true;
            this.clbLoanType.Location = new System.Drawing.Point(415, 43);
            this.clbLoanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbLoanType.Name = "clbLoanType";
            this.clbLoanType.Size = new System.Drawing.Size(258, 70);
            this.clbLoanType.TabIndex = 10;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanType.Location = new System.Drawing.Point(411, 18);
            this.lblLoanType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(88, 20);
            this.lblLoanType.TabIndex = 2;
            this.lblLoanType.Text = "Applied for:";
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.Location = new System.Drawing.Point(28, 245);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(131, 25);
            this.cbShowArchive.TabIndex = 46;
            this.cbShowArchive.Text = "Show Archives";
            this.cbShowArchive.UseVisualStyleBackColor = false;
            this.cbShowArchive.CheckedChanged += new System.EventHandler(this.cbShowArchive_CheckedChanged);
            // 
            // Penalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 522);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.gbPenalty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataPenalties);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "Penalties";
            this.Text = "Penalties";
            ((System.ComponentModel.ISupportInitialize)(this.dataPenalties)).EndInit();
            this.gbPenalty.ResumeLayout(false);
            this.gbPenalty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbPenalty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox clbLoanType;
        private System.Windows.Forms.ComboBox cbDeduction;
        private System.Windows.Forms.ComboBox cbDurationStatus;
        private System.Windows.Forms.ComboBox cbAmountStatus;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.NumericUpDown durationUD;
        private System.Windows.Forms.NumericUpDown gpUD;
        private System.Windows.Forms.Label lblPenaltyCharges;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chbStatus;
        public System.Windows.Forms.DataGridView dataPenalties;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.Label lblDuration;
        public System.Windows.Forms.Label lblBasis;
        public System.Windows.Forms.CheckBox cbGrace;
        public System.Windows.Forms.Label lblPenaltyName;
        public System.Windows.Forms.Label lblGracePeriod;
        public System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.CheckBox cbShowArchive;
    }
}