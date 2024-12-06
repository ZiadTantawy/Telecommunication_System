using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System.AdminPage1
{
    public partial class CustomerUsagePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string mobileNumber = txtMobileNumber.Text.Trim();
            string startDateText = txtStartDate.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(mobileNumber) || string.IsNullOrWhiteSpace(startDateText))
            {
                
                Response.Write("<script>alert('Please provide both mobile number and start date.');</script>");
                return;
            }

            DateTime startDate;

            
            if (!DateTime.TryParse(startDateText, out startDate))
            {
                
                Response.Write("<script>alert('Invalid date format. Please use the format YYYY-MM-DD.');</script>");
                return;
            }

            
            DisplayUsageData(mobileNumber, startDate);
        }

        private void DisplayUsageData(string mobileNumber, DateTime startDate)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Account_Usage_Plan(@mobile_num, @start_date)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);
                    cmd.Parameters.AddWithValue("@start_date", startDate);

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        tblUsageData.Rows.Clear();

                        
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblUsageData.Rows.Add(headerRow);

                        
                        while (rdr.Read())
                        {
                            TableRow row = new TableRow();
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                TableCell cell = new TableCell();
                                cell.Text = (rdr.IsDBNull(i) ? "null" : rdr[i].ToString());
                                row.Cells.Add(cell);
                            }
                            tblUsageData.Rows.Add(row);
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
            Response.Redirect("AdminDashboard1.aspx"); // Navigate back to the admin dashboard (or any other page you choose)
        }
    }
}
