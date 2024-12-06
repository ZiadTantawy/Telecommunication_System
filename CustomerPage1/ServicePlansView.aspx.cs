using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Telecommunication_System.CustomerPage1
{
    public partial class ServicePlansView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindServicePlansData();
            }
        }

        private void BindServicePlansData()
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM allServicePlans", conn);
                    cmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        
                        tblServicePlans.Rows.Clear();

                       
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblServicePlans.Rows.Add(headerRow);

                        
                        while (rdr.Read())
                        {
                            TableRow row = new TableRow();
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                TableCell cell = new TableCell();
                                cell.Text = rdr.IsDBNull(i) ? "null" : rdr[i].ToString();
                                row.Cells.Add(cell);
                            }
                            tblServicePlans.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Response.Write($"<script>alert('An error occurred: {ex.Message}');</script>");
            }
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            
            Response.Redirect("CustomerDashboard1.aspx");
        }
    }
}
