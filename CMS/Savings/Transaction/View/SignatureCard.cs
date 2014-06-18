using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Savings.Transaction.View
{
    public partial class SignatureCard : Form
    {
        String AccountNo = String.Empty;

        public SignatureCard(String AccountNo)
        {
            this.AccountNo = AccountNo;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setData()
        {
            DAL dal = new DAL(ConfigurationManager.ConnectionStrings["CMS"].ConnectionString);
            String sql = "SELECT CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS 'Name', CONCAT(AddressNo, ' ', AddressStreet, ', ', AddressBarangay, ', ', AddressCity, ', ', AddressProvince, ', ', AddressZipCode) AS 'Address', BirthDate, TelephoneNo, Gender FROM MEMBER WHERE AccountNo = @AccountNo";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountNo", this.AccountNo);
            DataSet ds = dal.executeDataSet(sql, parameters);
        }
    }
}
