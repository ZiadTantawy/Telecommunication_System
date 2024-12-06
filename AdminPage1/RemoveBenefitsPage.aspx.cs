using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System.AdminPage1
{
    public partial class BenefitsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRemoveBenefits_Click(object sender, EventArgs e)
        {
            string mobileNumber = txtMobileNumber.Text.Trim();
            string planIdText = txtPlanID.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(mobileNumber) || string.IsNullOrWhiteSpace(planIdText))
            {
                lblStatus.Text = "Please provide both mobile number and plan ID.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int planId;

            
            if (!int.TryParse(planIdText, out planId))
            {
                lblStatus.Text = "Invalid plan ID.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            
            RemoveBenefits(mobileNumber, planId);
        }

        private void RemoveBenefits(string mobileNumber, int planId)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    
                    SqlCommand cmd = new SqlCommand("Benefits_Account", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);
                    cmd.Parameters.AddWithValue("@plan_id", planId);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    lblStatus.Text = "Benefits removed successfully!";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "An error occurred: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard1.aspx"); 
        }
    }
}
