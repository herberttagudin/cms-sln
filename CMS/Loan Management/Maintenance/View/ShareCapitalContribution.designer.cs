namespace CMS.Loan_Management.Maintenance.View
{
    partial class ShareCapitalContribution
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.CheckBox();
            this.comboContribution = new System.Windows.Forms.ComboBox();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMemberType = new System.Windows.Forms.Label();
            this.txtContribution = new System.Windows.Forms.TextBox();
            this.lblCapitalContrib = new System.Windows.Forms.Label();
            this.dataCapitalContribution = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.cbShowArchive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCapitalContribution)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 79;
            this.label5.Text = "Status";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(567, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(469, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(74, 149);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(71, 25);
            this.Status.TabIndex = 10;
            this.Status.Text = "Active";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // comboContribution
            // 
            this.comboContribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContribution.FormattingEnabled = true;
            this.comboContribution.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboContribution.Location = new System.Drawing.Point(137, 113);
            this.comboContribution.Name = "comboContribution";
            this.comboContribution.Size = new System.Drawing.Size(171, 29);
            this.comboContribution.TabIndex = 8;
            // 
            // comboAccountType
            // 
            this.comboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(137, 36);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(171, 29);
            this.comboAccountType.TabIndex = 5;
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Location = new System.Drawing.Point(18, 39);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(109, 21);
            this.lblMemberType.TabIndex = 19;
            this.lblMemberType.Text = "Member Type:";
            // 
            // txtContribution
            // 
            this.txtContribution.ContextMenuStrip = this.contextMenuBlank;
            this.txtContribution.Location = new System.Drawing.Point(330, 74);
            this.txtContribution.Name = "txtContribution";
            this.txtContribution.Size = new System.Drawing.Size(137, 29);
            this.txtContribution.TabIndex = 7;
            this.txtContribution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContribution_KeyDown);
            this.txtContribution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContribution_KeyPress);
            // 
            // lblCapitalContrib
            // 
            this.lblCapitalContrib.AutoSize = true;
            this.lblCapitalContrib.Location = new System.Drawing.Point(18, 77);
            this.lblCapitalContrib.Name = "lblCapitalContrib";
            this.lblCapitalContrib.Size = new System.Drawing.Size(306, 21);
            this.lblCapitalContrib.TabIndex = 15;
            this.lblCapitalContrib.Text = "Minimum Initial Capital Contribution:   Php";
            // 
            // dataCapitalContribution
            // 
            this.dataCapitalContribution.AllowUserToAddRows = false;
            this.dataCapitalContribution.AllowUserToDeleteRows = false;
            this.dataCapitalContribution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataCapitalContribution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCapitalContribution.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCapitalContribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCapitalContribution.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCapitalContribution.Location = new System.Drawing.Point(12, 12);
            this.dataCapitalContribution.MultiSelect = false;
            this.dataCapitalContribution.Name = "dataCapitalContribution";
            this.dataCapitalContribution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCapitalContribution.Size = new System.Drawing.Size(678, 171);
            this.dataCapitalContribution.TabIndex = 1;
            this.dataCapitalContribution.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCapitalContribution_CellClick);
            this.dataCapitalContribution.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataCapitalContribution_KeyUp);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(579, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(481, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblDuration);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblMemberType);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblCapitalContrib);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtContribution);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.comboContribution);
            this.groupBox1.Controls.Add(this.comboAccountType);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Modify Share Capital";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(18, 116);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 21);
            this.lblDuration.TabIndex = 80;
            this.lblDuration.Text = "Duration:";
            // 
            // cbShowArchive
            // 
            this.cbShowArchive.AutoSize = true;
            this.cbShowArchive.BackColor = System.Drawing.Color.Yellow;
            this.cbShowArchive.Location = new System.Drawing.Point(12, 194);
            this.cbShowArchive.Name = "cbShowArchive";
            this.cbShowArchive.Size = new System.Drawing.Size(131, 25);
            this.cbShowArchive.TabIndex = 48;
            this.cbShowArchive.Text = "Show Archives";
            this.cbShowArchive.UseVisualStyleBackColor = false;
            // 
            // ShareCapitalContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.cbShowArchive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataCapitalContribution);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "ShareCapitalContribution";
            this.Text = "Share Capital Contribution";
            ((System.ComponentModel.ISupportInitialize)(this.dataCapitalContribution)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.ComboBox comboContribution;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.TextBox txtContribution;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataCapitalContribution;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        public System.Windows.Forms.Label lblMemberType;
        public System.Windows.Forms.Label lblCapitalContrib;
        public System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.CheckBox cbShowArchive;
    }
}