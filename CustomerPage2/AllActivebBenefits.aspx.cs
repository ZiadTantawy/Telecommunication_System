using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;  
using System.Data;

namespace Telecommunication_System.CustomerPage2
{
    public partial class AllActiveBenefits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                lblMessage.Visible = false;
                ActiveBenefits();
            }
        }
        private void ActiveBenefits()
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;
            string query = "select * from Benefits where status = 'active'";
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if(dataTable.Rows.Count > 0)
                    {
                        GridViewAllBenefits.DataSource = dataTable; 
                        GridViewAllBenefits.DataBind();
                    }
                    else{
                        lblMessage.Text = "No active benefits found.";
                        lblMessage.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred while loading benefits: " + ex.Message;
                lblMessage.Visible = true;
            }
        }
    }   
}
    
