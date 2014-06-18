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
    public partial class InterestRates : Form
    {
        public InterestRates()
        {
            InitializeComponent();
        }

        public void disableFunction()
        {
            this.comboAccountType.SelectedIndex = -1;
            this.txtInterestRate.Clear();
            this.comboInterestRate.SelectedIndex = -1;
            this.txtMinBal.Clear();
            this.checkMaximum.CheckState = CheckState.Unchecked;
            this.txtMaxBal.Clear();
            this.Status.CheckState = CheckState.Unchecked;

            this.comboAccountType.Enabled = false;
            this.txtInterestRate.Enabled = false;
            this.comboInterestRate.Enabled = false;
            this.txtMinBal.Enabled = false;
            this.checkMaximum.Enabled = false;
            this.txtMaxBal.Enabled = false;
            this.Status.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
        }

        public void enableFunction()
        {
            this.comboAccountType.SelectedIndex = -1;
            this.txtInterestRate.Clear();
            this.comboInterestRate.SelectedIndex = -1;
            this.txtMinBal.Clear();
            this.checkMaximum.CheckState = CheckState.Unchecked;
            this.txtMaxBal.Clear();
            this.Status.CheckState = CheckState.Unchecked;

            this.comboAccountType.Enabled = true;
            this.txtInterestRate.Enabled = true;
            this.comboInterestRate.Enabled = true;
            this.txtMinBal.Enabled = true;
            this.checkMaximum.Enabled = true;
            this.Status.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
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

        public void setInterestRates(String s)
        {
            this.txtInterestRate.Text = s;
        }

        public double getInterestRates()
        {
            return double.Parse(this.txtInterestRate.Text.ToString());
        }

        public void setInterestRatesSchedule(String s)
        {
            this.comboInterestRate.SelectedItem = s;
        }

        public String getInterestRatesSchedule()
        {
            if (this.comboInterestRate.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboInterestRate.SelectedItem.ToString();
            }
        }

        public void setMinimumBalance(String s)
        {
            this.txtMinBal.Text = s;
        }

        public double getMinimumBalance()
        {
            return double.Parse(this.txtMinBal.Text.ToString());
        }

        private void checkMaximum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMaximum.CheckState == CheckState.Checked)
            {
                this.txtMaxBal.Enabled = true;
            }
            else
            {
                this.txtMaxBal.Enabled = false;
            }
        }

        public void setCheckMaxBal(String s)
        {
            this.checkMaximum.CheckState = CheckState.Checked;
            this.txtMaxBal.Text = s;
        }

        public Boolean getCheckMaximumBalance()
        {
            if (this.checkMaximum.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double getMaximumBalance()
        {
            return double.Parse(this.txtMaxBal.Text.ToString());
        }

        public void setStatus()
        {
            this.Status.CheckState = CheckState.Checked;
        }

        public Boolean getStatus()
        {
            if (this.Status.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void interestRatesGrid(DataSet ds)
        {
            this.dataInterestRates.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataInterestRates.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
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

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }

        private void txtMinBal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMaxBal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
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
                if (parts.Length > 1 || tb.TextLength > 2)
                {
                    if (parts[0].Length > 3 || parts[1].Length > 2 || parts.Length > 2)
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

        public void setErrorInterestRate()
        {
            lblInterestRate.ForeColor = Color.Red;
        }

        public void setErrorPer()
        {
            lblPer.ForeColor = Color.Red;
        }

        public void setErrorMinimum()
        {
            lblMinimum.ForeColor = Color.Red;
        }

        public void setErrorMaximum()
        {
            checkMaximum.ForeColor = Color.Red;
        }

        public void clearError()
        {
            lblAccountType.ForeColor = SystemColors.ControlText;
            lblInterestRate.ForeColor = SystemColors.ControlText;
            lblPer.ForeColor = SystemColors.ControlText;
            lblMinimum.ForeColor = SystemColors.ControlText;
            checkMaximum.ForeColor = SystemColors.ControlText;
        }

        public void removeColumns()
        {
            dataInterestRates.Columns[0].Visible = false;
            dataInterestRates.Columns[1].Visible = false;
            dataInterestRates.Columns[6].Visible = false;
            dataInterestRates.Columns[7].Visible = false;
            dataInterestRates.Columns[8].Visible = false;
        }

        private void txtInterestRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtMinBal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtMaxBal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dataInterestRates_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataInterestRates.Rows;
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

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataInterestRates.Rows;
        }

        public void setArchivedColor(int i)
        {
            dataInterestRates.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataInterestRates.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataInterestRates.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void txtSearch_TextChanged(EventHandler e)
        {
            this.txtSearch.TextChanged += e;
        }

        public String getSearch()
        {
            return this.txtSearch.Text;
        }
    }
}
