using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CMS.Savings.Transaction.Controller
{
    class TerminationController
    {
        Savings.Transaction.Model.TerminationModel terminationModel;
        Savings.Transaction.View.MemberTermination termination;


        public TerminationController(Transaction.Model.TerminationModel terminationModel, Transaction.View.MemberTermination termination, SavingsMenu savingsMenu)
        {
            this.terminationModel = terminationModel;
            this.termination = termination;
            this.termination.setBtnSaveEventHandler(this.btnSave);
            this.termination.setBtnSearchMemberEventHandler(this.btnSearchMember);
            this.termination.setTxtAccountNameEventHandler(this.typeSearchMember);
            this.termination.setTxtAccountNoEventHandler(this.typeSearchMember);
            this.termination.classGridSearch(this.terminationModel.selectActiveMember());
            this.termination.setDataSearchEventHandler(this.dataSearch_CellClick);
            this.termination.MdiParent = savingsMenu;
            this.termination.Show();
            if(this.terminationModel.checkEmpty!=0)this.termination.noRowsSelected();
            this.terminationModel.checkEmpty = 0;
            this.termination.clearFields();
        }



        public void btnSave(object args, EventArgs e) {
            
            DataGridViewRow selectedData = this.termination.getSelected();
            String accountNo = selectedData.Cells["Account No."].Value.ToString();
            String reason = this.termination.getReason();
            String details = this.termination.getDetails();
            double totalRefundables = this.terminationModel.selectCurrentShareCapital(accountNo) + this.terminationModel.selectTotalSavings(accountNo);
            double netRefunds = totalRefundables - this.terminationModel.selectRemainingBalance(accountNo);
            CultureInfo ph = new CultureInfo("en-PH");

            if (netRefunds < 0)
            {

                DialogResult dr = MessageBox.Show("Member still has to pay " + (netRefunds * -1).ToString("c", ph) + " to continue termination. Proceed?", "Member Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                if (dr == DialogResult.Yes)
                {

                    if ((this.terminationModel.selectTotalSavings(accountNo) > 0 && this.terminationModel.withdrawSavings(accountNo, this.terminationModel.selectTotalSavings(accountNo)) == 1) || (this.terminationModel.selectCurrentShareCapital(accountNo) >= 0 && this.terminationModel.withdrawShareCapital(accountNo, this.terminationModel.selectCurrentShareCapital(accountNo)) == 1))
                    {
                        //insert loanpayment here
                        int result = this.terminationModel.insertTermination(reason, details, accountNo);
                        if ( result > 0)
                        {
                            MessageBox.Show("Transaction successful.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                            this.termination.clearFields();
                        }
                        else
                        {
                            MessageBox.Show("Transaction failed.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    

                }


            }
            else
            {

                if ((this.terminationModel.selectTotalSavings(accountNo) > 0 && this.terminationModel.withdrawSavings(accountNo, this.terminationModel.selectTotalSavings(accountNo)) == 1) || (this.terminationModel.selectCurrentShareCapital(accountNo) >= 0 && this.terminationModel.withdrawShareCapital(accountNo, this.terminationModel.selectCurrentShareCapital(accountNo)) == 1))

                {
                    //insert loanpayment here

                    if (this.terminationModel.insertTermination(reason, details, accountNo) == 1)
                    {
                        MessageBox.Show("Transaction successful.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                        this.termination.clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Transaction failed.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                
            }
        }

        public void btnSearchMember(object args, EventArgs e) {
            
            bool getSearchType = this.termination.getSearchType();

            if (getSearchType)
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByName(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {
                    
                    this.termination.selectFeesBySearch();
                }
                else {
                    MessageBox.Show("Data not found.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                    if (this.terminationModel.checkEmpty != 0) this.termination.noRowsSelected();
                    this.termination.clearFields();
                }
            }

            else {
                this.termination.classGridSearch(this.terminationModel.searchMemberByAccount(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {
                    
                    this.termination.selectFeesBySearch();
                }
                else
                {
                    MessageBox.Show("Data not found.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                    if (this.terminationModel.checkEmpty != 0) this.termination.noRowsSelected();
                    this.termination.clearFields();
                }
            }


        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            this.termination.selectAnotherMember();
            DataGridViewRow selectedData = this.termination.getSelected();
            String accountNo = selectedData.Cells["Account No."].Value.ToString();
            CultureInfo ph = new CultureInfo("en-PH");
            this.termination.setShareCapitalBalance(this.terminationModel.selectCurrentShareCapital(accountNo).ToString("c",ph));
            this.termination.setSavingsBalance(this.terminationModel.selectTotalSavings(accountNo).ToString("c", ph));
            this.termination.setLoanBalance(this.terminationModel.selectRemainingBalance(accountNo).ToString("c", ph));

            double totalRefundables = this.terminationModel.selectCurrentShareCapital(accountNo) + this.terminationModel.selectTotalSavings(accountNo);
            this.termination.setTotalRefundables(totalRefundables.ToString("c", ph));

            double netRefunds = totalRefundables - this.terminationModel.selectRemainingBalance(accountNo);
            this.termination.setNetRefunds(netRefunds.ToString("c", ph));
            if (netRefunds < 0)
                this.termination.restrictTerminate();
        }

        public void typeSearchMember(object args, EventArgs e)
        {

            bool getSearchType = this.termination.getSearchType();

            if (getSearchType)
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByName(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {

                    this.termination.selectFeesBySearch();
                }
               
            }

            else
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByAccount(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {

                    this.termination.selectFeesBySearch();
                }

            }


        }
         
    }
}
