using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage2
{
    public partial class ExtraPlanAmount : System.Web.UI.Page
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
            string paymentId = PaymentId.Text;  // Assuming PaymentId is a TextBox in your form
            string planId = PlanId.Text;  

             if (!string.IsNullOrEmpty(paymentId) && !string.IsNullOrEmpty(planId))
            {
                ShowExtraAmount(paymentId, planId);
            }
            else
            {
                lblMessage.Text = "Please enter a valid payment ID and plan ID.";
                lblMessage.Visible = true;
            }
        }

        private void ShowExtraAmount(string paymentId, string planId)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ToString();
            string query = "SELECT dbo.function_extra_amount(@payment_id,@plan_id) AS ExtraAmount";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@payment_id", paymentId);
                    cmd.Parameters.AddWithValue("@plan_id", planId);

                    conn.Open();
                    object result = cmd.ExecuteScalar(); 

                    if (result != null && int.TryParse(result.ToString(), out int ExtraAmount))
                    {
                        lblMessage.Text = $"Extra Amount: {ExtraAmount}"; 
                        lblMessage.Visible = true;
                    }
                    else
                    {
                        lblMessage.Text = "No data found for the given payment ID and plan ID";
                        lblMessage.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred: "+ ex.Message;
                lblMessage.Visible = true;
            }
        }
    }
}
