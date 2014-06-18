using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.Controller
{
    class SavingsAccountTypeController
    {
        Maintenance.Model.SavingsAccountTypeModel savingsAccountTypeModel;
        Maintenance.View.SavingsAccountType savingsAccountType;
        Dictionary<int, string> memberTypes = new Dictionary<int, string>();
        Boolean isAdd = false;
        String errorMessage = String.Empty;
        int TypeId = 0;

        public SavingsAccountTypeController(Maintenance.Model.SavingsAccountTypeModel savingsAccountTypeModel, Maintenance.View.SavingsAccountType savingsAccountType, Savings.SavingsMenu savingsMenu)
        {
            this.savingsAccountTypeModel = savingsAccountTypeModel;
            this.savingsAccountType = savingsAccountType;
            this.savingsAccountType.btnAddEventHandler(this.btnAdd);
            this.savingsAccountType.btnEditEventHandler(this.btnEdit);
            this.savingsAccountType.btnDeleteEventHandler(this.btnDelete);
            this.savingsAccountType.btnSaveEventHandler(this.btnSave);
            this.savingsAccountType.btnCancelEventHandler(this.btnCancel);
            this.savingsAccountType.btnRetrieveEventHandler(this.btnRetrieve);
            this.savingsAccountType.checkArchived_CheckStateChanged(this.checkArchived);
            this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
            this.savingsAccountType.removeColumns();
            this.savingsAccountType.disableFunction();
            this.savingsAccountType.MdiParent = savingsMenu;
            this.savingsAccountType.Show();
        }

        public void clbMemberTypes()
        {
            memberTypes.Clear();
            DataTable ds = this.savingsAccountTypeModel.selectMemberTypes().Tables[0];
            foreach (DataRow dr in ds.Rows)
            {
                memberTypes.Add(int.Parse(dr["MemberTypeNo"].ToString()), dr["Description"].ToString());
            }
            this.savingsAccountType.populateMemberTypes(memberTypes);
        }

        public void activeMemberTypes(int statusNo)
        {

            ArrayList checkedTypes = new ArrayList();
            DataTable ds = this.savingsAccountTypeModel.selectMemberTypeSavings(statusNo).Tables[0];
            foreach (DataRow dr in ds.Rows)
            {

                foreach (KeyValuePair<int, string> pair in memberTypes)
                {
                    if (int.Parse(dr[0].ToString()) == pair.Key)
                        checkedTypes.Add(pair.Value);
                }
            }
            this.savingsAccountType.toggleCheckedTypes(checkedTypes);

        }

        public void btnAdd(object args, EventArgs e)
        {
            this.savingsAccountType.enableFunction();
            clbMemberTypes();
            this.savingsAccountTypeModel.memberSavingsChecklist.Clear();
            this.savingsAccountType.setStatus();
            isAdd = true;
            TypeId = 0;
        }

        public void btnEdit(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.savingsAccountType.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isAdd = false;
                this.savingsAccountType.enableFunction();
                this.clbMemberTypes();
                this.savingsAccountTypeModel.memberSavingsChecklist.Clear();
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    this.savingsAccountType.showRetrieve();
                }
                else
                {
                    this.savingsAccountType.hideRetrieve();
                }
                TypeId = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString());
                this.activeMemberTypes(TypeId);
                this.savingsAccountType.setTextName(selectedData.Cells["Savings Type Name"].Value.ToString());
                this.savingsAccountType.setTextInitDeposit(selectedData.Cells["Initial Deposit"].Value.ToString());
                this.savingsAccountType.setAccountHolder(int.Parse(selectedData.Cells["No of Account Holders"].Value.ToString()));
                if (bool.Parse(selectedData.Cells["Maintaining Balance"].Value.ToString()))
                {
                    this.savingsAccountType.setMaintainingBalance();
                }
                if (bool.Parse(selectedData.Cells["Interest Rate"].Value.ToString()))
                {
                    this.savingsAccountType.setInterestRates();
                }
                if (bool.Parse(selectedData.Cells["Dormancy"].Value.ToString()))
                {
                    this.savingsAccountType.setDormancy();
                }
                if (bool.Parse(selectedData.Cells["Maximum Withdrawal"].Value.ToString()))
                {
                    this.savingsAccountType.setMaximumWithdrawal();
                }
                if (bool.Parse(selectedData.Cells["Time Deposit"].Value.ToString()))
                {
                    this.savingsAccountType.setTimeDeposit();
                }
                if (bool.Parse(selectedData.Cells["Status"].Value.ToString()))
                {
                    this.savingsAccountType.setStatus();
                }
            }
        }

        public void btnDelete(object args, EventArgs e)
        {
            DataGridViewRow selectedData = this.savingsAccountType.getSelected();
            if (selectedData == null)
            {
                MessageBox.Show("No Row Selected.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Cannot Delete Archives.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String savingsType = selectedData.Cells["Savings Type Name"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete '" + savingsType + "'?", "Savings Account Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TypeId = int.Parse(selectedData.Cells["Account Type Id"].Value.ToString());
                        if (this.savingsAccountTypeModel.deleteSavingsAccount(TypeId) == 1)
                        {
                            MessageBox.Show("Delete Success.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.savingsAccountType.checkArchivedState())
                            {
                                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                                DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.savingsAccountType.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.savingsAccountType.removeColumns();
                                this.savingsAccountType.clearError();
                                this.savingsAccountType.disableFunction();
                            }
                            else
                            {
                                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                                this.savingsAccountType.removeColumns();
                                this.savingsAccountType.clearError();
                                this.savingsAccountType.disableFunction();
                            }
                            isAdd = false;
                            TypeId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isAdd = false;
                            TypeId = 0;
                        }
                    }
                }
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            this.savingsAccountTypeModel.memberSavingsChecklist.Clear();
            this.errorMessage = String.Empty;
            this.savingsAccountType.clearError();
            Boolean checkName = false;
            Boolean checkInitDeposit = false;
            Boolean checkAccountHolder = false;
            Boolean cancel = false;
            if (isAdd)
            {
                this.errorMessage += "Add Failed!" + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                this.errorMessage += "Update Failed!" + Environment.NewLine + Environment.NewLine;
            }
            try
            {
                if (this.savingsAccountType.getTextName() != String.Empty)
                {
                    if (isAdd)
                    {
                        if (this.savingsAccountTypeModel.checkName(this.savingsAccountType.getTextName()) > 0)
                        {
                            this.errorMessage += "Savings Account Type Already Exists.";
                            this.savingsAccountType.setErrorName();
                            checkName = false;
                        }
                        else
                        {
                            this.savingsAccountTypeModel.Name = this.savingsAccountType.getTextName();
                            checkName = true;
                        }
                    }
                    else
                    {
                        this.savingsAccountTypeModel.Name = this.savingsAccountType.getTextName();
                        checkName = true;
                    }
                }
                else
                {
                    this.errorMessage += "Please Specify Name." + Environment.NewLine;
                    this.savingsAccountType.setErrorName();
                    checkName = false;
                }
                if (!cancel)
                {
                    if (this.savingsAccountType.getTextInitDeposit() != 0)
                    {
                        this.savingsAccountTypeModel.InitDeposit = this.savingsAccountType.getTextInitDeposit();
                        checkInitDeposit = true;
                    }
                    else
                    {
                        this.errorMessage += "Please Specify Amount - Initial Deposit." + Environment.NewLine;
                        this.savingsAccountType.setErrorInitDeposit();
                        checkInitDeposit = false;
                    }
                    if (this.savingsAccountType.getAccountHolder() != 0)
                    {
                        this.savingsAccountTypeModel.AccountHolders = this.savingsAccountType.getAccountHolder();
                        checkAccountHolder = true;
                    }
                    else
                    {
                        this.errorMessage += "Please Specify No of Account Holders." + Environment.NewLine;
                        this.savingsAccountType.setErrorAccountHolder();
                        checkAccountHolder = false;
                    }
                    if (this.savingsAccountType.getMaintainingBalance())
                    {
                        this.savingsAccountTypeModel.isMaintainingBalance = 1;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.isMaintainingBalance = 0;
                    }
                    if (this.savingsAccountType.getDormancy())
                    {
                        this.savingsAccountTypeModel.isDormancy = 1;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.isDormancy = 0;
                    }
                    if (this.savingsAccountType.getInterestRates())
                    {
                        this.savingsAccountTypeModel.isInterestRates = 1;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.isInterestRates = 0;
                    }
                    if (this.savingsAccountType.getMaintainingBalance())
                    {
                        this.savingsAccountTypeModel.isMaintainingBalance = 1;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.isMaintainingBalance = 0;
                    }
                    if (this.savingsAccountType.getMaximumWithdrawal())
                    {
                        this.savingsAccountTypeModel.isMaximumWithdrawal = 1;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.isMaximumWithdrawal = 0;
                    }
                    if (this.savingsAccountType.getTimeDeposit())
                    {
                        this.savingsAccountTypeModel.isTimeDeposit = 1;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.isTimeDeposit = 0;
                    }
                    if (this.savingsAccountType.getStatus())
                    {
                        this.savingsAccountTypeModel.Status = 1;
                    }
                    else
                    {
                        this.savingsAccountTypeModel.Status = 0;
                    }
                    CheckedListBox.CheckedItemCollection checkedMemberSavings = this.savingsAccountType.getCheckedTypes();
                    foreach (String s in checkedMemberSavings)
                    {
                        foreach (KeyValuePair<int, string> pair in memberTypes)
                        {
                            if (s.Equals(pair.Value))
                            {
                                Model.MemberSavingsTypeModel ms = new Model.MemberSavingsTypeModel();
                                ms.AccountTypeId = this.savingsAccountTypeModel.getInsertId();
                                ms.MemberTypeNo = pair.Key;
                                this.savingsAccountTypeModel.memberSavingsChecklist.Add(ms);
                            }
                        }
                    }
                    if (checkName && checkInitDeposit && checkAccountHolder)
                    {
                        if (isAdd)
                        {
                            if (this.savingsAccountTypeModel.insertSavingsAccount() == 1)
                            {
                                MessageBox.Show("Add Success.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (this.savingsAccountType.checkArchivedState())
                                {
                                    this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                                    DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                                    int i = 0;
                                    foreach (DataGridViewRow row in dr)
                                    {
                                        if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                        {
                                            this.savingsAccountType.setArchivedColor(i);
                                        }
                                        i++;
                                    }
                                    this.savingsAccountType.removeColumns();
                                    this.savingsAccountType.clearError();
                                    this.savingsAccountType.disableFunction();
                                }
                                else
                                {
                                    this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                                    this.savingsAccountType.removeColumns();
                                    this.savingsAccountType.clearError();
                                    this.savingsAccountType.disableFunction();
                                }
                                isAdd = false;
                                TypeId = 0;
                            }
                            else
                            {
                                MessageBox.Show("Add Failed.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (this.savingsAccountTypeModel.updateSavingsAccount(TypeId) == 1)
                            {
                                MessageBox.Show("Update Success.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (this.savingsAccountType.checkArchivedState())
                                {
                                    this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                                    DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                                    int i = 0;
                                    foreach (DataGridViewRow row in dr)
                                    {
                                        if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                        {
                                            this.savingsAccountType.setArchivedColor(i);
                                        }
                                        i++;
                                    }
                                    this.savingsAccountType.removeColumns();
                                    this.savingsAccountType.clearError();
                                    this.savingsAccountType.disableFunction();
                                }
                                else
                                {
                                    this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                                    this.savingsAccountType.removeColumns();
                                    this.savingsAccountType.clearError();
                                    this.savingsAccountType.disableFunction();
                                }
                                isAdd = false;
                                TypeId = 0;
                            }
                            else
                            {
                                MessageBox.Show("Update Failed.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                this.savingsAccountType.clearError();
                this.savingsAccountType.setErrorInitDeposit();
                this.savingsAccountType.setErrorAccountHolder();
                MessageBox.Show(this.errorMessage + "Invalid Input!" + Environment.NewLine + "Check Red Labels.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.savingsAccountType.disableFunction();
            this.savingsAccountType.clearError();
            isAdd = false;
            TypeId = 0;
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.savingsAccountType.checkArchivedState())
            {
                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if(bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.savingsAccountType.setArchivedColor(i);
                    }
                    i++;
                }
                this.savingsAccountType.removeColumns();
            }
            else
            {
                this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                this.savingsAccountType.removeColumns();
            }
        }

        public void btnRetrieve(object sender, EventArgs e)
        {
            if (this.savingsAccountType.getTextName() != String.Empty)
            {
                if (this.savingsAccountTypeModel.checkName(this.savingsAccountType.getTextName()) > 0)
                {
                    MessageBox.Show("Savings Account Type Already Exists." + Environment.NewLine + "Please Try A Different Name.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.savingsAccountType.setErrorName();
                }
                else
                {
                    this.savingsAccountTypeModel.retrieveSavingsAccount(this.TypeId);
                    MessageBox.Show("Retrieve Success.", "Savings Account Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.savingsAccountType.checkArchivedState())
                    {
                        this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypesAll());
                        DataGridViewRowCollection dr = this.savingsAccountType.getAllRows();
                        int i = 0;
                        foreach (DataGridViewRow row in dr)
                        {
                            if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                            {
                                this.savingsAccountType.setArchivedColor(i);
                            }
                            i++;
                        }
                        this.savingsAccountType.removeColumns();
                        this.savingsAccountType.clearError();
                        this.savingsAccountType.disableFunction();
                    }
                    else
                    {
                        this.savingsAccountType.accountTypeGrid(this.savingsAccountTypeModel.selectAccountTypes());
                        this.savingsAccountType.removeColumns();
                        this.savingsAccountType.clearError();
                        this.savingsAccountType.disableFunction();
                    }
                    isAdd = false;
                    TypeId = 0;
                }
            }
        }
    }
}
