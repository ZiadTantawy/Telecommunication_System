using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage2
{
    public partial class HighestVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                checkinput();
               
            }
        }
        protected void checkinput(object sender, EventArgs e)
        {
    
            string Mobilenumber = MobileNumber.Text; 

            if (!string.IsNullOrEmpty(Mobilenumber) && Mobilenumber.Length == 11)
            {
                GetHighestVoucher(Mobilenumber); 
            }
            else
            {
                lblMessage.Text = "invalid mobile number."; 
                lblMessage.Visible = true;
            }
        }

        private void GetHighestVoucher(string Mobilenumber)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ToString();
            string proc = "Account_Highest_Voucher";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(proc, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mobile_num", Mobilenumber);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lblMessage.Text = $"Highest Voucher ID: {result.ToString()}";

                    }
                    else
                    {
                        lblMessage.Text = "No vouchers found for this mobile number.";

                    }
                    lblMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred: " + ex.Message;
                lblMessage.Visible = true;
            }
        }
        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDashboard2.aspx");
        }

    }
}
