using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.Controller
{
    class MemberTypesController
    {
        Maintenance.Model.MemberTypesModel memberTypesModel;
        Maintenance.View.MemberTypes memberTypes;

        int TypeNo = 0;
        String TypeName = String.Empty;
        String oldName = String.Empty;
        Boolean isAdd = false;

        public MemberTypesController(Maintenance.Model.MemberTypesModel memberTypesModel, Maintenance.View.MemberTypes memberTypes, Loan_Management.LoanManagementMenu loanManagementMenu)
        {
            this.memberTypesModel = memberTypesModel;
            this.memberTypes = memberTypes;
            this.memberTypes.setBtnAddEventHandler(this.btnAdd);
            this.memberTypes.setBtnCancelEventHandler(this.btnCancel);
            this.memberTypes.setBtnDeleteEventHandler(this.btnDelete);
            this.memberTypes.setBtnEditEventHandler(this.btnEdit);
            this.memberTypes.setBtnRetrieveEventHandler(this.btnRetrieve);
            this.memberTypes.checkArchived_CheckStateChanged(this.checkArchived);
            this.memberTypes.setBtnSaveEventHandler(this.btnSave);
            this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypes());
            this.memberTypes.disableFunction();
            this.memberTypes.MdiParent = loanManagementMenu;
            this.memberTypes.Show();
        }

        public void btnAdd(object args, EventArgs e)
        {
            this.memberTypes.enableFunction();
            this.memberTypes.setCheckStatus();
            isAdd = true;
            TypeNo = 0;
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.memberTypes.disableFunction();
            isAdd = false;
            TypeNo = 0;
        }

        public void btnDelete(object args, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedData = this.memberTypes.getSelected();

                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    MessageBox.Show("Cannot Delete Archives.", "Member Types", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String memberType = selectedData.Cells["Type Name"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete '" + memberType + "'?", "Member Types", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TypeNo = int.Parse(selectedData.Cells["Type No"].Value.ToString());
                        if (memberTypesModel.deleteMemberTypes(TypeNo) == 1)
                        {
                            MessageBox.Show("Delete Success.", "Member Types", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.memberTypes.checkArchivedState())
                            {
                                this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypesAll());
                                DataGridViewRowCollection dr = this.memberTypes.getAllRows();
                                int i = 0;
                                foreach (DataGridViewRow row in dr)
                                {
                                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                    {
                                        this.memberTypes.setArchivedColor(i);
                                    }
                                    i++;
                                }
                                this.memberTypes.disableFunction();
                            }
                            else
                            {
                                this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypes());
                                this.memberTypes.disableFunction();
                            } 
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed.", "Member Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        TypeNo = 0;
                    }
                }
            }
            catch (Exception) {

                MessageBox.Show("No rows were selected.", "Member Types", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void btnEdit(object args, EventArgs e)
        {
            
            try
            {
                
                DataGridViewRow selectedData = this.memberTypes.getSelected();
                memberTypes.enableFunction();
                isAdd = false;
                TypeNo = int.Parse(selectedData.Cells["Type No"].Value.ToString());
                TypeName = selectedData.Cells["Type Name"].Value.ToString();
                
                bool serviceLoan = bool.Parse(selectedData.Cells["Loan"].Value.ToString());
                bool serviceSavings = bool.Parse(selectedData.Cells["Savings"].Value.ToString());
                bool serviceShareCapital = bool.Parse(selectedData.Cells["Share Capital"].Value.ToString());
                bool Status = bool.Parse(selectedData.Cells["Status"].Value.ToString());

                if (Status)
                {
                    memberTypes.setCheckStatus();
                }

                if (serviceLoan)
                {
                    memberTypes.setCheckLoan();
                }

                if (serviceSavings)
                {
                    memberTypes.setCheckSavings();
                }

                if (serviceShareCapital)
                {
                    memberTypes.setCheckShareCapital();
                }

                if (int.Parse(selectedData.Cells["Minimum Age"].Value.ToString()) != 0)
                {
                    memberTypes.setCheckMinAge();
                    memberTypes.setNumberMinAge(int.Parse(selectedData.Cells["Minimum Age"].Value.ToString()));
                }
                if (int.Parse(selectedData.Cells["Maximum Age"].Value.ToString()) != 0)
                {
                    memberTypes.setCheckMaxAge();
                    memberTypes.setNumberMaxAge(int.Parse(selectedData.Cells["Maximum Age"].Value.ToString()));
                }

                if (bool.Parse(selectedData.Cells["isArchived"].Value.ToString()))
                {
                    this.memberTypes.showRetrieve();
                }
                else
                {
                    this.memberTypes.hideRetrieve();
                }
                memberTypes.setTypeName(TypeName);
                oldName = TypeName;
            }
            catch (Exception) {
                MessageBox.Show("No rows were selected.", "Member Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                memberTypes.disableFunction();
            }
        }

        public void btnSave(object args, EventArgs e)
        {
            TypeName = memberTypes.getTypeName();
            String Availability = String.Empty;
            String errorMessage = String.Empty;
            int ServiceLoan = 0;
            int ServiceSavings = 0;
            int ServiceShareCapital = 0;

            if (isAdd)
                errorMessage += "Add Failed!" + Environment.NewLine + Environment.NewLine;
            else
                errorMessage += "Update Failed!" + Environment.NewLine + Environment.NewLine;

            if (memberTypes.getLoan())
            {
                ServiceLoan = 1;
            }
            if (memberTypes.getSavings())
            {
                ServiceSavings = 1;
            }
            if (memberTypes.getShareCapital())
            {
                ServiceShareCapital = 1;
            }
            int MinAge = 0;
            int MaxAge = 0;
            if (memberTypes.getMinAgeChecked())
            {
                MinAge = memberTypes.getMinAge();
            }
            if (memberTypes.getMaxAgeChecked())
            {
                MaxAge = memberTypes.getMaxAge();
            }
           
            int Status = 0;
            if (memberTypes.checkStatusChecked())
            {
                Status = 1;
            }

            this.memberTypes.resetServices();
            this.memberTypes.resetTypeName();
            bool insertError = false;

            if (TypeName == String.Empty)
            {
                insertError = true;
                memberTypes.errorTypeName();
                errorMessage += "Please Specify Name." + Environment.NewLine;

            }


            else
            {
                try
                {
                    SqlDataReader dr;
                    if (isAdd)
                        dr = memberTypesModel.selectMemberTypeNames(TypeName); //checks all names if it exists
                    else  dr = memberTypesModel.selectMemberTypeNames(TypeName,oldName); //checks all names excluding itself

                    while (dr.Read())
                    {
                        if (int.Parse(dr[0].ToString()) > 0)
                        {
                            insertError = true;
                            memberTypes.errorTypeName();
                            errorMessage += "'" + TypeName + "' Already Exists.";
                        }
                    }
                }
                catch (InvalidOperationException io) {
                    MessageBox.Show(io.Message);
                }
            }


            if (ServiceLoan == 0 && ServiceSavings == 0 && ServiceShareCapital == 0)
            {
                insertError = true;
                memberTypes.errorServices();
                errorMessage += "Specify at least One Service." + Environment.NewLine;

            }

            if (isAdd)
            {
                if (!(insertError))
                {
                    if (this.memberTypesModel.insertMemberType(TypeName, ServiceLoan, ServiceSavings, ServiceShareCapital, MinAge, MaxAge, Status) != 0)
                    {
                        MessageBox.Show("Add Success.", "Member Types", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.memberTypes.checkArchivedState())
                        {
                            this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypesAll());
                            DataGridViewRowCollection dr = this.memberTypes.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.memberTypes.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.memberTypes.disableFunction();
                        }
                        else
                        {
                            this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypes());
                            this.memberTypes.disableFunction();
                        } 
              
                    }
                    else
                    {
                        MessageBox.Show("Add Failed.", "Member Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(errorMessage, "Member Types", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!(insertError))
                {
                    if (this.memberTypesModel.updateMemberType(TypeNo, TypeName, ServiceLoan, ServiceSavings, ServiceShareCapital, MinAge, MaxAge, Status) != 0 && !(insertError))
                    {
                        MessageBox.Show("Update Success.", "Update Member Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.memberTypes.checkArchivedState())
                        {
                            this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypesAll());
                            DataGridViewRowCollection dr = this.memberTypes.getAllRows();
                            int i = 0;
                            foreach (DataGridViewRow row in dr)
                            {
                                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                                {
                                    this.memberTypes.setArchivedColor(i);
                                }
                                i++;
                            }
                            this.memberTypes.disableFunction();
                        }
                        else
                        {
                            this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypes());
                            this.memberTypes.disableFunction();
                        } 
                        TypeNo = 0;
                    }
                    else
                    {
                        MessageBox.Show("Update Failed.", "Update Member Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        public void checkArchived(object sender, EventArgs e)
        {
            if (this.memberTypes.checkArchivedState())
            {
                this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypesAll());
                DataGridViewRowCollection dr = this.memberTypes.getAllRows();
                int i = 0;
                foreach (DataGridViewRow row in dr)
                {
                    if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                    {
                        this.memberTypes.setArchivedColor(i);
                    }
                    i++;
                }
            }
            else
            {
                this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypes());
            }
        }

        public void btnRetrieve(object sender, EventArgs e)
        {

            bool retrieveError = false;
            SqlDataReader sdr;
            sdr = memberTypesModel.selectMemberTypeNames(TypeName);
            while (sdr.Read())
            {
                if (int.Parse(sdr[0].ToString()) > 0)
                {
                    retrieveError = true;
                    memberTypes.errorTypeName();
                    MessageBox.Show("'" + TypeName + "' Already Exists." + Environment.NewLine + "It Cannot be Retrieved at the Moment.","Member Type",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (!retrieveError)
            {
                this.memberTypesModel.retrieveMemberType(this.TypeNo);
                MessageBox.Show("Retrieve Success.", "Member Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.memberTypes.checkArchivedState())
                {
                    this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypesAll());
                    DataGridViewRowCollection dr = this.memberTypes.getAllRows();
                    int i = 0;
                    foreach (DataGridViewRow row in dr)
                    {
                        if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                        {
                            this.memberTypes.setArchivedColor(i);
                        }
                        i++;
                    }
                    this.memberTypes.disableFunction();
                }
                else
                {
                    this.memberTypes.memberTypeGrid(this.memberTypesModel.selectMemberTypes());
                    this.memberTypes.disableFunction();
                }
                isAdd = false;
                TypeNo = 0;
            }
        }

    }
}
