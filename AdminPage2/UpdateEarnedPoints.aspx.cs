using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Telecommunication_System.AdminPage2
{
    public partial class UpdateEarnedPoints : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code to run when the page loads, if necessary
        }

        protected void btnUpdatePoints_Click(object sender, EventArgs e)
        {
            // Get the mobile number from the input
            string mobileNumber = txtMobileNumber.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 11)
            {
                DisplayMessage("Please enter a valid 11-digit mobile number.", "error");
                return;
            }

            // Call the stored procedure to update points
            UpdatePointsForMobileNumber(mobileNumber);
        }

        private void UpdatePointsForMobileNumber(string mobileNumber)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    // Command to execute the stored procedure
                    SqlCommand cmd = new SqlCommand("Total_Points_Account", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Add mobile number as parameter
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // If rows are affected, assume success
                    if (rowsAffected > 0)
                    {
                        DisplayMessage($"The earned points for mobile number {mobileNumber} have been successfully updated.", "success");
                    }
                    else
                    {
                        DisplayMessage($"No points were updated for mobile number {mobileNumber}.", "error");
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
            // Set the panel visibility
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
