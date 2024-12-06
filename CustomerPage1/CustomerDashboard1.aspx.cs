using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage1
{
    public partial class CustomerDashboard1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page load logic (if any)
        }

        protected void ServicePlans(object sender, EventArgs e)
        {
            Response.Redirect("ServicePlansView.aspx");
        }

        protected void Consumption(object sender, EventArgs e)
        {
            Response.Redirect("ConsumptionView.aspx");
        }

        protected void OtherPlans(object sender, EventArgs e)
        {
            Response.Redirect("OtherPlansView.aspx");
        }

        protected void MonthlyUsage(object sender, EventArgs e)
        {
            Response.Redirect("MonthlyUsageView.aspx");
        }

        protected void Cashback(object sender, EventArgs e)
        {
            Response.Redirect("CashbackView.aspx");
        }

        // Redirect to another dashboard (Dashboard 2)
        protected void RedirectToDashboard2(object sender, EventArgs e)
        {
            Response.Redirect("../CustomerPage3/CostumerDashboard.aspx"); // Adjust this if the URL or page name is different
        }
        protected void AdminlogoutRedirect(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
            Session.Clear();
        }
    }
}
