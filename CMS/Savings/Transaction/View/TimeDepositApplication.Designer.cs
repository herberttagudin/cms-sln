namespace CMS.Savings.Transaction.View
{
    partial class TimeDepositApplication
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
            this.dateMaturity = new System.Windows.Forms.DateTimePicker();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.radioMemberName = new System.Windows.Forms.RadioButton();
            this.radioAccountNo = new System.Windows.Forms.RadioButton();
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMaturity = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // dateMaturity
            // 
            this.dateMaturity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateMaturity.ContextMenuStrip = this.contextMenuBlank;
            this.dateMaturity.Enabled = false;
            this.dateMaturity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMaturity.Location = new System.Drawing.Point(275, 394);
            this.dateMaturity.Name = "dateMaturity";
            this.dateMaturity.Size = new System.Drawing.Size(261, 27);
            this.dateMaturity.TabIndex = 15;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(161, 26);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(407, 27);
            this.txtAccountNo.TabIndex = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(161, 59);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(407, 27);
            this.txtMemberName.TabIndex = 7;
            // 
            // radioMemberName
            // 
            this.radioMemberName.AutoSize = true;
            this.radioMemberName.Location = new System.Drawing.Point(13, 60);
            this.radioMemberName.Name = "radioMemberName";
            this.radioMemberName.Size = new System.Drawing.Size(130, 24);
            this.radioMemberName.TabIndex = 6;
            this.radioMemberName.TabStop = true;
            this.radioMemberName.Text = "Member Name:";
            this.radioMemberName.UseVisualStyleBackColor = true;
            this.radioMemberName.CheckedChanged += new System.EventHandler(this.radioMemberName_CheckedChanged);
            // 
            // radioAccountNo
            // 
            this.radioAccountNo.AutoSize = true;
            this.radioAccountNo.Location = new System.Drawing.Point(13, 27);
            this.radioAccountNo.Name = "radioAccountNo";
            this.radioAccountNo.Size = new System.Drawing.Size(142, 24);
            this.radioAccountNo.TabIndex = 4;
            this.radioAccountNo.Text = "Account Number:";
            this.radioAccountNo.UseVisualStyleBackColor = true;
            this.radioAccountNo.CheckedChanged += new System.EventHandler(this.radioAccountNo_CheckedChanged);
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
            this.dataMember.Location = new System.Drawing.Point(12, 144);
            this.dataMember.MultiSelect = false;
            this.dataMember.Name = "dataMember";
            this.dataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMember.Size = new System.Drawing.Size(680, 191);
            this.dataMember.TabIndex = 8;
            // 
            // groupSearch
            // 
            this.groupSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupSearch.Controls.Add(this.txtAccountNo);
            this.groupSearch.Controls.Add(this.txtMemberName);
            this.groupSearch.Controls.Add(this.radioMemberName);
            this.groupSearch.Controls.Add(this.radioAccountNo);
            this.groupSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.Location = new System.Drawing.Point(63, 46);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(580, 92);
            this.groupSearch.TabIndex = 3;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search Member";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(502, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 32);
            this.btnClear.TabIndex = 16;
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
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // comboAccountType
            // 
            this.comboAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(307, 12);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(224, 28);
            this.comboAccountType.TabIndex = 2;
            // 
            // comboDuration
            // 
            this.comboDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "Day/s",
            "Week/s",
            "Month/s",
            "Year/s"});
            this.comboDuration.Location = new System.Drawing.Point(512, 348);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(162, 28);
            this.comboDuration.TabIndex = 13;
            // 
            // numDuration
            // 
            this.numDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numDuration.ContextMenuStrip = this.contextMenuBlank;
            this.numDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDuration.Location = new System.Drawing.Point(441, 349);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(65, 27);
            this.numDuration.TabIndex = 12;
            this.numDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numDuration_KeyDown);
            this.numDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDuration_KeyPress);
            // 
            // lblAccountType
            // 
            this.lblAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(185, 15);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(102, 20);
            this.lblAccountType.TabIndex = 1;
            this.lblAccountType.Text = "Account Type:";
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(343, 351);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(70, 20);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "Duration:";
            // 
            // lblMaturity
            // 
            this.lblMaturity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaturity.AutoSize = true;
            this.lblMaturity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaturity.Location = new System.Drawing.Point(166, 399);
            this.lblMaturity.Name = "lblMaturity";
            this.lblMaturity.Size = new System.Drawing.Size(103, 20);
            this.lblMaturity.TabIndex = 14;
            this.lblMaturity.Text = "Maturity Date:";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDeposit.ContextMenuStrip = this.contextMenuBlank;
            this.txtDeposit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(146, 348);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(165, 27);
            this.txtDeposit.TabIndex = 10;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeposit_KeyDown);
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // lblDeposit
            // 
            this.lblDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(12, 351);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(121, 20);
            this.lblDeposit.TabIndex = 9;
            this.lblDeposit.Text = "Deposit Amount:";
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // TimeDepositApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.dateMaturity);
            this.Controls.Add(this.dataMember);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboAccountType);
            this.Controls.Add(this.comboDuration);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblMaturity);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "TimeDepositApplication";
            this.Text = "Time Deposit Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateMaturity;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton radioMemberName;
        private System.Windows.Forms.RadioButton radioAccountNo;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMaturity;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
    }
}