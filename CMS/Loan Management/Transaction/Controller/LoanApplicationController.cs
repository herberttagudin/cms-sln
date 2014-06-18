using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace CMS.Loan_Management.Transaction.Controller
{
    class LoanApplicationController
    {
        Transaction.Model.LoanApplicationModel loanApplicationModel;
        Transaction.View.LoanApplication loanApplication;

        Boolean isbtnDetailsPrevious = false;
        Boolean isAddEditCollateral = false;
        Boolean isAddEditComaker = false;
        Boolean isAddCollateral = false;
        Boolean isAddComaker = false;
        Boolean isFixed = false;
        Boolean hasSpouse = false;
        int collateralIndex = 0;
        int comakerIndex = 0;
        int isCollateral = 0;
        int noOfComakers = 0;

        String finalAccountNo = String.Empty;
        int finalMemberType = 0;

        String accountNo = String.Empty;
        String memberName = String.Empty;

        Dictionary<int, string> requirements = new Dictionary<int, string>();

        public LoanApplicationController(Transaction.Model.LoanApplicationModel loanApplicationModel, Transaction.View.LoanApplication loanApplication, Loan_Management.LoanManagementMenu loanMenu)
        {
            this.loanApplicationModel = loanApplicationModel;
            this.loanApplication = loanApplication;
            this.loanApplication.setBtnAddCollateralEventHandler(this.btnAddCollateral);
            this.loanApplication.setBtnAddComakerEventHandler(this.btnAddComaker);
            this.loanApplication.setBtnApplyLoanEventHandler(this.btnApplyLoan);
            this.loanApplication.setBtnCancelLoanEventHandler(this.btnCancelLoan);
            this.loanApplication.setBtnCollateralNextEventHandler(this.btnCollateralNext);
            this.loanApplication.setBtnCollateralPreviousEventHandler(this.btnCollateralPrevious);
            this.loanApplication.setBtnComakerPreviousEventHandler(this.btnComakerPrevious);
            this.loanApplication.setBtnDetailsNextEventHandler(this.btnDetailsNext);
            this.loanApplication.setBtnDetailsPreviousEventHandler(this.btnDetailsPrevious);
            this.loanApplication.setBtnEditCollateralEventHandler(this.btnEditCollateral);
            this.loanApplication.setBtnIncomeNextEventHandler(this.btnIncomeNext);
            this.loanApplication.setBtnIncomePreviousEventHandler(this.btnIncomePrevious);
            this.loanApplication.setBtnProceedEventHandler(this.btnProceed);
            this.loanApplication.setBtnDeleteComakerEventHandler(this.btnDeleteComaker);
            this.loanApplication.setBtnSaveCollateralEventHandler(this.btnSaveCollateral);
            this.loanApplication.setBtnDeleteCollateralEventHandler(this.btnDeleteCollateral);
            this.loanApplication.setBtnCancelCollateralEventHandler(this.btnCancelCollateral);
            this.loanApplication.setBtnEditComakerEventHandler(this.btnEditComaker);
            this.loanApplication.setBtnSaveComakerEventHandler(this.btnSaveComaker);
            this.loanApplication.setBtnCancelComakerEventHandler(this.btnCancelComaker);
            this.loanApplication.disableCollateralFunction();
            this.loanApplication.txtPurpose_TextChanged(this.changeLabelCount);
            this.loanApplication.txtCMMemberName_TextChanged(this.searchCMMemberName);
            this.loanApplication.txtCMAccountNo_TextChanged(this.searchCMAccountNo);
            this.loanApplication.txtMemberName_TextChanged(this.searchMemberName);
            this.loanApplication.txtAccountNo_TextChanged(this.searchAccountNo);
            this.loanApplication.txtExpenses_TextChanged(this.addExpenses);
            this.loanApplication.txtMonthlyExpense_TextChanged(this.addMonthlyExpense);
            this.loanApplication.txtIncome_TextChanged(this.addIncomes);
            this.loanApplication.txtGrossIncome_TextChanged(this.addGrossIncome);
            this.loanApplication.cbLoanType_SelectedIndexChanged(this.addRequirementsAndLAD);
            this.loanApplication.cbSourceOfFund_SelectedIndexChanged(this.addCurrentBalance);
            this.loanApplication.dataActiveMember_CellClick(this.showShareCapitalAndSavings);
            this.loanApplication.activeMemberGrid(this.loanApplicationModel.selectActiveMemberWithLoan());
            this.loanApplication.disableFunction();
            this.loanApplication.enableDataActiveMember();
            this.loanApplication.MdiParent = loanMenu;
            this.loanApplication.Show();
            this.loanApplication.clearSelectionActiveMember();
        }

        public void showShareCapitalAndSavings(object args, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0)
            {
                Boolean hasSavings = this.loanApplicationModel.selectSavingsStatus(this.loanApplication.getMemberType());
                this.loanApplication.setRowSelectionActiveMemberErrorFalse();
                this.loanApplication.setCurrentShareCapital(this.loanApplicationModel.selectCurrentShareCapital(this.loanApplication.getAccountNo()));
                if (hasSavings) { this.loanApplication.setCurrentTotalSavings(this.loanApplicationModel.selectTotalSavings(this.loanApplication.getAccountNo())); }
                else { this.loanApplication.disableSavings(); }
            }
        }

        public void addCurrentBalance(object args, EventArgs e)
        {
            int i = this.loanApplication.getCBLADIndex();
            if (i != -1)
            {
                this.loanApplication.clearCurrentBalance();
                double currentBalance = this.loanApplicationModel.selectTimeDepositBalance(this.loanApplication.getSourceOfFund());
                this.loanApplication.setCurrentBalance(currentBalance);
                this.loanApplication.setLblMaxAmount(currentBalance+"");
            }
            else
            {
                this.loanApplication.setStateMaxAmountFalse();
                this.loanApplication.clearCurrentBalance(); 
            }
        }

        public void addRequirementsAndLAD(object args, EventArgs e)
        {
            this.loanApplication.setAllTpDetailsLabelsToBlack();
            int i = this.loanApplication.getCBLoanTypeIndex();
            if (i == -1) { this.loanApplication.getifcbLoanTypeIndexNegOne(); this.loanApplication.setStatePaymentDurationFalse(); }
            else
            {
                this.loanApplication.disableLAD();
                this.loanApplication.removeAllRequirements();
                int selectedLoanTypeId = this.loanApplication.getTypeOfLoan();

                isCollateral = this.loanApplicationModel.checkIfLoanIsCollateralized(selectedLoanTypeId);
                noOfComakers = this.loanApplicationModel.checkIfLoanHasComakers(selectedLoanTypeId);
                if (isCollateral == 0 && noOfComakers == 0)
                {
                    this.loanApplication.noCollateralAndComakerFunc();
                }
                else
                {
                    this.loanApplication.setBtnDetailsNext();
                }

                requirements.Clear();
                DataTable ds = this.loanApplicationModel.selectRequirements(selectedLoanTypeId).Tables[0];
                foreach (DataRow dr in ds.Rows)
                {

                    requirements.Add(int.Parse(dr["RequirementNo"].ToString()), (dr["Description"].ToString() + " (" + dr["Necessity"].ToString() + ")"));

                }
                this.loanApplication.addItemsAtRequirements(requirements);

                String paymentDuration = this.loanApplicationModel.selectPaymentDuration(selectedLoanTypeId);
                this.loanApplication.setLblPaymentDuration(paymentDuration);

                isFixed = this.loanApplicationModel.checkIfLoanIsFixed(selectedLoanTypeId);
                if (isFixed)
                {
                    this.loanApplication.enableLoanAgainstDeposit(isFixed);
                    this.loanApplication.addItemsAtSourceOfFund(this.loanApplicationModel.selectTimeDepositAccounts(finalAccountNo));
                    this.loanApplication.setCBLADIndex();
                }
                else 
                {
                    this.loanApplication.enableLoanAgainstDeposit(isFixed);
                    String maxLoanableAmount = this.loanApplicationModel.selectMaximumLoanableAmount(selectedLoanTypeId);
                    String[] amount = maxLoanableAmount.Split(' ');
                    double initAmt = double.Parse(amount[0]);
                    if(maxLoanableAmount.Contains("% Share Capital"))
                    {
                        double shareCapital = this.loanApplication.getCurrentShareCapital();
                        double loanAmount = (initAmt / 100) * shareCapital;
                        this.loanApplication.setLblMaxAmount(loanAmount+"");
                    }

                    else if (maxLoanableAmount.Contains("% Savings Balance"))
                    {
                        double savingsBalance = this.loanApplication.getCurrentTotalSavings();
                        double loanAmount = (initAmt / 100) * savingsBalance;
                        this.loanApplication.setLblMaxAmount(loanAmount + "");
                    }

                    else if (maxLoanableAmount.Contains("Php"))
                    {
                        this.loanApplication.setLblMaxAmount(initAmt+"");
                    }
                }
            }
        }

        public void addGrossIncome(object args, EventArgs e) 
        {
            double netMonthlyIncome = 0;

            netMonthlyIncome = this.loanApplication.getGrossIncome() - this.loanApplication.getLessMonthlyExpense();

            this.loanApplication.setNetMonthlyIncome(netMonthlyIncome);
        }

        public void addIncomes(object args, EventArgs e) 
        {
            double grossIncome = 0;
            grossIncome += this.loanApplication.getMonthlyIncome();
            grossIncome += this.loanApplication.getSpouseIncome();
            grossIncome += this.loanApplication.getOtherSources();

            this.loanApplication.setGrossIncome(grossIncome);
        }

        public void addMonthlyExpense(object args, EventArgs e) 
        {
            double netMonthlyIncome = 0;
            this.loanApplication.setLessMonthlyExpense(this.loanApplication.getMonthlyExpense());

            netMonthlyIncome = this.loanApplication.getGrossIncome() - this.loanApplication.getLessMonthlyExpense();
            this.loanApplication.setNetMonthlyIncome(netMonthlyIncome);
        }

        public void addExpenses(object args, EventArgs e) 
        {
            double monthlyExpenses = 0;
            monthlyExpenses += this.loanApplication.getFood();
            monthlyExpenses += this.loanApplication.getElectricity();
            monthlyExpenses += this.loanApplication.getWater();
            monthlyExpenses += this.loanApplication.getTuition();
            monthlyExpenses += this.loanApplication.getRent();
            monthlyExpenses += this.loanApplication.getTransportation();
            monthlyExpenses += this.loanApplication.getLoanRepayment();
            monthlyExpenses += this.loanApplication.getTelephone();
            monthlyExpenses += this.loanApplication.getMiscellaneous();

            this.loanApplication.setMonthlyExpense(monthlyExpenses);
        }

        public void searchMemberName(object args, EventArgs e) 
        {
            this.loanApplication.activeMemberGrid(this.loanApplicationModel.searchMemberByMemberName(this.loanApplication.getActiveMemberName()));
            this.loanApplication.clearSelectionActiveMember();
            this.loanApplication.clearSavingsAndShareCapital();
        }

        public void searchAccountNo(object args, EventArgs e) 
        {
            this.loanApplication.activeMemberGrid(this.loanApplicationModel.searchMemberByAccountNo(this.loanApplication.getActiveAccountNo()));
            this.loanApplication.clearSelectionActiveMember();
            this.loanApplication.clearSavingsAndShareCapital();
        }

        public void searchCMMemberName(object args, EventArgs e) 
        {
            this.loanApplication.viewComakerGrid(this.loanApplicationModel.searchComakerByMemberName(this.loanApplication.getCMMemberName()));
            this.loanApplication.clearSelectionViewComaker();
            this.loanApplication.clearComaker();
        }

        public void searchCMAccountNo(object args, EventArgs e) 
        { 
             this.loanApplication.viewComakerGrid(this.loanApplicationModel.searchComakerByAccountNo(this.loanApplication.getCMAccountNo()));
             this.loanApplication.clearSelectionViewComaker();
             this.loanApplication.clearComaker();
        }

        public void changeLabelCount(object args, EventArgs e)
        {
            int length = 160;
            length-=this.loanApplication.getPurposeLength();
            this.loanApplication.setLabelLimit(length);
        }

        public void btnProceed(object args, EventArgs e)
        {
      
            int row = this.loanApplication.getActiveMemberIndex();
            int noOfPendingLoans = this.loanApplicationModel.selectPendingLoans(this.loanApplication.getAccountNo());

            if (noOfPendingLoans > 0) 
            {
                MessageBox.Show("There is still a pending loan for Account No. :"+this.loanApplication.getAccountNo()+".","Loan Application",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(row>=0 && noOfPendingLoans ==0)
            {
            this.loanApplication.btnProceedFunc();
            this.loanApplication.disableDataActiveMember();
            finalAccountNo = this.loanApplication.getAccountNo();
            finalMemberType = this.loanApplication.getMemberType();
            String spouse = this.loanApplicationModel.checkSpouseName(finalAccountNo);
            if (spouse == String.Empty) { this.loanApplication.disableSpouseIncome(); }
            this.loanApplication.setChildrenDependents(this.loanApplicationModel.selectNoOfDependents(finalAccountNo));
            }
        }
        
        public void btnIncomePrevious(object args, EventArgs e) 
        {
            this.loanApplication.btnIncomePreviousFunc();
            this.loanApplication.setAllTpDetailsLabelsToBlack();
        }
        
        public void btnIncomeNext(object args, EventArgs e) 
        {
            this.loanApplication.btnIncomeNextFunc();

            if (isbtnDetailsPrevious == false)
            {
                this.loanApplication.setLoanCount(this.loanApplicationModel.selectLoanApprovedCount(this.loanApplication.getAccountNo()));
                
                DataTable ds = this.loanApplicationModel.selectLoanTypeUnpaid(finalAccountNo).Tables[0];
                if (ds.Rows.Count > 0)
                {
                    int checkAdd = 0;
                    DataTable loanType =new DataTable();
                    //loanType.Columns.Add("LoanTypeId", typeof(int));
                    //loanType.Columns.Add("LoanTypeName", typeof(String));

                    foreach (DataRow dr in ds.Rows)
                    {
                        int currentLoan = this.loanApplicationModel.selectCurrentEligibility(int.Parse(dr["LoanTypeId"].ToString()));
                       
                        if (checkAdd == 0 && currentLoan == 1) 
                        { 
                            loanType = this.loanApplicationModel.selectLoanType(finalMemberType).Tables[0];
                            for(int i =0;i<loanType.Rows.Count;i++) 
                            {
                                int previousLoan = this.loanApplicationModel.selectPreviousEligibility(int.Parse(loanType.Rows[i]["LoanTypeId"].ToString()));
                                if (previousLoan == 0) 
                                {
                                    loanType.Rows.RemoveAt(i);
                                    i--;
                                }
                            }

                        }

                        else if (checkAdd == 0 && currentLoan == 0) 
                        {
                            checkAdd = 1;
                            loanType = this.loanApplicationModel.selectLoanType(finalMemberType).Tables[0];
                            loanType.Rows.Clear();
                            DataTable allLoanTypes = this.loanApplicationModel.selectLoanType(finalMemberType).Tables[0];
                            for (int i = 0; i < allLoanTypes.Rows.Count; i++)
                            {
                                int previousLoan = this.loanApplicationModel.selectPreviousEligibility(int.Parse(allLoanTypes.Rows[i]["LoanTypeId"].ToString()));
                                if (previousLoan == 1)
                                {
                                    loanType.Rows.Add(allLoanTypes.Rows[i]["LoanTypeId"], allLoanTypes.Rows[i]["LoanTypeName"]);
                                }
                            }
                        }

                    }

                    DataSet dataLoanType = loanType.DataSet;
                    dataLoanType.Tables.Remove(loanType.TableName);
                    dataLoanType.Tables.Add(loanType);
                    this.loanApplication.addItemsAtTypeOfLoan(dataLoanType);
                    this.loanApplication.setCBLoanTypeIndex();
                }

                else
                {
                    this.loanApplication.addItemsAtTypeOfLoan(this.loanApplicationModel.selectLoanType(finalMemberType));
                    this.loanApplication.setCBLoanTypeIndex();
                }
            }
        }
        
        public void btnDetailsPrevious(object args, EventArgs e) 
        {
            isbtnDetailsPrevious = true;
            this.loanApplication.btnDetailsPreviousFunc();
        }

        public void btnDetailsNext(object args, EventArgs e)
        {
            this.loanApplication.setAllTpDetailsLabelsToBlack();
            int countRequired = 0;
            int countError = 0;
            CheckedListBox.CheckedItemCollection requirementsName = this.loanApplication.getCheckedRequirements();
            Dictionary<string, int> setOfRequirement = new Dictionary<string, int>();

            //details-validation
            foreach (KeyValuePair<int, string> pair in requirements)
            {
                setOfRequirement.Add(pair.Value, 0);
            }

            foreach (String s in requirementsName)
            {
                setOfRequirement[s] += 1;
            }

            foreach (KeyValuePair<string, int> pair in setOfRequirement) 
            {
                if (pair.Value == 0) 
                {
                    if (pair.Key.ToString().Contains("(Required upon application)")) { countRequired++; }
                }
            }

            if (countRequired > 0 || requirementsName.Count == 0) { this.loanApplication.lblRequirementChecklist.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getCBLoanTypeIndex() == -1) { this.loanApplication.lblLoanType.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getPurpose() == String.Empty) { this.loanApplication.lblPurpose.ForeColor = Color.Red; countError++; }
            try
            {
                if (this.loanApplication.getLoanAmount() > this.loanApplication.getMaxAmount()) { this.loanApplication.lblLoanAmount.ForeColor = Color.Red; countError++; }
            }
            catch (Exception) { this.loanApplication.lblLoanAmount.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getPaymentDurationValue() <= 0) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
            try
            {
                int value = this.loanApplication.getPaymentDurationValue();
                String duration = this.loanApplication.getDurationStatus();
                if (duration == "month/s") { value *= 4; }
                else if (duration == "year/s") { value *= 48; }
                String[] s = this.loanApplication.getLblPaymentDuration().Split(' ');

                if (value < int.Parse(s[0]) || value > int.Parse(s[1])) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
            }
            catch (Exception) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }

            try 
            {
                this.loanApplication.getTermsOfPayment();
            }
            catch (Exception) { this.loanApplication.lblTerms.ForeColor = Color.Red; countError++; }

            if (this.loanApplication.getIfLoanAgainstDeposit()) 
            {
                if(this.loanApplication.getSourceOfFund() == 0) { this.loanApplication.lblSourceOfFund.ForeColor = Color.Red; countError++; }
            }

            //details-validation end

            if(countError == 0)
            {

                if (isCollateral == 1)
                {
                    this.loanApplication.btnDetailsNextFunc();
                }

                if (noOfComakers == 0) //pag walang comaker
                {
                    this.loanApplication.noComakerFunc();
                }

                if (isCollateral == 0 && noOfComakers > 0) //pag walang collateral
                {
                    this.loanApplication.btnCollateralNextFunc();
                    this.loanApplication.viewComakerGrid(this.loanApplicationModel.selectActiveMemberWithNoDeficiency());
                    this.loanApplication.clearSelectionViewComaker();
                    this.loanApplication.disableComakerFunction();
                }
            }
        }
        
        public void btnCollateralPrevious(object args, EventArgs e)
        {
            this.loanApplication.btnCollateralPreviousFunc();
            this.loanApplication.setRowSelectionCollateralErrorFalse();
        }

        public void btnCollateralNext(object args, EventArgs e) 
        {
            this.loanApplication.setPlsAddCollateralFalse();
            this.loanApplication.setAllTpCollateralsLabelsToBlack();
            int countError = 0;

            if (this.loanApplication.dataCollateral.Rows.Count == 0) { this.loanApplication.setPlsAddCollateralTrue(); countError++; }
            
            if (isAddEditCollateral) 
            {
                this.loanApplication.gbProperty.ForeColor = Color.Red;
                countError++;
            }

            if (countError == 0)
            {
                this.loanApplication.btnCollateralNextFunc();
                this.loanApplication.viewComakerGrid(this.loanApplicationModel.selectActiveMemberWithNoDeficiency());
                this.loanApplication.clearSelectionViewComaker();
                this.loanApplication.disableComakerFunction();
            }
        }

        public void btnComakerPrevious(object args, EventArgs e) 
        {
            if (isCollateral == 1)
            {
                this.loanApplication.btnComakerPreviousFunc();
                this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Black;
                this.loanApplication.setRowSelectionComakerErrorFalse();
            }
            else 
            {
                this.loanApplication.btnCollateralPreviousFunc();
                this.loanApplication.setRowSelectionCollateralErrorFalse();
            }
        }

        public void btnAddCollateral(object args, EventArgs e) 
        {
            this.loanApplication.enableCollateralFunction();
            this.loanApplication.setRowSelectionCollateralErrorFalse();
            isAddCollateral = true;
            isAddEditCollateral = true;
        }
        
        public void btnEditCollateral(object args, EventArgs e) 
        {
                this.loanApplication.setPlsAddCollateralFalse();
                this.loanApplication.setRowSelectionCollateralErrorFalse();
                collateralIndex = this.loanApplication.getSelectedCollateralIndex();
                if (collateralIndex >=0)
                {
                    isAddEditCollateral = true;
                    this.loanApplication.enableCollateralFunction();
                    isAddCollateral = false;
                    collateralIndex = this.loanApplication.getSelectedCollateralIndex();
                }

        }
        
        public void btnDeleteCollateral(object args, EventArgs e) 
        {
            this.loanApplication.setPlsAddCollateralFalse();
            this.loanApplication.deleteCollateralRow();
            this.loanApplication.clearSelectionCollateral();
        }
        
        public void btnSaveCollateral(object args, EventArgs e) 
        {
            this.loanApplication.setAllTpCollateralsLabelsToBlack();
            int countError = 0;
            isAddEditCollateral = false;
            String title = this.loanApplication.getTitle();
            String condition = this.loanApplication.getCondition();
            String description = this.loanApplication.getDescription();
            String serialNo = this.loanApplication.getSerialNo();
            int yearAcquired = this.loanApplication.getYearAcquired();
            double acquiredAmount = 0;

            try
            {
                acquiredAmount = this.loanApplication.getAcquiredAmount();
            }
            catch (Exception) { this.loanApplication.lblAcquiredAmount.ForeColor = Color.Red; countError++; }

            if (title == String.Empty) { this.loanApplication.lblTitle.ForeColor = Color.Red; countError++; }
            if (condition == String.Empty) { this.loanApplication.lblCondition.ForeColor = Color.Red; countError++; }
            if (description == String.Empty) { this.loanApplication.lblDescription.ForeColor = Color.Red; countError++; }
            if (serialNo == String.Empty) { this.loanApplication.lblSerialNo.ForeColor = Color.Red; countError++; }

            if (isAddCollateral && countError ==0)
            {
                this.loanApplication.addCollateralRow(title, condition, description, serialNo, yearAcquired, acquiredAmount);
                this.loanApplication.disableCollateralFunction();
                this.loanApplication.clearSelectionCollateral();
                isAddCollateral = false;
            }

            else if (!isAddCollateral && countError ==0)
            {
                this.loanApplication.editCollateralRow(title, condition, description, serialNo, yearAcquired, acquiredAmount, collateralIndex);
                this.loanApplication.disableCollateralFunction();
                this.loanApplication.clearSelectionCollateral();
                collateralIndex = 0;
            }

        }

        public void btnCancelCollateral(object args, EventArgs e) 
        {
            isAddEditCollateral = false;
            isAddCollateral = false;
            this.loanApplication.disableCollateralFunction();
        }
        
        public void btnAddComaker(object args, EventArgs e) 
        {
            hasSpouse = false;
            this.loanApplication.setRowSelectionComakerErrorFalse();

            if (this.loanApplication.getComaker() == String.Empty)
            {
                this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                isAddEditComaker = true;
                this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Black;
                this.loanApplication.enableComakerFunction();
                isAddComaker = true;


                DataGridViewRow selectedData = this.loanApplication.getSelectedViewComaker();
                accountNo = selectedData.Cells["Account No."].Value.ToString();
                memberName = selectedData.Cells["Name"].Value.ToString();

                String spouse = this.loanApplicationModel.checkSpouseName(accountNo);

                if (spouse == String.Empty) { this.loanApplication.hideSpouseFields(); }
                else { this.loanApplication.showSpouseFields(); hasSpouse = true; }
            }
            this.loanApplication.setCMMemberNameUnchecked();
        }

        public void btnEditComaker(object args, EventArgs e)
        {
            hasSpouse = false;
            this.loanApplication.setPlsAddComakerFalse();
            this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Black;
            this.loanApplication.setRowSelectionComakerErrorFalse();
            comakerIndex = this.loanApplication.getSelectedComakerIndex();
            if (comakerIndex >= 0)
            {
                isAddEditComaker = true;
                String spouse = this.loanApplicationModel.checkSpouseName(this.loanApplication.getAccountNoOfDataAddedMember());

                if (spouse == String.Empty) { this.loanApplication.hideSpouseFields(); }
                else { this.loanApplication.showSpouseFields(); hasSpouse = true; }
                this.loanApplication.enableComakerFunction();
                isAddComaker = false;
                comakerIndex = this.loanApplication.getSelectedComakerIndex();
            }

        }
        
        public void btnDeleteComaker(object args, EventArgs e) 
        {
            this.loanApplication.setPlsAddComakerFalse();
            this.loanApplication.lblComaker.ForeColor = System.Drawing.Color.Black;
            this.loanApplication.deleteAddedComakerRow();
            this.loanApplication.clearSelectionAddedComaker();
        }

        public void btnSaveComaker(object args, EventArgs e) 
        {
            this.loanApplication.setAllTpComakersLabelsToBlack();
            int countError = 0;
            isAddEditComaker = false;
            String resCertNo = this.loanApplication.getCResidentCertNo();
            String resPlaceOfIssue = this.loanApplication.getCPlaceIssued();
            String resDateIssued = this.loanApplication.getDateRIssued();
            String spouseResCertNo = String.Empty;
            String spousePlaceOfIssue = String.Empty;
            String spouseDateIssued = String.Empty;

            if (resCertNo == String.Empty) { this.loanApplication.lblResCertNo.ForeColor = Color.Red; countError++; }
            if (resPlaceOfIssue == String.Empty) { this.loanApplication.lblRPlaceIssued.ForeColor = Color.Red; countError++; }

            if (hasSpouse)
            {
                spouseResCertNo = this.loanApplication.getSResidentCertNo();
                spousePlaceOfIssue = this.loanApplication.getSPlaceIssued();
                spouseDateIssued = this.loanApplication.getDateSIssued();

                if (spouseResCertNo == String.Empty) { this.loanApplication.lblSpouseCertNo.ForeColor = Color.Red; countError++; }
                if (spousePlaceOfIssue == String.Empty) { this.loanApplication.lblSPlaceIssued.ForeColor = Color.Red; countError++; }
            }


            if (isAddComaker && countError ==0)
            {
                this.loanApplication.addComakerRow(accountNo, memberName, resCertNo, resPlaceOfIssue, resDateIssued, spouseResCertNo, spousePlaceOfIssue, spouseDateIssued);
                this.loanApplication.disableComakerFunction();
                this.loanApplication.clearSelectionViewComaker();
                this.loanApplication.clearSelectionAddedComaker();
                this.loanApplication.hideSpouseFields();
                isAddComaker = false;
            }

            else if (!isAddEditComaker && countError ==0)
            {
                this.loanApplication.editComakerRow(resCertNo, resPlaceOfIssue, resDateIssued, spouseResCertNo, spousePlaceOfIssue, spouseDateIssued, comakerIndex);
                this.loanApplication.disableComakerFunction();
                this.loanApplication.clearSelectionAddedComaker();
                this.loanApplication.hideSpouseFields();
                collateralIndex = 0;
            }

        }

        public void btnCancelComaker(object args, EventArgs e)
        {
            isAddEditComaker = false;
            isAddComaker = false;
            this.loanApplication.clearSelectionViewComaker();
            this.loanApplication.disableComakerFunction();
        }
        
        public void btnCancelLoan(object args, EventArgs e) 
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel application?\nAll inputs will be reset.", "Cancel Loan Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.loanApplication.disableFunction();
                this.loanApplication.enableDataActiveMember();
                this.loanApplication.clearSelectionActiveMember();
                isbtnDetailsPrevious = false;
                isAddEditCollateral = false;
                isAddEditComaker = false;
                isAddCollateral = false;
                isAddComaker = false;
                isFixed = false;
                hasSpouse = false;
                collateralIndex = 0;
                comakerIndex = 0;
                isCollateral = 0;
                noOfComakers = 0;

                finalAccountNo = String.Empty;
                finalMemberType = 0;

                accountNo = String.Empty;
                memberName = String.Empty;

                requirements.Clear();
            }
        }
        
        public void btnApplyLoan(object args, EventArgs e) 
        {
            this.loanApplication.setAllTpDetailsLabelsToBlack();
            int countRequired = 0;
            int countError = 0;
            CheckedListBox.CheckedItemCollection requirementsName1 = this.loanApplication.getCheckedRequirements();
            Dictionary<string, int> setOfRequirement = new Dictionary<string, int>();

            //details validation start
            foreach (KeyValuePair<int, string> pair in requirements)
            {
                setOfRequirement.Add(pair.Value, 0);
            }

            foreach (String s in requirementsName1)
            {
                setOfRequirement[s] += 1;
            }

            foreach (KeyValuePair<string, int> pair in setOfRequirement)
            {
                if (pair.Value == 0)
                {
                    if (pair.Key.ToString().Contains("(Required upon application)")) { countRequired++; }
                }
            }

            if (countRequired > 0 || requirementsName1.Count == 0) { this.loanApplication.lblRequirementChecklist.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getCBLoanTypeIndex() == -1) { this.loanApplication.lblLoanType.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getPurpose() == String.Empty) { this.loanApplication.lblPurpose.ForeColor = Color.Red; countError++; }
            try
            {
                if (this.loanApplication.getLoanAmount() > this.loanApplication.getMaxAmount()) { this.loanApplication.lblLoanAmount.ForeColor = Color.Red; countError++; }
            }
            catch (Exception) { this.loanApplication.lblLoanAmount.ForeColor = Color.Red; countError++; }
            if (this.loanApplication.getPaymentDurationValue() <= 0) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
            try
            {
                int value = this.loanApplication.getPaymentDurationValue();
                String duration = this.loanApplication.getDurationStatus();
                if (duration == "month/s") { value *= 4; }
                else if (duration == "year/s") { value *= 48; }
                String[] s = this.loanApplication.getLblPaymentDuration().Split(' ');

                if (value < int.Parse(s[0]) || value > int.Parse(s[1])) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }
            }
            catch (Exception) { this.loanApplication.lblPaymentDuration.ForeColor = Color.Red; countError++; }

            try
            {
                this.loanApplication.getTermsOfPayment();
            }
            catch (Exception) { this.loanApplication.lblTerms.ForeColor = Color.Red; countError++; }

            if (this.loanApplication.getIfLoanAgainstDeposit())
            {
                if (this.loanApplication.getSourceOfFund() == 0) { this.loanApplication.lblSourceOfFund.ForeColor = Color.Red; countError++; }
            }

            //details validation end


            //collaterals validation start
            if (isCollateral != 0)
            {
                this.loanApplication.setPlsAddCollateralTrue();
                this.loanApplication.setAllTpCollateralsLabelsToBlack();

                if (this.loanApplication.dataCollateral.Rows.Count == 0) { this.loanApplication.setPlsAddCollateralTrue(); countError++; }

                if (isAddEditCollateral)
                {
                    this.loanApplication.gbProperty.ForeColor = Color.Red;
                    countError++;
                }
            }
            //collaterals validation end


            //comakers validation start
            if (noOfComakers != 0)
            {
                this.loanApplication.setPlsAddComakerFalse();
                this.loanApplication.setAllTpComakersLabelsToBlack();

                if (this.loanApplication.dataAddedComaker.Rows.Count == 0) { this.loanApplication.setPlsAddComakerTrue(); countError++; }

                if (isAddEditComaker)
                {
                    this.loanApplication.gbSelectedComaker.ForeColor = Color.Red;
                    countError++;
                }
            }
            //comakers validation end

            MessageBox.Show(countError + "");
            if(countError ==0)
            {
                //insert income start
                int incomeId = 0;

                double monthlyIncome = this.loanApplication.getMonthlyIncome();
                double spouseIncome = this.loanApplication.getSpouseIncome();
                double otherSources = this.loanApplication.getOtherSources();
                double netMonthlyIncome = this.loanApplication.getNetMonthlyIncome();

                incomeId = this.loanApplicationModel.insertIncome(monthlyIncome, spouseIncome, otherSources, netMonthlyIncome);

                //insert income end


                //insert expense start
                int expenseId = 0;

                double food = this.loanApplication.getFood();
                double water = this.loanApplication.getWater();
                double electricity = this.loanApplication.getElectricity();
                double tuitionfee = this.loanApplication.getTuition();
                double rent = this.loanApplication.getRent();
                double transportation = this.loanApplication.getTransportation();
                double loanRepayment = this.loanApplication.getLoanRepayment();
                double load = this.loanApplication.getTelephone();
                double miscellaneuous = this.loanApplication.getMiscellaneous();
                double monthlyExpense = this.loanApplication.getMonthlyExpense();

                expenseId = this.loanApplicationModel.insertExpense(food, water, electricity, tuitionfee, rent, transportation, loanRepayment, load, miscellaneuous, monthlyExpense);

                //insert expense end


                //insert loanapplication start

                int loanApplicationId = 0;

                int loanTypeId = this.loanApplication.getTypeOfLoan();
                Boolean isLoanAgainstDeposit = this.loanApplication.getIfLoanAgainstDeposit();
                int certificateNo = this.loanApplication.getSourceOfFund(); //pending
                String purpose = this.loanApplication.getPurpose();
                String paymentDurationStatus = this.loanApplication.getDurationStatus();
                int paymentDurationValue = this.loanApplication.getPaymentDurationValue();
                String terms = this.loanApplication.getTermsOfPayment();
                double loanAmount = this.loanApplication.getLoanAmount();
                String dateFiled = this.loanApplication.getDateOfFiling();

                    //if time deposit
                if (certificateNo != 0) { this.loanApplicationModel.updateTimeDeposit(certificateNo); }


                loanApplicationId = this.loanApplicationModel.insertLoanApplication(finalAccountNo, incomeId, expenseId, loanTypeId, isLoanAgainstDeposit, certificateNo, purpose, paymentDurationStatus, paymentDurationValue, terms, loanAmount, dateFiled);

                //insert loan application end


                //insert loan app requirements

                CheckedListBox.CheckedItemCollection requirementsName = this.loanApplication.getCheckedRequirements();

                foreach (KeyValuePair<int, string> pair in requirements)
                {
                    this.loanApplicationModel.insertLoanApplicationRequirements(pair.Key, loanApplicationId, false);
                }


                foreach (String s in requirementsName)
                {
                    foreach (KeyValuePair<int, string> pair in requirements)
                    {
                        if (s.Equals(pair.Value)) { this.loanApplicationModel.updateLoanApplicationRequirements(pair.Key, loanApplicationId); }
                    }
                }

                //insert loan app requirements end


                //insert collaterals start

                if (collateralIndex >= 0)
                {

                    for (int i = 0; i < this.loanApplication.dataCollateral.Rows.Count; i++)
                    {

                        String title = this.loanApplication.dataCollateral.Rows[i].Cells[0].Value.ToString();
                        String condition = this.loanApplication.dataCollateral.Rows[i].Cells[1].Value.ToString();
                        String description = this.loanApplication.dataCollateral.Rows[i].Cells[2].Value.ToString();
                        String serialNo = this.loanApplication.dataCollateral.Rows[i].Cells[3].Value.ToString();
                        String yearAcquired = this.loanApplication.dataCollateral.Rows[i].Cells[4].Value.ToString();
                        double acquiredAmount = double.Parse(this.loanApplication.dataCollateral.Rows[i].Cells[4].Value.ToString());

                        this.loanApplicationModel.insertCollateral(loanApplicationId, serialNo, title, condition, description, yearAcquired, acquiredAmount);
                    }
                }

                //insert collateral end


                //insert comaker start

                if (comakerIndex >= 0)
                {

                    for (int i = 0; i < this.loanApplication.dataAddedComaker.Rows.Count; i++)
                    {
                        int spouseCheck = 0;
                        String comakerAccountNo = this.loanApplication.dataAddedComaker.Rows[i].Cells[0].Value.ToString();
                        String resCertNo = this.loanApplication.dataAddedComaker.Rows[i].Cells[2].Value.ToString();
                        String placeIssued = this.loanApplication.dataAddedComaker.Rows[i].Cells[3].Value.ToString();
                        String dateIssued = this.loanApplication.dataAddedComaker.Rows[i].Cells[4].Value.ToString();
                        String spouseCertNo = this.loanApplication.dataAddedComaker.Rows[i].Cells[5].Value.ToString();
                        String splaceIssued = this.loanApplication.dataAddedComaker.Rows[i].Cells[6].Value.ToString();
                        String sdateIssued = this.loanApplication.dataAddedComaker.Rows[i].Cells[5].Value.ToString();

                        if (spouseCertNo == String.Empty) { spouseCheck = 1; }
                        this.loanApplicationModel.insertComaker(spouseCheck, loanApplicationId, comakerAccountNo, resCertNo, placeIssued, dateIssued, spouseCertNo, splaceIssued, sdateIssued);
                    }
                }

                //insert comaker end



                MessageBox.Show("Loan application successful", "LOAN APPLICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loanApplication.disableFunction();
                this.loanApplication.enableDataActiveMember();
                this.loanApplication.clearSelectionActiveMember();
                isbtnDetailsPrevious = false;
                isAddEditCollateral = false;
                isAddEditComaker = false;
                isAddCollateral = false;
                isAddComaker = false;
                hasSpouse = false;
                isFixed = false;
                collateralIndex = 0;
                comakerIndex = 0;
                isCollateral = 0;
                noOfComakers = 0;

                finalAccountNo = String.Empty;
                finalMemberType = 0;

                accountNo = String.Empty;
                memberName = String.Empty;

                requirements.Clear();


            }
        }//end applyloan
    






    
    }
}
