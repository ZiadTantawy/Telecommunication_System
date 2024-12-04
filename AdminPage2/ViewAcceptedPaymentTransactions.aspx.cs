using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System.AdminPage2
{
    public partial class ViewAcceptedPaymentTransactions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code that runs when the page is loaded
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string mobileNumber = txtMobileNumber.Text.Trim();

            if (string.IsNullOrEmpty(mobileNumber))
            {
                // Show a message if the mobile number is not entered
                lblStatus.Text = "Please enter a valid mobile number.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Bind payment transactions data for the given mobile number
            BindPaymentTransactionsData(mobileNumber);
        }

        private void BindPaymentTransactionsData(string mobileNumber)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    // Modify the command to call the stored procedure
                    SqlCommand cmd = new SqlCommand("Account_Payment_Points", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        // Clear any existing rows in the table
                        tblTransactions.Rows.Clear();

                        // Create header row (columns for the table)
                        TableRow headerRow = new TableRow();
                        headerRow.Cells.Add(new TableCell { Text = "Payment Count" });
                        headerRow.Cells.Add(new TableCell { Text = "Points Amount" });
                        tblTransactions.Rows.Add(headerRow);

                        // Check if the result exists
                        if (rdr.HasRows)
                        {
                            // Add data rows if results exist
                            while (rdr.Read())
                            {
                                TableRow row = new TableRow();

                                // Check for null and show 0 if the result is null
                                TableCell cell1 = new TableCell();
                                cell1.Text = rdr.IsDBNull(0) ? "0" : rdr[0].ToString();
                                row.Cells.Add(cell1);

                                TableCell cell2 = new TableCell();
                                cell2.Text = rdr.IsDBNull(1) ? "0" : rdr[1].ToString();
                                row.Cells.Add(cell2);

                                tblTransactions.Rows.Add(row);
                            }
                        }
                        else
                        {
                            // If no data is returned, show 0 for both columns
                            TableRow row = new TableRow();
                            row.Cells.Add(new TableCell { Text = "0" });
                            row.Cells.Add(new TableCell { Text = "0" });
                            tblTransactions.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message
                lblStatus.Text = "An error occurred: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard2.aspx"); // Navigate back to admin dashboard
        }
    }
}
