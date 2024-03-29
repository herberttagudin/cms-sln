﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Savings.Transaction.Model
{
    class SavingsTransactionModel
    {
        public String AccountNo { get; set; }
        public double Amount { get; set; }
        public String Representative { get; set; }
        public String TransactionMode { get; set; }
        public int PassbookNo { get; set; }

        public SavingsTransactionModel()
        {
            this.AccountNo = String.Empty;
            this.Amount = 0;
            this.Representative = String.Empty;
            this.TransactionMode = String.Empty;
            this.PassbookNo = 0;
        }

        public DataSet selectMember()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT DISTINCT sa.SavingsAccountNo AS 'Account No', SavingsTypeName AS 'Savings Type', sa.AccountTypeId, Balance FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId = sat.AccountTypeId";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchMember(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT DISTINCT sa.SavingsAccountNo AS 'Account Holder', SavingsTypeName AS 'Savings Type', sa.AccountTypeId, Balance FROM SAVINGS_ACCOUNT sa INNER JOIN MEMBER_SAVINGS_ACCOUNT msa ON sa.SavingsAccountNo = msa.SavingsAccountNo INNER JOIN SAVINGS_ACCOUNT_TYPE sat ON sa.AccountTypeId = sat.AccountTypeId WHERE sa.SavingsAccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public double selectMaintainingBalance(int AccountType)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MaintainingBalance FROM MAINTAINING_BALANCE WHERE SavingsAccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", AccountType);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            return d;
        }

        public double selectMaximumWithdrawal(int AccountType)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MaximumWithdrawal FROM MAXIMUM_WITHDRAWAL WHERE AccountTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", AccountType);
            SqlDataReader read = dal.executeReader(sql, parameters);
            double d = 0;
            while (read.Read())
            {
                d = double.Parse(read[0].ToString());
            }
            return d;
        }

        public DataSet selectAccountHolder(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name' FROM MEMBER_SAVINGS_ACCOUNT msa INNER JOIN MEMBER m ON msa.MemberAccountNo = m.AccountNo WHERE msa.SavingsAccountNo LIKE(@AccountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int selectActivePassbook(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SavingsPassbookNo FROM MEMBER_SAVINGS_PASSBOOK WHERE SavingsAccountNo = @accountNo AND Status = 1";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            SqlDataReader read = dal.executeReader(sql, parameters);
            int i = 0;
            while (read.Read())
            {
                i = int.Parse(read[0].ToString());
            }
            return i;
        }

        public int insertSavingsTransaction()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertSavingsTransaction @SavingsAccountNo, @TransactionMode, @Amount, @Representative, @SavingsPassbook";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@SavingsAccountNo", this.AccountNo);
            parameters.Add("@TransactionMode", this.TransactionMode);
            parameters.Add("@Amount", this.Amount);
            parameters.Add("@Representative", this.Representative);
            parameters.Add("@SavingsPassbook", this.PassbookNo);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                if (this.TransactionMode == "Withdraw")
                {
                    String sql2 = "UPDATE SAVINGS_ACCOUNT SET Balance = Balance - @Amount WHERE SavingsAccountNo = @SavingsAccountNo";
                    Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
                    parameters2.Add("@SavingsAccountNo", this.AccountNo);
                    parameters2.Add("@Amount", this.Amount);
                    dal.executeNonQuery(sql2, parameters2);
                }
                else if (this.TransactionMode == "Deposit")
                {
                    String sql2 = "UPDATE SAVINGS_ACCOUNT SET Balance = Balance + @Amount WHERE SavingsAccountNo = @SavingsAccountNo";
                    Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
                    parameters2.Add("@SavingsAccountNo", this.AccountNo);
                    parameters2.Add("@Amount", this.Amount);
                    dal.executeNonQuery(sql2, parameters2);
                }
            }
            return result;
        }
    }
}
