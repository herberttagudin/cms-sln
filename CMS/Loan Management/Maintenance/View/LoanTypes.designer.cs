namespace CMS.Loan_Management.Maintenance.View
{
    partial class LoanTypes
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
            this.gbAvailability = new System.Windows.Forms.GroupBox();
            this.clbMemberType = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbCollateral = new System.Windows.Forms.CheckBox();
            this.cbDeduction = new System.Windows.Forms.ComboBox();
            this.cbAmtStatus = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMaximumStatus = new System.Windows.Forms.ComboBox();
            this.cbMinimumStatus = new System.Windows.Forms.ComboBox();
            this.maximumUD = new System.Windows.Forms.NumericUpDown();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMaximumPaymentDur = new System.Windows.Forms.Label();
            this.minimumUD = new System.Windows.Forms.NumericUpDown();
            this.lblMinimumPaymentDur = new System.Windows.Forms.Label();
            this.comakersUD = new System.Windows.Forms.NumericUpDown();
            this.lblComaker = new System.Windows.Forms.Label();
            this.txtMaxAmt = new System.Windows.Forms.TextBox();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblMaxLoanableAmt = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            this.gbAvailability.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comakersUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAvailability
            // 
            this.gbAvailability.Controls.Add(this.clbMemberType);
            this.gbAvailability.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailability.Location = new System.Drawing.Point(373, 10);
            this.gbAvailability.Name = "gbAvailability";
            this.gbAvailability.Size = new System.Drawing.Size(302, 149);
            this.gbAvailability.TabIndex = 15;
            this.gbAvailability.TabStop = false;
            this.gbAvailability.Text = "Available for:";
            // 
            // clbMemberType
            // 
            this.clbMemberType.FormattingEnabled = true;
            this.clbMemberType.Location = new System.Drawing.Point(6, 28);
            this.clbMemberType.Name = "clbMemberType";
            this.clbMemberType.Size = new System.Drawing.Size(282, 114);
            this.clbMemberType.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnRetrieve);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.chbStatus);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.gbAvailability);
            this.panel1.Controls.Add(this.chbCollateral);
            this.panel1.Controls.Add(this.cbDeduction);
            this.panel1.Controls.Add(this.cbAmtStatus);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.comakersUD);
            this.panel1.Controls.Add(this.lblComaker);
            this.panel1.Controls.Add(this.txtMaxAmt);
            this.panel1.Controls.Add(this.lblOf);
            this.panel1.Controls.Add(this.lblMaxLoanableAmt);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(12, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 244);
            this.panel1.TabIndex = 5;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(149, 202);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(96, 28);
            this.btnRetrieve.TabIndex = 81;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 206);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 21);
            this.lblStatus.TabIndex = 77;
            this.lblStatus.Text = "Status";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(569, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Location = new System.Drawing.Point(72, 205);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(71, 25);
            this.chbStatus.TabIndex = 22;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(463, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chbCollateral
            // 
            this.chbCollateral.AutoSize = true;
            this.chbCollateral.Location = new System.Drawing.Point(207, 38);
            this.chbCollateral.Name = "chbCollateral";
            this.chbCollateral.Size = new System.Drawing.Size(132, 25);
            this.chbCollateral.TabIndex = 9;
            this.chbCollateral.Text = "Has Collateral?";
            this.chbCollateral.UseVisualStyleBackColor = true;
            // 
            // cbDeduction
            // 
            this.cbDeduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeduction.FormattingEnabled = true;
            this.cbDeduction.Items.AddRange(new object[] {
            "Share Capital",
            "Savings Balance"});
            this.cbDeduction.Location = new System.Drawing.Point(482, 165);
            this.cbDeduction.Name = "cbDeduction";
            this.cbDeduction.Size = new System.Drawing.Size(179, 29);
            this.cbDeduction.TabIndex = 19;
            // 
            // cbAmtStatus
            // 
            this.cbAmtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmtStatus.FormattingEnabled = true;
            this.cbAmtStatus.Items.AddRange(new object[] {
            "Times",
            "Php"});
            this.cbAmtStatus.Location = new System.Drawing.Point(345, 165);
            this.cbAmtStatus.Name = "cbAmtStatus";
            this.cbAmtStatus.Size = new System.Drawing.Size(98, 29);
            this.cbAmtStatus.TabIndex = 18;
            this.cbAmtStatus.SelectedIndexChanged += new System.EventHandler(this.cbAmtStatus_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMaximumStatus);
            this.groupBox3.Controls.Add(this.cbMinimumStatus);
            this.groupBox3.Controls.Add(this.maximumUD);
            this.groupBox3.Controls.Add(this.lblMaximumPaymentDur);
            this.groupBox3.Controls.Add(this.minimumUD);
            this.groupBox3.Controls.Add(this.lblMinimumPaymentDur);
            this.groupBox3.Location = new System.Drawing.Point(8, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 90);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allowable Payment Durations";
            // 
            // cbMaximumStatus
            // 
            this.cbMaximumStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaximumStatus.FormattingEnabled = true;
            this.cbMaximumStatus.Items.AddRange(new object[] {
            "week/s",
            "month/s",
            "year/s"});
            this.cbMaximumStatus.Location = new System.Drawing.Point(162, 56);
            this.cbMaximumStatus.Name = "cbMaximumStatus";
            this.cbMaximumStatus.Size = new System.Drawing.Size(184, 29);
            this.cbMaximumStatus.TabIndex = 14;
            // 
            // cbMinimumStatus
            // 
            this.cbMinimumStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinimumStatus.FormattingEnabled = true;
            this.cbMinimumStatus.Items.AddRange(new object[] {
            "week/s",
            "month/s",
            "year/s"});
            this.cbMinimumStatus.Location = new System.Drawing.Point(162, 21);
            this.cbMinimumStatus.Name = "cbMinimumStatus";
            this.cbMinimumStatus.Size = new System.Drawing.Size(184, 29);
            this.cbMinimumStatus.TabIndex = 12;
            // 
            // maximumUD
            // 
            this.maximumUD.ContextMenuStrip = this.contextMenuBlank;
            this.maximumUD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumUD.Location = new System.Drawing.Point(96, 58);
            this.maximumUD.Name = "maximumUD";
            this.maximumUD.Size = new System.Drawing.Size(60, 27);
            this.maximumUD.TabIndex = 13;
            this.maximumUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maximumUD_KeyDown);
            this.maximumUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maximumUD_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMaximumPaymentDur
            // 
            this.lblMaximumPaymentDur.AutoSize = true;
            this.lblMaximumPaymentDur.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumPaymentDur.Location = new System.Drawing.Point(6, 60);
            this.lblMaximumPaymentDur.Name = "lblMaximumPaymentDur";
            this.lblMaximumPaymentDur.Size = new System.Drawing.Size(78, 20);
            this.lblMaximumPaymentDur.TabIndex = 6;
            this.lblMaximumPaymentDur.Text = "Maximum:";
            // 
            // minimumUD
            // 
            this.minimumUD.ContextMenuStrip = this.contextMenuBlank;
            this.minimumUD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumUD.Location = new System.Drawing.Point(96, 23);
            this.minimumUD.Name = "minimumUD";
            this.minimumUD.Size = new System.Drawing.Size(60, 27);
            this.minimumUD.TabIndex = 11;
            this.minimumUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.minimumUD_KeyDown);
            this.minimumUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minimumUD_KeyPress);
            // 
            // lblMinimumPaymentDur
            // 
            this.lblMinimumPaymentDur.AutoSize = true;
            this.lblMinimumPaymentDur.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumPaymentDur.Location = new System.Drawing.Point(6, 25);
            this.lblMinimumPaymentDur.Name = "lblMinimumPaymentDur";
            this.lblMinimumPaymentDur.Size = new System.Drawing.Size(75, 20);
            this.lblMinimumPaymentDur.TabIndex = 6;
            this.lblMinimumPaymentDur.Text = "Minimum:";
            // 
            // comakersUD
            // 
            this.comakersUD.ContextMenuStrip = this.contextMenuBlank;
            this.comakersUD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comakersUD.Location = new System.Drawing.Point(102, 36);
            this.comakersUD.Name = "comakersUD";
            this.comakersUD.Size = new System.Drawing.Size(62, 27);
            this.comakersUD.TabIndex = 7;
            this.comakersUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comakersUD_KeyDown);
            this.comakersUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comakersUD_KeyPress);
            // 
            // lblComaker
            // 
            this.lblComaker.AutoSize = true;
            this.lblComaker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComaker.Location = new System.Drawing.Point(13, 40);
            this.lblComaker.Name = "lblComaker";
            this.lblComaker.Size = new System.Drawing.Size(83, 20);
            this.lblComaker.TabIndex = 54;
            this.lblComaker.Text = "Co-Makers:";
            // 
            // txtMaxAmt
            // 
            this.txtMaxAmt.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaxAmt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAmt.Location = new System.Drawing.Point(212, 167);
            this.txtMaxAmt.Name = "txtMaxAmt";
            this.txtMaxAmt.Size = new System.Drawing.Size(127, 27);
            this.txtMaxAmt.TabIndex = 17;
            this.txtMaxAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxAmt_KeyDown);
            this.txtMaxAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxAmt_KeyPress);
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOf.Location = new System.Drawing.Point(449, 169);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(23, 20);
            this.lblOf.TabIndex = 49;
            this.lblOf.Text = "of";
            // 
            // lblMaxLoanableAmt
            // 
            this.lblMaxLoanableAmt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLoanableAmt.Location = new System.Drawing.Point(14, 169);
            this.lblMaxLoanableAmt.Name = "lblMaxLoanableAmt";
            this.lblMaxLoanableAmt.Size = new System.Drawing.Size(175, 26);
            this.lblMaxLoanableAmt.TabIndex = 48;
            this.lblMaxLoanableAmt.Text = "Max. Loanable Amount:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(63, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(299, 27);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Name:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(12, 10);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(678, 171);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(581, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(483, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(385, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.Location = new System.Drawing.Point(20, 194);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(131, 25);
            this.cbShowArchive.TabIndex = 47;
            this.cbShowArchive.Text = "Show Archives";
            this.cbShowArchive.UseVisualStyleBackColor = false;
            // 
            // LoanTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "LoanTypes";
            this.Text = "Loan Types";
            this.Load += new System.EventHandler(this.LoanTypes_Load);
            this.gbAvailability.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comakersUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMemberType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.CheckBox chbCollateral;
        private System.Windows.Forms.ComboBox cbDeduction;
        private System.Windows.Forms.ComboBox cbAmtStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbMaximumStatus;
        private System.Windows.Forms.ComboBox cbMinimumStatus;
        private System.Windows.Forms.NumericUpDown maximumUD;
        private System.Windows.Forms.NumericUpDown minimumUD;
        private System.Windows.Forms.NumericUpDown comakersUD;
        private System.Windows.Forms.TextBox txtMaxAmt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.GroupBox gbAvailability;
        public System.Windows.Forms.Label lblMaximumPaymentDur;
        public System.Windows.Forms.Label lblMinimumPaymentDur;
        public System.Windows.Forms.Label lblComaker;
        public System.Windows.Forms.Label lblMaxLoanableAmt;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.CheckBox cbShowArchive;
        public System.Windows.Forms.Label lblOf;

    }
}