using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System.AdminPage1
{
    public partial class AccountSMSOffers : System.Web.UI.Page
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

            // Bind SMS offers data for the given mobile number
            BindSMSOffersData(mobileNumber);
        }

        private void BindSMSOffersData(string mobileNumber)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    // Modify the command to call the TVF like a SELECT query
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Account_SMS_Offers(@mobile_num)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        // Clear any existing rows in the table
                        tblSMSOffers.Rows.Clear();

                        // Create header row
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblSMSOffers.Rows.Add(headerRow);

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
                            tblSMSOffers.Rows.Add(row);
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
            Response.Redirect("AdminDashboard1.aspx"); // Navigate back to admin dashboard
        }
    }
}
