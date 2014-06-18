using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CMS.Loan_Management.Maintenance.Model
{
    class ShareCapitalContributionModel
    {
        public int comboAccountType { get; set; }
        public double txtContribution { get; set; }
        public string comboContribution { get; set; }
        public double txtPenalty { get; set; }
        public string comboCharge { get; set; }
        public int Status { get; set; }

        public ShareCapitalContributionModel()
        {
            this.comboAccountType = 0;
            this.txtContribution = 0;
            this.comboContribution = String.Empty;
            this.txtPenalty = 0;
            this.comboCharge = String.Empty;
            this.Status = 0;
        }
        public DataSet SelectCapitalContribution()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MinCapitalContributionId AS 'Minimum Capital Contribution ID', l.MemberTypeNo AS 'Member Type Id', Description AS 'Member Type', MinimumContribution AS 'Share Capital', Duration, Penalty, ChargeIn AS 'Charge In', l.Status FROM MINIMUM_CAPITAL_CONTRIBUTION l INNER JOIN MEMBER_TYPE m ON l.MemberTypeNo = m.MemberTypeNo";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectAllMemberTypes()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MemberTypeNo, Description FROM MEMBER_TYPE WHERE isArchived=0 and hasLoan=1";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet SelectMemberType()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT MEMBER_TYPE.MemberTypeNo, Description from MEMBER_TYPE LEFT JOIN MINIMUM_CAPITAL_CONTRIBUTION ON MEMBER_TYPE.MemberTypeNo= MINIMUM_CAPITAL_CONTRIBUTION.MemberTypeNo where MEMBER_TYPE.MemberTypeNo NOT IN(SELECT MemberTypeNo from MINIMUM_CAPITAL_CONTRIBUTION) AND MEMBER_TYPE.isArchived = 0 ";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }
        public int InsertMinCapitalContrib()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC SpInsert_MinimumCapitalContribution @MinimumContribution,@Penalty,@Duration,@ChargeIn,@Status,@MemberTypeNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@MinimumContribution", this.txtContribution);
            parameters.Add("@Penalty", this.txtPenalty);
            parameters.Add("@Duration", this.comboContribution);
            parameters.Add("@ChargeIn", this.comboCharge);
            parameters.Add("@Status", this.Status);
            parameters.Add("@MemberTypeNo", this.comboAccountType);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
         }

        public int UpdateMinCapitalContrib(int capId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC Update_MinimumCapitalContribution @MinimumContribution,@Penalty,@Duration,@ChargeIn,@Status,@MinCapitalContributionId";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@MinimumContribution", this.txtContribution);
            parameters.Add("@Penalty", this.txtPenalty);
            parameters.Add("@Duration", this.comboContribution);
            parameters.Add("@ChargeIn", this.comboCharge);
            parameters.Add("@Status", this.Status);
            parameters.Add("@MinCapitalContributionId", capId);
            int result = Convert.ToInt32(dal.executeNonQuery(sql, parameters));
            return result;
        }

    }
}
