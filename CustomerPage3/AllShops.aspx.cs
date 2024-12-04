using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage3
{
    public partial class AllShops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ToString();
            

            string query = "SELECT * FROM allShops";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connStr);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);


                    GridViewAllShops.DataSource = dataTable;
                    GridViewAllShops.DataBind();

                }
                catch (Exception)
                {
                    Response.Write("An error has occured"); 
                }
            }

        }
    }
}