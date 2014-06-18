using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CMS.Savings.Transaction.Model
{
    class TerminationModel
    {
        public int checkEmpty = 0;

        public DataSet selectActiveMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Account Name', Member_Type.Description AS 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and AccountNo not in (Select AccountNo from Termination)";
            String sqlct = "Select COUNT(Member.AccountNo) from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and AccountNo not in (Select AccountNo from Termination)";
            DataSet ds = dal.executeDataSet(sql);
            checkEmpty = Convert.ToInt32(dal.executeScalar(sqlct));
            return ds;
        }

        public DataSet searchMemberByName(String Name)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Account Name', Member_Type.Description AS 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and AccountNo not in (Select AccountNo from Termination) and concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) like(@MemberName)";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            Name = "%" + Name + "%";
            parameters.Add("@MemberName", Name);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByAccount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Account Name', Member_Type.Description AS 'Member Type' from Member, Member_Type where Member.MemberTypeNo=Member_Type.MemberTypeNo and AccountNo not in (Select AccountNo from Termination) and Member.AccountNo LIKE(@AccountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertTermination(String reason, String details, String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertTermination @Reason, @Details, @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Reason", reason);
            parameters.Add("@Details", details);
            parameters.Add("@AccountNo", accountNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));

            return result;
        }

        public double selectTotalSavings(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select sum(SAVINGS_ACCOUNT.Balance) from SAVINGS_ACCOUNT, MEMBER_SAVINGS_ACCOUNT WHERE SAVINGS_ACCOUNT.SavingsAccountNo = MEMBER_SAVINGS_ACCOUNT.SavingsAccountNo AND MEMBER_SAVINGS_ACCOUNT.MemberAccountNo = " + "'" + accountNo + "'";
                double totalSavings = (Convert.ToDouble(dal.executeScalar(sql)));
                return totalSavings;
            }
            catch (Exception) { return 0.00; }
        }

        public double  selectCurrentShareCapital(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select SUM(ShareCapital) from MEMBER_SHARECAPITAL where  AccountNo =  " + "'" + accountNo + "'";
                double currentShareCapital = (Convert.ToDouble(dal.executeScalar(sql)));
                return currentShareCapital;
            }
            catch (Exception) { return 0.00; }
        }

        public double selectRemainingBalance(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select sum(Amount) from loan_amortization inner join loan_application on loan_amortization.LoanApplicationId = loan_application.LoanApplicationId inner join Member on loan_application.AccountNo = Member.AccountNo where isPaid = 0 and member.AccountNo = " + "'" + accountNo + "'";
           double amount = 0.00;
           try
           {
               amount = Convert.ToDouble(dal.executeScalar(sql));
           }
           catch (InvalidCastException) {
               amount = 0.00;
           }
            return amount;
        }

        public String selectSavingsAccount (String AccountNo){
        
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select SavingsAccountNo FROM MEMBER_SAVINGS_ACCOUNT where MemberAccountNo = @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", AccountNo);
            String read = dal.executeScalar(sql, parameters).ToString();
            return read;
        }

         public int selectActivePassbook(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SavingsPassbookNo FROM MEMBER_SAVINGS_PASSBOOK WHERE SavingsAccountNo = @accountNo AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", this.selectSavingsAccount(accountNo));
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }

        public int withdrawSavings(String AccountNo, double Amount){

           
           DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsTransaction @SavingsAccountNo, @TransactionMode, @Amount, @Representative, @SavingsPassbook";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SavingsAccountNo", this.selectSavingsAccount(AccountNo));
            parameters.Add("@TransactionMode", "Withdraw");
            parameters.Add("@Amount", Amount);
            parameters.Add("@Representative", "");
            parameters.Add("@SavingsPassbook", this.selectActivePassbook(this.selectSavingsAccount(AccountNo)));
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
            String sql2 = "UPDATE SAVINGS_ACCOUNT SET Balance = 0.00 WHERE SavingsAccountNo = @AccountNo)";
            Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
            parameters2.Add("@AccountNo", this.selectSavingsAccount(AccountNo));
            dal.executeNonQuery(sql2, parameters2);
            }

            return result;
        }

        public int withdrawShareCapital(String accountNo, double amount) {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertContribution @accountNo, @amount";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", accountNo);
            parameters.Add("@amount", (amount*-1));
            int result = dal.executeNonQuery(sql, parameters);
            return result;
        }

        public void insertLoanPayment(String accountNo) { 
        
        
        }
    }
}
