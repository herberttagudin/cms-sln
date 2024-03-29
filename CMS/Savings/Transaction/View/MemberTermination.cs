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
    public partial class MemberTermination : Form
    {
        //Model.PaymentModel paymentModel = new Model.PaymentModel();
        public MemberTermination()
        {
            InitializeComponent();
            dataSearch.ReadOnly = true;
        }

        public void noRowsSelected()
        {
            dataSearch.Rows[0].Selected = false;
        }

        public void clearFields()
        {
            this.btnSave.Enabled = false;
            this.dataSearch.ClearSelection();
            this.txtAccountNo.Clear();
            this.txtMemberName.Clear();
            this.rbAccountNo.Checked = false;
            this.rbMemberName.Checked = false;
            this.txtAccountNo.Enabled = false;
            this.txtMemberName.Enabled = false;
            this.rbVLeave.Checked = false;
            this.rbVIncapable.Checked = false;
            this.rbRVoluntary.Checked = false;
            this.rbROthers.Checked = false;
            this.rbRForced.Checked = false;
            this.rbFDormant.Checked = false;
            this.rbFViolation.Checked = false;
            this.txtShareBalance.Clear();
            this.txtSavingsBalance.Clear();
            this.txtTotalRefundables.Clear();
            this.txtSCapBalance.Clear();
            this.txtSavings.Clear();
            this.txtLoanBalance.Clear();
            this.txtNetRefunds.Clear();
            this.txtSpecify.Clear();

        }

        private void rbRVoluntary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRVoluntary.Checked)
            {
                rbVIncapable.Enabled = true;
                rbVLeave.Enabled = true;
                this.btnSave.Enabled = false;

            }
            else
            {
                rbVIncapable.Enabled = false;
                rbVLeave.Enabled = false;
                rbVIncapable.Checked = false;
                rbVLeave.Checked = false;
            }
        }

        private void rbRForced_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRForced.Checked)
            {
                rbFDormant.Enabled = true;
                rbFViolation.Enabled = true;
                this.btnSave.Enabled = false;
            }
            else {
                rbFDormant.Enabled = false;
                rbFViolation.Enabled = false;
                rbFDormant.Checked = false;
                rbFViolation.Checked = false;
            }
        }

        private void rbROthers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbROthers.Checked)
            {
                txtSpecify.Enabled = true;
            }
            else {
                txtSpecify.Enabled = false;
                txtSpecify.Clear();
            }
        }

        public void setTxtAccountNameEventHandler(EventHandler e)
        {

            txtMemberName.TextChanged += e;
        }

        public void setTxtAccountNoEventHandler(EventHandler e)
        {

            txtAccountNo.TextChanged += e;
        }



        public void setBtnSearchMemberEventHandler(EventHandler e)
        {
            this.btnSearchMember.Click += e;
        }



        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setShareCapitalBalance(String s) {

            this.txtSCapBalance.Text = s;
            this.txtShareBalance.Text = s;
        }

        public void setSavingsBalance(String s) {

            this.txtSavings.Text = s;
            this.txtSavingsBalance.Text = s;
        
        }

        public void setLoanBalance(String s)
        {
            this.txtLoanBalance.Text = s;
        }

        public void setTotalRefundables(String s) {

            this.txtTotalRefundables.Text = s;
        }

        public void setNetRefunds(String s) {

            this.txtNetRefunds.Text = s;
        }

        public void restrictTerminate() {

            txtNetRefunds.ForeColor = Color.Red;
        }

        public void classGridSearch(DataSet ds)
        {
            this.dataSearch.DataSource = ds.Tables[0];
        }


        public DataGridViewRow getSelected()
        {
            return this.dataSearch.SelectedRows[0];
        }

        public bool checkIfEmpty()
        {

            Boolean check;
            if (this.dataSearch.Rows.Count == 0) { check = false; }
            else { check = true; }

            return check;
        }

        public String getReason() 
        {
            String reason = String.Empty;
            if (rbRForced.Checked == true) { reason = "Forced Termination"; }
            else if (rbRVoluntary.Checked == true) { reason = "Voluntary Withdrawal"; }
            else if (rbROthers.Checked == true) { reason = "Others"; }
            return reason;
        }

        public String getDetails() 
        {
            String details = String.Empty;
            if (rbFDormant.Checked == true) { details = "Dormancy/Deliquency"; }
            else if (rbFViolation.Checked == true) { details = "Violation of By-Laws"; }
            else if (rbVIncapable.Checked == true) { details = "Incapable of Funding"; }
            else if (rbVLeave.Checked== true) { details = "Leaving the Vicinity"; }
            else { details = txtSpecify.Text; }

            return details;
        }

        public double getShareCapital() {

            return Double.Parse(this.txtSCapBalance.Text);
        
        }

        public double getSavings()
        {

            return Double.Parse(this.txtSavings.Text);
        }

        public double getLoanBalance()
        {

            return Double.Parse(this.txtLoanBalance.Text);
        
        }


        public bool getSearchType()
        {
            bool check = false;

            if (rbAccountNo.Checked) check = false;
            if (rbMemberName.Checked) check = true;

            return check;

        }

        

        public String getSearch()
        {
            String searchName = String.Empty;
            if (rbAccountNo.Checked == true)
            {
                searchName = this.txtAccountNo.Text;
            }

            else if (rbMemberName.Checked == true)
            {
                searchName = this.txtMemberName.Text;
            }


            return searchName;
        }

        

        private void rbAccountNo_CheckedChanged(object sender, EventArgs e)
        {

            if (rbAccountNo.Checked)
            {
                txtAccountNo.Enabled = true;
                txtMemberName.Clear();
                txtMemberName.Enabled = false;
            }
            
        }

        private void rbMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMemberName.Checked)
            {
                txtMemberName.Enabled = true;
                txtAccountNo.Clear();
                txtAccountNo.Enabled = false;
            }
        }



        public void selectFeesBySearch()
        {
            /*
            this.btnMoveAll.Enabled = true;
            this.btnMoveBackAll.Enabled = true;
            this.btnMoveBackSelected.Enabled = true;
            this.btnMoveSelected.Enabled = true;
            this.dataAddedFee.Rows.Clear();
            DataGridViewRow selectedData = this.getSelected();
            int accountNo = int.Parse(selectedData.Cells["Account No."].Value.ToString());

            DataSet ds = paymentModel.selectAccountNoFromPayment(accountNo);

            if (ds.Tables[0].Rows.Count == 0)
            {
                String memberType = selectedData.Cells["Member Type"].Value.ToString();
                this.classGridFee(this.paymentModel.selectFeesPerMemberType(memberType));
            }
            else
            {
                this.classGridFee(this.paymentModel.selectFeesPerPayment(accountNo));
            }
             */

        }



        private void rbAccountNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbAccountNo.Checked == true) { txtAccountNo.Enabled = true; }
            else { txtAccountNo.Enabled = false; txtAccountNo.Clear(); }
        }

        private void rbMemberName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbMemberName.Checked == true) { txtMemberName.Enabled = true; }
            else { txtMemberName.Enabled = false; txtMemberName.Clear(); }
        }

        public void setDataSearchEventHandler(DataGridViewCellEventHandler e) {

            this.dataSearch.CellClick += e;
        }

        public void selectAnotherMember()
        {

            this.btnSave.Enabled = false;
            this.rbVLeave.Checked = false;
            this.rbVIncapable.Checked = false;
            this.rbRVoluntary.Checked = false;
            this.rbROthers.Checked = false;
            this.rbRForced.Checked = false;
            this.rbFDormant.Checked = false;
            this.rbFViolation.Checked = false;
            this.txtShareBalance.Clear();
            this.txtSavingsBalance.Clear();
            this.txtTotalRefundables.Clear();
            this.txtSCapBalance.Clear();
            this.txtSavings.Clear();
            this.txtLoanBalance.Clear();
            this.txtNetRefunds.Clear();
            this.txtSpecify.Clear();
            this.tabTermination.SelectedIndex = 0;
        
        }

        private void rbVLeave_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVLeave.Checked == true) { this.btnSave.Enabled = true; }
            else { this.btnSave.Enabled = false; }
        }

        private void rbVIncapable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVIncapable.Checked == true) { this.btnSave.Enabled = true; }
            else { this.btnSave.Enabled = false; }
        }

        private void rbFDormant_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFDormant.Checked == true) { this.btnSave.Enabled = true; }
            else { this.btnSave.Enabled = false; }
        }

        private void rbFViolation_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFViolation.Checked == true) { this.btnSave.Enabled = true; }
            else { this.btnSave.Enabled = false; }
        }

        private void txtSpecify_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.btnSave.Enabled = true;
        }




    }
}
