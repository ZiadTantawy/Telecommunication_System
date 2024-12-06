using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System.AdminPage1
{
    public partial class CustomerAccountSubscriptionsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAccountPlanData();
            }
        }

        private void BindAccountPlanData()
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    SqlCommand cmd = new SqlCommand("Account_Plan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        
                        tblAccountPlans.Rows.Clear();

                        
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblAccountPlans.Rows.Add(headerRow);

                        
                        while (rdr.Read())
                        {
                            TableRow row = new TableRow();
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                TableCell cell = new TableCell();
                                cell.Text = (rdr.IsDBNull(i) ? "null" : rdr[i].ToString());
                                row.Cells.Add(cell);
                            }
                            tblAccountPlans.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Redirect($"ErrorPage.aspx?message={Server.UrlEncode("An error occurred: " + ex.Message)}");
            }
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard1.aspx");
        }
    }
}
