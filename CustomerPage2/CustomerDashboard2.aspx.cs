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
            protected void btnAllActiveBenefits(object sender, EventArgs e)
            {
                Response.Redirect("AllActiveBenefits.aspx");
            }

            protected void btnExtraPlanAmount(object sender, EventArgs e)
            {
                Response.Redirect("ExtraPlanAmount.aspx");
            }

            protected void btnRemPlanAmount(object sender, EventArgs e)
            {
                Response.Redirect("RemPlanAmount.aspx");
            }

            protected void btnHighestVoucher(object sender, EventArgs e)
            {
                Response.Redirect("HighestVoucher.aspx");
            }

            protected void btnTop10payments(object sender, EventArgs e)
            {
                Response.Redirect("Top10payments.aspx");
            }

            protected void btnUnresolvedTickets(object sender, EventArgs e)
            {
                Response.Redirect("UnresolvedTickets.aspx");
            }



        
    }
}
 