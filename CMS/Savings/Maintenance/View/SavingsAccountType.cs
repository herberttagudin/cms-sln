using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Maintenance.View
{
    public partial class SavingsAccountType : Form
    {
        public SavingsAccountType()
        {
            InitializeComponent();
        }

        public void disableFunction()
        {
            txtName.Clear();
            txtInitDeposit.Clear();
            numAccountHolder.Value = 0;
            checkMaintainingBalance.CheckState = CheckState.Unchecked;
            checkInterestRates.CheckState = CheckState.Unchecked;
            checkMaximumWithdrawal.CheckState = CheckState.Unchecked;
            checkDormancy.CheckState = CheckState.Unchecked;
            checkTimeDeposit.CheckState = CheckState.Unchecked;
            checkStatus.CheckState = CheckState.Unchecked;

            txtName.Enabled = false;
            txtInitDeposit.Enabled = false;
            numAccountHolder.Enabled = false;
            checkMaintainingBalance.Enabled = false;
            checkInterestRates.Enabled = false;
            checkDormancy.Enabled = false;
            checkMaximumWithdrawal.Enabled = false;
            checkTimeDeposit.Enabled = false;
            checkStatus.Enabled = false;
            checkedMemberTypes.Items.Clear();

            btnRetrieve.Visible = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        public void enableFunction()
        {
            txtName.Clear();
            txtInitDeposit.Clear();
            numAccountHolder.Value = 0;
            checkMaintainingBalance.CheckState = CheckState.Unchecked;
            checkInterestRates.CheckState = CheckState.Unchecked;
            checkMaximumWithdrawal.CheckState = CheckState.Unchecked;
            checkDormancy.CheckState = CheckState.Unchecked;
            checkTimeDeposit.CheckState = CheckState.Unchecked;
            checkStatus.CheckState = CheckState.Unchecked;

            txtName.Enabled = true;
            txtInitDeposit.Enabled = true;
            numAccountHolder.Enabled = true;
            checkMaintainingBalance.Enabled = true;
            checkInterestRates.Enabled = true;
            checkMaximumWithdrawal.Enabled = true;
            checkDormancy.Enabled = true;
            checkTimeDeposit.Enabled = true;
            checkStatus.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void setTextName(String s)
        {
            this.txtName.Text = s;
        }

        public String getTextName()
        {
            return this.txtName.Text;
        }

        public void setTextInitDeposit(String s)
        {
            this.txtInitDeposit.Text = s;
        }

        public double getTextInitDeposit()
        {
            return double.Parse(this.txtInitDeposit.Text);
        }

        public void setAccountHolder(int i)
        {
            this.numAccountHolder.Value = i;
        }

        public int getAccountHolder()
        {
            return int.Parse(this.numAccountHolder.Value.ToString());
        }

        public void setMaintainingBalance()
        {
            this.checkMaintainingBalance.CheckState = CheckState.Checked;
        }

        public Boolean getMaintainingBalance()
        {
            if (this.checkMaintainingBalance.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setDormancy()
        {
            this.checkDormancy.CheckState = CheckState.Checked;
        }

        public Boolean getDormancy()
        {
            if (this.checkDormancy.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setInterestRates()
        {
            this.checkInterestRates.CheckState = CheckState.Checked;
        }

        public Boolean getInterestRates()
        {
            if (this.checkInterestRates.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setMaximumWithdrawal()
        {
            this.checkMaximumWithdrawal.CheckState = CheckState.Checked;
        }

        public Boolean getMaximumWithdrawal()
        {
            if (this.checkMaximumWithdrawal.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setTimeDeposit()
        {
            this.checkTimeDeposit.CheckState = CheckState.Checked;
        }

        public Boolean getTimeDeposit()
        {
            if (this.checkTimeDeposit.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setStatus()
        {
            this.checkStatus.CheckState = CheckState.Checked;
        }

        public Boolean getStatus()
        {
            if (this.checkStatus.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void populateMemberTypes(Dictionary<int, string> memberTypes)
        {
            foreach (String s in memberTypes.Values)
            {
                checkedMemberTypes.Items.Add(s);
            }
        }

        public void toggleCheckedTypes(ArrayList activeTypes)
        {

            foreach (String s in activeTypes)
            {
                if (checkedMemberTypes.Items.Contains(s))
                {
                    int i = checkedMemberTypes.Items.IndexOf(s);
                    checkedMemberTypes.SetItemChecked(i, true);
                }
            }
        }

        public CheckedListBox.CheckedItemCollection getCheckedTypes()
        {
            return checkedMemberTypes.CheckedItems;
        }

        public void accountTypeGrid(DataSet ds)
        {
            this.dataAccountType.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataAccountType.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void btnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void btnCancelEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }

        public void btnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void btnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

        public void btnDeleteEventHandler(EventHandler e)
        {
            this.btnDelete.Click += e;
        }

        public void btnRetrieveEventHandler(EventHandler e)
        {
            this.btnRetrieve.Click += e;
        }

        private void txtInitDeposit_KeyPress(object sender, KeyPressEventArgs e)
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
                if (parts.Length > 1 || tb.TextLength > 5)
                {
                    if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtInitDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void setErrorName()
        {
            lblName.ForeColor = Color.Red;
        }

        public void setErrorInitDeposit()
        {
            lblInitDeposit.ForeColor = Color.Red;
        }

        public void setErrorAccountHolder()
        {
            lblAccountHolder.ForeColor = Color.Red;
        }

        public void clearError()
        {
            lblName.ForeColor = SystemColors.ControlText;
            lblInitDeposit.ForeColor = SystemColors.ControlText;
            lblAccountHolder.ForeColor = SystemColors.ControlText;
        }

        public void removeColumns()
        {
            dataAccountType.Columns[0].Visible = false;
            dataAccountType.Columns[4].Visible = false;
            dataAccountType.Columns[5].Visible = false;
            dataAccountType.Columns[6].Visible = false;
            dataAccountType.Columns[7].Visible = false;
            dataAccountType.Columns[8].Visible = false;
            dataAccountType.Columns[10].Visible = false;
            dataAccountType.Columns[11].Visible = false;
            dataAccountType.Columns[12].Visible = false;
        }

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataAccountType.Rows;
        }

        public void setArchivedColor(int i)
        {
            dataAccountType.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataAccountType.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataAccountType.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void showRetrieve()
        {
            this.btnRetrieve.Visible = true;
        }

        public void hideRetrieve()
        {
            this.btnRetrieve.Visible = false;
        }
        
        private void numAccountHolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (numAccountHolder.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void numAccountHolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void checkArchived_CheckStateChanged(EventHandler e)
        {
            this.checkArchived.Click += e;
        }

        public bool checkArchivedState()
        {
            if (this.checkArchived.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dataAccountType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataAccountType.Rows;
            foreach (DataGridViewRow row in rowCollection)
            {
                if (bool.Parse(row.Cells["isArchived"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
                    row.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
                }
                else
                {
                    row.DefaultCellStyle = null;
                }
            }
        }

        private void checkTimeDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTimeDeposit.Checked)
            {
                this.numAccountHolder.Value = 1;
                this.numAccountHolder.Enabled = false;
            }
            else
            {
                this.numAccountHolder.Value = 0;
                this.numAccountHolder.Enabled = true;
            }
        }
    }
}
