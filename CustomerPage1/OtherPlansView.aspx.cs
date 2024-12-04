using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage1
{
    public partial class OtherPlansView : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Unsubscribed_Plans(@MobileNo)", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MobileNo", mobileNo);

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        Table tblOtherPlans = new Table { CssClass = "styled-table" };

                        // Create header row
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblOtherPlans.Rows.Add(headerRow);

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
                            tblOtherPlans.Rows.Add(row);
                        }

                        // Add the dynamically created table to the form
                        form1.Controls.Add(tblOtherPlans);
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
    