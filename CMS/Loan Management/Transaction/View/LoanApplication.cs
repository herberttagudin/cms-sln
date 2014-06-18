using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Transaction.View
{
    public partial class LoanApplication : Form
    {
        public LoanApplication()
        {
            InitializeComponent();
        }

        private void LoanApplication_Load(object sender, EventArgs e)
        {
            
            
        }

        //ENABLE-DISABLE FUNCTION START

        public void disableFunction() 
        {
            this.tcLoanApp.SelectTab(this.tpPersonal);

            this.tpIncome.Enabled = false;
            this.tpDetails.Enabled = false;
            this.tpComaker.Enabled = false;
            this.tpCollaterals.Enabled = false;
            this.btnApplyLoan.Enabled = false;
            this.btnCancelLoan.Enabled = false;


            //tpPersonal-start

            this.txtMemberName.Enabled = false;
            this.txtAccountNo.Enabled = false;

            this.txtMemberName.Text = String.Empty;
            this.txtAccountNo.Text = String.Empty;

            this.rbAccountNo.Checked = false;
            this.rbMemberName.Checked = false;

            this.txtCurrentShareCap.Text = String.Empty;
            this.txtCurrentTotSavings.Text = String.Empty;

            this.txtCurrentTotSavings.Enabled = true;

            //tpPersonal-end


            //tpIncome-start

            this.txtMonthlyIncome.Text = String.Empty;
            this.txtSpouseIncome.Text = String.Empty;
            this.txtOtherSources.Text = String.Empty;
            this.txtGrossIncome.Text = "0";
            this.txtLessMonthlyExpense.Text = "0";
            this.txtNetMonthlyIncome.Text = "0";

            this.txtChildrenDependents.Text = String.Empty;
            this.txtFood.Text = String.Empty;
            this.txtWater.Text = String.Empty;
            this.txtElectricity.Text = String.Empty;
            this.txtTuition.Text = String.Empty;
            this.txtRent.Text = String.Empty;
            this.txtTransporation.Text = String.Empty;
            this.txtLoanRepayment.Text = String.Empty;
            this.txtTelephone.Text = String.Empty;
            this.txtMiscellaneous.Text = String.Empty;
            this.txtMonthlyExpenses.Text = "0";

            this.txtSpouseIncome.Enabled = true;
            this.txtChildrenDependents.Enabled = true;

            //tpIncome-end


            //tpDetails-start


            DateTime date = DateTime.Now;
            this.fileDate.MaxDate = date;
            this.fileDate.Value = date;
            this.udPaymentDuration.Value = 0;
            this.cbDurationStatus.SelectedValue = -1;
            this.cbTerms.SelectedIndex = -1;
            this.cbSourceOfFund.SelectedIndex=-1;
            this.clbRequirements.Items.Clear();
            this.lblStateMaxLoanAmount.Visible = false;
            this.lblStatePaymentDuration.Visible = false;
            this.cbLoanType.SelectedIndex = -1;

            this.txtLoanCount.Text = String.Empty;
            this.txtLoanAmount.Text = String.Empty;
            this.txtPurpose.Text = String.Empty;
            this.txtCurrentBalance.Text = String.Empty;
            this.gbLoanAgainstDeposit.Enabled = false;

            //tpDetails-end


            //tpComaker-start
            this.lblPlsAddComaker.Visible = false;
            this.lblPlsSelectARow2.Visible = false;

            this.dataViewComaker.DataSource = null;
            this.dataViewComaker.Columns.Clear();

            this.dataViewComaker.Columns.Clear();
            this.dataAddedComaker.Rows.Clear();

            this.txtCMMemberName.Enabled = false;
            this.txtCMAccountNo.Enabled = false;

            this.txtCMMemberName.Text = String.Empty;
            this.txtCMAccountNo.Text = String.Empty;

            this.rbCMAccountNo.Checked = false;
            this.rbCMMemberName.Checked = false;

            this.txtComaker.Text = String.Empty;

            this.txtSpouseCertNo.Visible = false;
            this.txtSPlaceIssued.Visible = false;
            this.issuedSDate.Visible = false;
            this.lblSpouseCertNo.Visible = false;
            this.lblSPlaceIssued.Visible = false;
            this.lblSDateIssued.Visible = false;

            //tpComaker-end


            //tpCollateral-start

            this.dataCollateral.Rows.Clear();
            this.lblPlsAddCollateral.Visible = false;
            this.lblPlsSelectARow.Visible = false;
            this.udYearAcquired.Maximum = DateTime.Now.Year;

            //tpCollateral-end
           
        }

        public void disableSavings() 
        {
            this.txtCurrentTotSavings.Text = "0";
            this.txtCurrentTotSavings.Enabled = false;
        }

        public void disableSpouseIncome() 
        {
            this.txtSpouseIncome.Enabled = false;
        }

        public void setCMMemberNameUnchecked() 
        {
            this.rbCMMemberName.Checked = false;
        }

        public void hideSpouseFields() 
        {
            this.txtSpouseCertNo.Visible = false;
            this.txtSPlaceIssued.Visible = false;
            this.issuedSDate.Visible = false;
            this.lblSpouseCertNo.Visible = false;
            this.lblSPlaceIssued.Visible = false;
            this.lblSDateIssued.Visible = false;
        }

        public void showSpouseFields()
        {
            this.txtSpouseCertNo.Visible = true;
            this.txtSPlaceIssued.Visible = true;
            this.issuedSDate.Visible = true;
            this.lblSpouseCertNo.Visible = true;
            this.lblSPlaceIssued.Visible = true;
            this.lblSDateIssued.Visible = true;
        }


        public void clearSavingsAndShareCapital() 
        {
            this.txtCurrentTotSavings.Text = String.Empty;
            this.txtCurrentShareCap.Text = String.Empty;
        }

        public void clearComaker()
        {
            this.txtComaker.Text = String.Empty;
        }


        public void disableDataActiveMember() 
        {
            this.dataActiveMember.Enabled = false;
            this.txtMemberName.ReadOnly = true;
            this.txtAccountNo.ReadOnly = true;
            this.rbAccountNo.Enabled = false;
            this.rbMemberName.Enabled = false;
        }

        public void enableDataActiveMember() 
        {
            this.dataActiveMember.Enabled = true;
            this.txtMemberName.ReadOnly = false;
            this.txtAccountNo.ReadOnly = false;
            this.rbAccountNo.Enabled = true;
            this.rbMemberName.Enabled = true;
        }

        public void disableCollateralFunction()
        {
            this.txtTitle.Text = String.Empty;
            this.txtCondition.Text = String.Empty;
            this.txtDescription.Text = String.Empty;
            this.txtSerialNo.Text = String.Empty;
            this.txtAcquiredAmount.Text = String.Empty;
            this.udYearAcquired.Value = 1900;

            this.txtTitle.Enabled = false;
            this.txtCondition.Enabled = false;
            this.txtDescription.Enabled = false;
            this.txtSerialNo.Enabled = false;
            this.txtAcquiredAmount.Enabled = false;
            this.udYearAcquired.Enabled = false;

            this.btnSaveCollateral.Enabled = false;
            this.btnCancelCollateral.Enabled = false;

            this.btnAddCollateral.Enabled = true;
            this.btnEditCollateral.Enabled = true;
            this.btnDeleteCollateral.Enabled = true;

        }

        public void enableCollateralFunction()
        {
            this.txtTitle.Text = String.Empty;
            this.txtCondition.Text = String.Empty;
            this.txtDescription.Text = String.Empty;
            this.txtSerialNo.Text = String.Empty;
            this.txtAcquiredAmount.Text = String.Empty;
            this.udYearAcquired.Value = 1900;

            this.txtTitle.Enabled = true;
            this.txtCondition.Enabled = true;
            this.txtDescription.Enabled = true;
            this.txtSerialNo.Enabled = true;
            this.txtAcquiredAmount.Enabled = true;
            this.udYearAcquired.Enabled = true;

            this.btnSaveCollateral.Enabled = true;
            this.btnCancelCollateral.Enabled = true;

            this.btnAddCollateral.Enabled = false;
            this.btnEditCollateral.Enabled = false;
            this.btnDeleteCollateral.Enabled = false;

        }



        public void disableComakerFunction()
        {
            this.dataViewComaker.Enabled = true;

            this.txtComaker.Text = String.Empty;
            this.txtResCertNo.Text = String.Empty;
            this.txtRPlaceIssued.Text = String.Empty;
            this.issuedRDate.Value = DateTime.Now;
            this.txtSpouseCertNo.Text = String.Empty;
            this.txtSPlaceIssued.Text = String.Empty;
            this.issuedSDate.Value = DateTime.Now;

            this.txtResCertNo.Enabled = false;
            this.txtRPlaceIssued.Enabled = false;
            this.issuedRDate.Enabled = false;
            this.txtSpouseCertNo.Enabled = false;
            this.txtSPlaceIssued.Enabled = false;
            this.issuedSDate.Enabled = false;

            this.btnSaveComaker.Enabled = false;
            this.btnCancelComaker.Enabled = false;

            this.btnAddComaker.Enabled = true;
            this.btnEditComaker.Enabled = true;
            this.btnDeleteCoMaker.Enabled = true;

            
        }

        public void enableComakerFunction()
        {
            this.dataViewComaker.Enabled = false;

            this.txtResCertNo.Text = String.Empty;
            this.txtRPlaceIssued.Text = String.Empty;
            this.issuedRDate.Value = DateTime.Now;
            this.txtSpouseCertNo.Text = String.Empty;
            this.txtSPlaceIssued.Text = String.Empty;
            this.issuedSDate.Value = DateTime.Now;

            this.txtResCertNo.Enabled = true;
            this.txtRPlaceIssued.Enabled = true;
            this.issuedRDate.Enabled = true;
            this.txtSpouseCertNo.Enabled = true;
            this.txtSPlaceIssued.Enabled = true;
            this.issuedSDate.Enabled = true;

            this.btnSaveComaker.Enabled = true;
            this.btnCancelComaker.Enabled = true;

            this.btnAddComaker.Enabled = false;
            this.btnEditComaker.Enabled = false;
            this.btnDeleteCoMaker.Enabled = false;
        }

        //ENABLE-DISABLE FUNCTION END
        


        //buttons

        public void btnProceedFunc() 
        {
            this.tcLoanApp.SelectTab(this.tpIncome);
            this.tpIncome.Enabled = true;
            this.btnCancelLoan.Enabled = true;
        }

        public void btnIncomePreviousFunc() 
        {
            this.tcLoanApp.SelectTab(this.tpPersonal);
        }

        public void btnIncomeNextFunc() 
        {
            this.tcLoanApp.SelectTab(this.tpDetails);
            this.tpDetails.Enabled = true;
        }

        public void btnDetailsPreviousFunc() 
        {
            this.tcLoanApp.SelectTab(this.tpIncome);
        }

        public void btnDetailsNextFunc() 
        {
            this.tcLoanApp.SelectTab(this.tpCollaterals);
            this.tpCollaterals.Enabled = true;
        }

        public void btnCollateralPreviousFunc() 
        {
            this.tcLoanApp.SelectTab(this.tpDetails);
        }

        public void btnCollateralNextFunc() 
        {
            this.tcLoanApp.SelectTab(this.tpComaker);
            this.tpComaker.Enabled = true;
            this.btnApplyLoan.Enabled = true;
        }

        public void btnComakerPreviousFunc() 
        {
            this.tcLoanApp.SelectTab(this.tpCollaterals);
        }

        public void noCollateralAndComakerFunc() 
        {
            this.btnDetailsNext.Enabled = false;
            this.btnApplyLoan.Enabled = true;
            this.tpCollaterals.Enabled = false;
            this.tpComaker.Enabled = false;
        }

        public void noComakerFunc() 
        {
            this.btnCollateralNext.Enabled = false;
            this.btnApplyLoan.Enabled = true;
        }

        public void setBtnDetailsNext() 
        {
            this.btnDetailsNext.Enabled = true;
            this.btnApplyLoan.Enabled = false;
        }

        public void setBtnAddCollateralEventHandler(EventHandler e)
        {
            this.btnAddCollateral.Click += e;
        }

        public void setBtnAddComakerEventHandler(EventHandler e)
        {
            this.btnAddComaker.Click += e;
        }

        public void setBtnApplyLoanEventHandler(EventHandler e)
        {
            this.btnApplyLoan.Click += e;
        }

        public void setBtnCancelLoanEventHandler(EventHandler e)
        {
            this.btnCancelLoan.Click += e;
        }

        public void setBtnCollateralNextEventHandler(EventHandler e)
        {
            this.btnCollateralNext.Click += e;
        }

        public void setBtnCollateralPreviousEventHandler(EventHandler e)
        {
            this.btnCollateralPrevious.Click += e;
        }

        public void setBtnComakerPreviousEventHandler(EventHandler e)
        {
            this.btnComakerPrevious.Click += e;
        }

        public void setBtnDeleteCollateralEventHandler(EventHandler e)
        {
            this.btnDeleteCollateral.Click += e;
        }

        public void setBtnDetailsNextEventHandler(EventHandler e)
        {
            this.btnDetailsNext.Click += e;
        }

        public void setBtnDetailsPreviousEventHandler(EventHandler e)
        {
            this.btnDetailsPrevious.Click += e;
        }

        public void setBtnEditCollateralEventHandler(EventHandler e)
        {
            this.btnEditCollateral.Click += e;
        }

        public void setBtnIncomeNextEventHandler(EventHandler e)
        {
            this.btnIncomeNext.Click += e;
        }

        public void setBtnIncomePreviousEventHandler(EventHandler e)
        {
            this.btnIncomePrevious.Click += e;
        }

        public void setBtnProceedEventHandler(EventHandler e)
        {
            this.btnProceed.Click += e;
        }

        public void setBtnDeleteComakerEventHandler(EventHandler e)
        {
            this.btnDeleteCoMaker.Click += e;
        }

        public void setBtnSaveCollateralEventHandler(EventHandler e)
        {
            this.btnSaveCollateral.Click += e;
        }

        public void setBtnCancelCollateralEventHandler(EventHandler e)
        {
            this.btnCancelCollateral.Click += e;
        }

        public void setBtnSaveComakerEventHandler(EventHandler e)
        {
            this.btnSaveComaker.Click += e;
        }

        public void setBtnEditComakerEventHandler(EventHandler e)
        {
            this.btnEditComaker.Click += e;
        }

        public void setBtnCancelComakerEventHandler(EventHandler e)
        {
            this.btnCancelComaker.Click += e;
        }


        //buttons-end



        //datagridview-start

        public void dataActiveMember_CellClick(DataGridViewCellEventHandler e)
        {
                this.dataActiveMember.CellClick += e;
        }

        public int getActiveMemberIndex()
        {
            int row = 0;

            try
            {
                this.setRowSelectionActiveMemberErrorFalse();
                row = this.dataActiveMember.SelectedRows[0].Index;
            }
            catch (Exception) { row = -1; this.setRowSelectionActiveMemberErrorTrue(); }

            return row;
        }

        public void activeMemberGrid(DataSet ds)
        {
            this.dataActiveMember.DataSource = ds.Tables[0];
            this.dataActiveMember.Columns[3].Visible = false;
        }

        public DataGridViewRow getSelectedActiveMember()
        {
                return this.dataActiveMember.SelectedRows[0];
        }

        public void viewComakerGrid(DataSet ds)
        {
            this.dataViewComaker.DataSource = ds.Tables[0];
        }

        public void clearSelectionActiveMember() 
        {
            this.dataActiveMember.ClearSelection();
        }

        public DataGridViewRow getSelectedViewComaker()
        {
            return this.dataViewComaker.SelectedRows[0];
        }



        public void clearSelectionViewComaker() 
        {
            this.dataViewComaker.ClearSelection();
        }


        private void dataViewComaker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int row = this.dataViewComaker.SelectedRows[0].Index;
                int row1 = this.dataActiveMember.SelectedRows[0].Index;
                int checkExist = 0;

                if (this.dataAddedComaker.Rows.Count == 0)
                {
                    if (this.dataActiveMember[0, row1].Value.ToString() == this.dataViewComaker[0, row].Value.ToString()) 
                    {
                        this.clearComaker();
                        this.dataViewComaker.SelectedRows[0].Selected = false;
                        checkExist = 1;
                    }
                    else
                    {
                        this.setComaker(this.dataViewComaker[1, row].Value.ToString());
                        this.lblComaker.ForeColor = System.Drawing.Color.Black;
                    }
                }
                else
                {
                    if (this.dataActiveMember[0, row1].Value.ToString() == this.dataViewComaker[0, row].Value.ToString())
                    {
                        this.clearComaker();
                        this.dataViewComaker.SelectedRows[0].Selected = false;
                        checkExist = 1;
                    }
                    else
                    {
                        for (int i = 0; i < this.dataAddedComaker.Rows.Count; i++)
                        {


                            if (this.dataViewComaker[0, row].Value.ToString() == this.dataAddedComaker.Rows[i].Cells[0].Value.ToString())
                            {
                                this.dataViewComaker.SelectedRows[0].Selected = false;
                                checkExist = 1;
                            }

                        }
                    }
                }

                if (checkExist == 0)
                {
                    this.setComaker(this.dataViewComaker[1, row].Value.ToString());
                    this.lblComaker.ForeColor = System.Drawing.Color.Black;
                }
            }

        }

        public void clearSelectionAddedComaker()
        {
            this.dataAddedComaker.ClearSelection();
        }

        public String getAccountNoOfDataAddedMember() 
        {
            int row = this.dataAddedComaker.SelectedRows[0].Index;
            return this.dataAddedComaker[0, row].Value.ToString();
        }

        public int getSelectedCollateralIndex()
        {
            int row =0;

            try
            {
                row = this.dataCollateral.SelectedRows[0].Index;
            }
            catch (Exception) { row = -1; }

            if (row >= 0)
            {
                this.setRowSelectionCollateralErrorFalse();
                this.setTitle(this.dataCollateral[0, row].Value.ToString());
                this.setCondition(this.dataCollateral[1, row].Value.ToString());
                this.setDescription(this.dataCollateral[2, row].Value.ToString());
                this.setSerialNo(int.Parse(this.dataCollateral[3, row].Value.ToString()));
                this.setYearAcquired(int.Parse(this.dataCollateral[4, row].Value.ToString()));
                this.setAcquiredAmount(double.Parse(this.dataCollateral[5, row].Value.ToString()));
            }
            else 
            {
                this.setRowSelectionCollateralErrorTrue();
            }

            return row;

        }

        public int getSelectedComakerIndex()
        {
            int row = 0;

            try
            {
                row = this.dataAddedComaker.SelectedRows[0].Index;
            }
            catch (Exception) { row = -1; }

            if (row >= 0)
            {
                this.setRowSelectionComakerErrorFalse();
                this.setCResidentCertNo(this.dataAddedComaker[2, row].Value.ToString());
                this.setCPlaceIssued(this.dataAddedComaker[3, row].Value.ToString());
                this.setDateRIssued(System.DateTime.Parse(this.dataAddedComaker[4, row].Value.ToString()));
                this.setSResidentCertNo(this.dataAddedComaker[5, row].Value.ToString());
                this.setSPlaceIssued(this.dataAddedComaker[6, row].Value.ToString());
                this.setDateSIssued(System.DateTime.Parse(this.dataAddedComaker[4, row].Value.ToString()));
            }
            else
            {
                this.setRowSelectionComakerErrorTrue();
            }

            return row;

        }

        public void addCollateralRow(String title, String condition, String desc, String serialNo, int yearAcquired, double acquiredAmount)
        {
            this.dataCollateral.Rows.Add(title, condition, desc, serialNo, yearAcquired, acquiredAmount);
        }

        public void addComakerRow(String accountNo, String memberName, String resCertNo, String resPlaceOfIssue, String resDateIssued, String spouseResCertNo, String spousePlaceOfIssue, String spouseDateIssued)
        {
            //this.dataViewComaker.SelectedRows[0].Frozen = true;
            if (spouseResCertNo == String.Empty) this.dataAddedComaker.Rows.Add(accountNo, memberName, resCertNo, resPlaceOfIssue, resDateIssued, "", "","");
            else { this.dataAddedComaker.Rows.Add(accountNo, memberName, resCertNo, resPlaceOfIssue, resDateIssued, spouseResCertNo, spousePlaceOfIssue, spouseDateIssued); }
        }
        
        public void editCollateralRow(String title, String condition, String desc, String serialNo, int yearAcquired, double acquiredAmount, int rowIndex) 
        {
            this.dataCollateral[0, rowIndex].Value = title;
            this.dataCollateral[1, rowIndex].Value = condition;
            this.dataCollateral[2, rowIndex].Value = desc;
            this.dataCollateral[3, rowIndex].Value = serialNo;
            this.dataCollateral[4, rowIndex].Value = yearAcquired;
            this.dataCollateral[5, rowIndex].Value = acquiredAmount;
        }

        public void editComakerRow(String resCertNo, String resPlaceOfIssue, String resDateIssued, String spouseResCertNo, String spousePlaceOfIssue, String spouseDateIssued, int rowIndex)
        {
            this.dataAddedComaker[2, rowIndex].Value = resCertNo;
            this.dataAddedComaker[3, rowIndex].Value = resPlaceOfIssue;
            this.dataAddedComaker[4, rowIndex].Value = resDateIssued;
            this.dataAddedComaker[5, rowIndex].Value = spouseResCertNo;
            this.dataAddedComaker[6, rowIndex].Value = spousePlaceOfIssue;
            this.dataAddedComaker[7, rowIndex].Value = spouseDateIssued;
        }

        public void deleteCollateralRow() 
        {
            try
            {
                this.setRowSelectionCollateralErrorFalse();
                this.dataCollateral.Rows.RemoveAt(this.dataCollateral.SelectedRows[0].Index);
            }
            catch (Exception) { this.setRowSelectionCollateralErrorTrue(); }
        }

        public void deleteAddedComakerRow()
        {
            try
            {
                this.setRowSelectionComakerErrorFalse();
                this.dataAddedComaker.Rows.RemoveAt(this.dataAddedComaker.SelectedRows[0].Index);
            }
            catch (Exception) { this.setRowSelectionComakerErrorTrue(); }
        }

        public void clearSelectionCollateral() 
        {
            this.dataCollateral.ClearSelection();
        }

        public String getAccountNo() 
        {
            DataGridViewRow selectedData = this.getSelectedActiveMember();
            return selectedData.Cells["Account No."].Value.ToString();
        }

        public int getMemberType() 
        {
            DataGridViewRow selectedData = this.getSelectedActiveMember();
            return int.Parse(selectedData.Cells["MemberTypeNo"].Value.ToString());
        }

        //datagridview-end


        //radiobutton-start

        private void rbAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAccountNo.Checked == true) { txtAccountNo.Enabled = true; }
            else { txtAccountNo.Enabled = false; txtAccountNo.Clear(); }
        }

        private void rbMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMemberName.Checked == true) { txtMemberName.Enabled = true; }
            else { txtMemberName.Enabled = false; txtMemberName.Clear(); }
        }

        private void rbCMAccountNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCMAccountNo.Checked == true) { txtCMAccountNo.Enabled = true; }
            else { txtCMAccountNo.Enabled = false; txtCMAccountNo.Clear(); }
        }

        private void rbCMMemberName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCMMemberName.Checked == true) { txtCMMemberName.Enabled = true; }
            else { txtCMMemberName.Enabled = false; txtCMMemberName.Clear(); }
        }   

        //radiobuttond-end



        //date-start

        public String getDateOfFiling()
        {
            return this.fileDate.Value.ToString("yyyy-MM-dd");
        }

        public void setDateRIssued(System.DateTime s)
        {
            this.issuedRDate.Value = s;
        }

        public String getDateRIssued()
        {
            return this.issuedRDate.Value.ToString("yyyy-MM-dd");
        }

        public void setDateSIssued(System.DateTime s)
        {
            this.issuedSDate.Value = s;
        }

        public String getDateSIssued()
        {
            return this.issuedSDate.Value.ToString("yyyy-MM-dd");
        }

        //date-end



        //numeric up down-start

        public void setChildrenDependents(int i)
        {
            this.txtChildrenDependents.Text = i.ToString();
        }

        public void setYearAcquired(int i)
        {
            this.udYearAcquired.Value = i;
        }

        public int getYearAcquired()
        {
            return int.Parse(this.udYearAcquired.Value.ToString());
        }

        public int getPaymentDurationValue()
        {
       
            return int.Parse(this.udPaymentDuration.Value.ToString());
        }

        //numeric up down-end

        
        
        //combobox-start

        public void addItemsAtTypeOfLoan(DataSet ds)
        {
            this.cbLoanType.DataSource = ds.Tables[0];
            this.cbLoanType.ValueMember = "LoanTypeId";
            this.cbLoanType.DisplayMember = "LoanTypeName";
        }


        public int getTypeOfLoan()
        {
            DataRowView drv = (DataRowView)this.cbLoanType.SelectedItem;
            int valueOfItem = int.Parse(drv["LoanTypeId"].ToString());
            return valueOfItem;
        }

        public int addItemsAtSourceOfFund(DataSet ds)
        {
            int i = 0;
            this.cbSourceOfFund.DataSource = ds.Tables[0];
            this.cbSourceOfFund.ValueMember = "CertificateNo";
            this.cbSourceOfFund.DisplayMember = "CertificateNo";

            if (cbSourceOfFund.Items.Count == 0) { i = 1; }
            return i;
        }

        public int getSourceOfFund()
        {
            try
            {
                DataRowView drv = (DataRowView)this.cbSourceOfFund.SelectedItem;
                int valueOfItem = int.Parse(drv["CertificateNo"].ToString());
                return valueOfItem;
            }
            catch (Exception) { return 0; }
        }

        public String getDurationStatus()
        {
            return this.cbDurationStatus.SelectedItem.ToString();
        }

        public String getTermsOfPayment()
        {
            return this.cbTerms.SelectedItem.ToString();
        }

        public int getCBLoanTypeIndex() 
        {
            return this.cbLoanType.SelectedIndex;
        }

        public int getCBLADIndex()
        {
            return this.cbSourceOfFund.SelectedIndex;
        }

        public void setCBLoanTypeIndex() 
        {
            this.cbLoanType.SelectedIndex = -1;
        }

        public void setCBLADIndex()
        {
            this.cbSourceOfFund.SelectedIndex = -1;
        }

        public void getifcbLoanTypeIndexNegOne() 
        {
            this.btnDetailsNext.Enabled = false;
            this.clbRequirements.Items.Clear();
            this.gbLoanAgainstDeposit.Enabled = false;
            this.cbSourceOfFund.DataSource = null;
            this.txtCurrentBalance.Clear();
        }

        public void disableLAD() 
        {
            this.cbSourceOfFund.DataSource = null;
            this.txtCurrentBalance.Clear();
        }

        //combobox-end



        //check/list box start

        public void addItemsAtRequirements(Dictionary<int, string> requirements)
        {
            foreach (String s in requirements.Values)
            {
                this.clbRequirements.Items.Add(s);
            }
        }

        public CheckedListBox.CheckedItemCollection getCheckedRequirements()
        {
            return this.clbRequirements.CheckedItems;
        }


        public void removeAllRequirements() 
        {
            this.clbRequirements.Items.Clear();
        }

        public void getUncheckedRequirements() 
        { 
            
        }
        //check/list box end



        //textbox-start

        public void clearCurrentBalance() 
        {
            this.txtCurrentBalance.Clear();
        }

        public void setCurrentShareCapital(String s)
        {
            this.txtCurrentShareCap.Text = s;
        }

        public double getCurrentShareCapital()
        {
            return double.Parse(this.txtCurrentShareCap.Text);
        }

        public void setCurrentTotalSavings(String s)
        {
            this.txtCurrentTotSavings.Text = s;
        }

        public double getCurrentTotalSavings() 
        {
            return double.Parse(this.txtCurrentTotSavings.Text);
        }

        public double getMonthlyIncome()
        {
            try{
                return Double.Parse(this.txtMonthlyIncome.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getSpouseIncome()
        {
            try{
                return Double.Parse(this.txtSpouseIncome.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getOtherSources()
        {
            try{
            return Double.Parse(this.txtOtherSources.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getFood()
        {
            try
            {
                return Double.Parse(this.txtFood.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getWater()
        {
            try{
                return Double.Parse(this.txtWater.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getElectricity()
        {
            try{
                return Double.Parse(this.txtElectricity.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getTuition()
        {
            try{
                return Double.Parse(this.txtTuition.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getNetMonthlyIncome() 
        {
            return Double.Parse(this.txtNetMonthlyIncome.Text);
        }

        public double getRent()
        {
            try{
            return Double.Parse(this.txtRent.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getTransportation()
        {
            try{
            return Double.Parse(this.txtTransporation.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getLoanRepayment()
        {
            try{
                return Double.Parse(this.txtLoanRepayment.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getTelephone()
        {
            try{
            return Double.Parse(this.txtTelephone.Text);
            }
            catch (Exception) { return 0; }
        }

        public double getMiscellaneous()
        {
            try{
                return Double.Parse(this.txtMiscellaneous.Text);
            }
            catch (Exception) { return 0; }
        }

        public void setLoanCount(int i)
        {
            this.txtLoanCount.Text = i.ToString();
        }

        public double getLoanAmount()
        {
            return Double.Parse(this.txtLoanAmount.Text);
        }

        public String getPurpose()
        {
            return this.txtPurpose.Text.ToString();
        }

        public int getPurposeLength()
        {
            return this.txtPurpose.TextLength;
        }

        public void setCurrentBalance(double d)
        {
            this.txtCurrentBalance.Text = d.ToString();
        }

        public void setTitle(String s)
        {
            this.txtTitle.Text = s;
        }

        public String getTitle()
        {
            return this.txtTitle.Text.ToString();
        }

        public void setCondition(String s)
        {
            this.txtCondition.Text = s;
        }

        public String getCondition()
        {
            return this.txtCondition.Text.ToString();
        }

        public void setDescription(String s)
        {
            this.txtDescription.Text = s;
        }

        public String getDescription()
        {
            return this.txtDescription.Text.ToString();
        }

        public void setSerialNo(int i)
        {
            this.txtSerialNo.Text = i.ToString();
        }

        public String getSerialNo()
        {
            return this.txtSerialNo.Text.ToString() ;
        }

        public void setAcquiredAmount(double d)
        {
            this.txtAcquiredAmount.Text = d.ToString();
        }

        public double getAcquiredAmount()
        {
            return double.Parse(this.txtAcquiredAmount.Text);
        }

        public void setComaker(String s)
        {
            this.txtComaker.Text = s;
        }

        public String getComaker()
        {
            return this.txtComaker.Text.ToString();
        }

        public void setCResidentCertNo(String s)
        {
            this.txtResCertNo.Text = s;
        }

        public String getCResidentCertNo()
        {
            return this.txtResCertNo.Text.ToString();
        }

        public void setSResidentCertNo(String s)
        {
            this.txtSpouseCertNo.Text = s;
        }

        public String getSResidentCertNo()
        {
                return this.txtSpouseCertNo.Text.ToString();
        }

        public void setCPlaceIssued(String s)
        {
            this.txtRPlaceIssued.Text = s;
        }

        public String getCPlaceIssued()
        {
            return this.txtRPlaceIssued.Text.ToString();
        }

        public void setSPlaceIssued(String s)
        {
            this.txtSPlaceIssued.Text = s;
        }

        public String getSPlaceIssued()
        {
            return this.txtSPlaceIssued.Text.ToString();
        }

        public String getCMAccountNo() 
        {
            return this.txtCMAccountNo.Text.ToString();
        }

        public String getCMMemberName() 
        {
            return this.txtCMMemberName.Text.ToString();
        }

        public String getActiveAccountNo()
        {
            return this.txtAccountNo.Text.ToString();
        }

        public String getActiveMemberName()
        {
            return this.txtMemberName.Text.ToString();
        }

        

                //computed Text Box

        public void setGrossIncome(double d)
        {
            this.txtGrossIncome.Text = d.ToString();
        }

        public double getGrossIncome()
        {
            return double.Parse(this.txtGrossIncome.Text);
        }

        public void setLessMonthlyExpense(double d)
        {
            this.txtLessMonthlyExpense.Text = d.ToString();
        }

        public double getLessMonthlyExpense()
        {
            return double.Parse(this.txtLessMonthlyExpense.Text);
        }

        public void setNetMonthlyIncome(double d)
        {
            this.txtNetMonthlyIncome.Text = d.ToString();
        }

        public double getNetMonthlyExpense()
        {
            return double.Parse(this.txtNetMonthlyIncome.Text);
        }

        public void setMonthlyExpense(double d)
        {
            this.txtMonthlyExpenses.Text = d.ToString();
        }

        public double getMonthlyExpense()
        {
            return double.Parse(this.txtMonthlyExpenses.Text);
        }


        //textbox-ennd



        //label-start

        public void setLblMaxAmount(String s) 
        {
            this.lblStateMaxLoanAmount.Text = "Maximum loanable amount is Php "+s;
            this.setStateMaxAmountTrue();
        }

        public double getMaxAmount() 
        {
            String[] s = this.lblStateMaxLoanAmount.Text.Split(' ');
            return double.Parse(s[5]);
        }

        public void setLblPaymentDuration(String s)
        {
            this.lblStatePaymentDuration.Text = "Duration must be from " + s;
            this.setStatePaymentDurationTrue();
        }

        public String getLblPaymentDuration() 
        {
            String[] s = this.lblStatePaymentDuration.Text.Split(' ');
            int from = int.Parse(s[4]);
            int to = int.Parse(s[7]);
            String sFrom = s[5];
            String sTo = s[8];

            if (sFrom == "month/s") { from *= 4; }
            else if (sFrom == "year/s") { from *= 48; }
            if (sTo == "month/s") { to *= 4; }
            else if (sTo == "year/s") { to *= 48; }

            return from + " " + to;

        }

        public void setLabelLimit(int i)
        {
            this.lblPurposeLimit.Text = i.ToString();
        }

        public void setPlsAddComakerFalse() 
        {
            this.lblPlsAddComaker.Visible = false;
        }

        public void setPlsAddComakerTrue()
        {
            this.lblPlsAddComaker.Visible = true;
        }

        public void setPlsAddCollateralFalse() 
        {
            this.lblPlsAddCollateral.Visible = false;
        }

        public void setPlsAddCollateralTrue()
        {
            this.lblPlsAddCollateral.Visible = true;
        }

        public void setRowSelectionCollateralErrorFalse()
        {
            this.lblPlsSelectARow.Visible = false;
        }

        public void setRowSelectionCollateralErrorTrue()
        {
            this.lblPlsSelectARow.Visible = true;
        }

        public void setRowSelectionComakerErrorFalse()
        {
            this.lblPlsSelectARow2.Visible = false;
        }

        public void setRowSelectionComakerErrorTrue()
        {
            this.lblPlsSelectARow2.Visible = true;
        }

        public void setRowSelectionActiveMemberErrorTrue()
        {
            this.lblPlsSelectARow3.Visible = true;
        }

        public void setRowSelectionActiveMemberErrorFalse()
        {
            this.lblPlsSelectARow3.Visible = false;
        }

        public void setStateMaxAmountTrue() 
        {
            this.lblStateMaxLoanAmount.Visible = true;
        }

        public void setStateMaxAmountFalse()
        {
            this.lblStateMaxLoanAmount.Visible = false;
        }

        public void setStatePaymentDurationTrue()
        {
            this.lblStatePaymentDuration.Visible = true;
        }

        public void setStatePaymentDurationFalse()
        {
            this.lblStatePaymentDuration.Visible = false;
        }


        public void setAllTpDetailsLabelsToBlack() 
        {
            this.lblRequirementChecklist.ForeColor = Color.Black;
            this.lblLoanType.ForeColor = Color.Black;
            this.lblSourceOfFund.ForeColor = Color.Black;
            this.lblLoanAmount.ForeColor = Color.Black;
            this.lblPurpose.ForeColor = Color.Black;
            this.lblPaymentDuration.ForeColor = Color.Black;
            this.lblTerms.ForeColor = Color.Black;
        }

        public void setAllTpCollateralsLabelsToBlack() 
        {
            this.gbProperty.ForeColor = Color.Black;
            this.lblTitle.ForeColor = Color.Black;
            this.lblDescription.ForeColor = Color.Black;
            this.lblCondition.ForeColor = Color.Black;
            this.lblSerialNo.ForeColor = Color.Black;
            this.lblYearAcquired.ForeColor = Color.Black;
            this.lblAcquiredAmount.ForeColor = Color.Black;
            
        }

        public void setAllTpComakersLabelsToBlack()
        {
            this.gbSelectedComaker.ForeColor = Color.Black;
            this.lblResCertNo.ForeColor = Color.Black;
            this.lblRPlaceIssued.ForeColor = Color.Black;
            this.lblRDateIssued.ForeColor = Color.Black;
            this.lblSpouseCertNo.ForeColor = Color.Black;
            this.lblSPlaceIssued.ForeColor = Color.Black;
            this.lblSDateIssued.ForeColor = Color.Black;

        }
       
        
        //label-end



       //groupbox-start

        public Boolean getIfLoanAgainstDeposit() 
        {
            if (this.gbLoanAgainstDeposit.Enabled == true) { return true; }
            else return false;
        }

        public void enableLoanAgainstDeposit(Boolean b) 
        {
            this.gbLoanAgainstDeposit.Enabled = b;
        }

        //groupbox-end



        //textchange at kung ano ano pang change

        public void txtPurpose_TextChanged(EventHandler e)
        {
            this.txtPurpose.TextChanged += e;
        }

        public void txtCMMemberName_TextChanged(EventHandler e)
        {
            this.txtCMMemberName.TextChanged += e;
        }

        public void txtCMAccountNo_TextChanged(EventHandler e)
        {
            this.txtCMAccountNo.TextChanged += e;
        }

        public void txtMemberName_TextChanged(EventHandler e)
        {
            this.txtMemberName.TextChanged += e;
        }

        public void txtAccountNo_TextChanged(EventHandler e)
        {
            this.txtAccountNo.TextChanged += e;
        }

        public void txtExpenses_TextChanged(EventHandler e)
        {
            this.txtFood.TextChanged += e;
            this.txtWater.TextChanged += e;
            this.txtElectricity.TextChanged += e;
            this.txtTuition.TextChanged += e;
            this.txtRent.TextChanged += e;
            this.txtTransporation.TextChanged += e;
            this.txtLoanRepayment.TextChanged += e;
            this.txtTelephone.TextChanged += e;
            this.txtMiscellaneous.TextChanged += e;

        }

        public void txtMonthlyExpense_TextChanged(EventHandler e) 
        {
            this.txtMonthlyExpenses.TextChanged += e;
        }

        public void txtIncome_TextChanged(EventHandler e)
        {
            this.txtMonthlyIncome.TextChanged += e;
            this.txtSpouseIncome.TextChanged += e;
            this.txtOtherSources.TextChanged += e;
        }

        public void txtGrossIncome_TextChanged(EventHandler e) 
        {
            this.txtGrossIncome.TextChanged += e;
        }

        public void cbLoanType_SelectedIndexChanged(EventHandler e) 
        {
            this.cbLoanType.SelectedIndexChanged += e;
        }

        public void cbSourceOfFund_SelectedIndexChanged(EventHandler e)
        {
            this.cbSourceOfFund.SelectedIndexChanged += e;
        }
        
        //textchange at kung ano ano pang change

        

        //other events

        private void txtPurpose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if (this.txtPurpose.TextLength == 160)
                {
                    e.Handled = true;
                }
            }

        }

        private void txtSPlaceIssued_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpouseCertNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDurationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTerms.Items.Clear();

            if (cbDurationStatus.SelectedItem.ToString() == "week/s") 
            {
                cbTerms.Items.Add("weekly");
            }

            else if (cbDurationStatus.SelectedItem.ToString() == "month/s") 
            {
                cbTerms.Items.Add("weekly");
                cbTerms.Items.Add("monthly");
            }

            else if (cbDurationStatus.SelectedItem.ToString() == "year/s") 
            {
                cbTerms.Items.Add("weekly");
                cbTerms.Items.Add("monthly");
                cbTerms.Items.Add("quarterly");
                cbTerms.Items.Add("semi-annually");
                cbTerms.Items.Add("annually");
            }
        }

        private void incomeAndExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
                if (parts.Length > 1 || tb.TextLength > 7)
                {
                    if (parts[0].Length > 8 || parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }   
                
        }

        private void incomeAndExpense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAcquiredAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
                if (parts.Length > 1 || tb.TextLength > 7)
                {
                    if (parts[0].Length > 8 || parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }   
        }

        private void txtAcquiredAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void udYearAcquired_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (this.udYearAcquired.Text.Length >= 4)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void udPaymentDuration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPurpose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }







        //other events end
    }
}
