using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.Controller
{
    class MaximumWithdrawalController
    {
        Maintenance.Model.MaximumWithdrawalModel maximumWithdrawalModel;
        Maintenance.View.MaximumWithdrawal maximumWithdrawal;
        String errorMessage = String.Empty;
        Boolean isAdd = false;
        int TypeId = 0;

        public MaximumWithdrawalController(Maintenance.Model.MaximumWithdrawalModel maximumWithdrawalModel, Maintenance.View.MaximumWithdrawal maximumWithdrawal, SavingsMenu savingsMenu)
        {
            this.maximumWithdrawalModel = maximumWithdrawalModel;
            this.maximumWithdrawal = maximumWithdrawal;
            this.maximumWithdrawal.btnAddEventHandler(this.btnAdd);
            this.maximumWithdrawal.btnCancelEventHandler(this.btnCancel);
            this.maximumWithdrawal.btnEditEventHandler(this.btnEdit);
            this.maximumWithdrawal.btnSaveEventHandler(this.btnSave);
            this.maximumWithdrawal.checkArchived_CheckStateChanged(this.checkArchived);
            this.maximumWithdrawal.maxWithGrid(this.maximumWithdrawalModel.selectMaximumWithdrawal());
            this.maximumWithdrawal.removeColumns();
            this.maximumWithdrawal.MdiParent = savingsMenu;
            this.maximumWithdrawal.disableFunction();
            this.maximumWithdrawal.Show();
        }

        public void btnAdd(object args, EventArgs e)
        {
            isAdd = true;
            TypeId = 0;
            this.maximumWithdrawal.enableFunction();
            this.maximumWithdrawal.initAccountType(this.maximumWithdrawalModel.selectAccountTypes());
            this.maximumWithdrawal.setStatus();
        }

        public void btnCancel(object args, EventArgs e)
        {
            isAdd = false;
            TypeId = 0;
            this.maximumWithdrawal.disableFunction();
            this.maximumWithdrawal.clearError();
            this.errorMessage = String.Empty;
        }

        public void btnEdit(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.maximumWithdrawal.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Maximum Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Unable to Edit Archives." + Environment.NewLine + "Please Retrieve Savings Account Type First.", "Maximum Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    isAdd = false;
                    this.maximumWithdrawal.initAccountType(this.maximumWithdrawalModel.selectAccountTypes());
                    this.maximumWithdrawal.enableFunction();
                    this.maximumWithdrawal.disableType();
                    this.TypeId = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString()); ;
                    this.maximumWithdrawal.setAccountType(selectedData.Cells["Account Type"].Value.ToString());
                    this.maximumWithdrawal.setMaxWith(selectedData.Cells["Maximum Withdrawal"].Value.ToString());
                    if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
                    {
                        this.maximumWithdrawal.setStatus();
                    }
                }
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            this.errorMessage = String.Empty;
            this.maximumWithdrawal.clearError();
            Boolean checkAccountType = false;
            Boolean checkMaxWith = false;
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
                    if(this.maximumWithdrawal.getAccountType() == 0)
                    {
                        errorMessage += "Please Specify Account Type." + Environment.NewLine;
                        this.maximumWithdrawal.setErrorAccountType();
                        checkAccountType = false;
                    }
                    else
                    {
                        this.maximumWithdrawalModel.AccountTypeId = this.maximumWithdrawal.getAccountType();
                        checkAccountType = true;
                    }
                }
                else
                {
                    checkAccountType = true;
                }
                if (this.maximumWithdrawal.getMaxWith() != 0)
                {
                    this.maximumWithdrawalModel.MaxWith = this.maximumWithdrawal.getMaxWith();
                    checkMaxWith = true;
                }
                else
                {
                    errorMessage += "Please Specify Amount - Maximum Withdrawal." + Environment.NewLine;
                    this.maximumWithdrawal.setErrorMaxWith();
                    checkMaxWith = false;
                }
                if (this.maximumWithdrawal.getStatus())
                {
                    this.maximumWithdrawalModel.Status = 1;
                }
                else
                {
                    this.maximumWithdrawalModel.Status = 0;
                }
                if (checkAccountType && checkMaxWith)
                {
                    if (isAdd)
                    {
                        if (this.maximumWithdrawalModel.insertMaximumWithdrawal() == 1)
                        {
                            MessageBox.Show("Add Success.", "Maximum Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.maximumWithdrawal.checkArchivedState())
                            {
                                this.maximumWithdrawal.maxWithGrid(this.maximumWithdrawalModel.selectMaximumWithdrawalAll());
                                DataGridViewRowCollection dr = this.maximumWithdrawal.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.maximumWithdrawal.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.maximumWithdrawal.maxWithGrid(this.maximumWithdrawalModel.selectMaximumWithdrawal());
                            }
                            this.maximumWithdrawal.removeColumns();
                            this.maximumWithdrawal.clearError();
                            this.maximumWithdrawal.disableFunction();
                        }
                        else
                        {
                            MessageBox.Show("Add Failed.", "Maximum Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (this.maximumWithdrawalModel.updateMaximumWithdrawal(TypeId) == 1)
                        {
                            MessageBox.Show("Update Success.", "Maximum Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.maximumWithdrawal.checkArchivedState())
                            {
                                this.maximumWithdrawal.maxWithGrid(this.maximumWithdrawalModel.selectMaximumWithdrawalAll());
                                DataGridViewRowCollection dr = this.maximumWithdrawal.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.maximumWithdrawal.setArchivedColor(i);
                                    }
                                    i++;
                                }
                            }
                            else
                            {
                                this.maximumWithdrawal.maxWithGrid(this.maximumWithdrawalModel.selectMaximumWithdrawal());
                            }
                            this.maximumWithdrawal.removeColumns();
                            this.maximumWithdrawal.clearError();
                            this.maximumWithdrawal.disableFunction();
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Update Failed.", "Maximum Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, "Maximum Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                this.maximumWithdrawal.setErrorMaxWith();
                MessageBox.Show(this.errorMessage + "Invalid Input!" + Environment.NewLine + "Check Red Labels.", "Maximum Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void checkArchived(object sender, EventArgs e)
        {
            if (this.maximumWithdrawal.checkArchivedState())
            {
                this.maximumWithdrawal.maxWithGrid(this.maximumWithdrawalModel.selectMaximumWithdrawalAll());
                DataGridViewRowCollection dr = this.maximumWithdrawal.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.maximumWithdrawal.setArchivedColor(i);
                    }
                    i++;
                }
                this.maximumWithdrawal.removeColumns();
            }
            else
            {
                this.maximumWithdrawal.maxWithGrid(this.maximumWithdrawalModel.selectMaximumWithdrawal());
                this.maximumWithdrawal.removeColumns();
            }
        }
    }
}
