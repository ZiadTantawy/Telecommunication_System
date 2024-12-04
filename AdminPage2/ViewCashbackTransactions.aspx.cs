using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System
{
    public partial class ViewNumOfCashbackDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Only bind data on the first load of the page (to avoid re-binding on postbacks)
            if (!IsPostBack)
            {
                LoadNumOfCashbackDetails();
            }
        }

        // Function to load the number of cashback details from the database
        private void LoadNumOfCashbackDetails()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Num_of_cashback", conn);
                    cmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tblNumOfCashbackDetails.Rows.Clear();  // Clear previous data from the table

                        // Add header row for the table
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = reader.GetName(i);  // Use field name as the header
                            headerRow.Cells.Add(headerCell);
                        }
                        tblNumOfCashbackDetails.Rows.Add(headerRow);

                        // Add data rows
                        while (reader.Read())
                        {
                            TableRow dataRow = new TableRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                TableCell dataCell = new TableCell();
                                dataCell.Text = reader.IsDBNull(i) ? "N/A" : reader[i].ToString(); // Use "N/A" for null values
                                dataRow.Cells.Add(dataCell);
                            }
                            tblNumOfCashbackDetails.Rows.Add(dataRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error loading data: {ex.Message}";
            }
        }

        // Redirect back to the admin dashboard
        protected void GoBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard2.aspx");  // Navigate to admin dashboard or modify as per your requirement
        }
    }
}
