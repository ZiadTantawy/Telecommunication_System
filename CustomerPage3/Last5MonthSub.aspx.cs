using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerContent3
{
    public partial class Last5MonthSub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

                        using(SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                         
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);


                            if (dataTable.Rows.Count == 0)
                            {
                                lblMessage.Text = "You have no Subsciptions in the last 5 month";
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
                catch(Exception ex)
                {
                    Response.Write("An error has occured: "+ex.Message);
                }
            }
        }
    }
}