using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage1
{
    public partial class CustomerDashboard1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Serviceplans(object sender, EventArgs e)
        {
            Response.Redirect("ServicePlansView.aspx");
        }
        protected void Consumption(object sender, EventArgs e)
        {
            Response.Redirect("ConsumptionView.aspx");
        }
        protected void Otherplans(object sender, EventArgs e)
        {
            Response.Redirect("OtherPlansView.aspx");
        }
        protected void Monthlyusage(object sender, EventArgs e)
        {
            Response.Redirect("MonthlyUsageView.aspx");
        }
        protected void Cashback(object sender, EventArgs e)
        {
            Response.Redirect("CashbackView.aspx");
        }
    }
}