using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Telecommunication_System.CustomerPage1
{
    public partial class OtherPlansView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Retrieve the mobile number from the session and display it in the label
            string mobileNo = Session["MobileNumber"] as string;

            if (!string.IsNullOrWhiteSpace(mobileNo))
            {
                lblMobileNo.Text = mobileNo; // Display the mobile number
            }
            else
            {
                lblMobileNo.Text = "Mobile number not found.";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Retrieve the mobile number from the session
            string mobileNo = Session["MobileNumber"] as string;

            // Validate the mobile number
            if (string.IsNullOrWhiteSpace(mobileNo) || mobileNo.Length != 11 || !long.TryParse(mobileNo, out _))
            {
                Response.Write("<script>alert('Invalid Mobile Number in session.');</script>");
                return;
            }

            // Call the method to fetch and display unsubscribed plans
            BindUnsubscribedPlans(mobileNo);
        }

        private void BindUnsubscribedPlans(string mobileNo)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    // Correct parameter name to match the stored procedure
                    SqlCommand cmd = new SqlCommand("Unsubscribed_Plans", conn);
                    cmd.CommandType = CommandType.StoredProcedure; // Call stored procedure

                    // Ensure the parameter name matches exactly
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNo); // Pass the correct parameter name

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        Table tblUnsubscribedPlans = new Table { CssClass = "styled-table" };

                        // Create header row
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblUnsubscribedPlans.Rows.Add(headerRow);

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
                            tblUnsubscribedPlans.Rows.Add(row);
                        }

                        // Add the dynamically created table to the form
                        form1.Controls.Add(tblUnsubscribedPlans);
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
