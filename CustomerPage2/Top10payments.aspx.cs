using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage2
{
    public partial class Top10payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                lblMessage.Visible = false;
                GridViewTopPayments.Visible = false;
            }
        }
        protected void checkid(object sender, EventArgs e)
        {
            string mobileNumber = MobileNumber.Text; 

            if (!string.IsNullOrEmpty(mobileNumber))
            {
                ShowTop10Payments(mobileNumber);
            }
            else
            {
                lblMessage.Text = "Please enter a valid mobile number.";
                lblMessage.Visible = true;
            }
        }

        private void ShowTop10Payments(string mobileNumber)
        {

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;
            string query = "Top_Successful_Payments";
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@mobile_num", mobileNumber); 
                    dataAdapter.Fill(dataTable);
                }

                if (dataTable.Rows.Count > 0)
                {
                        
                    GridViewTopPayments.DataSource = dataTable; 
                    GridViewTopPayments.DataBind();
                    lblMessage.Visible = false;
                    GridViewTopPayments.Visible = true;
                }
                else
                {
                    lblMessage.Text = "No payments found for this mobile number.";
                    lblMessage.Visible = true;  
                    GridViewTopPayments.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred:" + ex.Message; 
                lblMessage.Visible = true;
                GridViewTopPayments.Visible = false;
            }   
            }
        }
    }
}