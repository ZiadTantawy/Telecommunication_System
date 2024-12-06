using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage3
{
    public partial class Last5MonthSub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Only execute on the initial page load
                BindGridView();
            }
        }

        private void BindGridView()
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            string query = "Select * from dbo.Subscribed_plans_5_Months(@MobileNo)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MobileNo", Session["MobileNumber"].ToString());
                        conn.Open();

                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            if (dataTable.Rows.Count == 0)
                            {
                                lblMessage.Text = "You have no Subscriptions in the last 5 months";
                                lblMessage.Visible = true;
                                GridViewServicePlans.Visible = false;
                            }
                            else
                            {
                                GridViewServicePlans.DataSource = dataTable;
                                GridViewServicePlans.DataBind();
                                lblMessage.Visible = false;
                                GridViewServicePlans.Visible = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "An error has occurred: " + ex.Message;
                    lblMessage.Visible = true;
                    GridViewServicePlans.Visible = false;
                }
            }
        }

                 protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDashboard2.aspx");
        }
    
    }
    
}
