using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.Controller
{
    class TimeDepositWithdrawalController
    {
        Model.TimeDepositWithdrawalModel timeDepositWithdrawalModel;
        View.TimeDepositWithdrawal timeDepositWithdrawal;

        public TimeDepositWithdrawalController(Model.TimeDepositWithdrawalModel timeDepositWithdrawalModel, View.TimeDepositWithdrawal timeDepositWithdrawal, SavingsMenu savingsMenu)
        {
            this.timeDepositWithdrawal = timeDepositWithdrawal;
            this.timeDepositWithdrawalModel = timeDepositWithdrawalModel;
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.selectTimeDeposit());
            this.timeDepositWithdrawal.txtAccountNo_TextChanged(this.txtAccountNo);
            this.timeDepositWithdrawal.txtMemberName_TextChanged(this.txtMemberName);
            this.timeDepositWithdrawal.txtCertificateNo_TextChanged(this.txtCertificateNo);
            this.timeDepositWithdrawal.dataTimeDeposit_CellContentClick(this.dataTimeDeposit);
            this.timeDepositWithdrawal.setBtnClearEventHandler(this.btnSave);
            this.timeDepositWithdrawal.setBtnSaveEventHandler(this.btnSave);
            this.timeDepositWithdrawal.MdiParent = savingsMenu;
            this.timeDepositWithdrawal.Show();
        }

        public void txtAccountNo(object sender, EventArgs e)
        {
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.searchTimeDepositAccountNo(this.timeDepositWithdrawal.getAccountNo()));
        }

        public void txtMemberName(object sender, EventArgs e)
        {
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.searchTimeDepositMemberName(this.timeDepositWithdrawal.getMemberName()));
        }

        public void txtCertificateNo(object sender, EventArgs e)
        {
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.searchTimeDepositCertificateNo(this.timeDepositWithdrawal.getCertificateNo()));
        }

        public void dataTimeDeposit(object sender, EventArgs e)
        {
            DataGridViewRow row = this.timeDepositWithdrawal.getSelected();
            this.timeDepositWithdrawalModel.CertificateNo = row.Cells[2].Value.ToString();
            this.timeDepositWithdrawal.setGross(row.Cells[3].Value.ToString());
            this.timeDepositWithdrawal.setPenalty("0");
            this.timeDepositWithdrawal.setTotal((double.Parse(row.Cells[3].Value.ToString()) - this.timeDepositWithdrawal.getPenalty()).ToString());
        }

        public void btnClear(object sender, EventArgs e)
        {
            this.timeDepositWithdrawal.reset();
            this.timeDepositWithdrawal.setDataTimeDeposit(this.timeDepositWithdrawalModel.selectTimeDeposit());
        }

        public void btnSave(object sender, EventArgs e)
        {
            DataGridViewRow row = this.timeDepositWithdrawal.getSelected();
            if (bool.Parse(row.Cells[4].Value.ToString()) == false)
            {
                this.timeDepositWithdrawalModel.Penalty = this.timeDepositWithdrawal.getPenalty();
                this.timeDepositWithdrawalModel.TotalAmount = this.timeDepositWithdrawal.getTotal();
                if (this.timeDepositWithdrawalModel.insertTimeDepositDetails() == 1)
                {
                    MessageBox.Show("Transaction Success", "Time Deposit Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction Failed", "Time Deposit Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cannot Process Transaction." + Environment.NewLine + "Time Deposit was Hold by the Cooperative.", "Time Deposit Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
