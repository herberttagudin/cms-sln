﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Loan_Management
{
    class LoanManagementController
    {
        LoanManagementMenu loanManagementMenu= new LoanManagementMenu();

        public LoanManagementController(LoanManagementMenu loanManagementMenu)
        {
            this.loanManagementMenu = loanManagementMenu;
            this.loanManagementMenu.setItemLoanTypesEventHandler(this.itemLoanTypes);
            this.loanManagementMenu.setItemLoanInterestRateEventHandler(this.itemLoanInterestRate);
            this.loanManagementMenu.setItemLoanChargesEventHandler(this.itemLoanCharges);
            this.loanManagementMenu.setItemPenaltiesEventHandler(this.itemPenalties);
            this.loanManagementMenu.setItemShareCapitalEventHandler(this.itemShareCapital);
            this.loanManagementMenu.setItemMemberTypesEventHandler(this.itemMemberType);
            this.loanManagementMenu.setItemDeliquencyClassification(this.itemDeliquencyClassification);
            this.loanManagementMenu.setItemFeeSchedule(this.itemFeeSchedule);
            //trans
            this.loanManagementMenu.setItemMemberProfileEventHandler(this.itemMemberProfile);
            this.loanManagementMenu.setItemLoanApplicationEventHandler(this.itemLoanApp);
            this.loanManagementMenu.setItemCapitalContributionEventHandler(this.itemCapitalContribution);
            this.loanManagementMenu.ShowDialog();
        }

        public void itemMemberType(object args, EventArgs e)
        {
            Maintenance.Controller.MemberTypesController memberTypeController = new Maintenance.Controller.MemberTypesController(new Maintenance.Model.MemberTypesModel(), new Maintenance.View.MemberTypes(), this.loanManagementMenu);
        }

        public void itemDeliquencyClassification(object args, EventArgs e)
        {
            Maintenance.Controller.MemberClassificationController membershipClassification = new Maintenance.Controller.MemberClassificationController(new Maintenance.Model.MemberClassificationModel(), new Maintenance.View.MemberClassification(), this.loanManagementMenu);
        }

        public void itemFeeSchedule(object args, EventArgs e)
        {
            Maintenance.Controller.ScheduleOfFeesController feeSchedule = new Maintenance.Controller.ScheduleOfFeesController(new Maintenance.Model.ScheduleOfFeesModel(), new Maintenance.View.ScheduleOfFees(), this.loanManagementMenu);
        }

        public void itemLoanTypes(object args, EventArgs e)
        {
            Maintenance.Controller.LoanAccountTypeController loanController =  new Maintenance.Controller.LoanAccountTypeController(new Maintenance.Model.LoanTypeModel(), new Maintenance.View.LoanTypes(),loanManagementMenu);
        }

        public void itemLoanInterestRate(object args, EventArgs e)
        {
            Maintenance.Controller.LoanInterestRateController loanController = new Maintenance.Controller.LoanInterestRateController(new Maintenance.Model.LoanInterestRateModel(), new Maintenance.View.LoanInterestRate(), loanManagementMenu);
        }

        public void itemShareCapital(object args, EventArgs e)
        {
            Maintenance.Controller.ShareCapitalContributionController capitalContributionController = new Maintenance.Controller.ShareCapitalContributionController(new Maintenance.Model.ShareCapitalContributionModel(), new Maintenance.View.ShareCapitalContribution(), loanManagementMenu);
        }

        public void itemLoanCharges(object args, EventArgs e)
        {
            Maintenance.Controller.LoanChargesController loanChargesController = new Maintenance.Controller.LoanChargesController(new Maintenance.Model.LoanChargesModel(), new Maintenance.View.LoanCharges(), loanManagementMenu);
        }

        public void itemPenalties(object args, EventArgs e)
        {
            Maintenance.Controller.PenaltiesController penaltiesController = new Maintenance.Controller.PenaltiesController(new Maintenance.Model.PenaltiesModel(), new Maintenance.View.Penalties(), loanManagementMenu);
        }

        //trans
        public void itemMemberProfile(object args, EventArgs e)
        {
            Transaction.Controller.UpdateMemberController membershipController = new Transaction.Controller.UpdateMemberController(new Transaction.Model.UpdateMemberModel(), new Transaction.View.UpdateMember(), this.loanManagementMenu);
        }

        public void itemLoanApp(object args, EventArgs e)
        {
            Transaction.Controller.LoanApplicationController loanApplicationController = new Transaction.Controller.LoanApplicationController(new Transaction.Model.LoanApplicationModel(), new Transaction.View.LoanApplication(), loanManagementMenu); 
        }

        public void itemCapitalContribution(object args, EventArgs e)
        {
            Transaction.Controller.ShareCapitalContributionController shareCapitlContrib = new Transaction.Controller.ShareCapitalContributionController(new Transaction.Model.ShareCapitalContributionModel(), new Transaction.View.ShareCapitalContribution(), loanManagementMenu);
        }

        
    }
}
