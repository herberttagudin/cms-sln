using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CMS.Savings.Maintenance.Model
{
    class SavingsAccountTypeModel
    {
        public String Name { get; set; }
        public double InitDeposit { get; set; }
        public int AccountHolders { get; set; }
        public int isMaintainingBalance { get; set; }
        public int isDormancy { get; set; }
        public int isInterestRates { get; set; }
        public int isMaximumWithdrawal { get; set; }
        public int isTimeDeposit { get; set; }
        public int Status { get; set; }
        public List<MemberSavingsTypeModel> memberSavingsChecklist { get; set; }

        public SavingsAccountTypeModel()
        {
            this.Name = String.Empty;
            this.InitDeposit = 0;
            this.AccountHolders = 0;
            this.isMaintainingBalance = 0;
            this.isDormancy = 0;
            this.isInterestRates = 0;
            this.isMaximumWithdrawal = 0;
            this.isTimeDeposit = 0;
            this.Status = 0;
            this.memberSavingsChecklist = new List<MemberSavingsTypeModel>();
        }

        public DataSet selectAccountTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Savings Type Name', InitialDeposit AS 'Initial Deposit', NoOfAccountHolders AS 'No of Account Holders', isMaintainingBalance AS 'Maintaining Balance', isInterestRate AS 'Interest Rate', isDormancy AS 'Dormancy', isMaximumWithdrawal AS 'Maximum Withdrawal', isTimeDeposit AS 'Time Deposit', Status, isArchived, DateCreated AS 'Date Created', DateModified AS 'Last Modified' FROM SAVINGS_ACCOUNT_TYPE WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAccountTypesAll()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Savings Type Name', InitialDeposit AS 'Initial Deposit', NoOfAccountHolders AS 'No of Account Holders', isMaintainingBalance AS 'Maintaining Balance', isInterestRate AS 'Interest Rate', isDormancy AS 'Dormancy', isMaximumWithdrawal AS 'Maximum Withdrawal', isTimeDeposit AS 'Time Deposit', Status, isArchived, DateCreated AS 'Date Created', DateModified AS 'Last Modified' FROM SAVINGS_ACCOUNT_TYPE";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectMemberTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo, Description FROM MEMBER_TYPE WHERE hasSavings = 1 AND Status = 1 AND isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public int checkName(String Name)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT COUNT(*) FROM SAVINGS_ACCOUNT_TYPE WHERE dbo.RemoveSpecialChars(SavingsTypeName) = dbo.RemoveSpecialChars(@Name) AND isArchived = 0";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", Name);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i;
        }

        public DataSet selectMemberTypeSavings(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int getInsertId()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT TOP 1 AccountTypeId FROM SAVINGS_ACCOUNT_TYPE ORDER BY AccountTypeId DESC";
            SqlDataReader read = dal.executeReader(sql);
            int i = 0;
            while (read.Read())
            {
                i = (int)read[0];
            }
            return i + 1;
        }

        public int insertSavingsAccount()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsAccountType @Name, @InitDeposit, @AccountHolders, @isMaintainingBalance, @isDormancy, @isInterestRates, @isMaximumWithdrawal, @isTimeDeposit, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", this.Name);
            parameters.Add("@InitDeposit", this.InitDeposit);
            parameters.Add("@AccountHolders", this.AccountHolders);
            parameters.Add("@isMaintainingBalance", this.isMaintainingBalance);
            parameters.Add("@isDormancy", this.isDormancy);
            parameters.Add("@isInterestRates", this.isInterestRates);
            parameters.Add("@isMaximumWithdrawal", this.isMaximumWithdrawal);
            parameters.Add("@isTimeDeposit", this.isTimeDeposit);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                foreach (MemberSavingsTypeModel memberSavings in this.memberSavingsChecklist)
                {
                    String s = "EXEC insertMemberTypeSavings @AccountTypeId, @MemberTypeNo";
                    Dictionary<String, Object> param = new Dictionary<string, object>();
                    param.Add("@AccountTypeId", memberSavings.AccountTypeId);
                    param.Add("@MemberTypeNo", memberSavings.MemberTypeNo);
                    dal.executeNonQuery(s, param);
                }
            }
            return result;
        }

        public int updateSavingsAccount(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateSavingsAccountType @Name, @InitDeposit, @AccountHolders, @isMaintainingBalance, @isDormancy, @isInterestRates, @isMaximumWithdrawal, @isTimeDeposit, @Status, @AccountTypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", this.Name);
            parameters.Add("@InitDeposit", this.InitDeposit);
            parameters.Add("@AccountHolders", this.AccountHolders);
            parameters.Add("@isMaintainingBalance", this.isMaintainingBalance);
            parameters.Add("@isDormancy", this.isDormancy);
            parameters.Add("@isInterestRates", this.isInterestRates);
            parameters.Add("@isMaximumWithdrawal", this.isMaximumWithdrawal);
            parameters.Add("@isTimeDeposit", this.isTimeDeposit);
            parameters.Add("@Status", this.Status);
            parameters.Add("@AccountTypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result != 0)
            {
                String sqlInner = "DELETE FROM MEMBER_TYPE_SAVINGS_TYPE WHERE AccountTypeId = @TypeId";
                Dictionary<String, Object> parametersInner = new Dictionary<string, object>();
                parametersInner.Add("@TypeId", TypeId);
                dal.executeNonQuery(sqlInner, parametersInner);
                foreach (MemberSavingsTypeModel memberSavings in this.memberSavingsChecklist)
                {
                    String s = "EXEC insertMemberTypeSavings @TypeId, @MemberTypeNo";
                    Dictionary<String, Object> param = new Dictionary<string, object>();
                    param.Add("@TypeId", TypeId);
                    param.Add("@MemberTypeNo", memberSavings.MemberTypeNo);
                    dal.executeNonQuery(s, param);
                }
            }
            return result;
        }

        public int deleteSavingsAccount(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE SAVINGS_ACCOUNT_TYPE SET isArchived = 1 WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int retrieveSavingsAccount(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE SAVINGS_ACCOUNT_TYPE SET isArchived = 0 WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}