using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Telecommunication_System.CustomerPage1
{
    public partial class ConsumptionView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string planName = txtplanName.Text.Trim();
            string startDateText = txtstartDate.Text.Trim();
            string endDateText = txtendDate.Text.Trim();

            // Validate subscription date and plan ID
            if (string.IsNullOrWhiteSpace(planName) || string.IsNullOrWhiteSpace(startDateText) || string.IsNullOrWhiteSpace(endDateText))
            {
                // Display error if inputs are missing
                Response.Write("<script>alert('Please provide Plan name and start and end dates.');</script>");
                return;
            }

            DateTime startDate, endDate;

            // Validate start date format
            if (!DateTime.TryParse(startDateText, out startDate))
            {
                Response.Write("<script>alert('Invalid start date format. Please use the format YYYY-MM-DD.');</script>");
                return;
            }

            // Validate end date format
            if (!DateTime.TryParse(endDateText, out endDate))
            {
                Response.Write("<script>alert('Invalid end date format. Please use the format YYYY-MM-DD.');</script>");
                return;
            }

            // Ensure start date is earlier than or equal to end date
            if (startDate > endDate)
            {
                Response.Write("<script>alert('Start date cannot be later than end date.');</script>");
                return;
            }

            // Call the method to bind data with the validated date and plan name
            BindConsumptionData(planName, startDate, endDate);
        }

        private void BindConsumptionData(string planName, DateTime startDate, DateTime endDate)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    // Query to execute the function or stored procedure
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Consumption(@Plan_name, @start_date, @end_date)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Plan_name", planName);
                    cmd.Parameters.AddWithValue("@start_date", startDate);
                    cmd.Parameters.AddWithValue("@end_date", endDate);

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        tblPlanconsumption.Rows.Clear();

                        // Create header row
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblPlanconsumption.Rows.Add(headerRow);

                        // Add data rows
                        while (rdr.Read())
                        {
                            TableRow row = new TableRow();
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                TableCell cell = new TableCell();
                                cell.Text = (rdr.IsDBNull(i) ? "null" : rdr[i].ToString());
                                row.Cells.Add(cell);
                            }
                            tblPlanconsumption.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error if any exception occurs
                Response.Redirect($"ErrorPage.aspx?message={Server.UrlEncode("An error occurred: " + ex.Message)}");
            }
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDashboard1.aspx");
        }
    }
}
