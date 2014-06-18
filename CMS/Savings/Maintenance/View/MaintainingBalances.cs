using System;
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
    public partial class MaintainingBalances : Form
    {
        public MaintainingBalances()
        {
            InitializeComponent();
        }

        public void disableFunction()
        {
            comboAccountType.SelectedIndex = -1;
            comboAccountType.Enabled = false;
            txtMaintaningBalance.Clear();
            txtMaintaningBalance.Enabled = false;
            txtCharge.Clear();
            txtCharge.Enabled = false;
            comboCharge.SelectedIndex = -1;
            comboCharge.Enabled = false;
            numChargeDuration.Value = 0;
            numChargeDuration.Enabled = false;
            comboChargeDuration.SelectedIndex = -1;
            comboChargeDuration.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            checkStatus.CheckState = CheckState.Unchecked;
            checkStatus.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
        }

        public void enableFunction()
        {
            comboAccountType.SelectedIndex = -1;
            comboAccountType.Enabled = true;
            txtMaintaningBalance.Clear();
            txtMaintaningBalance.Enabled = true;
            txtCharge.Clear();
            txtCharge.Enabled = true;
            comboCharge.SelectedIndex = -1;
            comboCharge.Enabled = true;
            numChargeDuration.Value = 0;
            numChargeDuration.Enabled = true;
            comboChargeDuration.SelectedIndex = -1;
            comboChargeDuration.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            checkStatus.CheckState = CheckState.Unchecked;
            checkStatus.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
        }

        public void disableType()
        {
            this.comboAccountType.Enabled = false;
        }

        public void initAccountType(DataSet ds)
        {
            this.comboAccountType.DataSource = ds.Tables[0];
            this.comboAccountType.ValueMember = "AccountTypeId";
            this.comboAccountType.DisplayMember = "SavingsTypeName";
        }

        public void setAccountType(String s)
        {
            this.comboAccountType.DataSource = null;
            this.comboAccountType.Items.Add(s);
            this.comboAccountType.SelectedItem = s;
        }

        public int getAccountType()
        {
            if (this.comboAccountType.SelectedIndex == -1)
            {
                return 0;
            }
            else
            {
                return int.Parse(this.comboAccountType.SelectedValue.ToString());
            }
        }

        public void setMaintainingBalance(String s)
        {
            this.txtMaintaningBalance.Text = s;
        }

        public double getMaintainingBalance()
        {
            return double.Parse(this.txtMaintaningBalance.Text);
        }

        public void setCharge(String s)
        {
            this.txtCharge.Text = s;
        }

        public double getCharge()
        {
            return double.Parse(this.txtCharge.Text);
        }
        
        public void setComboCharge(String s)
        {
            this.comboCharge.SelectedItem = s;
        }

        public String getComboCharge()
        {
            if (this.comboCharge.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboCharge.SelectedItem.ToString();
            }
        }

        public void setNumChargeDuration(int i)
        {
            this.numChargeDuration.Value = i;
        }

        public int getNumChargeDuration()
        {
            return int.Parse(this.numChargeDuration.Value.ToString());
        }

        public void setComboChargeDuration(String s)
        {
            this.comboChargeDuration.SelectedItem = s;
        }

        public String getComboChargeDuration()
        {
            if (this.comboChargeDuration.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboChargeDuration.SelectedItem.ToString();
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

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setBtnCancelEventHandler(EventHandler e)
        {
            this.btnCancel.Click += e;
        }

        public void maintainingBalanceGrid(DataSet ds)
        {
            this.dataMaintaningBalance.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataMaintaningBalance.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

        private void txtCharge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMaintaningBalance_KeyPress(object sender, KeyPressEventArgs e)
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

        public void setErrorAccountType()
        {
            lblAccountType.ForeColor = Color.Red;
        }

        public void setErrorMaintainingBalance()
        {
            lblMaintainingBalance.ForeColor = Color.Red;
        }

        public void setErrorPenalty()
        {
            lblPenalty.ForeColor = Color.Red;
        }

        public void setErrorCharge()
        {
            lblCharge.ForeColor = Color.Red;
        }

        public void clearError()
        {
            lblAccountType.ForeColor = SystemColors.ControlText;
            lblMaintainingBalance.ForeColor = SystemColors.ControlText;
            lblPenalty.ForeColor = SystemColors.ControlText;
            lblCharge.ForeColor = SystemColors.ControlText;
        }

        public void removeColumns()
        {
            dataMaintaningBalance.Columns[0].Visible = false;
            dataMaintaningBalance.Columns[6].Visible = false;
            dataMaintaningBalance.Columns[7].Visible = false;
            dataMaintaningBalance.Columns[8].Visible = false;
        }

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataMaintaningBalance.Rows;
        }

        public void setArchivedColor(int i)
        {
            dataMaintaningBalance.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataMaintaningBalance.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataMaintaningBalance.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        private void numChargeDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numChargeDuration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (numChargeDuration.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void txtCharge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtMaintaningBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
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

        private void dataMaintaningBalance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataMaintaningBalance.Rows;
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
    }
}
