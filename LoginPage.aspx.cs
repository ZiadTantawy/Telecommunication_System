using System;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;

namespace Telecommunication_System
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            string mobileNumber = txtMobileNumber.Text.Trim();
            string password = txtPassword.Text;

            // Admin login logic
            if (mobileNumber == "admin" && password == "admin")
            {
                Response.Redirect("AdminPage1.aspx");
                return;
            }

            // Database login logic
            string connectionString = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Response.Write("connect");

                    // Call your stored SQL function for user validation
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.AccountLoginValidation(@mobile_num, @pass)", conn))
                    {
                        cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);
                        cmd.Parameters.AddWithValue("@pass", password);

                        // Execute the function and get the result
                        var result = cmd.ExecuteScalar();
                        conn.Close();
                        Response.Write(result.ToString());
                        // Check if the result is 1 (valid login)
                        if (result != null && result.ToString() == "True")
                        {
                            Response.Write("redirect");
                            // Redirect to user dashboard or another page on successful login
                            Response.Redirect("CustomerPage1/CostumerDashboard.aspx"); // Replace with actual user page
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}
