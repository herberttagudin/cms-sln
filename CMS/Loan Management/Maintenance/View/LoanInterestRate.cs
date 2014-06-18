﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.View
{
    public partial class LoanInterestRate : Form
    {
        public LoanInterestRate()
        {
            InitializeComponent();
            dataInterest.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void disableFunction()
        {
            this.startDate.MinDate = DateTime.Now;
            this.endDate.MinDate = DateTime.Now.AddDays(1);
            this.cbLoanType.SelectedIndex=-1;
            gbInterest.Enabled = false;
            this.chbStatus.CheckState = CheckState.Unchecked;
            this.txtInterest.Text = String.Empty;
            this.cbInterestStatus.SelectedIndex = -1;
            this.cbDuration.SelectedIndex = -1;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            //this.btnDelete.Enabled = true;

        }
        public void enableFunction()
        {
            this.cbLoanType.Enabled = true;
            this.startDate.MinDate = DateTime.Now;
            this.endDate.MinDate = DateTime.Now.AddDays(1);
            this.cbLoanType.SelectedIndex = -1;
            gbInterest.Enabled = true;
            this.txtInterest.Text = String.Empty;
            this.cbInterestStatus.SelectedIndex = -1;
            this.cbDuration.SelectedIndex = -1;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
           // this.btnDelete.Enabled = false;
        }

        

        public void setAllLabelsToBlack()
        {
            this.lblLoanType.ForeColor = System.Drawing.Color.Black;
            this.lblInterestRate.ForeColor = System.Drawing.Color.Black;
            this.lblPer.ForeColor = System.Drawing.Color.Black;
        }

        public void disableType()
        {
            this.cbLoanType.Enabled = false;
        }

        public void resetDate() {

            this.startDate.MinDate = DateTime.Now;
            this.endDate.MinDate = DateTime.Now.AddDays(1);
            this.startDate.Value = DateTime.Now;
            this.endDate.Value = DateTime.Now.AddDays(1);
        
        }


        public int initLoanType(DataSet ds)
        {
            int i = 0;
            this.cbLoanType.DataSource = ds.Tables[0];
            this.cbLoanType.ValueMember = "LoanTypeId";
            this.cbLoanType.DisplayMember = "LoanTypeName";

            if (cbLoanType.Items.Count == 0) { i = 1; }
            return i;
        }

        public void setLoanType(String s)
        {
            this.cbLoanType.Text = s;
        }

        public int getLoanType()
        {
            return int.Parse(this.cbLoanType.SelectedValue.ToString());
        }



        public void setInterestRate(double d)
        {
            this.txtInterest.Text = d.ToString();
        }

        public double getInterestRate()
        {
            return double.Parse(this.txtInterest.Text);
        }

        public void setInterestRateStatus(String s)
        {
            this.cbInterestStatus.SelectedItem = s;
        }

        public String getInterestRateStatus()
        {
            return this.cbInterestStatus.SelectedItem.ToString();
        }

        public void setDuration(String s)
        {
            this.cbDuration.SelectedItem = s;
        }

        public String getDuration()
        {
            return this.cbDuration.SelectedItem.ToString();
        }

        public void setStartDate(System.DateTime s)
        {
            this.startDate.MinDate = s;
        }

        public String getStartDate()
        {
            return this.startDate.Value.ToString("yyyy-MM-dd");
        }

        public void setEndDate(System.DateTime s)
        {
            try
            {
                this.endDate.Value = s;
            }
            catch (Exception) { }
        }

        public String getEndDate()
        {
            return this.endDate.Value.ToString("yyyy-MM-dd");
        }



        
        public void setStatus()
        {
            this.chbStatus.CheckState = CheckState.Checked;
        }

        public bool getStatus()
        {
            return this.chbStatus.Checked;
        }

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setBtnCancelEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }

        public void loanGrid(DataSet ds)
        {
            this.dataInterest.DataSource = ds.Tables[0];
            this.dataInterest.Columns[0].Visible = false;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataInterest.SelectedRows[0];
        }

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

       /* public void setBtnDeletEventHandler(EventHandler e)
        {
            this.btnDelete.Click += e;
        }*/
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LoanInterestRate_Load(object sender, EventArgs e)
        {
            this.startDate.MinDate = DateTime.Now;
            this.endDate.MinDate = DateTime.Now.AddDays(1);
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            this.endDate.MinDate = this.startDate.Value.Date.AddDays(1);
        }

        private void startDate_TabIndexChanged(object sender, EventArgs e)
        {
            this.startDate.MinDate = DateTime.Now;
            this.endDate.MinDate = DateTime.Now.AddDays(1);
        }

        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
                if (parts.Length > 1 || tb.TextLength > 5)
                {
                    if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }   
                
        }

        private void txtInterest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


    }
}