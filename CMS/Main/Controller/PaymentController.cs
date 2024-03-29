﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CMS.Main.Controller
{
    class PaymentController
    {
        Model.PaymentModel paymentModel;
        View.PaymentForm payment;

        Dictionary<int, string> fees = new Dictionary<int, string>();

        double totalPenalty = 0;
        double totalInterest = 0;
        Boolean hasInterest = false;

        public PaymentController(Model.PaymentModel paymentModel, View.PaymentForm payment, Main.View.CMS cms)
        {
            this.paymentModel = paymentModel;
            this.payment = payment;
            cms.setPanel2(this.payment);
            this.payment.setBtnClearEventHandler(this.btnClear);
            this.payment.setBtnMoveAllEventHandler(this.btnMoveAll);
            this.payment.setBtnMoveBackAllEventHandler(this.btnMoveBackAll);
            this.payment.setBtnMoveBackSelectedEventHandler(this.btnMoveBackSelected);
            this.payment.setBtnMoveSelectedEventHandler(this.btnMoveSelected);
            this.payment.setBtnSaveEventHandler(this.btnSave);
            this.payment.dataAmortization_CellValueChanged(this.showPenalties);
            this.payment.txtAmountDue_TextChanged(this.showTotalAmortization);
            this.payment.txtPenalty_TextChanged(this.showTotalAmortization);
            this.payment.txtAccountNo_TextChanged(this.searchMember);
            this.payment.txtMemberName_TextChanged(this.searchMember);
            this.payment.classGridSearch(this.paymentModel.selectActiveMembershipUnpaid());
            if (this.paymentModel.checkEmpty != 0) this.payment.noRowsSelected();
            this.paymentModel.checkEmpty = 0;
            this.payment.clearLoanFields();
        }



        public void listOfFees()
        {

            fees.Clear();
            DataTable ds = this.paymentModel.selectFees().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                fees.Add(int.Parse(dr["Fee Id"].ToString()), dr["Description"].ToString());

            }
        }

        public void showTotalAmortization(object args, EventArgs e) 
        {
            double amountdue = this.payment.getAmountDue();
            double penalty = this.payment.getPenalty();
            double interest = this.payment.getInterest();

            this.payment.setTotalAmortization(amountdue + penalty + interest);
        }


        public void showPenalties(object args, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                totalPenalty = 0;
                totalInterest = 0;

                this.payment.clearTendered();
                this.payment.resetLoanAmortizationAmount();
                this.payment.clearPenaltyList();
                this.payment.setPenalty(0);
                this.payment.setInterest(0);

                Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
                Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();
                int lappId = Convert.ToInt32(this.payment.dataAmortization.Rows[0].Cells[4].Value);
                String maturityDate = this.paymentModel.selectMaturityDate(lappId);
                String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
                String[] interest = this.paymentModel.selectInterestPerLoanType(this.payment.getTypeOfLoan()).Split(' ');
                
                if (DateTime.Now > DateTime.Parse(maturityDate) && interest[0]!="")
                {
                String interestRateStatus = interest[0];
                double interestRate = Convert.ToDouble(interest[1]);
                String per = interest[2];

                if (interestRateStatus == "%") { interestRate *= 0.01; }


                    if (per == "month")
                    {
                        for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(1)).ToString())
                        {
                            listOfInterestDates.Add(a, 0);
                        }

                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                            String secondDate = DateTime.Parse(pair.Key).AddMonths(1).ToString();
                            int i = this.paymentModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

                            if (i > 0)
                            {
                                finalListOfInterestDates.Add(pair.Key, 0);
                            }
                        }

                        String last = String.Empty;
                        try
                        {
                            last = finalListOfInterestDates.Keys.Last();
                        }
                        catch (Exception) { last = maturityDate; }
                                foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                                {
                                    if (DateTime.Parse(pair.Key) > DateTime.Parse(last))
                                    {
                                        hasInterest = true;
                                        double finalInterest = 0;
                                        double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(lappId);
                                        if (interestRateStatus == "%") { finalInterest = grantedLoanAmount * interestRate; }
                                        else if (interestRateStatus == "Php") { finalInterest = interestRate; }
                                        totalInterest += finalInterest;
                                        this.payment.setPenaltyList("Interest Rate: " + pair.Key + "- Php " + finalInterest);
                                    }
                                }
                            
                    }

                    else if (per == "annum")
                    {
                        for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddYears(1)).ToString())
                        {
                            listOfInterestDates.Add(a, 0);
                        }

                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                            String secondDate = DateTime.Parse(pair.Key).AddYears(1).ToString();
                            int i = this.paymentModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

                            if (i > 0)
                            {
                                finalListOfInterestDates.Add(pair.Key, 0);
                            }
                        }

                        String last = String.Empty;
                        try
                        {
                            last = finalListOfInterestDates.Keys.Last();
                        }
                        catch (Exception) { last = maturityDate; }
                        foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                        {
                            if (DateTime.Parse(pair.Key) > DateTime.Parse(last))
                            {
                                hasInterest = true;
                                double finalInterest = 0;
                                double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(lappId);
                                if (interestRateStatus == "%") { finalInterest = grantedLoanAmount * interestRate; }
                                else if (interestRateStatus == "Php") { finalInterest = interestRate; }
                                totalInterest += finalInterest;
                                this.payment.setPenaltyList("Interest Rate: " + pair.Key + "- Php " + finalInterest);
                            }
                        }
                    }
                }

                if (this.payment.getIfPenaltyListIsEmpty("Interest Rate")) 
                {
                    this.payment.setPenaltyList("No interest.");
                }

                this.payment.setInterest(totalInterest);

                foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
                {
                    DataGridViewCheckBoxCell chk1 = rows.Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(chk1.Value) == true)
                    {

                        int loanApplicationId = int.Parse(rows.Cells[4].Value.ToString());
                        DataSet ds2 = this.paymentModel.selectMonthlyAmortization(loanApplicationId);
                        double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                        String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                        if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                        else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }
                        double grantedLoanAmount = this.paymentModel.selectGrantedLoanAmount(loanApplicationId);
                        double remainingBalance = this.paymentModel.selectRemainingBalance(loanApplicationId);

                        String dueDate = rows.Cells[3].Value.ToString();
                        double amortizationAmount = double.Parse(rows.Cells[2].Value.ToString());
                        int loanTypeId = this.payment.getTypeOfLoan();
                        DataSet ds = this.paymentModel.selectPenaltiesPerLoanType(loanTypeId);
                        if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Now)
                        {
                            this.payment.setPenalty(0);
                            this.payment.setLoanAmortizationAmount(amortizationAmount);
                            this.payment.setPenaltyList("No penalties - Amortization #" + rows.Cells[1].Value.ToString());
                        }

                        else
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                double initialPenalty = 0;
                                String finalDate = String.Empty;
                                String penaltyName = ds.Tables[0].Rows[i][0].ToString();
                                int gracePeriod = int.Parse(ds.Tables[0].Rows[i][1].ToString());
                                double amount = double.Parse(ds.Tables[0].Rows[i][2].ToString());
                                String amountStatus = ds.Tables[0].Rows[i][3].ToString();
                                String deductTo = ds.Tables[0].Rows[i][4].ToString();
                                int duration = int.Parse(ds.Tables[0].Rows[i][5].ToString());
                                String durationStatus = ds.Tables[0].Rows[i][6].ToString();

                                if (durationStatus == "week/s") { duration = duration * 7; }
                                //TimeSpan diffDate = DateTime.Now.Subtract(DateTime.Parse(dueDate));
                                //int totalDays = (int)diffDate.TotalDays;
                                //totalDays -= gracePeriod;
                                String newDate = (DateTime.Parse(dueDate).AddDays(gracePeriod)).ToString();

                                if (amountStatus == "%") { amount = amount * 0.01; }

                                finalDate = DateTime.Parse(newDate).AddDays(1).ToString();

                                if (deductTo == "monthly amortization")
                                {
                                    if (durationStatus == "month/s")
                                    {
                                        for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                        {
                                            initialPenalty = amount * monthlyAmortization;
                                            totalPenalty += initialPenalty;
                                            this.payment.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                        {
                                            initialPenalty = amount * monthlyAmortization;
                                            totalPenalty += initialPenalty;
                                            this.payment.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                        }
                                    }
                                }
                                else if (deductTo == "remaining balance")
                                {
                                    if (durationStatus == "month/s")
                                    {
                                        for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                        {
                                            initialPenalty = amount * remainingBalance;
                                            totalPenalty += initialPenalty;
                                            this.payment.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                        {
                                            initialPenalty = amount * remainingBalance;
                                            totalPenalty += initialPenalty;
                                            this.payment.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                        }
                                    }
                                }
                                else if (deductTo == "granted loan amount")
                                {
                                    if (durationStatus == "month/s")
                                    {
                                        for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                        {
                                            initialPenalty = amount * grantedLoanAmount;
                                            totalPenalty += initialPenalty;
                                            this.payment.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                        {
                                            initialPenalty = amount * grantedLoanAmount;
                                            totalPenalty += initialPenalty;
                                            this.payment.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                        }
                                    }
                                }

                                else if (deductTo == String.Empty)
                                {
                                    if (durationStatus == "month/s")
                                    {
                                        for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                        {
                                            initialPenalty = amount;
                                            totalPenalty += initialPenalty;
                                            this.payment.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                        {
                                            initialPenalty = amount;
                                            totalPenalty += initialPenalty;
                                            this.payment.setPenaltyList(penaltyName + ": " + a + "- Php" + initialPenalty + " - Amortization #" + rows.Cells[1].Value.ToString());
                                        }
                                    }
                                }
                            }//end for loop

                            if (this.payment.getIfPenaltyListIsEmpty("Amortization #" + rows.Cells[1].Value.ToString()))
                            {
                                this.payment.setPenaltyList("No penalties - Amortization #" + rows.Cells[1].Value.ToString());
                            }

                            this.payment.setPenalty(totalPenalty);
                            this.payment.setLoanAmortizationAmount(amortizationAmount);

                        }//end else

                    }
                }
            }
        }


        public void btnClear(object args, EventArgs e) {
            this.payment.clearLoanFields();
        }

        public void btnMoveAll(object args, EventArgs e) {
            this.payment.moveAllRows();
        }

        public void btnMoveBackAll(object args, EventArgs e) {
            this.payment.moveBackAllRows();
        }
        public void btnMoveBackSelected(object args, EventArgs e) {
            this.payment.moveBackSelectedRow();
        }
        public void btnMoveSelected(object args, EventArgs e) {
            this.payment.moveSelectedRow();
        }
        public void btnSave(object args, EventArgs e) {
            String paymentType = this.payment.getPaymentType();

            if (paymentType == "Membership")
            {
                this.listOfFees();
                DataGridViewRow selectedData = this.payment.getSelected();
                String accountNo = selectedData.Cells["Account No."].Value.ToString();
                double amount = this.payment.getTotalAmount();

                int isFullyPaid = this.payment.getTotalNoOfFees();

                if (isFullyPaid == 0) { isFullyPaid = 1; }
                else { isFullyPaid = 0; }

                ArrayList feeList = this.payment.getFees();

                ArrayList feeId = new ArrayList();
                foreach (String s in feeList)
                {
                    foreach (KeyValuePair<int, string> pair in fees)
                    {
                        if (s.Equals(pair.Value))
                            feeId.Add(pair.Key);
                    }
                }


                if (this.paymentModel.insertPayment(paymentType, amount, accountNo, isFullyPaid, feeId) == 1)
                {
                    MessageBox.Show("Transaction successful.", "Membership Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.payment.classGridSearch(this.paymentModel.selectActiveMembershipUnpaid());
                    this.payment.totAmt = 0.00;
                    this.payment.clearLoanFields();
                }
                else
                {
                    MessageBox.Show("Transaction failed.", "Membership Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else 
            {
                DataGridViewRow selectedDataLoan = this.payment.getSelectedLoan();
                String accountNo = selectedDataLoan.Cells["Account No."].Value.ToString();
                double amount = this.payment.getTotalAmortization();

                foreach (DataGridViewRow rows in this.payment.dataAmortization.Rows)
                {
                    if ((Boolean)(rows.Cells[0] as DataGridViewCheckBoxCell).Value == true)
                    {
                        this.paymentModel.insertLoanPayment(paymentType, accountNo, Convert.ToInt32(rows.Cells[4].Value), amount, rows.Cells[3].Value.ToString(), hasInterest);
                    }
                }

                MessageBox.Show("Transaction successful.", "Amortization Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.payment.classGridLoanSearch(this.paymentModel.selectActiveMemberWithLoan());
                this.payment.clearLoanFields();
                totalPenalty = 0;
                totalInterest = 0;
            }
        }

        public void searchMember(object args, EventArgs e) {
            
            bool getSearchType = this.payment.getSearchType();
            String paymentType = this.payment.getPaymentType();

            if (paymentType == "Membership")
            {

                if (getSearchType)
                {
                    this.payment.classGridSearch(this.paymentModel.searchMemberByName(this.payment.getSearch()));
                    this.payment.clearSelectionDataSearch();
                }

                else
                {
                    this.payment.classGridSearch(this.paymentModel.searchMemberByAccount(this.payment.getSearch()));
                    this.payment.clearSelectionDataSearch();
                }
            }
            else 
            {
                if (getSearchType)
                {
                    this.payment.classGridLoanSearch(this.paymentModel.searchMemberByLName(this.payment.getSearch()));
                    this.payment.clearSelectionDataLoanSearch();
                }

                else
                {
                    this.payment.classGridLoanSearch(this.paymentModel.searchMemberByLAccount(this.payment.getSearch()));
                    this.payment.clearSelectionDataLoanSearch();
                }
            }

        }

    }
}
