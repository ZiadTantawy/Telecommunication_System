using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage2
{
    public partial class ShowTicketCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                checkinput();
            }
        }

        protected void checkinput(object sender, EventArgs e)
        {
            string nationalID = NationalID.Text; 

            if (!string.IsNullOrEmpty(nationalID))
            {
                TicketCount(nationalID); 
            }
            else
            {
                lblMessage.Text = "Please enter a valid National ID."; 
                lblMessage.Visible = true;
            }
        }

        private void TicketCount(string nationalID)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ToString();
            string storedProcedure = "Ticket_Account_Customer"; 

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NID", nationalID); 
                    conn.Open();
                    object result = cmd.ExecuteScalar(); 
                    if (result != null)
                    {
                        lblMessage.Text = $"Unresolved Tickets: {result.ToString()}"; 
                        lblMessage.Visible = true;
                    }
                    else
                    {
                        lblMessage.Text = "No unresolved tickets found for this National ID."; 
                        lblMessage.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "An error occurred";
                lblMessage.Visible = true;
            }
        }
        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDashboard2.aspx");
        }
    }
}
