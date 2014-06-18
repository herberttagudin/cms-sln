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

namespace CMS.Loan_Management.Maintenance.View
{
    public partial class LoanTypes : Form
    {
        public LoanTypes()
        {
            InitializeComponent();
        }

        public void disableFunction() {
            txtName.Clear();
            txtName.Enabled = false;
            minimumUD.Value = 0;
            minimumUD.Enabled = false;
            maximumUD.Value = 0;
            maximumUD.Enabled = false;
            cbMinimumStatus.SelectedIndex = -1;
            cbMinimumStatus.Enabled = false;
            cbMaximumStatus.SelectedIndex = -1;
            cbMaximumStatus.Enabled = false;
            txtMaxAmt.Clear();
            txtMaxAmt.Enabled = false;
            cbDeduction.SelectedIndex = -1;
            cbDeduction.Enabled = false;
            comakersUD.Value = 0;
            comakersUD.Enabled = false;
            chbFixed.CheckState = CheckState.Unchecked;
            chbFixed.Enabled = false;
            cbAmtStatus.SelectedIndex = -1;
            cbAmtStatus.Enabled = false;
            chbCollateral.CheckState = CheckState.Unchecked;
            chbCollateral.Enabled = false;
            chbPrevious.CheckState = CheckState.Unchecked;
            chbPrevious.Enabled = false;
            chbCurrent.CheckState = CheckState.Unchecked;
            chbCurrent.Enabled = false;
            chbStatus.CheckState = CheckState.Unchecked;
            chbStatus.Enabled = false;
            clbMemberType.Enabled = false;
            clbMemberType.Items.Clear();


            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnRetrieve.Visible = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;    
        }

        public void enableFunction() {
            txtName.Clear();
            txtName.Enabled = true;
            minimumUD.Value = 0;
            minimumUD.Enabled = true;
            maximumUD.Value = 0;
            maximumUD.Enabled = true;
            cbMinimumStatus.SelectedIndex = -1;
            cbMinimumStatus.Enabled = true;
            cbMaximumStatus.SelectedIndex = -1;
            cbMaximumStatus.Enabled = true;
            txtMaxAmt.Clear();
            txtMaxAmt.Enabled = true;
            cbAmtStatus.SelectedIndex = -1;
            cbAmtStatus.Enabled = true;
            cbDeduction.SelectedIndex = -1;
            cbDeduction.Enabled = false;
            comakersUD.Value = 0;
            comakersUD.Enabled = true;
            chbFixed.CheckState = CheckState.Unchecked;
            chbFixed.Enabled = true;
            chbCollateral.CheckState = CheckState.Unchecked;
            chbCollateral.Enabled = true;
            chbPrevious.CheckState = CheckState.Unchecked;
            chbPrevious.Enabled = true;
            chbCurrent.CheckState = CheckState.Unchecked;
            chbCurrent.Enabled = true;
            chbStatus.Enabled = true;
            clbMemberType.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnRetrieve.Visible = false;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false; 
        
        }

        public void enableDeduction() 
        {
            this.cbDeduction.Enabled = true;
        }

        public void disableDeduction() 
        {
            this.cbDeduction.Enabled = false;
            this.cbDeduction.SelectedIndex = -1;
        }

        public Boolean getDeductionStatus() 
        {
            if (this.cbDeduction.Enabled == true) { return true; }
            else { return false; }
        }



        public void setAllLabelsToBlack() {
            this.lblComaker.ForeColor = System.Drawing.Color.Black;
            this.lblMaximumPaymentDur.ForeColor = System.Drawing.Color.Black;
            this.lblMaxLoanableAmt.ForeColor = System.Drawing.Color.Black;
            this.lblMinimumPaymentDur.ForeColor = System.Drawing.Color.Black;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.gbAvailability.ForeColor = System.Drawing.Color.Black;
            this.lblOf.ForeColor = System.Drawing.Color.Black;  
        }

        public void setBtnRetrieveEventHandler(EventHandler e)
        {
            this.btnRetrieve.Click += e;
        }


        public void showRetrieve()
        {
            this.btnRetrieve.Visible = true;
        }

        public void hideRetrieve()
        {
            this.btnRetrieve.Visible = false;
        }

