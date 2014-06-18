using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class OpenAccount : Form
    {
        public OpenAccount()
        {
            InitializeComponent();
        }

        public void txtSearchTextChanged(EventHandler e)
        {
            this.txtSearch.TextChanged += e;
        }

        public void btnClearEventHandler(EventHandler e)
        {
            this.btnClear.Click += e;
        }

        public void btnSaveEventHandler(EventHandler e)
        {
            this.btnSave.Click += e;
        }

        public void btnForwardEventHandler(EventHandler e)
        {
            this.btnForward.Click += e;
        }

        public void btnBackwardEventHandler(EventHandler e)
        {
            this.btnBackward.Click += e;
        }

        public void setDataMember(DataSet ds)
        {
            if (ds == null)
            {
                this.dataMember.DataSource = null;
            }
            else
            {
                this.dataMember.DataSource = ds.Tables[0];
            }
        }

        public void setDataDepositor(DataSet ds)
        {
            if (ds == null)
            {
                this.dataDepositor.DataSource = null;
            }
            else
            {
                this.dataDepositor.DataSource = ds.Tables[0];
            }
        }
        
        public DataGridViewRow getSelectedMember()
        {
            try
            {
                return this.dataMember.SelectedRows[0];
            }
            catch(Exception)
            {
                return null;
            }
        }

        public DataGridViewRow getSelectedDepositor()
        {
            try
            {
                return this.dataDepositor.SelectedRows[0];
            }
            catch(Exception)
            {
                return null;
            }
        }

        public void addDataDepositor(DataGridViewRow row)
        {
            DataTable table = new DataTable();
            table.Columns.Add("AccountNo", typeof(String));
            table.Columns.Add("Member Name", typeof(String));

            foreach (DataGridViewRow rows in dataDepositor.Rows)
            {
                DataRow dr = table.NewRow();
                dr[0] = rows.Cells[0].Value.ToString();
                dr[1] = rows.Cells[1].Value.ToString();
                table.Rows.Add(dr);
            }

            DataRow newdr = table.NewRow();
            newdr[0] = row.Cells[0].Value.ToString();
            newdr[1] = row.Cells[1].Value.ToString();
            table.Rows.Add(newdr);

            dataDepositor.DataSource = table;
            dataMember.Rows.Remove(row);
        }

        public void addDataMember(DataGridViewRow row)
        {
            DataTable table = new DataTable();
            table.Columns.Add("AccountNo", typeof(String));
            table.Columns.Add("Member Name", typeof(String));

            foreach (DataGridViewRow rows in dataMember.Rows)
            {
                DataRow dr = table.NewRow();
                dr[0] = rows.Cells[0].Value.ToString();
                dr[1] = rows.Cells[1].Value.ToString();
                table.Rows.Add(dr);
            }

            DataRow newdr = table.NewRow();
            newdr[0] = row.Cells[0].Value.ToString();
            newdr[1] = row.Cells[1].Value.ToString();
            table.Rows.Add(newdr);

            dataMember.DataSource = table;
            dataDepositor.Rows.Remove(row);
        }
        
        public int getDepositorRowCount()
        {
            return this.dataDepositor.Rows.Count;
        }

        public DataGridViewRowCollection getDepositors()
        {
            return this.dataDepositor.Rows;
        }

        public void filterMember()
        {
            int i = 0;
            foreach (DataGridViewRow rows in dataMember.Rows)
            {
                dataMember.CurrentCell = null;
                dataMember.Rows[i].Visible = true;
                i++;
            }
            i = 0;
            foreach (DataGridViewRow rows in dataMember.Rows)
            {
                if (rows.Cells[1].Value.ToString().Contains(txtSearch.Text))
                {

                }
                else
                {
                    dataMember.CurrentCell = null;
                    dataMember.Rows[i].Visible = false;
                }
            }
            i++;
        }

        public String getSearch()
        {
            return this.txtSearch.Text;
        }

        public void initAccountType(DataSet ds)
        {
            this.comboAccountType.DataSource = ds.Tables[0];
            this.comboAccountType.DisplayMember = "SavingsType";
            this.comboAccountType.ValueMember = "TypeId";
            this.comboAccountType.SelectedIndex = -1;
        }

        public int getComboAccountType()
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

        public void setAccountTypeSelectedItemChanged(EventHandler e)
        {
            this.comboAccountType.SelectedIndexChanged += e;
        }

        public void setAccountHolder(String s)
        {
            this.txtAccountHolder.Text = s;
        }

        public int getAccountHolder()
        {
            return int.Parse(this.txtAccountHolder.Text.ToString());
        }

        public void setAccountNo(String s)
        {
            this.txtAccountNo.Text = s;
        }

        public String getAccountNo()
        {
            return this.txtAccountNo.Text;
        }

        public void enableInitialDeposit()
        {
            this.txtInitialDeposit.Enabled = true;
        }

        public void disableInitialDeposit()
        {
            this.txtInitialDeposit.Enabled = false;
        }

        public double getInitialDeposit()
        {
            return double.Parse(this.txtInitialDeposit.Text.ToString());
        }

        public void setPassbookNo(String s)
        {
            this.txtPassbook.Text = s;
        }

        public int getPassbookNo()
        {
            return int.Parse(this.txtPassbook.Text.ToString());
        }

        public String getWithdrawMode()
        {
            if (radioAnd.Checked)
            {
                return "And";
            }
            else if (radioOr.Checked)
            {
                return "Or";
            }
            else
            {
                return String.Empty;
            }
        }

        public void enableWithdrawMode()
        {
            this.groupWithdrawMode.Enabled = true;
        }

        public void disableWithdrawMode()
        {
            this.groupWithdrawMode.Enabled = false;
        }

        public void reset(String accountNo, String passbookNo)
        {
            this.dataMember.DataSource = null;
            this.dataDepositor.DataSource = null;
            this.comboAccountType.SelectedIndex = -1;
            this.groupWithdrawMode.Enabled = false;
            this.radioAnd.Checked = false;
            this.radioOr.Checked = false;
            this.txtInitialDeposit.Clear();
            this.txtAccountNo.Text = accountNo;
            this.txtPassbook.Text = passbookNo;
            this.txtSearch.Clear();
        }

        public void setErrorAccountType()
        {
            this.lblAccountType.ForeColor = Color.Red;
        }

        public void setErrorDepositor()
        {
            this.lblDepositor.ForeColor = Color.Red;
        }

        public void setErrorWithdrawMode()
        {
            this.groupWithdrawMode.ForeColor = Color.Red;
        }

        public void setErrorInitialDeposit()
        {
            this.lblInitialDeposit.ForeColor = Color.Red;
        }

        public void clearErrors()
        {
            this.lblAccountType.ForeColor = SystemColors.ControlText;
            this.lblDepositor.ForeColor = SystemColors.ControlText;
            this.groupWithdrawMode.ForeColor = SystemColors.ControlText;
            this.lblInitialDeposit.ForeColor = SystemColors.ControlText;
        }
    }
}
