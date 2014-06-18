namespace CMS.Savings.Maintenance.View
{
    partial class MaximumWithdrawal
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.CheckBox();
            this.txtMaxWith = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMaxWith = new System.Windows.Forms.Label();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataMaxWith = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkArchived = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaxWith)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.txtMaxWith);
            this.groupBox1.Controls.Add(this.lblMaxWith);
            this.groupBox1.Controls.Add(this.comboAccountType);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(678, 230);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Modify Maximum Withdrawal";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 196);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(569, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(471, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(85, 196);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(69, 24);
            this.Status.TabIndex = 11;
            this.Status.Text = "Active";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // txtMaxWith
            // 
            this.txtMaxWith.ContextMenuStrip = this.contextMenuBlank;
            this.txtMaxWith.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxWith.Location = new System.Drawing.Point(282, 102);
            this.txtMaxWith.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxWith.Name = "txtMaxWith";
            this.txtMaxWith.Size = new System.Drawing.Size(268, 27);
            this.txtMaxWith.TabIndex = 9;
            this.txtMaxWith.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxWith_KeyDown);
            this.txtMaxWith.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxWith_KeyPress);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMaxWith
            // 
            this.lblMaxWith.AutoSize = true;
            this.lblMaxWith.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWith.Location = new System.Drawing.Point(96, 109);
            this.lblMaxWith.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxWith.Name = "lblMaxWith";
            this.lblMaxWith.Size = new System.Drawing.Size(155, 20);
            this.lblMaxWith.TabIndex = 8;
            this.lblMaxWith.Text = "Maximum Withdrawal";
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(282, 64);
            this.comboAccountType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(268, 28);
            this.comboAccountType.TabIndex = 7;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(96, 67);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(99, 20);
            this.lblAccountType.TabIndex = 6;
            this.lblAccountType.Text = "Account Type";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(582, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dataMaxWith
            // 
            this.dataMaxWith.AllowUserToAddRows = false;
            this.dataMaxWith.AllowUserToDeleteRows = false;
            this.dataMaxWith.AllowUserToResizeRows = false;
            this.dataMaxWith.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataMaxWith.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMaxWith.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaxWith.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMaxWith.Location = new System.Drawing.Point(12, 12);
            this.dataMaxWith.MultiSelect = false;
            this.dataMaxWith.Name = "dataMaxWith";
            this.dataMaxWith.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMaxWith.Size = new System.Drawing.Size(678, 171);
            this.dataMaxWith.TabIndex = 1;
            this.dataMaxWith.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataMaxWith_CellFormatting);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(484, 189);
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
            // MaximumWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.checkArchived);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataMaxWith);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "MaximumWithdrawal";
            this.Text = "Maximum Withdrawal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaxWith)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.TextBox txtMaxWith;
        private System.Windows.Forms.Label lblMaxWith;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataMaxWith;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.CheckBox checkArchived;
    }
}