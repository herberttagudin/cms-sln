using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CMS.Savings.Maintenance.Model
{
    class DormancyModel
    {
        public int TypeId { get; set; }
        public double Penalty { get; set; }
        public String PenaltyStatus { get; set; }
        public int Dormancy { get; set; }
        public String DormancyStatus { get; set; }
        public int Charge { get; set; }
        public String ChargeStatus { get; set; }
        public int Status { get; set; }

        public DormancyModel()
        {
            this.TypeId = 0;
            this.Penalty = 0;
            this.PenaltyStatus = String.Empty;
            this.Dormancy = 0;
            this.DormancyStatus = String.Empty;
            this.Charge = 0;
            this.ChargeStatus = String.Empty;
            this.Status = 0;
        }

        public DataSet selectAccountTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId, SavingsTypeName FROM SAVINGS_ACCOUNT_TYPE WHERE isDormancy = 1 AND isArchived = 0 AND AccountTypeId NOT IN(SELECT AccountTypeId FROM DORMANCY)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectDormancy()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT d.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', CONCAT(DormancyValue, ' ', DormancyStatus) AS 'Dormancy', CONCAT(PenaltyValue, ' ', PenaltyStatus) AS 'Penalty', CONCAT(ChargeDurationValue, ' ', ChargeDurationStatus) AS 'Penalty Schedule', d.Status, isArchived, d.DateCreated AS 'Date Created', d.DateModified AS 'Last Modified' FROM DORMANCY d INNER JOIN SAVINGS_ACCOUNT_TYPE s ON d.AccountTypeId = s.AccountTypeId WHERE isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectDormancyAll()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT d.AccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', CONCAT(DormancyValue, ' ', DormancyStatus) AS 'Dormancy', CONCAT(PenaltyValue, ' ', PenaltyStatus) AS 'Penalty', CONCAT(ChargeDurationValue, ' ', ChargeDurationStatus) AS 'Penalty Schedule', d.Status, isArchived, d.DateCreated AS 'Date Created', d.DateModified AS 'Last Modified' FROM DORMANCY d INNER JOIN SAVINGS_ACCOUNT_TYPE s ON d.AccountTypeId = s.AccountTypeId";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public int insertDormancy()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertDormancy @TypeId, @PenaltyValue, @PenaltyStatus, @DormancyValue, @DormancyStatus, @ChargeValue, @ChargeStatus, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.TypeId);
            parameters.Add("@PenaltyValue", this.Penalty);
            parameters.Add("@PenaltyStatus", this.PenaltyStatus);
            parameters.Add("@DormancyValue", this.Dormancy);
            parameters.Add("@DormancyStatus", this.DormancyStatus);
            parameters.Add("@ChargeValue", this.Charge);
            parameters.Add("@ChargeStatus", this.ChargeStatus);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateDormancy(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateDormancy @TypeId, @PenaltyValue, @PenaltyStatus, @DormancyValue, @DormancyStatus, @ChargeValue, @ChargeStatus, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            parameters.Add("@PenaltyValue", this.Penalty);
            parameters.Add("@PenaltyStatus", this.PenaltyStatus);
            parameters.Add("@DormancyValue", this.Dormancy);
            parameters.Add("@DormancyStatus", this.DormancyStatus);
            parameters.Add("@ChargeValue", this.Charge);
            parameters.Add("@ChargeStatus", this.ChargeStatus);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
