using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AdminloginRedirect(object sender, EventArgs e)
        {
            string AdminID = txtAdminID.Text;
            string Password = txtPassword.Text;

            if (AdminID == "admin" && Password == "admin")
            {
                Response.Redirect("AdminPage1/AdminDashboard1.aspx");
                return;
            }
        }
    }
}