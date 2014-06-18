using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.View
{
    public partial class ShareCapitalContribution : Form
    {
        public ShareCapitalContribution()
        {
            InitializeComponent();
        }

        public void enableFunction()
        {
            this.comboAccountType.SelectedIndex = -1;
            this.txtContribution.Clear();
            this.comboContribution.SelectedIndex = -1;
            this.txtPenalty.Clear();
            this.comboCharge.SelectedIndex = -1;
            this.Status.CheckState = CheckState.Unchecked;

            this.comboAccountType.Enabled = true;
            this.txtContribution.Enabled = true;
            this.comboContribution.Enabled = true;
            this.txtPenalty.Enabled = true;
            this.comboCharge.Enabled = true;
            this.Status.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;

            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
        }

        public void disableFunction()
        {
            this.comboAccountType.SelectedIndex = -1;
            this.txtContribution.Clear();
            this.comboContribution.SelectedIndex = -1;
            this.txtPenalty.Clear();
            this.comboCharge.SelectedIndex = -1;
            this.Status.CheckState = CheckState.Unchecked;

            this.comboAccountType.Enabled = false;
            this.txtContribution.Enabled = false;
            this.comboContribution.Enabled = false;
            this.txtPenalty.Enabled = false;
            this.comboCharge.Enabled = false;
            this.Status.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
        }




       
        public void disableType()
        {
            this.comboAccountType.Enabled = false;
        }

        public int initAccountType(DataSet ds)
        {
            int i = 0;
            this.comboAccountType.DataSource = ds.Tables[0];
            this.comboAccountType.ValueMember = "MemberTypeNo";
            this.comboAccountType.DisplayMember = "Description";

            if (comboAccountType.Items.Count == 0) { i = 1; }
            return i;
        }

        public void setAccountType(String s)
        {
            this.comboAccountType.Text = s;
        }

        public int getAccountType()
        {
            return int.Parse(this.comboAccountType.SelectedValue.ToString());
        }

        public void setCapitalContrib(String s)
        {
            this.txtContribution.Text = s;
        }

        public double getCapitalContrib()
        {
            return double.Parse(this.txtContribution.Text.ToString());
        }

        public void setComboContrib(String s)
        {
            this.comboContribution.SelectedItem = s;
        }

        public String getComboContrib()
        {
            return this.comboContribution.SelectedItem.ToString();
        }

        public void setPenalty(String s)
        {
            this.txtPenalty.Text = s;
        }

        public double getPenalty()
        {
            return double.Parse(this.txtPenalty.Text.ToString());
        }

        public void setComboCharge(String s)
        {
            this.comboCharge.SelectedItem = s;
        }

        public String getComboCharge()
        {
            return this.comboCharge.Text.ToString();
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
            this.btnCancel.Click += e;
        }

        public void capitalContributionGrid(DataSet ds)
        {
            this.dataCapitalContribution.DataSource = ds.Tables[0];
            this.dataCapitalContribution.Columns[0].Visible = false;
            this.dataCapitalContribution.Columns[1].Visible = false;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataCapitalContribution.SelectedRows[0];
        }

        public void setBtnAddEventHandler(EventHandler e)
        {
            this.btnAdd.Click += e;
        }

        public void setBtnEditEventHandler(EventHandler e)
        {
            this.btnEdit.Click += e;
        }
        public void setAllLabelsToBlack()
        {
            this.lblMemberType.ForeColor = System.Drawing.Color.Black;
            this.lblCapitalContrib.ForeColor = System.Drawing.Color.Black;
            this.lblPenalty.ForeColor = System.Drawing.Color.Black;
            this.lblBasis.ForeColor = System.Drawing.Color.Black;
           
        }

        private void txtContribution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtContribution_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPenalty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
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
                if (parts.Length > 1 || tb.TextLength > 5)
                {
                    if (parts[0].Length > 6 || parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
