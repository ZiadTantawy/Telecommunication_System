using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage3
{
    public partial class RenewSubscription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        protected void Renew(object sender, EventArgs e)
        {
            string paymentMethod = "";
            string planInput = PlanID.Text;
            string amountInput = PaymentAmount.Text;
            bool isValid = true;

            // Initialize planID and validate
            int planID = 0;
            if (!int.TryParse(planInput, out planID))
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Please enter a valid Plan ID.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                isValid = false;
            }

            // Initialize Amount and validate
            decimal amount = 0;
            if (!decimal.TryParse(amountInput, out amount) || amount <= 0)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Please enter a valid Payment Amount.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                isValid = false;
            }

            // Initialize Payment Method
            if (rbtnCash.Checked)
            {
                paymentMethod = "cash";
            }
            else if (rbtnCredit.Checked)
            {
                paymentMethod = "credit";
            }

            // Ensure payment method is selected
            if (string.IsNullOrEmpty(paymentMethod))
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Please select a Payment Method.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                isValid = false;
            }

            // If all validations pass, process the payment
            if (isValid)
            {
                string connStr = ConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("dbo.Initiate_plan_payment", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Add parameters
                            cmd.Parameters.AddWithValue("@mobile_num", Session["MobileNumber"]);
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.Parameters.AddWithValue("@payment_method", paymentMethod);
                            cmd.Parameters.AddWithValue("@plan_id", planID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            lblMessage.Visible = true;
                            lblMessage.Text = "Payment added successfully!";
                            lblMessage.ForeColor = System.Drawing.Color.Green;
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMessage.Visible = true;
                        lblMessage.Text = "An error occurred: " + ex.Message;
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CostumerDashboard.aspx");
        }
    
    }
}
