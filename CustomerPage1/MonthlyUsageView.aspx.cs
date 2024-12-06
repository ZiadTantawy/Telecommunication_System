using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Telecommunication_System.CustomerPage1
{
    public partial class MonthlyUsageView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["MobileNumber"] != null)
                {
                    
                    string mobileNo = Session["MobileNumber"].ToString();

                   
                    lblMobileNumber.Text = mobileNo;

                    
                    tblMonthlyUsage.Rows.Clear();
                }
                else
                {
                    
                    Response.Redirect("LoginPage.aspx"); 
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
            string mobileNo = Session["MobileNumber"].ToString();

            
            BindMonthlyUsage(mobileNo);
        }

        private void BindMonthlyUsage(string mobileNo)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Usage_Plan_CurrentMonth(@mobile_num)", conn);
                    cmd.CommandType = CommandType.Text; 
                    cmd.Parameters.AddWithValue("@mobile_num", mobileNo);

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        tblMonthlyUsage.Rows.Clear(); 

                        
                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblMonthlyUsage.Rows.Add(headerRow);

                       
                        while (rdr.Read())
                        {
                            TableRow row = new TableRow();
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                TableCell cell = new TableCell();
                                cell.Text = rdr.IsDBNull(i) ? "null" : rdr[i].ToString();
                                row.Cells.Add(cell);
                            }
                            tblMonthlyUsage.Rows.Add(row);
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
            
            Response.Redirect("CustomerDashboard1.aspx");
        }
    }
}
