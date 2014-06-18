using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace CMS.Loan_Management.Maintenance.Model
{
    class LoanInterestRateModel
    {
        public int LoanTypeId { get; set; }
        public double InterestRate { get; set; }
        public String InterestRateStatus { get; set; }
        public String Per { get; set; }
        public String DateFrom { get; set; }
        public String DateTo { get; set; }
        public int Status { get; set; }

        public LoanInterestRateModel()
        {
            this.LoanTypeId = 0;
            this.InterestRate = 0.00;
            this.InterestRateStatus = String.Empty;
            this.Per = String.Empty;
            this.DateFrom = String.Empty;
            this.DateTo = String.Empty;
            this.Status = 0;
        }

        /*public int deleteInterestRate(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "UPDATE LOAN_INTEREST_RATE SET isArchived = 1 WHERE LoanTypeId = @TypeId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }*/
        public DataSet selectAllLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId, LoanTypeName FROM LOAN_TYPE WHERE isArchived=0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectLoanTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LoanTypeId, LoanTypeName FROM LOAN_TYPE WHERE LoanTypeId NOT IN(Select LoanTypeId FROM LOAN_INTEREST_RATE) AND LOAN_TYPE.isArchived=0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectInterestRates()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LOAN_TYPE.LoanTypeId as 'Loan Type Id', LOAN_TYPE.LoanTypeName as 'Loan Type Name', concat(LOAN_INTEREST_RATE.InterestRateValue,' ',LOAN_INTEREST_RATE.InterestRateStatus) as 'Interest Rate', LOAN_INTEREST_RATE.Per as 'Duration', LOAN_INTEREST_RATE.StartDate as 'Start Date', LOAN_INTEREST_RATE.EndDate as 'End Date', LOAN_INTEREST_RATE.Status as 'Active' from LOAN_INTEREST_RATE, LOAN_TYPE WHERE LOAN_INTEREST_RATE.LoanTypeId=LOAN_TYPE.LoanTypeId";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchInterestRates(String searchName)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT LOAN_TYPE.LoanTypeId, LOAN_TYPE.LoanTypeName, LOAN_INTEREST_RATE.InterestRateStatus, LOAN_INTEREST_RATE.InterestRateValue, LOAN_INTEREST_RATE.Per, LOAN_INTEREST_RATE.StartDate, LOAN_INTEREST_RATE.EndDate, LOAN_INTEREST_RATE.Status, LOAN_INTEREST_RATE.DateCreated, LOAN_INTEREST_RATE.DateModified from LOAN_INTEREST_RATE, LOAN_TYPE WHERE LOAN_INTEREST_RATE.LoanTypeId=LOAN_TYPE.LoanTypeId AND LOAN_TYPE.LoanTypeName=@searchName";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            searchName = "%" + searchName + "%";
            parameters.Add("@searchName", searchName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public int insertInterestRate()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertLoanInterestRate @LoanTypeId, @InterestRateStatus, @InterestRateValue, @Per, @StartDate, @EndDate, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@LoanTypeId", this.LoanTypeId);
            parameters.Add("@InterestRateStatus", this.InterestRateStatus);
            parameters.Add("@InterestRateValue", this.InterestRate);
            parameters.Add("@Per", this.Per);
            parameters.Add("@StartDate", this.DateFrom);
            parameters.Add("@EndDate", this.DateTo);        
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;

        }

        public int updateInterestRate(int TypeId)
        {
           
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateLoanInterestRate @LoanTypeId, @InterestRateStatus, @InterestRateValue, @Per, @StartDate, @EndDate, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
              parameters.Add("@LoanTypeId", TypeId);
              parameters.Add("@InterestRateStatus", this.InterestRateStatus);
              parameters.Add("@InterestRateValue", this.InterestRate);
              parameters.Add("@Per", this.Per);
              parameters.Add("@StartDate", this.DateFrom);
              parameters.Add("@EndDate", this.DateTo);
              parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
             
        }
    }
}
