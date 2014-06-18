namespace CMS.Loan_Management.Maintenance.View
{
    partial class MemberClassification
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
            this.dataMemberClass = new System.Windows.Forms.DataGridView();
            this.groupDeliqStatus = new System.Windows.Forms.GroupBox();
            this.rbDelinquent = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.numDelValue = new System.Windows.Forms.NumericUpDown();
            this.ContextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbBasis = new System.Windows.Forms.ComboBox();
            this.cbDelUnits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApplied = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkedMemberType = new System.Windows.Forms.CheckedListBox();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatusDesc = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblClassification = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMemberClass)).BeginInit();
            this.groupDeliqStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataMemberClass
            // 
            this.dataMemberClass.AllowUserToAddRows = false;
            this.dataMemberClass.AllowUserToDeleteRows = false;
            this.dataMemberClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMemberClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMemberClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMemberClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMemberClass.Location = new System.Drawing.Point(12, 49);
            this.dataMemberClass.Name = "dataMemberClass";
            this.dataMemberClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMemberClass.Size = new System.Drawing.Size(674, 145);
            this.dataMemberClass.TabIndex = 3;
            this.dataMemberClass.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataMemberClass_CellFormatting);
            // 
            // groupDeliqStatus
            // 
            this.groupDeliqStatus.Controls.Add(this.rbDelinquent);
            this.groupDeliqStatus.Controls.Add(this.rbNone);
            this.groupDeliqStatus.Controls.Add(this.numDelValue);
            this.groupDeliqStatus.Controls.Add(this.cbBasis);
            this.groupDeliqStatus.Controls.Add(this.cbDelUnits);
            this.groupDeliqStatus.Controls.Add(this.label4);
            this.groupDeliqStatus.Location = new System.Drawing.Point(10, 63);
            this.groupDeliqStatus.Name = "groupDeliqStatus";
            this.groupDeliqStatus.Size = new System.Drawing.Size(371, 126);
            this.groupDeliqStatus.TabIndex = 11;
            this.groupDeliqStatus.TabStop = false;
            this.groupDeliqStatus.Text = "Deliquency Status";
            // 
            // rbDelinquent
            // 
            this.rbDelinquent.AutoSize = true;
            this.rbDelinquent.Location = new System.Drawing.Point(6, 59);
            this.rbDelinquent.Name = "rbDelinquent";
            this.rbDelinquent.Size = new System.Drawing.Size(133, 25);
            this.rbDelinquent.TabIndex = 13;
            this.rbDelinquent.TabStop = true;
            this.rbDelinquent.Text = "Deliquent After";
            this.rbDelinquent.UseVisualStyleBackColor = true;
            this.rbDelinquent.CheckedChanged += new System.EventHandler(this.rbDelinquent_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(6, 28);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(161, 25);
            this.rbNone.TabIndex = 12;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None (Good Payer)";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // numDelValue
            // 
            this.numDelValue.ContextMenuStrip = this.ContextMenuBlank;
            this.numDelValue.Location = new System.Drawing.Point(168, 57);
            this.numDelValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDelValue.Name = "numDelValue";
            this.numDelValue.Size = new System.Drawing.Size(60, 29);
            this.numDelValue.TabIndex = 14;
            this.numDelValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            this.numDelValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWholeNum);
            // 
            // ContextMenuBlank
            // 
            this.ContextMenuBlank.Name = "ContextMenuBlank";
            this.ContextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // cbBasis
            // 
            this.cbBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBasis.FormattingEnabled = true;
            this.cbBasis.ItemHeight = 21;
            this.cbBasis.Items.AddRange(new object[] {
            "Amortization Due Date",
            "Loan Maturity Date"});
            this.cbBasis.Location = new System.Drawing.Point(105, 92);
            this.cbBasis.Name = "cbBasis";
            this.cbBasis.Size = new System.Drawing.Size(261, 29);
            this.cbBasis.TabIndex = 17;
            // 
            // cbDelUnits
            // 
            this.cbDelUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelUnits.FormattingEnabled = true;
            this.cbDelUnits.ItemHeight = 21;
            this.cbDelUnits.Items.AddRange(new object[] {
            "Days",
            "Months",
            "Years"});
            this.cbDelUnits.Location = new System.Drawing.Point(234, 57);
            this.cbDelUnits.Name = "cbDelUnits";
            this.cbDelUnits.Size = new System.Drawing.Size(132, 29);
            this.cbDelUnits.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "of";
            // 
            // lblApplied
            // 
            this.lblApplied.AutoSize = true;
            this.lblApplied.Location = new System.Drawing.Point(395, 34);
            this.lblApplied.Name = "lblApplied";
            this.lblApplied.Size = new System.Drawing.Size(93, 21);
            this.lblApplied.TabIndex = 18;
            this.lblApplied.Text = "Applied For:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(576, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(478, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // checkedMemberType
            // 
            this.checkedMemberType.FormattingEnabled = true;
            this.checkedMemberType.Location = new System.Drawing.Point(395, 63);
            this.checkedMemberType.Name = "checkedMemberType";
            this.checkedMemberType.Size = new System.Drawing.Size(273, 124);
            this.checkedMemberType.TabIndex = 19;
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Location = new System.Drawing.Point(78, 195);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(71, 25);
            this.checkStatus.TabIndex = 21;
            this.checkStatus.Text = "Active";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Status:";
            // 
            // txtStatusDesc
            // 
            this.txtStatusDesc.Enabled = false;
            this.txtStatusDesc.Location = new System.Drawing.Point(168, 31);
            this.txtStatusDesc.MaxLength = 50;
            this.txtStatusDesc.Name = "txtStatusDesc";
            this.txtStatusDesc.Size = new System.Drawing.Size(213, 29);
            this.txtStatusDesc.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 21);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Classification Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(594, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(496, 200);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(398, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(173, 14);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(507, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // lblClassification
            // 
            this.lblClassification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(12, 17);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(155, 21);
            this.lblClassification.TabIndex = 1;
            this.lblClassification.Text = "Search Classification:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnRetrieve);
            this.groupBox1.Controls.Add(this.groupDeliqStatus);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblApplied);
            this.groupBox1.Controls.Add(this.txtStatusDesc);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.checkStatus);
            this.groupBox1.Controls.Add(this.checkedMemberType);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 223);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Modify Classification";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(168, 190);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(92, 32);
            this.btnRetrieve.TabIndex = 22;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            // 
            // checkArchived
            // 
            this.checkArchived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkArchived.AutoSize = true;
            this.checkArchived.BackColor = System.Drawing.Color.Yellow;
            this.checkArchived.Location = new System.Drawing.Point(12, 205);
            this.checkArchived.Name = "checkArchived";
            this.checkArchived.Size = new System.Drawing.Size(131, 25);
            this.checkArchived.TabIndex = 4;
            this.checkArchived.Text = "Show Archives";
            this.checkArchived.UseVisualStyleBackColor = false;
            // 
            // MemberClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblClassification);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataMemberClass);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "MemberClassification";
            this.Text = "Membership Classification";
            ((System.ComponentModel.ISupportInitialize)(this.dataMemberClass)).EndInit();
            this.groupDeliqStatus.ResumeLayout(false);
            this.groupDeliqStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMemberClass;
        private System.Windows.Forms.ComboBox cbDelUnits;
        private System.Windows.Forms.NumericUpDown numDelValue;
        private System.Windows.Forms.CheckedListBox checkedMemberType;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatusDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblApplied;
        private System.Windows.Forms.GroupBox groupDeliqStatus;
        private System.Windows.Forms.RadioButton rbDelinquent;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbBasis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuBlank;
        private System.Windows.Forms.CheckBox checkArchived;
        private System.Windows.Forms.Button btnRetrieve;
    }
}