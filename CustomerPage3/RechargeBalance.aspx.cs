using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage3
{
    public partial class RechargeBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblMessage.Visible = false;

        }
        protected void Recharge(object sender, EventArgs e)
        {
            string amountInput = txtAmount.Text;
            string paymentMethod = "";

            if (!decimal.TryParse(amountInput, out decimal amount))
            {
                lblMessage.Text = "Please enter a valid amount.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Visible = true;
            }

            if (rbtnCash.Checked)
            {
                paymentMethod = "cash";
            }
            else if (rbtnCredit.Checked)
            {
                paymentMethod = "credit";
            }

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.Initiate_balance_payment", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@mobile_num", Session["MobileNumber"].ToString());
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@payment_method", paymentMethod);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        lblMessage.Text = "Account recharged successfully.";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "An error has occurred: " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Visible = true;

                }
            }
        }
        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CostumerDashboard.aspx");
        }
    }
}
