using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage3
{
    public partial class RedeemVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }
        protected void Redeem(object sender, EventArgs e)
        {
            string voucherIDInput = VoucherID.Text;

            if(int.TryParse(voucherIDInput, out int voucherID))
            {
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Text = "Please enter a valid Voucher ID";
                lblMessage.Visible = true;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.Redeem_voucher_points")) 
                    {
                        cmd.Parameters.AddWithValue("@mobile_num", Session["MobileNumber"]);
                        cmd.Parameters.AddWithValue("@voucher_id",voucherID);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        lblMessage.Text = "Voucher reedemed successfully";
                        lblMessage.Visible = true;
                        lblMessage.ForeColor = System.Drawing.Color.Green;

                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "An error has occured : "+ ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Visible = true;
                }
            }
        }
    }
}