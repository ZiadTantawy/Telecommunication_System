using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecommunication_System.AdminPage2
{
    public partial class LinkedToWallet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code to run when the page loads, if necessary
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            // Get input mobile number
            string mobileNumber = txtMobileNumber.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 11)
            {
                DisplayMessage("Please enter a valid 11-digit mobile number.", "error");
                return;
            }

            // Check if mobile number is linked to a wallet
            CheckWalletLink(mobileNumber);
        }

        private void CheckWalletLink(string mobileNumber)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    // Command to call Wallet_MobileNo function
                    SqlCommand cmd = new SqlCommand("SELECT dbo.Wallet_MobileNo(@mobile_num)", conn);
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);

                    conn.Open();

                    // Execute the command and fetch the result
                    object result = cmd.ExecuteScalar();
                    bool isLinked = result != null && Convert.ToBoolean(result);

                    // Display the result
                    if (isLinked)
                    {
                        DisplayMessage($"The mobile number {mobileNumber} is linked to a wallet.", "success");
                    }
                    else
                    {
                        DisplayMessage($"The mobile number {mobileNumber} is not linked to any wallet.", "error");
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message
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
