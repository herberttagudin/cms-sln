﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.Controller
{
    class OpenAccountController
    {
        Model.SavingsAccountModel savingsAccountModel;
        View.OpenAccount openAccount;
        double initialDeposit = 0;

        public OpenAccountController(Model.SavingsAccountModel savingsAccountModel, View.OpenAccount openAccount, SavingsMenu savingsMenu)
        {
            this.savingsAccountModel = savingsAccountModel;
            this.openAccount = openAccount;
            this.openAccount.initAccountType(this.savingsAccountModel.selectAccountType());
            this.openAccount.setAccountTypeSelectedItemChanged(this.accountTypeItemChanged);
            this.openAccount.setPassbookNo(this.savingsAccountModel.generateSavingsPassbook().ToString());
            this.openAccount.setAccountNo("SV-" + this.savingsAccountModel.generateAccountNo().ToString("D5"));
            this.openAccount.txtSearchTextChanged(this.txtSearch);
            this.openAccount.btnForwardEventHandler(this.btnForward);
            this.openAccount.btnBackwardEventHandler(this.btnBackward);
            this.openAccount.btnClearEventHandler(this.btnClear);
            this.openAccount.btnSaveEventHandler(this.btnSave);
            this.openAccount.MdiParent = savingsMenu;
            this.openAccount.Show();
        }

        public void accountTypeItemChanged(object sender, EventArgs e)
        {
            if (this.openAccount.getComboAccountType() == 0)
            {
                this.openAccount.setAccountHolder("0");
                this.openAccount.disableInitialDeposit();
            }
            else
            {
                this.openAccount.setDataDepositor(null);
                DataSet ds = this.savingsAccountModel.selectAccountTypeDetails(this.openAccount.getComboAccountType());
                DataTable dt = ds.Tables[0];
                DataRow dr = dt.Rows[0];
                this.openAccount.setDataMember(this.savingsAccountModel.selectMember(this.openAccount.getComboAccountType()));
                this.openAccount.enableInitialDeposit();
                this.initialDeposit = double.Parse(dr["InitialDeposit"].ToString());
                this.openAccount.setAccountHolder(dr["NoOfAccountHolders"].ToString());
                if (int.Parse(dr["NoOfAccountHolders"].ToString()) > 1)
                {
                    this.openAccount.enableWithdrawMode();
                }
                else
                {
                    this.openAccount.disableWithdrawMode();
                }
            }
        }

        public void txtSearch(object sender, EventArgs e)
        {
            if (this.openAccount.getComboAccountType() == 0)
            {
                this.openAccount.setDataMember(null);
                this.openAccount.setDataDepositor(null);
            }
            else
            {
                if (this.openAccount.getDepositorRowCount() > 0)
                {
                    this.openAccount.filterMember();
                }
                else
                {
                    this.openAccount.setDataMember(this.savingsAccountModel.searchMember(this.openAccount.getComboAccountType(), this.openAccount.getSearch()));
                }
            }
        }

        public void btnForward(object sender, EventArgs e)
        {
            if (this.openAccount.getSelectedMember() == null)
            {
                MessageBox.Show("No Row Selected.", "Open Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.openAccount.getDepositorRowCount() < this.openAccount.getAccountHolder())
                {
                    this.openAccount.addDataDepositor(this.openAccount.getSelectedMember());
                }
                else
                {
                    MessageBox.Show("No of Account Holder Cannot be Greater than " + this.openAccount.getAccountHolder() + ".", "Open Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnBackward(object sender, EventArgs e)
        {
            if (this.openAccount.getSelectedDepositor() == null)
            {
                MessageBox.Show("No Row Selected.", "Open Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.openAccount.addDataMember(this.openAccount.getSelectedDepositor());
            }
        }

        public void btnClear(object sender, EventArgs e)
        {
            this.openAccount.disableInitialDeposit();
            this.openAccount.clearErrors();
            this.savingsAccountModel.memberSavingsAccount.Clear();
            this.openAccount.reset("SV-" + this.savingsAccountModel.generateAccountNo().ToString("D5"), this.savingsAccountModel.generateSavingsPassbook().ToString());
        }

        public void btnSave(object sender, EventArgs e)
        {
            this.openAccount.clearErrors();
            this.savingsAccountModel.memberSavingsAccount.Clear();
            String errorMessage = String.Empty;
            Boolean checkAccountType = false;
            Boolean checkInitialDeposit = false;
            Boolean checkWithdrawMode = false;
            Boolean checkDepositor = false;
            if (this.openAccount.getComboAccountType() == 0)
            {
                this.openAccount.setErrorAccountType();
                errorMessage += "Please Specify Account Type." + Environment.NewLine;
                checkAccountType = false;
            }
            else
            {
                this.savingsAccountModel.AccountTypeId = this.openAccount.getComboAccountType();
                checkAccountType = true;
            }
            try
            {
                if (this.openAccount.getInitialDeposit() < this.initialDeposit)
                {
                    errorMessage += "Initial Deposit for this Savings Account Must be Equal or Greater than " + this.initialDeposit + Environment.NewLine;
                    this.openAccount.setErrorInitialDeposit();
                    checkInitialDeposit = false;
                }
                else
                {
                    this.savingsAccountModel.InitialDeposit = this.openAccount.getInitialDeposit();
                    checkInitialDeposit = true;
                }
            }
            catch (FormatException)
            {
                errorMessage += "Invalid Amount - Initial Deposit." + Environment.NewLine;
                this.openAccount.setErrorInitialDeposit();
                checkInitialDeposit = false;
            }
            this.savingsAccountModel.PassbookNo = this.openAccount.getPassbookNo();
            this.savingsAccountModel.SavingsAccountNo = this.openAccount.getAccountNo();
            if (this.openAccount.getAccountHolder() > 1)
            {
                if (this.openAccount.getWithdrawMode() == String.Empty)
                {
                    this.openAccount.setErrorWithdrawMode();
                    errorMessage += "Please Specify Withdrawal Mode." + Environment.NewLine;
                    checkWithdrawMode = false;
                }
                else
                {
                    this.savingsAccountModel.WithdrawalMode = this.openAccount.getWithdrawMode();
                    checkWithdrawMode = true;
                }
            }
            else
            {
                this.savingsAccountModel.WithdrawalMode = this.openAccount.getWithdrawMode();
                checkWithdrawMode = true;
            }
            DataGridViewRowCollection rowCollection = this.openAccount.getDepositors();
            if (rowCollection.Count < 1)
            {
                this.openAccount.setErrorDepositor();
                errorMessage += "Please Add Depositors." + Environment.NewLine;
                checkDepositor = false;
            }
            else
            {
                foreach (DataGridViewRow row in rowCollection)
                {
                    Model.MemberSavingsAccountModel ms = new Model.MemberSavingsAccountModel();
                    ms.MemberAccountNo = row.Cells[0].Value.ToString();
                    ms.SavingsAccountNo = this.openAccount.getAccountNo();
                    this.savingsAccountModel.memberSavingsAccount.Add(ms);
                }
                checkDepositor = true;
            }
            if (checkAccountType && checkWithdrawMode && checkDepositor && checkInitialDeposit)
            {
                if (this.savingsAccountModel.insertSavingsAccount() == 1)
                {
                    MessageBox.Show("Save Success.", "Open Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.openAccount.clearErrors();
                    this.openAccount.reset("SV-" + this.savingsAccountModel.generateAccountNo().ToString("D5"), this.savingsAccountModel.generateSavingsPassbook().ToString());
                    this.savingsAccountModel.memberSavingsAccount.Clear();
                }
                else
                {
                    MessageBox.Show("Save Failed.", "Open Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Save Failed." + Environment.NewLine + Environment.NewLine + errorMessage, "Open Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
