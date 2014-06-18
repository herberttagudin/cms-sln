using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Savings
{
    class SavingsController
    {
        SavingsMenu savingsMenu = new SavingsMenu();

        public SavingsController(SavingsMenu savingsMenu)
        {
            this.savingsMenu = savingsMenu;
            this.savingsMenu.setItemInterestRatesEventHandler(this.itemInterestRates);
            this.savingsMenu.setItemSavingsAccountTypesEventHandler(this.itemSavingsAccountTypes);
            this.savingsMenu.setItemTimeDepositWithdrawalEventHandler(this.itemTimeDepositWithdrawal);
            this.savingsMenu.setDormancyEventHandler(this.itemDormancy);
            this.savingsMenu.setMaintainingBalancesEventHandler(this.itemMaintainingBalance);
            this.savingsMenu.setMaximumWithdrawalEventHandler(this.itemMaximumWithdrawal);
            //trans
            this.savingsMenu.setItemOpenAccountEventHandler(this.itemOpenAccount);
            this.savingsMenu.setItemSavingsAccountTransEventHandler(this.itemSavingsAccountTrans);
            this.savingsMenu.setItemTimeDepositAppEventHandler(this.itemTimeDepositApp);
            this.savingsMenu.setItemTimeDepositWithEventHandler(this.itemTimeDepositWith);
            this.savingsMenu.setItemMemberTerminationEventHandler(this.itemMemberTermination);
            this.savingsMenu.ShowDialog();
        }

        public void itemDormancy(object args, EventArgs e)
        {
            Maintenance.Controller.DormancyController dormancyController = new Maintenance.Controller.DormancyController(new Maintenance.Model.DormancyModel(), new Maintenance.View.Dormancy(), savingsMenu);
        }
        
        public void itemInterestRates(object args, EventArgs e)
        {
            Maintenance.Controller.InterestRatesController interestRatesController = new Maintenance.Controller.InterestRatesController(new Maintenance.Model.InterestRatesModel(), new Maintenance.View.InterestRates(), savingsMenu);
        }

        public void itemMaintainingBalance(object args, EventArgs e)
        {
            Maintenance.Controller.MaintainingBalanceController maintainingBalanceController = new Maintenance.Controller.MaintainingBalanceController(new Maintenance.Model.MaintainingBalancesModel(), new Maintenance.View.MaintainingBalances(), savingsMenu);
        }

        public void itemMaximumWithdrawal(object args, EventArgs e)
        {
            Maintenance.Controller.MaximumWithdrawalController maximumWithdrawalController = new Maintenance.Controller.MaximumWithdrawalController(new Maintenance.Model.MaximumWithdrawalModel(), new Maintenance.View.MaximumWithdrawal(), savingsMenu);
        }

        public void itemSavingsAccountTypes(object args, EventArgs e)
        {
            Maintenance.Controller.SavingsAccountTypeController savingsAccountTypeController = new Maintenance.Controller.SavingsAccountTypeController(new Maintenance.Model.SavingsAccountTypeModel(), new Maintenance.View.SavingsAccountType(), savingsMenu);
        }

        public void itemTimeDepositWithdrawal(object args, EventArgs e)
        {
            Maintenance.Controller.EarlyWithdrawalController timeDepositController = new Maintenance.Controller.EarlyWithdrawalController(new Maintenance.Model.EarlyWithdrawalModel(), new Maintenance.View.EarlyWithdrawal(), savingsMenu);
        }

        //trans
        public void itemOpenAccount(object args, EventArgs e)
        {
            Transaction.Controller.OpenAccountController openAccountController = new Transaction.Controller.OpenAccountController(new Transaction.Model.SavingsAccountModel(), new Transaction.View.OpenAccount(), this.savingsMenu);
        }

        public void itemSavingsAccountTrans(object args, EventArgs e)
        {
            Transaction.Controller.SavingsTransactionController savingsTransactionController = new Transaction.Controller.SavingsTransactionController(new Transaction.Model.SavingsTransactionModel(), new Transaction.View.SavingsTransaction(), this.savingsMenu);
        }

        public void itemTimeDepositApp(object args, EventArgs e)
        {
            Transaction.Controller.TimeDepositController timeDepositController = new Transaction.Controller.TimeDepositController(new Transaction.Model.TimeDepositModel(), new Transaction.View.TimeDepositApplication(), this.savingsMenu);
        }

        public void itemTimeDepositWith(object args, EventArgs e)
        {
            Transaction.Controller.TimeDepositWithdrawalController timeDepositWithdrawalModel = new Transaction.Controller.TimeDepositWithdrawalController(new Transaction.Model.TimeDepositWithdrawalModel(), new Transaction.View.TimeDepositWithdrawal(), this.savingsMenu);
        }

        public void itemMemberTermination(object args, EventArgs e)
        {
            Transaction.Controller.TerminationController terminationController = new Transaction.Controller.TerminationController(new Transaction.Model.TerminationModel(), new Transaction.View.MemberTermination(), this.savingsMenu);
        }
    }
}