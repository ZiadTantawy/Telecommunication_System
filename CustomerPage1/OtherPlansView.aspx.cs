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
            
            string mobileNo = Session["MobileNumber"] as string;

            if (!string.IsNullOrWhiteSpace(mobileNo))
            {
                lblMobileNo.Text = mobileNo; 
            }
            else
            {
                lblMobileNo.Text = "Mobile number not found.";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
            string mobileNo = Session["MobileNumber"] as string;

            
            if (string.IsNullOrWhiteSpace(mobileNo) || mobileNo.Length != 11 || !long.TryParse(mobileNo, out _))
            {
                Response.Write("<script>alert('Invalid Mobile Number in session.');</script>");
                return;
            }

            
            BindUnsubscribedPlans(mobileNo);
        }

        private void BindUnsubscribedPlans(string mobileNo)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    
                    SqlCommand cmd = new SqlCommand("Unsubscribed_Plans", conn);
                    cmd.CommandType = CommandType.StoredProcedure; 

                    
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNo); 

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        Table tblUnsubscribedPlans = new Table { CssClass = "styled-table" };

                        
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblUnsubscribedPlans.Rows.Add(headerRow);

                        
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

                        
                        form1.Controls.Add(tblUnsubscribedPlans);
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
            Response.Redirect("CustomerDashboard1.aspx");
        }
    }
}
