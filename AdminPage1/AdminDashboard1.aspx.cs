using System;
using System.Web.UI;

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
            Response.Redirect("PhysicalStoresPage.aspx");
        }

        protected void btnResolvedTickets_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResolvedTicketsPage.aspx");
        }

        protected void btnCustomerAccounts_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAccountsSubscriptionsPage.aspx");
        }

        protected void btnAccountsByPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAccountsByPlanPage.aspx");
        }

        protected void btnAccountUsage_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountUsagePage.aspx");
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
