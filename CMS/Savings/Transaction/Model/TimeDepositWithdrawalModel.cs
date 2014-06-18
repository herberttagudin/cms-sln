using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Savings.Transaction.Model
{
    class TimeDepositWithdrawalModel
    {
        public String CertificateNo { get; set; }
        public double Penalty { get; set; }
        public double TotalAmount { get; set; }
        
        public TimeDepositWithdrawalModel()
        {
            this.CertificateNo = String.Empty;
            this.Penalty = 0;
            this.TotalAmount = 0;
        }

        public DataSet selectTimeDeposit()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance', isHold FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchTimeDepositAccountNo(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance', isHold FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1 AND m.AccountNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchTimeDepositMemberName(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance', isHold FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1 AND LastName LIKE(@searchName) OR MiddleName LIKE(@searchName) OR FirstName LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchTimeDepositCertificateNo(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT m.AccountNo AS 'Account No', CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS 'Member Name', CertificateNo AS 'Certificate No', DepositAmount AS 'Current Balance', isHold FROM MEMBER m INNER JOIN TIME_DEPOSIT td ON m.AccountNo = td.AccountNo WHERE td.Status = 1 AND CertificateNo LIKE(@searchName)";
            searchName = "%" + searchName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertTimeDepositDetails()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertTimeDepositDetails @CertificateNo, @TotalAmount, @Penalty";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@CertificateNo", this.CertificateNo);
            parameters.Add("@TotalAmount", this.TotalAmount);
            parameters.Add("@Penalty", this.Penalty);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            if (result == 1)
            {
                String sql2 = "UPDATE TIME_DEPOSIT SET Status = 0 WHERE CertificateNo = @CertificateNo";
                Dictionary<String, Object> parameters2 = new Dictionary<string, object>();
                parameters2.Add("@CertificateNo", this.CertificateNo);
                dal.executeNonQuery(sql2, parameters2);
            }
            return result;
        }
    }
}
