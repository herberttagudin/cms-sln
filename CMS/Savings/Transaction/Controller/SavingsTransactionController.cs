﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.Controller
{
    class SavingsTransactionController
    {
        Model.SavingsTransactionModel savingsTransactionModel;
        View.SavingsTransaction savingsTransaction;
        int TypeId = 0;

        public SavingsTransactionController(Model.SavingsTransactionModel savingsTransactionModel, View.SavingsTransaction savingsTransaction, SavingsMenu savingsMenu)
        {
            this.savingsTransactionModel = savingsTransactionModel;
            this.savingsTransaction = savingsTransaction;
            this.savingsTransaction.setDataMember(this.savingsTransactionModel.selectMember());
            this.savingsTransaction.txtAccountNo_TextChanged(this.txtSearch);
            this.savingsTransaction.dataMember_CellContentClick(this.dataMemberCellClick);
            this.savingsTransaction.setBtnClearEventHandler(this.btnClear);
            this.savingsTransaction.setBtnSaveEventHandler(this.btnSave);
            this.savingsTransaction.disableDetails();
            this.savingsTransaction.MdiParent = savingsMenu;
            this.savingsTransaction.Show();
        }

        public void txtSearch(object sender, EventArgs e)
        {
            this.savingsTransaction.clearDetails();
            this.savingsTransaction.disableDetails();
            this.savingsTransaction.setDataMember(this.savingsTransactionModel.searchMember(this.savingsTransaction.getAccountNo()));
        }

        public void dataMemberCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.savingsTransaction.getSelectedMember();
            if (row == null)
            {
                MessageBox.Show("No row selected.");
            }
            else
            {
                this.savingsTransaction.enableDetails();
                this.savingsTransaction.setSavingsAccountNo(row.Cells[0].Value.ToString());
                this.savingsTransaction.setAccountBalance(row.Cells[3].Value.ToString());
                this.TypeId = int.Parse(row.Cells[2].Value.ToString());
                this.savingsTransaction.setDataAccountHolder(this.savingsTransactionModel.selectAccountHolder(row.Cells[0].Value.ToString()));
            }
        }
        public void btnClear(object sender, EventArgs e)
        {
            this.savingsTransaction.clearAll();
            this.savingsTransaction.setAccountBalance("0");
            this.savingsTransaction.setDataMember(this.savingsTransactionModel.selectMember());
        }

        public void btnSave(object sender, EventArgs e)
        {
            this.savingsTransaction.clearErrors();
            String errorMessage = String.Empty;
            Boolean checkTransactionMode = false;
            Boolean checkAccountNo = false;
            Boolean checkAmount = false;
            Boolean checkRepresentative = false;
            if (this.savingsTransaction.getComboTransaction() != String.Empty)
            {
                this.savingsTransactionModel.TransactionMode = this.savingsTransaction.getComboTransaction();
                checkTransactionMode = true;
            }
            else
            {
                errorMessage += "Select Transaction Mode." + Environment.NewLine;
                this.savingsTransaction.setErrorMode();
                checkTransactionMode = false;
            }
            if (this.savingsTransaction.getSavingsAccountNo() == String.Empty)
            {
                errorMessage += "No Selected Account." + Environment.NewLine;
                checkAccountNo = false;
            }
            else
            {
                this.savingsTransactionModel.AccountNo = this.savingsTransaction.getSavingsAccountNo();
                checkAccountNo = true;
            }
            try
            {
                if (this.savingsTransaction.getAmount() <= 0)
                {
                    errorMessage += "Please Specify Amount." + Environment.NewLine;
                    this.savingsTransaction.setErrorAmount();
                    checkAmount = false;
                }
                else
                {
                    if (this.savingsTransaction.getComboTransaction() == "Withdraw")
                    {
                        if (this.savingsTransaction.getAmount() > this.savingsTransactionModel.selectMaximumWithdrawal(this.TypeId))
                        {
                            DialogResult result = MessageBox.Show("You are Attempting to Withdraw Beyond Maximum Allowable Amount. Do You Wish to Continue?", "Savins Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                                checkAmount = true;
                            }
                            else
                            {
                                checkAmount = false;
                            }
                        }
                        else
                        {
                            if (this.savingsTransaction.getAmount() > this.savingsTransaction.getAccountBalance())
                            {
                                errorMessage += "Insufficient Funds." + Environment.NewLine;
                                this.savingsTransaction.setErrorAmount();
                                checkAmount = false;
                            }
                            else if ((this.savingsTransaction.getAccountBalance() - this.savingsTransaction.getAmount()) < this.savingsTransactionModel.selectMaintainingBalance(this.TypeId))
                            {
                                MessageBox.Show("Account Balance is Now Below Maintaning Balance.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                                checkAmount = true;
                            }
                            else if ((this.savingsTransaction.getAccountBalance() - this.savingsTransaction.getAmount()) == 0)
                            {
                                MessageBox.Show("Account Balance is Now Empty.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                                checkAmount = true;
                            }
                            else
                            {
                                this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                                checkAmount = true;
                            }
                        }
                    }
                    else
                    {
                        this.savingsTransactionModel.Amount = this.savingsTransaction.getAmount();
                        checkAmount = true;
                    }
                }
            }
            catch (FormatException)
            {
                errorMessage += "Invalid Amount." + Environment.NewLine;
                this.savingsTransaction.setErrorAmount();
                checkAmount = false;
            }
            if (this.savingsTransaction.getCheckRepresentative())
            {
                if (this.savingsTransaction.getTextRepresentative() == String.Empty)
                {
                    errorMessage += "Please Specify Representative." + Environment.NewLine;
                    this.savingsTransaction.setErrorRepresentative();
                    checkRepresentative = false;
                }
                else
                {
                    this.savingsTransactionModel.Representative = this.savingsTransaction.getTextRepresentative();
                    checkRepresentative = true;
                }
            }
            else
            {
                this.savingsTransactionModel.Representative = String.Empty;
                checkRepresentative = true;
            }
            if (checkTransactionMode && checkAccountNo && checkAmount && checkRepresentative)
            {
                this.savingsTransactionModel.PassbookNo = this.savingsTransactionModel.selectActivePassbook(this.savingsTransaction.getSavingsAccountNo());
                if (this.savingsTransactionModel.insertSavingsTransaction() == 1)
                {
                    MessageBox.Show("Transaction Success.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.savingsTransaction.clearAll();
                    this.savingsTransaction.setAccountBalance("0");
                    this.savingsTransaction.setDataMember(this.savingsTransactionModel.selectMember());
                }
                else
                {
                    MessageBox.Show("Transaction Failed.", "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Transaction Failed." + Environment.NewLine + Environment.NewLine + errorMessage, "Savings Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
