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


            //Intialize amount
            if (decimal.TryParse(amountInput, out decimal amount))
            {
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Text = "Please Enter a vaild amount";
                lblMessage.Visible = false;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

            //Initlaize Payment Method
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
                    using (SqlCommand cmd = new SqlCommand("dbo.Initiate_balance_payment", conn)) { 
                        cmd.Parameters.AddWithValue("@mobile_num", Session["MobileNumber"]);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@payment_method", paymentMethod);
                        Response.Write(amount + " " + paymentMethod);


                        conn.Open();
                        
                        cmd.ExecuteNonQuery();
                        
                        
                        

                        lblMessage.Text = "Account Recharged Successfully";
                        lblMessage.Visible = true;
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }

                catch (Exception ex)
                {
                    lblMessage.Text = "An error has occured : " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Visible = true;
                        
                }
                    
            }
        }

    }
}
