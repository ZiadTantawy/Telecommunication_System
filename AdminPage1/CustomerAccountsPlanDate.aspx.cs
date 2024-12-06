using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System.AdminPage1
{
    public partial class CustomerAccountsByPlanPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string subscriptionDate = txtDate.Text.Trim();
            string planID = txtPlanID.Text.Trim();

            // Validate subscription date and plan ID
            if (string.IsNullOrWhiteSpace(subscriptionDate) || string.IsNullOrWhiteSpace(planID))
            {
                // Display error if inputs are missing
                Response.Write("<script>alert('Please provide both subscription date and plan ID.');</script>");
                return;
            }

            DateTime parsedDate;

            // Validate if the date is in correct format
            if (!DateTime.TryParse(subscriptionDate, out parsedDate))
            {
                Response.Write("<script>alert('Invalid date format. Please use the format YYYY-MM-DD.');</script>");
                return;
            }

            BindCustomerAccountsData(parsedDate, planID);
        }

        private void BindCustomerAccountsData(DateTime subscriptionDate, string planID)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Account_Plan_date(@sub_date, @plan_id)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@sub_date", subscriptionDate);
                    cmd.Parameters.AddWithValue("@plan_id", planID);        

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        tblCustomerAccounts.Rows.Clear();

                        // Create header row
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblCustomerAccounts.Rows.Add(headerRow);

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
                            tblCustomerAccounts.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Redirect($"ErrorPage.aspx?message={Server.UrlEncode("An error occurred: " + ex.Message)}");
            }
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard1.aspx");
        }
    }
}
