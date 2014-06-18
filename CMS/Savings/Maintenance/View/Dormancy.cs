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
    public partial class Dormancy : Form
    {
        public Dormancy()
        {
            InitializeComponent();
        }

        public void disableFunction()
        {
            comboAccountType.SelectedIndex = -1;
            comboAccountType.Enabled = false;
            txtPenalty.Clear();
            comboPenalty.SelectedIndex = -1;
            numDormancy.Value = 0;
            comboDormancy.SelectedIndex = -1;
            numCharge.Value = 0;
            comboCharge.SelectedIndex = -1;
            Status.CheckState = CheckState.Unchecked;

            txtPenalty.Enabled = false;
            comboPenalty.Enabled = false;
            numDormancy.Enabled = false;
            comboDormancy.Enabled = false;
            numCharge.Enabled = false;
            comboCharge.Enabled = false;

            Status.Enabled = false;
            btnSave.Enabled = false;
            lblAccountType.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
        }

        public void enableFunction()
        {
            comboAccountType.SelectedIndex = -1;
            comboAccountType.Enabled = true;
            txtPenalty.Clear();
            comboPenalty.SelectedIndex = -1;
            numDormancy.Value = 0;
            comboDormancy.SelectedIndex = -1;
            numCharge.Value = 0;
            comboCharge.SelectedIndex = -1;
            Status.CheckState = CheckState.Unchecked;

            txtPenalty.Enabled = true;
            comboPenalty.Enabled = true;
            numDormancy.Enabled = true;
            comboDormancy.Enabled = true;
            numCharge.Enabled = true;
            comboCharge.Enabled = true;

            Status.Enabled = true;
            btnSave.Enabled = true;
            lblAccountType.Enabled = true;

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

        public void setTextPenalty(String s)
        {
            this.txtPenalty.Text = s;
        }

        public double getTextPenalty()
        {
            return double.Parse(this.txtPenalty.Text.ToString());
        }

        public void setComboPenalty(String s)
        {
            this.comboPenalty.SelectedItem = s;
        }

        public String getComboPenalty()
        {
            if (this.comboPenalty.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboPenalty.SelectedItem.ToString();
            }
        }

        public void setNumDormancy(int i)
        {
            this.numDormancy.Value = i;
        }

        public int getNumDormancy()
        {
            return int.Parse(this.numDormancy.Value.ToString());
        }

        public void setComboDormancy(String s)
        {
            this.comboDormancy.SelectedItem = s;
        }

        public String getComboDormancy()
        {
            if (this.comboDormancy.SelectedIndex == -1)
            {
                return String.Empty;
            }
            else
            {
                return this.comboDormancy.SelectedItem.ToString();
            }
        }

        public void setNumCharge(int i)
        {
            this.numCharge.Value = i;
        }

        public int getNumCharge()
        {
            return int.Parse(this.numCharge.Value.ToString());
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
            {
                return this.comboCharge.SelectedItem.ToString();
            }
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

        public void setBtnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void setBtnCancelEventHandler(EventHandler e)
        {
            this.lblAccountType.Click += e;
        }

        public void dormancyGrid(DataSet ds)
        {
            this.dataDormancy.DataSource = ds.Tables[0];
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataDormancy.SelectedRows[0];
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

        private void txtPenalty_KeyPress(object sender, KeyPressEventArgs e)
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

        public void setErrorDormancy()
        {
            lblDormancy.ForeColor = Color.Red;
        }

        public void setErrorPenalty()
        {
            lblPenalty.ForeColor = Color.Red;
        }

        public void setErrorEvery()
        {
            lblEvery.ForeColor = Color.Red;
        }

        public void clearError()
        {
            lblAccountType.ForeColor = SystemColors.ControlText;
            lblDormancy.ForeColor = SystemColors.ControlText;
            lblPenalty.ForeColor = SystemColors.ControlText;
            lblEvery.ForeColor = SystemColors.ControlText;
        }

        public void removeColumns()
        {
            dataDormancy.Columns[0].Visible = false;
            dataDormancy.Columns[6].Visible = false;
            dataDormancy.Columns[7].Visible = false;
            dataDormancy.Columns[8].Visible = false;
        }

        private void numDormancy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numCharge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (numCharge.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void numDormancy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (numDormancy.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void txtPenalty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataDormancy.Rows;
        }

        public void setArchivedColor(int i)
        {
            dataDormancy.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataDormancy.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataDormancy.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
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

        private void dataDormancy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataDormancy.Rows;
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
