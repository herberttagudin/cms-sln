namespace CMS.Savings.Maintenance.View
{
    partial class Dormancy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboCharge = new System.Windows.Forms.ComboBox();
            this.lblAccountType = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblEvery = new System.Windows.Forms.Label();
            this.comboPenalty = new System.Windows.Forms.ComboBox();
            this.numCharge = new System.Windows.Forms.NumericUpDown();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.CheckBox();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.numDormancy = new System.Windows.Forms.NumericUpDown();
            this.lblDormancy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDormancy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataDormancy = new System.Windows.Forms.DataGridView();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDormancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDormancy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.comboCharge);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPenalty);
            this.groupBox1.Controls.Add(this.lblEvery);
            this.groupBox1.Controls.Add(this.comboPenalty);
            this.groupBox1.Controls.Add(this.numCharge);
            this.groupBox1.Controls.Add(this.lblPenalty);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.comboAccountType);
            this.groupBox1.Controls.Add(this.numDormancy);
            this.groupBox1.Controls.Add(this.lblDormancy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboDormancy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 234);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Modify Dormancy";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 202);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status";
            // 
            // comboCharge
            // 
            this.comboCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCharge.FormattingEnabled = true;
            this.comboCharge.Items.AddRange(new object[] {
            "Day/s",
            "Month/s",
            "Year/s"});
            this.comboCharge.Location = new System.Drawing.Point(339, 144);
            this.comboCharge.Name = "comboCharge";
            this.comboCharge.Size = new System.Drawing.Size(148, 28);
            this.comboCharge.TabIndex = 16;
            // 
            // lblAccountType
            // 
            this.lblAccountType.Location = new System.Drawing.Point(567, 196);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(92, 32);
            this.lblAccountType.TabIndex = 20;
            this.lblAccountType.Text = "&Cancel";
            this.lblAccountType.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(469, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPenalty
            // 
            this.txtPenalty.ContextMenuStrip = this.contextMenuBlank;
            this.txtPenalty.Location = new System.Drawing.Point(279, 108);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(102, 27);
            this.txtPenalty.TabIndex = 12;
            this.txtPenalty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPenalty_KeyDown);
            this.txtPenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalty_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblEvery
            // 
            this.lblEvery.AutoSize = true;
            this.lblEvery.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvery.Location = new System.Drawing.Point(192, 148);
            this.lblEvery.Name = "lblEvery";
            this.lblEvery.Size = new System.Drawing.Size(44, 20);
            this.lblEvery.TabIndex = 14;
            this.lblEvery.Text = "every";
            // 
            // comboPenalty
            // 
            this.comboPenalty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPenalty.FormattingEnabled = true;
            this.comboPenalty.Items.AddRange(new object[] {
            "Php",
            "%"});
            this.comboPenalty.Location = new System.Drawing.Point(387, 108);
            this.comboPenalty.Name = "comboPenalty";
            this.comboPenalty.Size = new System.Drawing.Size(100, 28);
            this.comboPenalty.TabIndex = 13;
            // 
            // numCharge
            // 
            this.numCharge.ContextMenuStrip = this.contextMenuBlank;
            this.numCharge.Location = new System.Drawing.Point(279, 144);
            this.numCharge.Name = "numCharge";
            this.numCharge.Size = new System.Drawing.Size(54, 27);
            this.numCharge.TabIndex = 15;
            this.numCharge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numCharge_KeyDown);
            this.numCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCharge_KeyPress);
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.Location = new System.Drawing.Point(158, 112);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(57, 20);
            this.lblPenalty.TabIndex = 11;
            this.lblPenalty.Text = "Penalty";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(76, 202);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(69, 24);
            this.Status.TabIndex = 18;
            this.Status.Text = "Active";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // comboAccountType
            // 
            this.comboAccountType.DisplayMember = "AccountTypeId";
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(279, 38);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(208, 28);
            this.comboAccountType.TabIndex = 7;
            // 
            // numDormancy
            // 
            this.numDormancy.ContextMenuStrip = this.contextMenuBlank;
            this.numDormancy.Location = new System.Drawing.Point(279, 73);
            this.numDormancy.Name = "numDormancy";
            this.numDormancy.Size = new System.Drawing.Size(54, 27);
            this.numDormancy.TabIndex = 9;
            this.numDormancy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numDormancy_KeyDown);
            this.numDormancy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDormancy_KeyPress);
            // 
            // lblDormancy
            // 
            this.lblDormancy.AutoSize = true;
            this.lblDormancy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDormancy.Location = new System.Drawing.Point(158, 77);
            this.lblDormancy.Name = "lblDormancy";
            this.lblDormancy.Size = new System.Drawing.Size(114, 20);
            this.lblDormancy.TabIndex = 8;
            this.lblDormancy.Text = "Dormancy After";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // comboDormancy
            // 
            this.comboDormancy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDormancy.FormattingEnabled = true;
            this.comboDormancy.Items.AddRange(new object[] {
            "Day/s",
            "Month/s",
            "Year/s"});
            this.comboDormancy.Location = new System.Drawing.Point(339, 73);
            this.comboDormancy.Name = "comboDormancy";
            this.comboDormancy.Size = new System.Drawing.Size(148, 28);
            this.comboDormancy.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account Type ";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(579, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(481, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataDormancy
            // 
            this.dataDormancy.AllowUserToAddRows = false;
            this.dataDormancy.AllowUserToDeleteRows = false;
            this.dataDormancy.AllowUserToResizeRows = false;
            this.dataDormancy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataDormancy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDormancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDormancy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataDormancy.Location = new System.Drawing.Point(12, 12);
            this.dataDormancy.MultiSelect = false;
            this.dataDormancy.Name = "dataDormancy";
            this.dataDormancy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDormancy.Size = new System.Drawing.Size(678, 171);
            this.dataDormancy.TabIndex = 1;
            this.dataDormancy.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataDormancy_CellFormatting);
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
            // Dormancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataDormancy);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "Dormancy";
            this.Text = "Dormancy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDormancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDormancy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label lblEvery;
        private System.Windows.Forms.ComboBox comboPenalty;
        private System.Windows.Forms.NumericUpDown numCharge;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.NumericUpDown numDormancy;
        private System.Windows.Forms.Label lblDormancy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDormancy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lblAccountType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataDormancy;
        private System.Windows.Forms.ComboBox comboCharge;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.CheckBox checkArchived;
    }
}