using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System.AdminPage2
{
    public partial class ViewAmountReturnedCashback : System.Web.UI.Page
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

            // Bind cashback amount data for the given mobile number
            BindCashbackAmountData(mobileNumber);
        }

        private void BindCashbackAmountData(string mobileNumber)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    // Modify the command to call the stored procedure for cashback amount
                    SqlCommand cmd = new SqlCommand("Wallet_Cashback_Amount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@walletID", GetWalletID(mobileNumber)); // This is a placeholder for getting wallet ID
                    cmd.Parameters.AddWithValue("@planID", GetPlanID(mobileNumber)); // This is a placeholder for getting plan ID

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        // Clear any existing rows in the table
                        tblCashbackAmount.Rows.Clear();

                        // Create header row (columns for the table)
                        TableRow headerRow = new TableRow();
                        headerRow.Cells.Add(new TableCell { Text = "Cashback Amount" });
                        tblCashbackAmount.Rows.Add(headerRow);

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

                                tblCashbackAmount.Rows.Add(row);
                            }
                        }
                        else
                        {
                            // If no data is returned, show 0 for cashback amount
                            TableRow row = new TableRow();
                            row.Cells.Add(new TableCell { Text = "0" });
                            tblCashbackAmount.Rows.Add(row);
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

        private int GetWalletID(string mobileNumber)
        {
            // Logic to get wallet ID based on mobile number (you need to implement this function)
            return 1; // Placeholder for wallet ID
        }

        private int GetPlanID(string mobileNumber)
        {
            // Logic to get plan ID based on mobile number (you need to implement this function)
            return 1; // Placeholder for plan ID
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard2.aspx"); // Navigate back to admin dashboard
        }
    }
}
