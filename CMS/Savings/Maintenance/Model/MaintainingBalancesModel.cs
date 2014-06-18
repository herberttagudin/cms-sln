using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace CMS.Savings.Maintenance.Model
{
    class MaintainingBalancesModel
    {
        public int AccountTypeId { get; set; }
        public double MaintainingBalance { get; set; }
        public double ServiceCharge { get; set; }
        public String ServiceChargeStatus { get; set; }
        public double ServiceChargeDuration { get; set; }
        public String ServiceChargeDurationStatus { get; set; }
        public int Status { get; set; }

        public MaintainingBalancesModel()
        {
            this.AccountTypeId = 0;
            this.MaintainingBalance = 0;
            this.ServiceCharge = 0;
            this.ServiceChargeStatus = String.Empty;
            this.ServiceChargeDuration = 0;
            this.ServiceChargeDurationStatus = String.Empty;
            this.Status = 0;
        }

        public DataSet selectAccountTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT AccountTypeId, SavingsTypeName FROM SAVINGS_ACCOUNT_TYPE WHERE isMaintainingBalance = 1 AND isArchived = 0 AND AccountTypeId NOT IN(SELECT SavingsAccountTypeId FROM MAINTAINING_BALANCE)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectMaintainingBalances()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SavingsAccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', MaintainingBalance AS 'Maintaining Balance', CONCAT(ServiceChargeValue, ' ', ServiceChargeStatus) AS 'Penalty', CONCAT(ChargeDurationValue, ' ', ChargeDurationStatus) AS 'Penalty Schedule', m.Status, isArchived, m.DateCreated AS 'Date Created', m.DateModified AS 'Last Modified' FROM MAINTAINING_BALANCE m INNER JOIN SAVINGS_ACCOUNT_TYPE s ON m.SavingsAccountTypeId = s.AccountTypeId WHERE s.isArchived = 0";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectMaintainingBalancesAll()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT SavingsAccountTypeId AS 'Account Type Id', SavingsTypeName AS 'Account Type', MaintainingBalance AS 'Maintaining Balance', CONCAT(ServiceChargeValue, ' ', ServiceChargeStatus) AS 'Penalty', CONCAT(ChargeDurationValue, ' ', ChargeDurationStatus) AS 'Penalty Schedule', m.Status, isArchived, m.DateCreated AS 'Date Created', m.DateModified AS 'Last Modified' FROM MAINTAINING_BALANCE m INNER JOIN SAVINGS_ACCOUNT_TYPE s ON m.SavingsAccountTypeId = s.AccountTypeId";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public int insertMaintainingBalance()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertMaintainingBalance @TypeId, @Balance, @Charge, @ChargeStatus, @Duration, @DurationStatus, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", this.AccountTypeId);
            parameters.Add("@Balance", this.MaintainingBalance);
            parameters.Add("@Charge", this.ServiceCharge);
            parameters.Add("@ChargeStatus", this.ServiceChargeStatus);
            parameters.Add("@Duration", this.ServiceChargeDuration);
            parameters.Add("@DurationStatus", this.ServiceChargeDurationStatus);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

        public int updateMaintainingBalance(int TypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC updateMaintainingBalance @TypeId, @Balance, @Charge, @ChargeStatus, @Duration, @DurationStatus, @Status";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@TypeId", TypeId);
            parameters.Add("@Balance", this.MaintainingBalance);
            parameters.Add("@Charge", this.ServiceCharge);
            parameters.Add("@ChargeStatus", this.ServiceChargeStatus);
            parameters.Add("@Duration", this.ServiceChargeDuration);
            parameters.Add("@DurationStatus", this.ServiceChargeDurationStatus);
            parameters.Add("@Status", this.Status);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }
    }
}
