using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
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

            //Initialze planID
            if (int.TryParse(planInput, out int planID))
            {
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Pleas enter a valid ID";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

            //Intialize Amount
            if (decimal.TryParse(amountInput, out decimal amount))
            {
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Pleas enter a valid amount";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }


            //Intialize Payment Method
            if (rbtnCash.Checked)
            {
                paymentMethod = "cash";
            }
            else if (rbtnCredit.Checked)
            {
                paymentMethod = "credit";
            }

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

                        lblMessage.Text = "Payment added successfully!";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "An error occurred: " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }

            }
    }
}