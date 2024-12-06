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
           
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string mobileNumber = txtMobileNumber.Text.Trim();

            if (string.IsNullOrEmpty(mobileNumber))
            {
                
                lblStatus.Text = "Please enter a valid mobile number.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            
            BindSMSOffersData(mobileNumber);
        }

        private void BindSMSOffersData(string mobileNumber)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Account_SMS_Offers(@mobile_num)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNumber);

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        
                        tblSMSOffers.Rows.Clear();

                        
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblSMSOffers.Rows.Add(headerRow);

                        
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
                
                lblStatus.Text = "An error occurred: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }


        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard1.aspx"); 
        }
    }
}
