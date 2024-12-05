using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage2
{
    public partial class RemaPlanAmount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               lblMessage.Visible = false;
            }
        }

        protected void checkinputs(object sender, EventArgs e)
        {
            string mobileNumber = MobileNumber.Text;
            string planName = PlanName.Text;

            if (!string.IsNullOrEmpty(mobileNumber) && mobileNumber.Length == 11 && !string.IsNullOrEmpty(planName))
            {
                ShowRemainingAmount(mobileNumber, planName);
            }
            else
            {
                lblMessage.Text = "Please enter a valid 11-digit mobile number and plan name.";
                lblMessage.Visible = true;
            }
        }

        private void ShowRemainingAmount(string mobileNumber, string planName)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ToString();
            string query = "SELECT dbo.Remaining_plan_amount(@mobile_num, @plan_name) AS RemainingAmount";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);
                    cmd.Parameters.AddWithValue("@plan_name", planName);

                    conn.Open();
                    object result = cmd.ExecuteScalar(); 

                    if (result != null && int.TryParse(result.ToString(), out int remainingAmount))
                    {
                        lblMessage.Text = $"Remaining Amount: {remainingAmount}";
                    }
                    else
                    {
                        lblMessage.Text = "No data found for the given mobile number and plan.";   
                    }
                    lblMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred:" + ex.Message;
                lblMessage.Visible = true;
            }
        }
    }
}
