using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.Controller
{
    class DormancyController
    {
        Maintenance.Model.DormancyModel dormancyModel;
        Maintenance.View.Dormancy dormancy;
        String errorMessage = String.Empty;
        Boolean isAdd = false;
        int TypeId = 0;

        public DormancyController(Maintenance.Model.DormancyModel dormancyModel, Maintenance.View.Dormancy dormancy, SavingsMenu savingsMenu)
        {
            this.dormancyModel = dormancyModel;
            this.dormancy = dormancy;
            this.dormancy.setBtnAddEventHandler(this.btnAdd);
            this.dormancy.setBtnCancelEventHandler(this.btnCancel);
            this.dormancy.setBtnEditEventHandler(this.btnEdit);
            this.dormancy.setBtnSaveEventHandler(this.btnSave);
            this.dormancy.checkArchived_CheckStateChanged(this.checkArchived);
            this.dormancy.disableFunction();
            this.dormancy.dormancyGrid(this.dormancyModel.selectDormancy());
            this.dormancy.removeColumns();
            this.dormancy.MdiParent = savingsMenu;
            this.dormancy.Show();
        }

        public void btnAdd(object args, EventArgs e)
        {
            this.dormancy.enableFunction();
            this.dormancy.initAccountType(this.dormancyModel.selectAccountTypes());
            this.dormancy.setStatus();
            isAdd = true;
            TypeId = 0;
        }

        public void btnEdit(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.dormancy.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Dormancy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Unable to Edit Archives." + Environment.NewLine + "Please Retrieve Savings Account Type First.", "Dormancy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.dormancy.enableFunction();
                    this.dormancy.disableType();
                    this.TypeId = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString());
                    this.dormancy.setAccountType(selectedData.Cells["Account Type"].Value.ToString());
                    String[] dormancy = selectedData.Cells["Dormancy"].Value.ToString().Split(' ');
                    this.dormancy.setNumDormancy(int.Parse(dormancy[0]));
                    this.dormancy.setComboDormancy(dormancy[1]);
                    String[] penalty = selectedData.Cells["Penalty"].Value.ToString().Split(' ');
                    this.dormancy.setTextPenalty(penalty[0]);
                    this.dormancy.setComboPenalty(penalty[1]);
                    String[] penaltySchedule = selectedData.Cells["Penalty Schedule"].Value.ToString().Split(' ');
                    this.dormancy.setNumCharge(int.Parse(penaltySchedule[0]));
                    this.dormancy.setComboCharge(penaltySchedule[1]);
                    if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
                    {
                        this.dormancy.setStatus();
                    }
                    isAdd = false;
                }
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            this.errorMessage = String.Empty;
            this.dormancy.clearError();
            Boolean checkAccountType = false;
            Boolean checkDormancy = false;
            Boolean checkDormancySchedule = false;
            Boolean checkPenalty = false;
            Boolean checkPenaltyCost = false;
            Boolean checkCharge = false;
            Boolean checkChargeSchedule = true;
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
                    if (this.dormancy.getAccountType() == 0)
                    {
                        errorMessage += "Please Specify Account Type." + Environment.NewLine;
                        this.dormancy.setErrorAccountType();
                        checkAccountType = false;
                    }
                    else
                    {
                        this.dormancyModel.TypeId = this.dormancy.getAccountType();
                        checkAccountType = true;
                    }
                }
                else
                {
                    checkAccountType = true;
                }
                if (this.dormancy.getNumDormancy() != 0)
                {
                    this.dormancyModel.Dormancy = this.dormancy.getNumDormancy();
                    checkDormancy = true;
                }
                else
                {
                    errorMessage += "Please Specify Dormancy After." + Environment.NewLine;
                    this.dormancy.setErrorDormancy();
                    checkDormancy = false;
                }
                if (this.dormancy.getComboDormancy() == String.Empty)
                {
                    errorMessage += "Please Specify Dormancy After Schedule." + Environment.NewLine;
                    this.dormancy.setErrorDormancy();
                    checkDormancySchedule = false;
                }
                else
                {
                    this.dormancyModel.DormancyStatus = this.dormancy.getComboDormancy();
                    checkDormancySchedule = true;
                }
                if (this.dormancy.getTextPenalty() != 0)
                {
                    this.dormancyModel.Penalty = this.dormancy.getTextPenalty();
                    checkPenalty = true;
                }
                else
                {
                    errorMessage += "Please Specify Penalty." + Environment.NewLine;
                    this.dormancy.setErrorPenalty();
                    checkPenalty = false;
                }
                if (this.dormancy.getComboPenalty() == String.Empty)
                {
                    errorMessage += "Please Specify Penalty Cost." + Environment.NewLine;
                    this.dormancy.setErrorPenalty();
                    checkPenaltyCost = false;
                }
                else
                {
                    this.dormancyModel.PenaltyStatus = this.dormancy.getComboPenalty();
                    checkPenaltyCost = true;
                }
                if(this.dormancy.getNumCharge() != 0)
                {
                    this.dormancyModel.Charge = this.dormancy.getNumCharge();
                    checkCharge = true;
                }
                else
                {
                    errorMessage += "Please Specify Penalty every." + Environment.NewLine;
                    this.dormancy.setErrorEvery();
                    checkCharge = false;
                }
                if (this.dormancy.getComboCharge() == String.Empty)
                {
                    errorMessage += "Please Specify Penalty Schedule every." + Environment.NewLine;
                    this.dormancy.setErrorEvery();
                    checkChargeSchedule = false;
                }
                else
                {
                    this.dormancyModel.ChargeStatus = this.dormancy.getComboCharge();
                    checkChargeSchedule = true;
                }
                if (this.dormancy.getStatus())
                {
                    this.dormancyModel.Status = 1;
                }
                else
                {
                    this.dormancyModel.Status = 0;
                }
                if (checkAccountType && checkDormancy && checkDormancySchedule && checkPenalty && checkPenaltyCost && checkCharge && checkChargeSchedule)
                {
                    if (isAdd)
                    {
                        if (this.dormancyModel.insertDormancy() == 1)
                        {
                            MessageBox.Show("Add Success.", "Dormancy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.dormancy.checkArchivedState())
                            {
                                this.dormancy.dormancyGrid(this.dormancyModel.selectDormancyAll());
                                DataGridViewRowCollection dr = this.dormancy.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.dormancy.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.dormancy.dormancyGrid(this.dormancyModel.selectDormancy());
                            }
                            this.dormancy.removeColumns();
                            this.dormancy.clearError();
                            this.dormancy.disableFunction();
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Add Failed.", "Dormancy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (this.dormancyModel.updateDormancy(this.TypeId) == 1)
                        {
                            MessageBox.Show("Update Success.", "Dormancy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.dormancy.checkArchivedState())
                            {
                                this.dormancy.dormancyGrid(this.dormancyModel.selectDormancyAll());
                                DataGridViewRowCollection dr = this.dormancy.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.dormancy.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.dormancy.dormancyGrid(this.dormancyModel.selectDormancy());
                            }
                            this.dormancy.removeColumns();
                            this.dormancy.clearError();
                            this.dormancy.disableFunction();
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Update Failed.", "Dormancy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, "Dormancy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                this.dormancy.setErrorDormancy();
                this.dormancy.setErrorPenalty();
                this.dormancy.setErrorEvery();
                MessageBox.Show(this.errorMessage + "Invalid Input!" + Environment.NewLine + "Check Red Labels.", "Dormancy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.dormancy.disableFunction();
            this.dormancy.clearError();
            this.errorMessage = String.Empty;
            isAdd = false;
            TypeId = 0;
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.dormancy.checkArchivedState())
            {
                this.dormancy.dormancyGrid(this.dormancyModel.selectDormancyAll());
                DataGridViewRowCollection dr = this.dormancy.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.dormancy.setArchivedColor(i);
                    }
                    i++;
                }
                this.dormancy.removeColumns();
            }
            else
            {
                this.dormancy.dormancyGrid(this.dormancyModel.selectDormancy());
                this.dormancy.removeColumns();
            }
        }
    }
}
