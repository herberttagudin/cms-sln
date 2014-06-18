namespace CMS.Savings.Transaction.View
{
    partial class SignatureCard
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
            this.groupSignature = new System.Windows.Forms.GroupBox();
            this.imgPicture = new System.Windows.Forms.PictureBox();
            this.imgSignature3 = new System.Windows.Forms.PictureBox();
            this.imgSignature2 = new System.Windows.Forms.PictureBox();
            this.imgSignature1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupSignature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignature3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignature2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignature1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSignature
            // 
            this.groupSignature.Controls.Add(this.imgSignature3);
            this.groupSignature.Controls.Add(this.imgSignature2);
            this.groupSignature.Controls.Add(this.imgSignature1);
            this.groupSignature.Location = new System.Drawing.Point(25, 254);
            this.groupSignature.Name = "groupSignature";
            this.groupSignature.Size = new System.Drawing.Size(514, 126);
            this.groupSignature.TabIndex = 14;
            this.groupSignature.TabStop = false;
            this.groupSignature.Text = "Signature Specimen";
            // 
            // imgPicture
            // 
            this.imgPicture.BackgroundImage = global::CMS.Properties.Resources.defaultimg;
            this.imgPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPicture.Enabled = false;
            this.imgPicture.InitialImage = null;
            this.imgPicture.Location = new System.Drawing.Point(13, 66);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(96, 96);
            this.imgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPicture.TabIndex = 87;
            this.imgPicture.TabStop = false;
            // 
            // imgSignature3
            // 
            this.imgSignature3.BackgroundImage = global::CMS.Properties.Resources.signimg;
            this.imgSignature3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSignature3.Enabled = false;
            this.imgSignature3.Location = new System.Drawing.Point(344, 28);
            this.imgSignature3.Name = "imgSignature3";
            this.imgSignature3.Size = new System.Drawing.Size(163, 90);
            this.imgSignature3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSignature3.TabIndex = 90;
            this.imgSignature3.TabStop = false;
            // 
            // imgSignature2
            // 
            this.imgSignature2.BackgroundImage = global::CMS.Properties.Resources.signimg;
            this.imgSignature2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSignature2.Enabled = false;
            this.imgSignature2.Location = new System.Drawing.Point(175, 28);
            this.imgSignature2.Name = "imgSignature2";
            this.imgSignature2.Size = new System.Drawing.Size(163, 90);
            this.imgSignature2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSignature2.TabIndex = 92;
            this.imgSignature2.TabStop = false;
            // 
            // imgSignature1
            // 
            this.imgSignature1.BackgroundImage = global::CMS.Properties.Resources.signimg;
            this.imgSignature1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSignature1.Enabled = false;
            this.imgSignature1.Location = new System.Drawing.Point(6, 28);
            this.imgSignature1.Name = "imgSignature1";
            this.imgSignature1.Size = new System.Drawing.Size(163, 90);
            this.imgSignature1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSignature1.TabIndex = 93;
            this.imgSignature1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(120, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 21);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Member Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(120, 101);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 21);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(120, 168);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(73, 21);
            this.lblBirthdate.TabIndex = 8;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(379, 201);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 21);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(120, 201);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(91, 21);
            this.lblContact.TabIndex = 10;
            this.lblContact.Text = "Contact No.";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(241, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 29);
            this.txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(241, 98);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(292, 58);
            this.txtAddress.TabIndex = 7;
            // 
            // dateBirth
            // 
            this.dateBirth.Enabled = false;
            this.dateBirth.Location = new System.Drawing.Point(241, 162);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(292, 29);
            this.dateBirth.TabIndex = 9;
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(241, 197);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(132, 29);
            this.txtContact.TabIndex = 11;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(446, 198);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(87, 29);
            this.txtGender.TabIndex = 13;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Location = new System.Drawing.Point(241, 28);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(292, 29);
            this.txtAccountNo.TabIndex = 3;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(120, 31);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(91, 21);
            this.lblAccountNo.TabIndex = 2;
            this.lblAccountNo.Text = "Account No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAccountNo);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.imgPicture);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.lblBirthdate);
            this.groupBox1.Controls.Add(this.dateBirth);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Details";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(463, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 32);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SignatureCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 420);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupSignature);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignatureCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signature Card";
            this.groupSignature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignature3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignature2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignature1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSignature;
        private System.Windows.Forms.PictureBox imgPicture;
        private System.Windows.Forms.PictureBox imgSignature3;
        private System.Windows.Forms.PictureBox imgSignature2;
        private System.Windows.Forms.PictureBox imgSignature1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;

    }
}