using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecommunication_System.CustomerPage1
{
    public partial class MonthlyUsageView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string mobileNo = txtMno.Text.Trim();

            // Validate the mobile number
            if (string.IsNullOrWhiteSpace(mobileNo) || mobileNo.Length != 11 || !long.TryParse(mobileNo, out _))
            {
                Response.Write("<script>alert('Please enter a valid 11-digit Mobile Number.');</script>");
                return;
            }

            // Call the method to fetch and display monthly usage
            BindMonthlyUsage(mobileNo);
        }

        private void BindMonthlyUsage(string mobileNo)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    // Use the SQL function to fetch monthly usage
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Usage_Plan_CurrentMonth(@MobileNo)", conn);
                    cmd.CommandType = CommandType.Text; // SQL functions are called as text
                    cmd.Parameters.AddWithValue("@MobileNo", mobileNo);

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        tblMonthlyUsage.Rows.Clear();

                        // Create header row
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblMonthlyUsage.Rows.Add(headerRow);

                        // Add data rows
                        while (rdr.Read())
                        {
                            TableRow row = new TableRow();
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                TableCell cell = new TableCell();
                                cell.Text = rdr.IsDBNull(i) ? "null" : rdr[i].ToString();
                                row.Cells.Add(cell);
                            }
                            tblMonthlyUsage.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Redirect to an error page if an exception occurs
                Response.Redirect($"ErrorPage.aspx?message={Server.UrlEncode("An error occurred: " + ex.Message)}");
            }
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDashboard1.aspx");
        }
    }
}
    