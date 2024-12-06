using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.CustomerPage2
{
    public partial class CustomerDashboard2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
            protected void btnAllActiveBenefits_click(object sender, EventArgs e)
            {
                Response.Redirect("AllActiveBenefits.aspx");
            }

            protected void btnExtraPlanAmount_click(object sender, EventArgs e)
            {
                Response.Redirect("ExtraPlanAmount.aspx");
            }

            protected void btnRemPlanAmount_click(object sender, EventArgs e)
            {
                Response.Redirect("RemPlanAmount.aspx");
            }

            protected void btnHighestVoucher_click(object sender, EventArgs e)
            {
                Response.Redirect("HighestVoucher.aspx");
            }

            protected void btnTop10payments_click(object sender, EventArgs e)
            {
                Response.Redirect("Top10payments.aspx");
            }

            protected void btnUnresolvedTickets_click(object sender, EventArgs e)
            {
                Response.Redirect("UnresolvedTickets.aspx");
            }
            protected void CustDash3(object sender, EventArgs e)
            {
                Response.Redirect("../CustomerPage3/CostumerDashboard.aspx");
            }
            protected void CustDashboard1(object sender, EventArgs e)
            {
                Response.Redirect("../CustomerPage1/CustomerDashboard1.aspx");
            }





    }
}
 