        public void setArchivedColor(int i)
        {
            this.dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            this.dataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            this.dataGridView.Rows[i].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        public void cbShowArchive_CheckStateChanged(EventHandler e)
        {
            this.cbShowArchive.Click += e;
        }


        public bool checkArchivedState()
        {
            if (this.cbShowArchive.CheckState == CheckState.Checked)
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
            return this.dataGridView.Rows;
        }

        public void populateMemberTypes(Dictionary<int, string> memberTypes)
        {
            foreach (String s in memberTypes.Values)
            {
                clbMemberType.Items.Add(s);
            }
        }


        public void toggleCheckedTypes(ArrayList activeTypes)
        {

            foreach (String s in activeTypes)
            {
                if (clbMemberType.Items.Contains(s))
                {
                    int i = clbMemberType.Items.IndexOf(s);
                    clbMemberType.SetItemChecked(i, true);
                }
            }
        }

        public void setTextName(String s)
        {
            this.txtName.Text = s;
        }

        public String getTextName()
        {
            return this.txtName.Text;
        }

        public void setMinimumPayment(int i)
        {
            this.minimumUD.Value = i;
        }

        public int getMinimumPayment()
        {
            return int.Parse(this.minimumUD.Value.ToString()); 
            
        }

        public void setMinimumStatus(String s) {
            this.cbMinimumStatus.SelectedItem = s;
        }

        public String getMinimumStatus() {
            return this.cbMinimumStatus.SelectedItem.ToString();
        }

        public void setMaximumPayment(int i)
        {
            this.maximumUD.Value = i;
        }

        public int getMaximumPayment()
        {
            return int.Parse(this.maximumUD.Value.ToString());
        }

        public void setMaximumStatus(String s)
        {
            this.cbMaximumStatus.SelectedItem = s;
        }

        public String getMaximumStatus()
        {
            return this.cbMaximumStatus.SelectedItem.ToString();
        }

        public void setMaximumAmount(Double d) {
            this.txtMaxAmt.Text = d.ToString();
        }

        public double getMaximumAmount() {
            return Double.Parse(this.txtMaxAmt.Text);
        }

        public void setMaximumAmountStatus(String s) {
            this.cbAmtStatus.SelectedItem = s;
        }

        public String getMaximumAmountStatus() {
            return this.cbAmtStatus.SelectedItem.ToString();
        }

        public void setDeduction(String s) {
            this.cbDeduction.SelectedItem = s;
        }

        public String getDeduction() {
            return this.cbDeduction.SelectedItem.ToString();
        }

        public void setComakers(int i)
        {
            this.comakersUD.Value = i;
        }

        public int getComakers()
        {
            return int.Parse(this.comakersUD.Value.ToString());
        }

        public void setFixed()
        {
            this.chbFixed.CheckState = CheckState.Checked;
        }

        public Boolean getFixed()
        {
            if (this.chbFixed.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setCollateral()
        {
            this.chbCollateral.CheckState = CheckState.Checked;
        }

        public Boolean getCollateral()
        {
            if (this.chbCollateral.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public CheckedListBox.CheckedItemCollection getCheckedTypes()
        {

            return clbMemberType.CheckedItems;
        }

        public void setMemberType(ArrayList loanTypes)
        {
            clbMemberType.Items.Add(loanTypes);
        }

        public void setPrevious()
        {
            this.chbPrevious.CheckState = CheckState.Checked;
        }

        public Boolean getPrevious()
        {
            if (this.chbPrevious.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public void setCurrent()
        {
            this.chbCurrent.CheckState = CheckState.Checked;
        }

        public Boolean getCurrent()
        {
            if (this.chbCurrent.CheckState == CheckState.Checked)
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
            this.chbStatus.CheckState = CheckState.Checked;
        }

        public Boolean getStatus()
        {
            if (this.chbStatus.CheckState == CheckState.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void loanTypeGrid(DataSet ds)
        {
            this.dataGridView.DataSource = ds.Tables[0];
            this.dataGridView.Columns[0].Visible = false;
            this.dataGridView.Columns[12].Visible = false;
        }

        public DataGridViewRow getSelected()
        {
            return this.dataGridView.SelectedRows[0];
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


        
        

        private void LoanTypes_Load(object sender, EventArgs e)
        {

        }

        private void comakersUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void minimumUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maximumUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaxAmt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comakersUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (comakersUD.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void minimumUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (minimumUD.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void maximumUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (!(e.KeyData == Keys.Back || e.KeyData == Keys.Delete))
                    if (maximumUD.Text.Length >= 2)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
            }
        }

        private void txtMaxAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRowCollection rowCollection = dataGridView.Rows;
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


        private void cbAmtStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAmtStatus.SelectedItem.ToString() == "%") { this.enableDeduction(); }
                else { this.disableDeduction(); }
            }
            catch (Exception) { }
        }

        private void chbFixed_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFixed.Checked == true)
            {
                this.txtMaxAmt.Enabled = false;
                this.txtMaxAmt.Clear();
                this.cbAmtStatus.Enabled = false;
                this.cbAmtStatus.SelectedIndex = -1;
            }
            else 
            {
                this.txtMaxAmt.Enabled = true;
                this.cbAmtStatus.Enabled = true;
            }
        }

    }
}
