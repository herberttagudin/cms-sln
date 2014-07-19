namespace CMS.Main.View
{
    partial class PaymentForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupPayment = new System.Windows.Forms.GroupBox();
            this.rbMembership = new System.Windows.Forms.RadioButton();
            this.rbLoan = new System.Windows.Forms.RadioButton();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.dataLoan = new System.Windows.Forms.DataGridView();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.rbMemberName = new System.Windows.Forms.RadioButton();
            this.rbAccountNo = new System.Windows.Forms.RadioButton();
            this.groupMembership = new System.Windows.Forms.GroupBox();
            this.btnMoveBackAll = new System.Windows.Forms.Button();
            this.btnMoveBackSelected = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.dataAddedFee = new System.Windows.Forms.DataGridView();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMPChange = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblMPAmountTendered = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblMPTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFee = new System.Windows.Forms.DataGridView();
            this.btnMoveSelected = new System.Windows.Forms.Button();
            this.groupLoan = new System.Windows.Forms.GroupBox();
            this.chbPayAll = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoanType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.txtAMChange = new System.Windows.Forms.TextBox();
            this.txtPenaltyList = new System.Windows.Forms.TextBox();
            this.lblCMChange = new System.Windows.Forms.Label();
            this.txtAMAmountTendered = new System.Windows.Forms.TextBox();
            this.lblCMAmountTendered = new System.Windows.Forms.Label();
            this.txtTotalAmortization = new System.Windows.Forms.TextBox();
            this.lblCMTotal = new System.Windows.Forms.Label();
            this.dataAmortization = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.lblAddPenalty = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupPayment.SuspendLayout();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.groupMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddedFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFee)).BeginInit();
            this.groupLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAmortization)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(703, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 31);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Cancel";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(703, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 31);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupPayment
            // 
            this.groupPayment.Controls.Add(this.rbMembership);
            this.groupPayment.Controls.Add(this.rbLoan);
            this.groupPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPayment.Location = new System.Drawing.Point(695, 27);
            this.groupPayment.Name = "groupPayment";
            this.groupPayment.Size = new System.Drawing.Size(128, 85);
            this.groupPayment.TabIndex = 65;
            this.groupPayment.TabStop = false;
            this.groupPayment.Text = "Payment Type";
            // 
            // rbMembership
            // 
            this.rbMembership.AutoSize = true;
            this.rbMembership.Checked = true;
            this.rbMembership.Location = new System.Drawing.Point(7, 26);
            this.rbMembership.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMembership.Name = "rbMembership";
            this.rbMembership.Size = new System.Drawing.Size(100, 21);
            this.rbMembership.TabIndex = 35;
            this.rbMembership.TabStop = true;
            this.rbMembership.Text = "Membership";
            this.rbMembership.UseVisualStyleBackColor = true;
            this.rbMembership.CheckedChanged += new System.EventHandler(this.radioMembership_CheckedChanged);
            // 
            // rbLoan
            // 
            this.rbLoan.AutoSize = true;
            this.rbLoan.Location = new System.Drawing.Point(6, 57);
            this.rbLoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLoan.Name = "rbLoan";
            this.rbLoan.Size = new System.Drawing.Size(107, 21);
            this.rbLoan.TabIndex = 35;
            this.rbLoan.TabStop = true;
            this.rbLoan.Text = "Loan Payment";
            this.rbLoan.UseVisualStyleBackColor = true;
            this.rbLoan.CheckedChanged += new System.EventHandler(this.radioLoan_CheckedChanged);
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.dataLoan);
            this.groupSearch.Controls.Add(this.dataSearch);
            this.groupSearch.Controls.Add(this.txtMemberName);
            this.groupSearch.Controls.Add(this.txtAccountNo);
            this.groupSearch.Controls.Add(this.rbMemberName);
            this.groupSearch.Controls.Add(this.rbAccountNo);
            this.groupSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.Location = new System.Drawing.Point(10, 3);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(679, 188);
            this.groupSearch.TabIndex = 64;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search Member";
            // 
            // dataLoan
            // 
            this.dataLoan.AllowUserToAddRows = false;
            this.dataLoan.AllowUserToDeleteRows = false;
            this.dataLoan.AllowUserToOrderColumns = true;
            this.dataLoan.AllowUserToResizeRows = false;
            this.dataLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataLoan.Location = new System.Drawing.Point(216, 21);
            this.dataLoan.Name = "dataLoan";
            this.dataLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLoan.Size = new System.Drawing.Size(448, 161);
            this.dataLoan.TabIndex = 70;
            this.dataLoan.Visible = false;
            this.dataLoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLoan_CellClick);
            // 
            // dataSearch
            // 
            this.dataSearch.AllowUserToAddRows = false;
            this.dataSearch.AllowUserToDeleteRows = false;
            this.dataSearch.AllowUserToOrderColumns = true;
            this.dataSearch.AllowUserToResizeRows = false;
            this.dataSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataSearch.Location = new System.Drawing.Point(216, 21);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSearch.Size = new System.Drawing.Size(448, 161);
            this.dataSearch.TabIndex = 55;
            this.dataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearch_CellClick);
            this.dataSearch.SelectionChanged += new System.EventHandler(this.dataSearch_SelectionChanged);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Location = new System.Drawing.Point(6, 124);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(200, 25);
            this.txtMemberName.TabIndex = 54;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Location = new System.Drawing.Point(6, 65);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(200, 25);
            this.txtAccountNo.TabIndex = 53;
            // 
            // rbMemberName
            // 
            this.rbMemberName.AutoSize = true;
            this.rbMemberName.Location = new System.Drawing.Point(8, 97);
            this.rbMemberName.Name = "rbMemberName";
            this.rbMemberName.Size = new System.Drawing.Size(118, 21);
            this.rbMemberName.TabIndex = 50;
            this.rbMemberName.TabStop = true;
            this.rbMemberName.Text = "Member Name:";
            this.rbMemberName.UseVisualStyleBackColor = true;
            this.rbMemberName.CheckedChanged += new System.EventHandler(this.rbMemberName_CheckedChanged);
            // 
            // rbAccountNo
            // 
            this.rbAccountNo.AutoSize = true;
            this.rbAccountNo.Location = new System.Drawing.Point(6, 38);
            this.rbAccountNo.Name = "rbAccountNo";
            this.rbAccountNo.Size = new System.Drawing.Size(97, 21);
            this.rbAccountNo.TabIndex = 49;
            this.rbAccountNo.TabStop = true;
            this.rbAccountNo.Text = "Account No:";
            this.rbAccountNo.UseVisualStyleBackColor = true;
            this.rbAccountNo.CheckedChanged += new System.EventHandler(this.rbAccountNo_CheckedChanged);
            // 
            // groupMembership
            // 
            this.groupMembership.Controls.Add(this.btnMoveBackAll);
            this.groupMembership.Controls.Add(this.btnMoveBackSelected);
            this.groupMembership.Controls.Add(this.btnMoveAll);
            this.groupMembership.Controls.Add(this.dataAddedFee);
            this.groupMembership.Controls.Add(this.txtChange);
            this.groupMembership.Controls.Add(this.lblMPChange);
            this.groupMembership.Controls.Add(this.txtAmount);
            this.groupMembership.Controls.Add(this.lblMPAmountTendered);
            this.groupMembership.Controls.Add(this.txtTotalAmount);
            this.groupMembership.Controls.Add(this.lblMPTotal);
            this.groupMembership.Controls.Add(this.label3);
            this.groupMembership.Controls.Add(this.label1);
            this.groupMembership.Controls.Add(this.dataFee);
            this.groupMembership.Controls.Add(this.btnMoveSelected);
            this.groupMembership.Location = new System.Drawing.Point(10, 199);
            this.groupMembership.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupMembership.Name = "groupMembership";
            this.groupMembership.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupMembership.Size = new System.Drawing.Size(921, 300);
            this.groupMembership.TabIndex = 66;
            this.groupMembership.TabStop = false;
            this.groupMembership.Text = "Membership Fees";
            // 
            // btnMoveBackAll
            // 
            this.btnMoveBackAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoveBackAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveBackAll.Location = new System.Drawing.Point(308, 212);
            this.btnMoveBackAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveBackAll.Name = "btnMoveBackAll";
            this.btnMoveBackAll.Size = new System.Drawing.Size(35, 30);
            this.btnMoveBackAll.TabIndex = 49;
            this.btnMoveBackAll.Text = "<<";
            this.btnMoveBackAll.UseVisualStyleBackColor = true;
            this.btnMoveBackAll.Click += new System.EventHandler(this.btnMoveBackAll_Click);
            // 
            // btnMoveBackSelected
            // 
            this.btnMoveBackSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoveBackSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveBackSelected.Location = new System.Drawing.Point(308, 176);
            this.btnMoveBackSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveBackSelected.Name = "btnMoveBackSelected";
            this.btnMoveBackSelected.Size = new System.Drawing.Size(35, 30);
            this.btnMoveBackSelected.TabIndex = 48;
            this.btnMoveBackSelected.Text = "<";
            this.btnMoveBackSelected.UseVisualStyleBackColor = true;
            this.btnMoveBackSelected.Click += new System.EventHandler(this.btnMoveBackSelected_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoveAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAll.Location = new System.Drawing.Point(307, 136);
            this.btnMoveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(35, 30);
            this.btnMoveAll.TabIndex = 47;
            this.btnMoveAll.Text = ">>";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // dataAddedFee
            // 
            this.dataAddedFee.AllowUserToAddRows = false;
            this.dataAddedFee.AllowUserToDeleteRows = false;
            this.dataAddedFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAddedFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAddedFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Items,
            this.clmAmt});
            this.dataAddedFee.Location = new System.Drawing.Point(350, 48);
            this.dataAddedFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataAddedFee.Name = "dataAddedFee";
            this.dataAddedFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAddedFee.Size = new System.Drawing.Size(318, 235);
            this.dataAddedFee.TabIndex = 46;
            this.dataAddedFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAddedFee_CellContentClick);
            // 
            // Items
            // 
            this.Items.HeaderText = "Fee";
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            // 
            // clmAmt
            // 
            this.clmAmt.HeaderText = "Amount";
            this.clmAmt.Name = "clmAmt";
            this.clmAmt.ReadOnly = true;
            // 
            // txtChange
            // 
            this.txtChange.ContextMenuStrip = this.contextMenuBlank;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(681, 224);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(199, 27);
            this.txtChange.TabIndex = 45;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMPChange
            // 
            this.lblMPChange.AutoSize = true;
            this.lblMPChange.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPChange.Location = new System.Drawing.Point(677, 202);
            this.lblMPChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPChange.Name = "lblMPChange";
            this.lblMPChange.Size = new System.Drawing.Size(65, 20);
            this.lblMPChange.TabIndex = 44;
            this.lblMPChange.Text = "Change:";
            this.lblMPChange.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(681, 158);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.MaxLength = 7;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(199, 27);
            this.txtAmount.TabIndex = 45;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyPaste);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblMPAmountTendered
            // 
            this.lblMPAmountTendered.AutoSize = true;
            this.lblMPAmountTendered.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPAmountTendered.Location = new System.Drawing.Point(677, 136);
            this.lblMPAmountTendered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPAmountTendered.Name = "lblMPAmountTendered";
            this.lblMPAmountTendered.Size = new System.Drawing.Size(136, 20);
            this.lblMPAmountTendered.TabIndex = 44;
            this.lblMPAmountTendered.Text = "Amount Tendered:";
            this.lblMPAmountTendered.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTotalAmount.Location = new System.Drawing.Point(681, 88);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(197, 35);
            this.txtTotalAmount.TabIndex = 45;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMPTotal
            // 
            this.lblMPTotal.AutoSize = true;
            this.lblMPTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMPTotal.Location = new System.Drawing.Point(676, 63);
            this.lblMPTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPTotal.Name = "lblMPTotal";
            this.lblMPTotal.Size = new System.Drawing.Size(92, 25);
            this.lblMPTotal.TabIndex = 44;
            this.lblMPTotal.Text = "TOTAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Currently Added:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Particulars:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataFee
            // 
            this.dataFee.AllowUserToAddRows = false;
            this.dataFee.AllowUserToDeleteRows = false;
            this.dataFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFee.Location = new System.Drawing.Point(6, 48);
            this.dataFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataFee.Name = "dataFee";
            this.dataFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFee.Size = new System.Drawing.Size(294, 235);
            this.dataFee.TabIndex = 40;
            this.dataFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFee_CellContentClick);
            // 
            // btnMoveSelected
            // 
            this.btnMoveSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoveSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveSelected.Location = new System.Drawing.Point(307, 96);
            this.btnMoveSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveSelected.Name = "btnMoveSelected";
            this.btnMoveSelected.Size = new System.Drawing.Size(35, 30);
            this.btnMoveSelected.TabIndex = 36;
            this.btnMoveSelected.Text = ">";
            this.btnMoveSelected.UseVisualStyleBackColor = true;
            this.btnMoveSelected.Click += new System.EventHandler(this.btnMoveSelected_Click);
            // 
            // groupLoan
            // 
            this.groupLoan.Controls.Add(this.chbPayAll);
            this.groupLoan.Controls.Add(this.label4);
            this.groupLoan.Controls.Add(this.cbLoanType);
            this.groupLoan.Controls.Add(this.label2);
            this.groupLoan.Controls.Add(this.txtInterest);
            this.groupLoan.Controls.Add(this.lblPenalty);
            this.groupLoan.Controls.Add(this.txtAMChange);
            this.groupLoan.Controls.Add(this.txtPenaltyList);
            this.groupLoan.Controls.Add(this.lblCMChange);
            this.groupLoan.Controls.Add(this.txtAMAmountTendered);
            this.groupLoan.Controls.Add(this.lblCMAmountTendered);
            this.groupLoan.Controls.Add(this.txtTotalAmortization);
            this.groupLoan.Controls.Add(this.lblCMTotal);
            this.groupLoan.Controls.Add(this.dataAmortization);
            this.groupLoan.Controls.Add(this.checkBox1);
            this.groupLoan.Controls.Add(this.txtPenalty);
            this.groupLoan.Controls.Add(this.txtAmountDue);
            this.groupLoan.Controls.Add(this.lblAddPenalty);
            this.groupLoan.Controls.Add(this.lblAmountDue);
            this.groupLoan.Controls.Add(this.textBox6);
            this.groupLoan.Controls.Add(this.label7);
            this.groupLoan.Controls.Add(this.textBox10);
            this.groupLoan.Controls.Add(this.label9);
            this.groupLoan.Controls.Add(this.textBox11);
            this.groupLoan.Controls.Add(this.label10);
            this.groupLoan.Location = new System.Drawing.Point(10, 199);
            this.groupLoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupLoan.Name = "groupLoan";
            this.groupLoan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupLoan.Size = new System.Drawing.Size(921, 300);
            this.groupLoan.TabIndex = 69;
            this.groupLoan.TabStop = false;
            this.groupLoan.Text = "Loan Payment";
            // 
            // chbPayAll
            // 
            this.chbPayAll.AutoSize = true;
            this.chbPayAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPayAll.Location = new System.Drawing.Point(212, 22);
            this.chbPayAll.Name = "chbPayAll";
            this.chbPayAll.Size = new System.Drawing.Size(73, 24);
            this.chbPayAll.TabIndex = 65;
            this.chbPayAll.Text = "Pay All";
            this.chbPayAll.UseVisualStyleBackColor = true;
            this.chbPayAll.CheckedChanged += new System.EventHandler(this.chbPayAll_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Loan Type";
            // 
            // cbLoanType
            // 
            this.cbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanType.FormattingEnabled = true;
            this.cbLoanType.Location = new System.Drawing.Point(85, 22);
            this.cbLoanType.Name = "cbLoanType";
            this.cbLoanType.Size = new System.Drawing.Size(121, 25);
            this.cbLoanType.TabIndex = 63;
            this.cbLoanType.SelectedIndexChanged += new System.EventHandler(this.cbLoanType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(730, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Interest";
            // 
            // txtInterest
            // 
            this.txtInterest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(813, 90);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 29);
            this.txtInterest.TabIndex = 61;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblPenalty.Location = new System.Drawing.Point(439, 61);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(174, 23);
            this.lblPenalty.TabIndex = 60;
            this.lblPenalty.Text = "Penalties and Interest";
            // 
            // txtAMChange
            // 
            this.txtAMChange.ContextMenuStrip = this.contextMenuBlank;
            this.txtAMChange.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAMChange.Location = new System.Drawing.Point(691, 256);
            this.txtAMChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAMChange.Name = "txtAMChange";
            this.txtAMChange.ReadOnly = true;
            this.txtAMChange.Size = new System.Drawing.Size(187, 27);
            this.txtAMChange.TabIndex = 59;
            this.txtAMChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPenaltyList
            // 
            this.txtPenaltyList.Location = new System.Drawing.Point(443, 87);
            this.txtPenaltyList.Multiline = true;
            this.txtPenaltyList.Name = "txtPenaltyList";
            this.txtPenaltyList.ReadOnly = true;
            this.txtPenaltyList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPenaltyList.Size = new System.Drawing.Size(237, 196);
            this.txtPenaltyList.TabIndex = 53;
            this.txtPenaltyList.WordWrap = false;
            // 
            // lblCMChange
            // 
            this.lblCMChange.AutoSize = true;
            this.lblCMChange.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMChange.Location = new System.Drawing.Point(687, 231);
            this.lblCMChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMChange.Name = "lblCMChange";
            this.lblCMChange.Size = new System.Drawing.Size(65, 20);
            this.lblCMChange.TabIndex = 58;
            this.lblCMChange.Text = "Change:";
            // 
            // txtAMAmountTendered
            // 
            this.txtAMAmountTendered.ContextMenuStrip = this.contextMenuBlank;
            this.txtAMAmountTendered.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAMAmountTendered.Location = new System.Drawing.Point(691, 199);
            this.txtAMAmountTendered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAMAmountTendered.MaxLength = 7;
            this.txtAMAmountTendered.Name = "txtAMAmountTendered";
            this.txtAMAmountTendered.Size = new System.Drawing.Size(187, 27);
            this.txtAMAmountTendered.TabIndex = 57;
            this.txtAMAmountTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAMAmountTendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAMAmountTendered_KeyPress);
            // 
            // lblCMAmountTendered
            // 
            this.lblCMAmountTendered.AutoSize = true;
            this.lblCMAmountTendered.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMAmountTendered.Location = new System.Drawing.Point(687, 174);
            this.lblCMAmountTendered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMAmountTendered.Name = "lblCMAmountTendered";
            this.lblCMAmountTendered.Size = new System.Drawing.Size(136, 20);
            this.lblCMAmountTendered.TabIndex = 56;
            this.lblCMAmountTendered.Text = "Amount Tendered:";
            // 
            // txtTotalAmortization
            // 
            this.txtTotalAmortization.ContextMenuStrip = this.contextMenuBlank;
            this.txtTotalAmortization.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmortization.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTotalAmortization.Location = new System.Drawing.Point(786, 121);
            this.txtTotalAmortization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmortization.Name = "txtTotalAmortization";
            this.txtTotalAmortization.Size = new System.Drawing.Size(127, 35);
            this.txtTotalAmortization.TabIndex = 55;
            this.txtTotalAmortization.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCMTotal
            // 
            this.lblCMTotal.AutoSize = true;
            this.lblCMTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCMTotal.Location = new System.Drawing.Point(686, 128);
            this.lblCMTotal.Name = "lblCMTotal";
            this.lblCMTotal.Size = new System.Drawing.Size(92, 25);
            this.lblCMTotal.TabIndex = 54;
            this.lblCMTotal.Text = "TOTAL:";
            // 
            // dataAmortization
            // 
            this.dataAmortization.AllowUserToAddRows = false;
            this.dataAmortization.AllowUserToDeleteRows = false;
            this.dataAmortization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAmortization.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAmortization.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataAmortization.Location = new System.Drawing.Point(18, 52);
            this.dataAmortization.Name = "dataAmortization";
            this.dataAmortization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAmortization.Size = new System.Drawing.Size(419, 232);
            this.dataAmortization.TabIndex = 52;
            this.dataAmortization.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAmortization_CellContentClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(614, 492);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 21);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "CRedit to Loan Balance";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtPenalty
            // 
            this.txtPenalty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenalty.Location = new System.Drawing.Point(813, 59);
            this.txtPenalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(100, 29);
            this.txtPenalty.TabIndex = 49;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDue.Location = new System.Drawing.Point(801, 26);
            this.txtAmountDue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(112, 29);
            this.txtAmountDue.TabIndex = 50;
            this.txtAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAddPenalty
            // 
            this.lblAddPenalty.AutoSize = true;
            this.lblAddPenalty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPenalty.Location = new System.Drawing.Point(700, 65);
            this.lblAddPenalty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddPenalty.Name = "lblAddPenalty";
            this.lblAddPenalty.Size = new System.Drawing.Size(93, 17);
            this.lblAddPenalty.TabIndex = 47;
            this.lblAddPenalty.Text = "Add: Penalites";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(687, 29);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(106, 21);
            this.lblAmountDue.TabIndex = 48;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(730, 444);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 27);
            this.textBox6.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(608, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Change:";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(216, 444);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(199, 27);
            this.textBox10.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 448);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Amount Tendered:";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(730, 395);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(199, 27);
            this.textBox11.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(592, 400);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "TOTAL:";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupPayment);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.groupMembership);
            this.Controls.Add(this.groupLoan);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaymentForm";
            this.Size = new System.Drawing.Size(960, 511);
            this.groupPayment.ResumeLayout(false);
            this.groupPayment.PerformLayout();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.groupMembership.ResumeLayout(false);
            this.groupMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddedFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFee)).EndInit();
            this.groupLoan.ResumeLayout(false);
            this.groupLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAmortization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupPayment;
        private System.Windows.Forms.RadioButton rbMembership;
        private System.Windows.Forms.RadioButton rbLoan;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.RadioButton rbMemberName;
        private System.Windows.Forms.RadioButton rbAccountNo;
        private System.Windows.Forms.GroupBox groupMembership;
        private System.Windows.Forms.DataGridView dataAddedFee;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblMPChange;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblMPAmountTendered;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblMPTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataFee;
        private System.Windows.Forms.Button btnMoveSelected;
        private System.Windows.Forms.GroupBox groupLoan;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label lblAddPenalty;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMoveBackAll;
        private System.Windows.Forms.Button btnMoveBackSelected;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmt;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.TextBox txtPenaltyList;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.TextBox txtAMChange;
        private System.Windows.Forms.Label lblCMChange;
        private System.Windows.Forms.TextBox txtAMAmountTendered;
        private System.Windows.Forms.Label lblCMAmountTendered;
        private System.Windows.Forms.TextBox txtTotalAmortization;
        private System.Windows.Forms.Label lblCMTotal;
        private System.Windows.Forms.DataGridView dataLoan;
        public System.Windows.Forms.DataGridView dataAmortization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.CheckBox chbPayAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoanType;



    }
}
