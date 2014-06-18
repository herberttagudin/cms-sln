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
    public partial class MaximumWithdrawal : Form
    {
        public MaximumWithdrawal()
        {
            InitializeComponent();
        }

        public void enableFunction()
        {
            this.txtMaxWith.Clear();
            this.comboAccountType.SelectedIndex = -1;
            this.Status.CheckState = CheckState.Unchecked;

            this.txtMaxWith.Enabled = true;
            this.comboAccountType.Enabled = true;
            this.Status.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
        }

        public void disableFunction()
        {
            this.txtMaxWith.Clear();
            this.comboAccountType.SelectedIndex = -1;
            this.Status.CheckState = CheckState.Unchecked;

            this.txtMaxWith.Enabled = false;
            this.comboAccountType.Enabled = false;
            this.Status.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
        }

        public void maxWithGrid(DataSet ds)
        {
            this.dataMaxWith.DataSource = ds.Tables[0];
        }

        public void disableType()
        {
            this.comboAccountType.Enabled = false;
        }

        public DataGridViewRow getSelected()
        {
            try
            {
                return this.dataMaxWith.SelectedRows[0];
            }
            catch (Exception)
            {
                return null;
            }
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

        public void setMaxWith(String s)
        {
            this.txtMaxWith.Text = s;
        }

        public double getMaxWith()
        {
            return double.Parse(this.txtMaxWith.Text);
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

        private void txtMaxWith_KeyPress(object sender, KeyPressEventArgs e)
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

        public void setErrorMaxWith()
        {
            lblMaxWith.ForeColor = Color.Red;
        }

        public void clearError()
        {
            lblAccountType.ForeColor = SystemColors.ControlText;
            lblMaxWith.ForeColor = SystemColors.ControlText;
        }

        private void txtMaxWith_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void removeColumns()
        {
            dataMaxWith.Columns[0].Visible = false;
            dataMaxWith.Columns[4].Visible = false;
            dataMaxWith.Columns[5].Visible = false;
            dataMaxWith.Columns[6].Visible = false;
        }

        public DataGridViewRowCollection getAllRows()
        {
            return this.dataMaxWith.Rows;
        }

        public void setArchivedColor(int i)
        {
            dataMaxWith.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            dataMaxWith.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataMaxWith.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
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

        private void dataMaxWith_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataMaxWith.Rows;
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
