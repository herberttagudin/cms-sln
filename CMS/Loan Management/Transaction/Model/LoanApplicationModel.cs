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

namespace CMS.Loan_Management.Transaction.Model
{
    class LoanApplicationModel
    {

        public Boolean selectSavingsStatus(int memberTypeNo) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select hasSavings from MEMBER_TYPE WHERE MemberTypeNo =" + "'" + memberTypeNo + "'";
            Boolean hasSavings = Convert.ToBoolean(dal.executeScalar(sql));
            return hasSavings;
        }

        public int selectPendingLoans(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select count(isPending) from LOAN_APPLICATION WHERE isPending = 1 and AccountNo = " + "'" + accountNo + "'";
                int noOfPendingLoans = Convert.ToInt32(dal.executeScalar(sql));
                return noOfPendingLoans;
            }
            catch (Exception) { return 0; }
        }

        public int selectPreviousEligibility(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isPreviousUnpaid from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            int elig = Convert.ToInt32(dal.executeScalar(sql));
            return elig;
        }

        public int selectCurrentEligibility(int loanTypeId) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isCurrentUnpaid from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            int elig = Convert.ToInt32(dal.executeScalar(sql));
            return elig;
        }

        public DataSet selectLoanTypeUnpaid(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_APPLICATION.LoanTypeId FROM LOAN_APPLICATION, LOAN_APPROVED where LOAN_APPLICATION.LoanApplicationId= LOAN_APPROVED.LoanApplicationId and LOAN_APPROVED.isCleared = 0 and LOAN_APPLICATION.AccountNo = " + "'" + accountNo + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public String selectPaymentDuration(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(MinimumPaymentDuration,' ',MinPDStatus,' to ',MaximumPaymentDuration,' ',MaxPDStatus) from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            String pd = Convert.ToString(dal.executeScalar(sql));
            return pd;
        }

        public String selectMaximumLoanableAmount(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select concat(MaxLoanableAmt,' ',MaxLoanableAmtStatus,' ',Deduction) from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            String mla = Convert.ToString(dal.executeScalar(sql));
            return mla;
        }

        public double selectTimeDepositBalance(int certificateNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select DepositAmount from TIME_DEPOSIT where CertificateNo = " + "'" + certificateNo + "'";
            double balance = Convert.ToDouble(dal.executeScalar(sql));
            return balance;
        }

        public DataSet selectTimeDepositAccounts(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select CertificateNo from TIME_DEPOSIT where Maturity > CURRENT_TIMESTAMP and isHold = 0 and Status=1 and AccountNo = "+"'"+accountNo+"'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public String checkSpouseName(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select SpouseName from MEMBER WHERE AccountNo = " + "'" + accountNo + "'";
            String spouse = Convert.ToString(dal.executeScalar(sql));
            return spouse;
        }

        public int selectNoOfDependents(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select NoOfDependents from MEMBER WHERE AccountNo = " + "'" + accountNo + "'";
            int dependents = Convert.ToInt32(dal.executeScalar(sql));
            return dependents;
        }

        public int selectLoanApprovedCount(String accountNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select count(LOAN_APPROVED.LoanApplicationId)+1 from Member, LOAN_APPLICATION, LOAN_APPROVED where Member.AccountNo=LOAN_APPLICATION.AccountNo AND LOAN_APPLICATION.LoanApplicationId=LOAN_APPROVED.LoanApplicationId and LOAN_APPLICATION.AccountNo= " + "'" + accountNo + "'";
            int loanCount = Convert.ToInt32(dal.executeScalar(sql));
            return loanCount;
        }

        public String selectTotalSavings(String accountNo)
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select sum(SAVINGS_ACCOUNT.Balance) from SAVINGS_ACCOUNT, MEMBER_SAVINGS_ACCOUNT WHERE SAVINGS_ACCOUNT.SavingsAccountNo = MEMBER_SAVINGS_ACCOUNT.SavingsAccountNo AND MEMBER_SAVINGS_ACCOUNT.MemberAccountNo = " + "'" + accountNo + "'";
                String totalSavings = (Convert.ToDouble(dal.executeScalar(sql))).ToString();
                return totalSavings;
            }
            catch (Exception) { return "0"; }
        }

        public String selectCurrentShareCapital(String accountNo) 
        {
            try
            {
                DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
                String sql = "Select SUM(ShareCapital) from MEMBER_SHARECAPITAL where  AccountNo =  " + "'" + accountNo + "'";
                String currentShareCapital = (Convert.ToDouble(dal.executeScalar(sql))).ToString();
                return currentShareCapital;
            }
            catch (Exception) { return "0"; }
        }

        public Boolean checkIfLoanIsFixed(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isFixed from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            Boolean isFixed = Convert.ToBoolean(dal.executeScalar(sql));
            return isFixed;
        }

        public int checkIfLoanHasComakers(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select CoMaker from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            int comaker = Convert.ToInt32(dal.executeScalar(sql));
            return comaker;
        }

        public int checkIfLoanIsCollateralized(int loanTypeId) 
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select isCollateral from LOAN_TYPE where LoanTypeId = " + "'" + loanTypeId + "'";
            int isCollateral = Convert.ToInt32(dal.executeScalar(sql));
            return isCollateral;
        }

        public DataSet selectActiveMemberWithLoan()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_TYPE.MemberTypeNo from Member, Member_Type, Payment where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member.AccountNo = Payment.AccountNo and Member_Type.hasLoan=1 and Member_Type.MinimumAge >= 18 and Member.Status=1 and Payment.PaymentType = 'Membership' and Payment.isFullyPaid = 1 and Member.AccountNo not in (Select AccountNo from Termination)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectRequirements(int loanTypeId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_REQUIREMENT.RequirementNo, LOAN_REQUIREMENT.Description, LOAN_REQUIREMENT.Necessity from LOAN_REQUIREMENT, LOAN_TYPE_REQUIREMENT WHERE LOAN_REQUIREMENT.RequirementNo=LOAN_TYPE_REQUIREMENT.RequirementNo AND LOAN_REQUIREMENT.isArchived=0 AND LOAN_REQUIREMENT.Status=1 AND LOAN_TYPE_REQUIREMENT.LoanTypeId="+ "'" + loanTypeId + "'";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet selectLoanType(int memberTypeNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select LOAN_TYPE.LoanTypeId as 'LoanTypeId', LOAN_TYPE.LoanTypeName as 'LoanTypeName' from LOAN_TYPE, LOAN_TYPE_AVAILABILITY, LOAN_TYPE_REQUIREMENT, MEMBER_TYPE WHERE LOAN_TYPE_AVAILABILITY.MemberTypeNo=MEMBER_TYPE.MemberTypeNo and LOAN_TYPE_AVAILABILITY.LoanTypeId=LOAN_TYPE.LoanTypeId and LOAN_TYPE.LoanTypeId = LOAN_TYPE_REQUIREMENT.LoanTypeId and Member_Type.hasLoan = 1 and Loan_Type.isArchived=0 and Loan_Type.Status=1 and Member_Type.MemberTypeNo = "+ "'" + memberTypeNo + "'"+" GROUP BY LOAN_TYPE.LoanTypeId, LOAN_TYPE.LoanTypeName HAVING count(LOAN_TYPE_REQUIREMENT.LoanTypeId) >0 ";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }

        public DataSet searchMemberByMemberName(String memberName)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_TYPE.MemberTypeNo from Member, Member_Type, Payment where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member.AccountNo = Payment.AccountNo and Member_Type.hasLoan=1 and Member_Type.MinimumAge >= 18 and Member.Status=1 and Payment.PaymentType = 'Membership' and Payment.isFullyPaid = 1 and Member.AccountNo not in (Select AccountNo from Termination) AND concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) LIKE(@memberName)";
            memberName = "%" + memberName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@memberName", memberName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchMemberByAccountNo(String accountNo)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_TYPE.MemberTypeNo from Member, Member_Type, Payment where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member.AccountNo = Payment.AccountNo and Member_Type.hasLoan=1 and Member_Type.MinimumAge >= 18 and Member.Status=1 and Payment.PaymentType = 'Membership' and Payment.isFullyPaid = 1 and Member.AccountNo not in (Select AccountNo from Termination) AND Member.AccountNo LIKE(@accountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchComakerByMemberName(String memberName)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_STATUS.DelinquencyValue from Member, Member_Type, MEMBER_STATUS, Payment where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member.MemberStatusNo=MEMBER_STATUS.MemberStatusNo and Member.AccountNo = Payment.AccountNo and MEMBER_STATUS.DelinquencyValue=0 and Member_Type.MinimumAge >=18 and Payment.PaymentType = 'Membership' and Payment.isFullyPaid = 1 and Member.Status=1 and Member.AccountNo not in (Select AccountNo from Termination) AND concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) LIKE(@memberName)";
            memberName = "%" + memberName + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@memberName", memberName);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet searchComakerByAccountNo(String accountNo)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_STATUS.DelinquencyValue from Member, Member_Type, MEMBER_STATUS, Payment where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member.MemberStatusNo=MEMBER_STATUS.MemberStatusNo and Member.AccountNo = Payment.AccountNo and MEMBER_STATUS.DelinquencyValue=0 and Member_Type.MinimumAge >=18 and Payment.PaymentType = 'Membership' and Payment.isFullyPaid = 1 and Member.Status=1 and Member.AccountNo not in (Select AccountNo from Termination) AND Member.AccountNo LIKE(@accountNo)";
            accountNo = "%" + accountNo + "%";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@accountNo", accountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
            return ds;
        }

        public DataSet selectActiveMemberWithNoDeficiency()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Select distinct Member.AccountNo as 'Account No.', concat(Member.FirstName,' ',Member.MiddleName,' ',Member.LastName) as 'Name', MEMBER_TYPE.Description as 'Member Type', MEMBER_STATUS.DelinquencyValue from Member, Member_Type, MEMBER_STATUS, Payment where Member.MemberTypeNo=Member_Type.MemberTypeNo and Member.MemberStatusNo=MEMBER_STATUS.MemberStatusNo and Member.AccountNo = Payment.AccountNo and MEMBER_STATUS.DelinquencyValue=0 and Member_Type.MinimumAge >=18 and Payment.PaymentType = 'Membership' and Payment.isFullyPaid = 1 and Member.Status=1 and Member.AccountNo not in (Select AccountNo from Termination)";
            DataSet ds = dal.executeDataSet(sql);
            return ds;
        }


        public int insertIncome(double MonthlyIncome,double SpouseIncome,double OtherSources,double NetMonthlyIncome)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertIncome @MonthlyIncome, @SpouseIncome, @OtherSources, @NetMonthlyIncome";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@MonthlyIncome", MonthlyIncome);
            parameters.Add("@SpouseIncome", SpouseIncome);
            parameters.Add("@OtherSources", OtherSources);
            parameters.Add("@NetMonthlyIncome", NetMonthlyIncome);
            dal.executeNonQuery(sql, parameters);

            String sql2 = "select max(IncomeId) from income";
            int incomeId = Convert.ToInt32(dal.executeScalar(sql2));
            return incomeId;


        }

        public int insertExpense(double Food, double Water, double Electricity, double TuitionFees, double Rent, double Transportation, double LoanRepayment, double CellphoneOrTelephone, double Miscellaneous, double MonthlyExpenses)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertExpense @Food,@Water,@Electricity,@TuitionFees,@Rent,@Transportation,@LoanRepayment,@CellphoneOrTelephone,@Miscellaneous,@MonthlyExpenses";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@Food", Food);
            parameters.Add("@Water", Water);
            parameters.Add("@Electricity", Electricity);
            parameters.Add("@TuitionFees", TuitionFees);
            parameters.Add("@Rent", Rent);
            parameters.Add("@Transportation", Transportation);
            parameters.Add("@LoanRepayment", LoanRepayment);
            parameters.Add("@CellphoneOrTelephone", CellphoneOrTelephone);
            parameters.Add("@Miscellaneous", Miscellaneous);
            parameters.Add("@MonthlyExpenses", MonthlyExpenses);
            dal.executeNonQuery(sql, parameters);

            String sql2 = "select max(ExpenseId) from Expense";
            int expenseId = Convert.ToInt32(dal.executeScalar(sql2));
            return expenseId;

        }

        public int insertLoanApplication(String AccountNo, int IncomeId, int ExpenseId, int LoanTypeId, Boolean isLoanAgainstDeposit, int SourceOfFund, String Purpose, String PaymentDurationStatus, int PaymentDurationValue, String Terms, double LoanAmount, String DateFiled)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertLoanApplication @AccountNo, @IncomeId, @ExpenseId, @LoanTypeId, @isLoanAgainstDeposit, @SourceOfFund, @Purpose, @PaymentDurationStatus, @PaymentDurationValue, @Terms, @LoanAmount, @DateFiled";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", AccountNo);
            parameters.Add("@IncomeId", IncomeId);
            parameters.Add("@ExpenseId", ExpenseId);
            parameters.Add("@LoanTypeId", LoanTypeId);
            parameters.Add("@isLoanAgainstDeposit", isLoanAgainstDeposit);
            parameters.Add("@SourceOfFund", SourceOfFund);
            parameters.Add("@Purpose", Purpose);
            parameters.Add("@PaymentDurationStatus", PaymentDurationStatus);
            parameters.Add("@PaymentDurationValue", PaymentDurationValue);
            parameters.Add("@Terms", Terms);
            parameters.Add("@LoanAmount", LoanAmount);
            parameters.Add("@DateFiled", DateFiled);
            dal.executeNonQuery(sql, parameters);

            String sql2 = "select max(LoanApplicationId) from Loan_Application";
            int loanApplicationId = Convert.ToInt32(dal.executeScalar(sql2));
            return loanApplicationId;

        }

        public void insertLoanApplicationRequirements(int RequirementNo, int LoanApplicationId, Boolean isPassed )
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertLoanApplicationRequirement @RequirementNo, @LoanApplicationId, @isPassed";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@RequirementNo", RequirementNo);
            parameters.Add("LoanApplicationId", LoanApplicationId);
            parameters.Add("@isPassed", isPassed);
            dal.executeNonQuery(sql, parameters);

        }

        public void updateLoanApplicationRequirements(int RequirementNo, int LoanApplicationId)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Update LOANAPPLICATION_REQUIREMENTS set isPassed = 1 where LoanApplicationId="+LoanApplicationId+" and RequirementNo ="+RequirementNo;
            dal.executeScalar(sql);
        }

        public void insertCollateral(int LoanApplicationId, String SerialNo, String Name, String Condition, String Description, String YearAcquired, double AcquiredAmount)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertPropertyCollateral @LoanApplicationId,@SerialNo,@Name,@Condition,@Description,@YearAcquired,@AcquiredAmount";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanApplicationId", LoanApplicationId);
            parameters.Add("@SerialNo", SerialNo);
            parameters.Add("@Name", Name);
            parameters.Add("@Condition", Condition);
            parameters.Add("@Description", Description);
            parameters.Add("@YearAcquired", YearAcquired);
            parameters.Add("@AcquiredAmount", AcquiredAmount);
            dal.executeNonQuery(sql, parameters);
        }

        public void insertComaker(int spouseCheck, int LoanApplicationId, String AccountNo, String ResidentCertificateNo, String RPlaceIssued, String RDateIssued, String SpouseCertificateNo, String SPlaceIssued, String SDateIssued)
        {

            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "EXEC insertComaker @LoanApplicationId,@AccountNo,@ResidentCertificateNo,@RPlaceIssued,@RDateIssued,@SpouseCertificateNo,@SPlaceIssued,@SDateIssued";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@LoanApplicationId", LoanApplicationId);
            parameters.Add("@AccountNo", AccountNo);
            parameters.Add("@ResidentCertificateNo", ResidentCertificateNo);
            parameters.Add("@RPlaceIssued", RPlaceIssued);
            parameters.Add("@RDateIssued", RDateIssued);
            parameters.Add("@SpouseCertificateNo", SpouseCertificateNo);
            parameters.Add("@SPlaceIssued", SPlaceIssued);
            parameters.Add("@SDateIssued", SDateIssued);
            dal.executeNonQuery(sql, parameters);
        }


        public void updateTimeDeposit(int certNo)
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "Update TIME_DEPOSIT set isHold = 1 where CertificateNo = " + "'"+certNo+"'";
            dal.executeScalar(sql);
        }


    }
}
