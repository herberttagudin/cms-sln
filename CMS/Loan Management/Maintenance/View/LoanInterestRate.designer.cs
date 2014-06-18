namespace CMS.Loan_Management.Maintenance.View
{
    partial class LoanInterestRate
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
            this.cbLoanType = new System.Windows.Forms.ComboBox();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbInterestStatus = new System.Windows.Forms.ComboBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.dataInterest = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbInterest = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbInclusiveDates = new System.Windows.Forms.GroupBox();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataInterest)).BeginInit();
            this.gbInterest.SuspendLayout();
            this.gbInclusiveDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLoanType
            // 
            this.cbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanType.FormattingEnabled = true;
            this.cbLoanType.Location = new System.Drawing.Point(115, 47);
            this.cbLoanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoanType.Name = "cbLoanType";
            this.cbLoanType.Size = new System.Drawing.Size(195, 28);
            this.cbLoanType.TabIndex = 5;
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(217, 28);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(122, 27);
            this.endDate.TabIndex = 11;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(56, 28);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(122, 27);
            this.startDate.TabIndex = 10;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            this.startDate.TabIndexChanged += new System.EventHandler(this.startDate_TabIndexChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(186, 33);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 20);
            this.lblTo.TabIndex = 19;
            this.lblTo.Text = "to";
            // 
            // txtInterest
            // 
            this.txtInterest.ContextMenuStrip = this.contextMenuBlank;
            this.txtInterest.Location = new System.Drawing.Point(115, 86);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 27);
            this.txtInterest.TabIndex = 6;
            this.txtInterest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtInterest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInterest_KeyDown);
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterest_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(7, 33);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 20);
            this.lblFrom.TabIndex = 20;
            this.lblFrom.Text = "from";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.Location = new System.Drawing.Point(76, 126);
            this.lblPer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(31, 20);
            this.lblPer.TabIndex = 21;
            this.lblPer.Text = "per";
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Items.AddRange(new object[] {
            "month",
            "annum"});
            this.cbDuration.Location = new System.Drawing.Point(115, 123);
            this.cbDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(195, 28);
            this.cbDuration.TabIndex = 88;
            // 
            // cbInterestStatus
            // 
            this.cbInterestStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterestStatus.FormattingEnabled = true;
            this.cbInterestStatus.Items.AddRange(new object[] {
            "%",
            "Php"});
            this.cbInterestStatus.Location = new System.Drawing.Point(223, 85);
            this.cbInterestStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInterestStatus.Name = "cbInterestStatus";
            this.cbInterestStatus.Size = new System.Drawing.Size(87, 28);
            this.cbInterestStatus.TabIndex = 7;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Location = new System.Drawing.Point(17, 50);
            this.lblLoanType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(77, 20);
            this.lblLoanType.TabIndex = 13;
            this.lblLoanType.Text = "Loan type:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(12, 88);
            this.lblInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(95, 20);
            this.lblInterestRate.TabIndex = 15;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // dataInterest
            // 
            this.dataInterest.AllowUserToAddRows = false;
            this.dataInterest.AllowUserToDeleteRows = false;
            this.dataInterest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataInterest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataInterest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataInterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInterest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataInterest.Location = new System.Drawing.Point(13, 14);
            this.dataInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataInterest.Name = "dataInterest";
            this.dataInterest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInterest.Size = new System.Drawing.Size(678, 171);
            this.dataInterest.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(470, 195);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbInterest
            // 
            this.gbInterest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInterest.Controls.Add(this.lblStatus);
            this.gbInterest.Controls.Add(this.gbInclusiveDates);
            this.gbInterest.Controls.Add(this.chbStatus);
            this.gbInterest.Controls.Add(this.btnCancel);
            this.gbInterest.Controls.Add(this.btnSave);
            this.gbInterest.Controls.Add(this.txtInterest);
            this.gbInterest.Controls.Add(this.lblPer);
            this.gbInterest.Controls.Add(this.cbDuration);
            this.gbInterest.Controls.Add(this.cbInterestStatus);
            this.gbInterest.Controls.Add(this.cbLoanType);
            this.gbInterest.Controls.Add(this.lblLoanType);
            this.gbInterest.Controls.Add(this.lblInterestRate);
            this.gbInterest.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInterest.Location = new System.Drawing.Point(13, 233);
            this.gbInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInterest.Name = "gbInterest";
            this.gbInterest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInterest.Size = new System.Drawing.Size(678, 226);
            this.gbInterest.TabIndex = 4;
            this.gbInterest.TabStop = false;
            this.gbInterest.Text = "Add/Modify Interest Rates";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 190);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 78;
            this.lblStatus.Text = "Status";
            // 
            // gbInclusiveDates
            // 
            this.gbInclusiveDates.Controls.Add(this.startDate);
            this.gbInclusiveDates.Controls.Add(this.lblFrom);
            this.gbInclusiveDates.Controls.Add(this.endDate);
            this.gbInclusiveDates.Controls.Add(this.lblTo);
            this.gbInclusiveDates.Location = new System.Drawing.Point(322, 65);
            this.gbInclusiveDates.Name = "gbInclusiveDates";
            this.gbInclusiveDates.Size = new System.Drawing.Size(349, 74);
            this.gbInclusiveDates.TabIndex = 9;
            this.gbInclusiveDates.TabStop = false;
            this.gbInclusiveDates.Text = "Inclusive Dates";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Location = new System.Drawing.Point(68, 189);
            this.chbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(69, 24);
            this.chbStatus.TabIndex = 12;
            this.chbStatus.Text = "Active";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 184);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(457, 184);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(570, 195);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // LoanInterestRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.gbInterest);
            this.Controls.Add(this.dataInterest);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "LoanInterestRate";
            this.Text = "Loan Interest Rate";
            this.Load += new System.EventHandler(this.LoanInterestRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataInterest)).EndInit();
            this.gbInterest.ResumeLayout(false);
            this.gbInterest.PerformLayout();
            this.gbInclusiveDates.ResumeLayout(false);
            this.gbInclusiveDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbInterestStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbInterest;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.GroupBox gbInclusiveDates;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.Label lblPer;
        public System.Windows.Forms.Label lblLoanType;
        public System.Windows.Forms.Label lblInterestRate;
        public System.Windows.Forms.DataGridView dataInterest;
        public System.Windows.Forms.ComboBox cbLoanType;
    }
}