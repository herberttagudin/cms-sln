﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class TimeDepositWithdrawal : Form
    {
        public TimeDepositWithdrawal()
        {
            InitializeComponent();
            this.radioAccountNo.Checked = true;
        }

        private void radioAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioAccountNo.Checked)
            {
                this.txtAccountNo.Clear();
                this.txtMemberName.Clear();
                this.txtCertificateNo.Clear();
                this.txtAccountNo.Enabled = true;
                this.txtMemberName.Enabled = false;
                this.txtCertificateNo.Enabled = false;
            }
        }

        private void radioMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioMemberName.Checked)
            {
                this.txtAccountNo.Clear();
                this.txtMemberName.Clear();
                this.txtCertificateNo.Clear();
                this.txtAccountNo.Enabled = false;
                this.txtMemberName.Enabled = true;
                this.txtCertificateNo.Enabled = false;
            }
        }

        private void radioCertificateNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioCertificateNo.Checked)
            {
                this.txtAccountNo.Clear();
                this.txtMemberName.Clear();
                this.txtCertificateNo.Clear();
                this.txtAccountNo.Enabled = false;
                this.txtMemberName.Enabled = false;
                this.txtCertificateNo.Enabled = true;
            }
        }

        public void setDataTimeDeposit(DataSet ds)
        {
            this.dataTimeDeposit.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataTimeDeposit.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void setGross(String s)
        {
            this.txtGross.Text = s;
        }

        public double getGross()
        {
            return double.Parse(this.txtGross.Text.ToString());
        }

        public void setPenalty(String s)
        {
            this.txtPenalty.Text = s;
        }

        public double getPenalty()
        {
            return double.Parse(this.txtPenalty.Text.ToString());
        }

        public void setTotal(String s)
        {
            this.txtTotal.Text = s;
        }

        public double getTotal()
        {
            return double.Parse(this.txtTotal.Text.ToString());
        }

        public void dataTimeDeposit_CellContentClick(DataGridViewCellEventHandler e)
        {
            this.dataTimeDeposit.CellClick += e;
        }

        public String getAccountNo()
        {
            return this.txtAccountNo.Text;
        }

        public String getMemberName()
        {
            return this.txtMemberName.Text;
        }

        public String getCertificateNo()
        {
            return this.txtCertificateNo.Text;
        }

        public void setBtnClearEventHandler(EventHandler e)
        {
            this.btnClear.Click += e;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void txtAccountNo_TextChanged(EventHandler e)
        {
            this.txtAccountNo.TextChanged += e;
        }

        public void txtMemberName_TextChanged(EventHandler e)
        {
            this.txtMemberName.TextChanged += e;
        }

        public void txtCertificateNo_TextChanged(EventHandler e)
        {
            this.txtCertificateNo.TextChanged += e;
        }

        public void reset()
        {
            this.radioAccountNo.Checked = true;
            this.txtAccountNo.Clear();
            this.txtMemberName.Clear();
            this.txtCertificateNo.Clear();
            this.txtAccountNo.Enabled = true;
            this.txtMemberName.Enabled = false;
            this.txtCertificateNo.Enabled = false;
            this.txtGross.Clear();
            this.txtPenalty.Clear();
            this.txtTotal.Clear();
        }
    }
}
