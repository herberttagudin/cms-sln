using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Main.Controller
{
    class MainController
    {
        Main.View.CMS cms;
        Main.View.PaymentForm paymentForm = new Main.View.PaymentForm();

        public MainController(Main.View.CMS cms)
        {
            this.cms = cms;
            this.cms.setUserName(Main.MainData.userName);
            //this.cms.setBtnHomeEventHandler(this.btnHome);
            this.cms.setBtnLoanManagementEventHandler(this.btnLoanManagement);
            this.cms.setBtnPaymentsEventHandler(this.btnPayments);
            this.cms.setBtnSavingsEventHandler(this.btnSavings);
            this.cms.setBtnSettingsEventHandler(this.btnSettings);
            this.cms.setLinkSignOutEventHandler(this.linkSignout);
            this.updateMemberClass();
            this.cms.ShowDialog();
        }

        /*public void btnHome(object args, EventArgs e)
        {
            
        }*/

        public void updateMemberClass()
        {
            
        }

        public void btnLoanManagement(object args, EventArgs e)
        {
            Loan_Management.LoanManagementController loanController = new Loan_Management.LoanManagementController(new Loan_Management.LoanManagementMenu());
        }

        public void btnPayments(object args, EventArgs e)
        {
            Controller.PaymentController paymentController = new Controller.PaymentController(new Model.PaymentModel(), new View.PaymentForm(), cms);
        }

        public void btnSavings(object args, EventArgs e)
        {
            Savings.SavingsController savingsController = new Savings.SavingsController(new Savings.SavingsMenu());
        }

        public void btnSettings(object args, EventArgs e)
        {

        }

        public void linkSignout(object args, EventArgs e)
        {
            Main.MainData.userFirst = String.Empty;
            Main.MainData.userLast = String.Empty;
            Main.MainData.userMiddle = String.Empty;
            Main.MainData.userName = String.Empty;
            Main.MainData.userAccountType = String.Empty;
            cms.Hide();
            cms.Dispose();
            new Login().ShowDialog();
        }
    }
}
