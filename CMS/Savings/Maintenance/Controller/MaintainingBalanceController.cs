using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.Controller
{
    class MaintainingBalanceController
    {
        Maintenance.Model.MaintainingBalancesModel maintainingBalancesModel;
        Maintenance.View.MaintainingBalances maintainingBalances;
        String errorMessage = String.Empty;
        Boolean isAdd = false;
        int TypeId = 0;

        public MaintainingBalanceController(Maintenance.Model.MaintainingBalancesModel maintaningBalancesModel, Maintenance.View.MaintainingBalances maintainingBalances, SavingsMenu savingsMenu)
        {
            this.maintainingBalancesModel = maintaningBalancesModel;
            this.maintainingBalances = maintainingBalances;
            this.maintainingBalances.setBtnAddEventHandler(this.btnAdd);
            this.maintainingBalances.setBtnCancelEventHandler(this.btnCancel);
            this.maintainingBalances.setBtnEditEventHandler(this.btnEdit);
            this.maintainingBalances.setBtnSaveEventHandler(this.btnSave);
            this.maintainingBalances.checkArchived_CheckStateChanged(this.checkedArchived);
            this.maintainingBalances.maintainingBalanceGrid(this.maintainingBalancesModel.selectMaintainingBalances());
            this.maintainingBalances.removeColumns();
            this.maintainingBalances.disableFunction();
            this.maintainingBalances.MdiParent = savingsMenu;
            isAdd = false;
            this.maintainingBalances.Show();
        }

        public void btnAdd(object args, EventArgs e)
        {
            this.maintainingBalances.initAccountType(this.maintainingBalancesModel.selectAccountTypes());
            this.maintainingBalances.enableFunction();
            this.maintainingBalances.setStatus();
            isAdd = true;
            TypeId = 0;
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.maintainingBalances.disableFunction();
            this.maintainingBalances.clearError();
            this.errorMessage = String.Empty;
            isAdd = false;
            TypeId = 0;
        }

        public void btnEdit(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.maintainingBalances.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Maintaining Balances", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Unable to Edit Archives." + Environment.NewLine + "Please Retrieve Savings Account Type First.", "Maintaining Balances", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    isAdd = false;
                    this.maintainingBalances.enableFunction();
                    this.maintainingBalances.disableType();
                    this.TypeId = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString());
                    this.maintainingBalances.setAccountType(selectedData.Cells["Account Type"].Value.ToString());
                    this.maintainingBalances.setMaintainingBalance(selectedData.Cells["Maintaining Balance"].Value.ToString());
                    String[] penalty = selectedData.Cells["Penalty"].Value.ToString().Split(' ');
                    String comboCharge = String.Empty;
                    for (int i = 0; i < penalty.Length; i++)
                    {
                        if (i == 0)
                        {
                            this.maintainingBalances.setCharge(penalty[i]);
                        }
                        else if (i == penalty.Length - 1)
                        {
                            comboCharge += penalty[i];
                        }
                        else
                        {
                            comboCharge += penalty[i] + ' ';
                        }
                    }
                    this.maintainingBalances.setComboCharge(comboCharge);
                    String[] penaltyDuration = selectedData.Cells["Penalty Schedule"].Value.ToString().Split(' ');
                    this.maintainingBalances.setNumChargeDuration(int.Parse(penaltyDuration[0]));
                    this.maintainingBalances.setComboChargeDuration(penaltyDuration[1]);
                    if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
                    {
                        this.maintainingBalances.setStatus();
                    }
                }
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            this.errorMessage = String.Empty;
            this.maintainingBalances.clearError();
            Boolean checkAccountType = false;
            Boolean checkMainBal = false;
            Boolean checkPenalty = false;
            Boolean checkPenaltyStatus = false;
            Boolean checkCharge = false;
            Boolean checkChargeSchedule = false;
            if (isAdd)
            {
                errorMessage += "Add Failed." + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                errorMessage += "Update Failed." + Environment.NewLine + Environment.NewLine;
            }
            try
            {
                if (isAdd)
                {
                    if (this.maintainingBalances.getAccountType() == 0)
                    {
                        errorMessage += "Please Specify Account Type." + Environment.NewLine;
                        this.maintainingBalances.setErrorAccountType();
                        checkAccountType = false;
                    }
                    else
                    {
                        this.maintainingBalancesModel.AccountTypeId = this.maintainingBalances.getAccountType();
                        checkAccountType = true;
                    }
                }
                else
                {
                    checkAccountType = true;
                }
                if (this.maintainingBalances.getMaintainingBalance() != 0)
                {
                    this.maintainingBalancesModel.MaintainingBalance = this.maintainingBalances.getMaintainingBalance();
                    checkMainBal = true;
                }
                else
                {
                    errorMessage += "Please Specify Amount - Maintaining Balance." + Environment.NewLine;
                    this.maintainingBalances.setErrorMaintainingBalance();
                    checkMainBal = false;
                }
                if (this.maintainingBalances.getCharge() != 0)
                {
                    if (this.maintainingBalances.getCharge() > this.maintainingBalances.getMaintainingBalance())
                    {
                        errorMessage += "Penalty Cannot be Greater than Maintaining Balance." + Environment.NewLine;
                        this.maintainingBalances.setErrorPenalty();
                        checkPenalty = false;
                    }
                    else
                    {
                        if (this.maintainingBalances.getComboCharge() == "% of Current Balance" && this.maintainingBalances.getCharge() > 100)
                        {
                            errorMessage += "Penalty Cannot be Greater than Maintaining Balance." + Environment.NewLine;
                            this.maintainingBalances.setErrorPenalty();
                            checkPenalty = false;
                        }
                        else
                        {
                            this.maintainingBalancesModel.ServiceCharge = this.maintainingBalances.getCharge();
                            checkPenalty = true;
                        }
                    }
                }
                else
                {
                    errorMessage += "Please Specify Amount - Penalty." + Environment.NewLine;
                    this.maintainingBalances.setErrorPenalty();
                    checkPenalty = false;
                }
                if (this.maintainingBalances.getComboCharge() == String.Empty)
                {
                    errorMessage += "Please Specify Penalty Status." + Environment.NewLine;
                    this.maintainingBalances.setErrorPenalty();
                    checkPenaltyStatus = false;
                }
                else
                {
                    this.maintainingBalancesModel.ServiceChargeStatus = this.maintainingBalances.getComboCharge();
                    checkPenaltyStatus = true;
                }
                if (this.maintainingBalances.getNumChargeDuration() == 0)
                {
                    errorMessage += "Please Specify Charge Schedule." + Environment.NewLine;
                    this.maintainingBalances.setErrorCharge();
                    checkCharge = false;
                }
                else
                {
                    this.maintainingBalancesModel.ServiceChargeDuration = this.maintainingBalances.getNumChargeDuration();
                    checkCharge = true;
                }
                if (this.maintainingBalances.getComboChargeDuration() == String.Empty)
                {
                    errorMessage += "Please Specify Charge Schedule Duration." + Environment.NewLine;
                    this.maintainingBalances.setErrorCharge();
                    checkChargeSchedule = false;
                }
                else
                {
                    this.maintainingBalancesModel.ServiceChargeDurationStatus = this.maintainingBalances.getComboChargeDuration();
                    checkChargeSchedule = true;
                }
                if (this.maintainingBalances.getStatus())
                {
                    this.maintainingBalancesModel.Status = 1;
                }
                else
                {
                    this.maintainingBalancesModel.Status = 0;
                }
                if (checkAccountType && checkMainBal && checkPenalty && checkPenaltyStatus && checkCharge && checkChargeSchedule)
                {
                    if (isAdd)
                    {
                        if (this.maintainingBalancesModel.insertMaintainingBalance() == 1)
                        {
                            MessageBox.Show("Add Success.", "Maintaining Balances", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.maintainingBalances.checkArchivedState())
                            {
                                this.maintainingBalances.maintainingBalanceGrid(this.maintainingBalancesModel.selectMaintainingBalancesAll());
                                DataGridViewRowCollection dr = this.maintainingBalances.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.maintainingBalances.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.maintainingBalances.maintainingBalanceGrid(this.maintainingBalancesModel.selectMaintainingBalances());
                            }
                            this.maintainingBalances.removeColumns();
                            this.maintainingBalances.clearError();
                            this.maintainingBalances.disableFunction();
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Add Failed.", "Maintaining Balances", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (this.maintainingBalancesModel.updateMaintainingBalance(TypeId) == 1)
                        {
                            MessageBox.Show("Update Success.", "Maintaining Balances", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.maintainingBalances.checkArchivedState())
                            {
                                this.maintainingBalances.maintainingBalanceGrid(this.maintainingBalancesModel.selectMaintainingBalancesAll());
                                DataGridViewRowCollection dr = this.maintainingBalances.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.maintainingBalances.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.maintainingBalances.maintainingBalanceGrid(this.maintainingBalancesModel.selectMaintainingBalances());
                            }
                            this.maintainingBalances.removeColumns();
                            this.maintainingBalances.clearError();
                            this.maintainingBalances.disableFunction();
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Update Failed.", "Maintaining Balances", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, "Maintaining Balances", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException)
            {
                this.maintainingBalances.setErrorMaintainingBalance();
                this.maintainingBalances.setErrorPenalty();
                this.maintainingBalances.setErrorCharge();
                MessageBox.Show(this.errorMessage + "Invalid Input!" + Environment.NewLine + "Check Red Labels.", "Maintaining Balances", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void checkedArchived(object sender, EventArgs e)
        {
            if (this.maintainingBalances.checkArchivedState())
            {
                this.maintainingBalances.maintainingBalanceGrid(this.maintainingBalancesModel.selectMaintainingBalancesAll());
                DataGridViewRowCollection dr = this.maintainingBalances.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.maintainingBalances.setArchivedColor(i);
                    }
                    i++;
                }
                this.maintainingBalances.removeColumns();
            }
            else
            {
                this.maintainingBalances.maintainingBalanceGrid(this.maintainingBalancesModel.selectMaintainingBalances());
                this.maintainingBalances.removeColumns();
            }
        }
    }
}
