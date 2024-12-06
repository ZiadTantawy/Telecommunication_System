using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage2
{
    public partial class RemPlanAmount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                checkinputs();
            }
        }

        protected void checkinputs(object sender, EventArgs e)
        {
            string Mobilenumber = MobileNumber.Text;
            string Planname = PlanName.Text;

            if (!string.IsNullOrEmpty(Mobilenumber) && Mobilenumber.Length == 11 && !string.IsNullOrEmpty(Planname))
            {
                ShowRemainingAmount(Mobilenumber, Planname);
            }
            else
            {
                lblMessage.Text = "Please enter a valid 11-digit mobile number and plan name.";
                lblMessage.Visible = true;
            }
        }

        private void ShowRemainingAmount(string Mobilenumber, string Planname)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ToString();
            string query = "SELECT * From dbo.Remaining_plan_amount(@mobile_num, @plan_name) ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mobile_num", Mobilenumber);
                    cmd.Parameters.AddWithValue("@plan_name", Planname);

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
        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDashboard2.aspx");
        }
    }
}
