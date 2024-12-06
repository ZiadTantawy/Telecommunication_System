using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage3
{
    public partial class PaymentCashback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }
        protected void Retrive(object sender, EventArgs e)
        {

            string paymentInput = PaymentID.Text;
            string benefitInput = BenefitID.Text;

            //Initialze PaymentID
            if (int.TryParse(paymentInput, out int paymentID))
            {
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Pleas enter a valid Payment ID";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

            //Intialize BenefitID
            if (int.TryParse(benefitInput, out int benefitID))
            {
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Pleas enter a valid Benefit ID";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.Payment_wallet_cashback", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mobile_num", Session["MobileNumber"]);
                        cmd.Parameters.AddWithValue("@payment_id", paymentID);
                        cmd.Parameters.AddWithValue("@benefit_id", benefitID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        lblMessage.Visible = true;
                        lblMessage.Text = "Cashback has been added";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }
                catch (Exception ex)
                {

                    lblMessage.Visible = true;
                    lblMessage.Text = "An error has occured: " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }


            }
        }
        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CostumerDashboard.aspx");
        }
    }
}