using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings
{
    public partial class SavingsMenu : Form
    {
        public SavingsMenu()
        {
            InitializeComponent();
        }

        public void setItemSavingsAccountTypesEventHandler(EventHandler e)
        {
            this.itemSavingsAccountTypes.Click += e;
        }

        public void setItemInterestRatesEventHandler(EventHandler e)
        {
            this.itemInterestRates.Click += e;
        }

        public void setItemTimeDepositWithdrawalEventHandler(EventHandler e)
        {
            this.itemTimeDepositWithdrawal.Click += e;
        }

        public void setMaintainingBalancesEventHandler(EventHandler e)
        {
            this.itemMaintainingBal.Click += e;
        }

        public void setDormancyEventHandler(EventHandler e)
        {
            this.itemDormancy.Click += e;
        }

        public void setMaximumWithdrawalEventHandler(EventHandler e)
        {
            this.itemMaxWith.Click += e;
        }
        //trans

        public void setItemOpenAccountEventHandler(EventHandler e)
        {
            this.itemOpenAccount.Click += e;
        }

        public void setItemSavingsAccountTransEventHandler(EventHandler e)
        {
            this.itemSavingsAccountTrans.Click += e;
        }

        public void setItemTimeDepositAppEventHandler(EventHandler e)
        {
            this.itemTimeDepositApp.Click += e;
        }

        public void setItemTimeDepositWithEventHandler(EventHandler e)
        {
            this.itemTimeDepositWith.Click += e;
        }

        public void setItemMemberTerminationEventHandler(EventHandler e)
        {
            this.itemMemberTermination.Click += e;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString();
        }
    }
}