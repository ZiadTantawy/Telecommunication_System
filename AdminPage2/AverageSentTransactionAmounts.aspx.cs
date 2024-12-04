using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace Telecommunication_System.AdminPage2
{
    public partial class AverageSentTransactionAmounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code to run on page load, if necessary
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Get input values
            int walletID;
            string startDate = txtStartDate.Text.Trim();
            string endDate = txtEndDate.Text.Trim();

            // Validate inputs
            if (!int.TryParse(txtWalletID.Text.Trim(), out walletID) || string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate))
            {
                DisplayMessage("Please provide valid inputs for Wallet ID and Date Range.", "error");
                return;
            }

            // Bind average transaction data
            BindTransactionData(walletID, startDate, endDate);
        }

        private void BindTransactionData(int walletID, string startDate, string endDate)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("Wallet_Transfer_Amount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@walletID", walletID);
                    cmd.Parameters.AddWithValue("@start_date", startDate);
                    cmd.Parameters.AddWithValue("@end_date", endDate);

                    conn.Open();

                    // Execute the command and fetch the result
                    object result = cmd.ExecuteScalar();
                    int avgAmount = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    // Display result in a styled box
                    DisplayMessage($"The average transaction amount is: {avgAmount} units.", "success");
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                DisplayMessage("An error occurred: " + ex.Message, "error");
            }
        }

        private void DisplayMessage(string message, string type)
        {
            // Set the panel and label visibility
            pnlStatus.Visible = true;

            // Apply styles based on the message type
            if (type == "success")
            {
                pnlStatus.CssClass = "box success-box";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pnlStatus.CssClass = "box error-box";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }

            // Set the message text
            lblStatus.Text = message;
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard2.aspx");
        }
    }
}
