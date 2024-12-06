using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage2
{
    public partial class Top10payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        protected void checkid(object sender, EventArgs e)
        {
            string Mobilenumber = MobileNumber.Text;

            if (!string.IsNullOrEmpty(Mobilenumber) && Mobilenumber.Length == 11)
            {
                Response.Write(Mobilenumber);
                ShowTop10Payments(Mobilenumber);
            }
            else
            {
                lblMessage.Text = "Please enter a valid mobile number.";
                lblMessage.Visible = true;
            }
        }

        private void ShowTop10Payments(string Mobilenumber)
        {

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;
            string query = "dbo.Top_Successful_Payments";

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mobile_num",Mobilenumber);
                        conn.Open();

                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                GridViewTopPayments.DataSource = dataTable;
                                GridViewTopPayments.DataBind();
                                lblMessage.Visible = false;
                                GridViewTopPayments.Visible = true;
                            }
                            else
                            {
                                lblMessage.Text = "No payments found for this mobile number.";
                                lblMessage.Visible = true;
                                GridViewTopPayments.Visible = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "An error occurred:" + ex.Message;
                    lblMessage.Visible = true;
                    GridViewTopPayments.Visible = false;
                }
            }
        }
        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDashboard2.aspx");
        }
    }
}
