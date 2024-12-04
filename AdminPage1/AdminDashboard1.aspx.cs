using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System.AdminPage1
{
    public partial class AdminDashboard1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCustomerProfiles_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerProfilesView.aspx");
        }

        protected void btnPhysicalStores_Click(object sender, EventArgs e)
        {
            Response.Redirect("PhysicalStoresView.aspx");
        }

        protected void btnResolvedTickets_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllResolvedTickets.aspx");
        }

        protected void btnCustomerAccounts_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAccountSubscriptionsPage.aspx");
        }

        protected void btnAccountsByPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAccountsPlanDate.aspx");
        }

        protected void btnAccountUsage_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerUsagePage.aspx");
        }

        protected void btnRemoveBenefits_Click(object sender, EventArgs e)
        {
            Response.Redirect("RemoveBenefitsPage.aspx");
        }

        protected void btnSmsOffers_Click(object sender, EventArgs e)
        {
            Response.Redirect("SmsOffersPage.aspx");
        }
    }
}
