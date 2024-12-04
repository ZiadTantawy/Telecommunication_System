using System;
using System.Web.UI;

namespace Telecommunication_System
{
    public partial class AdminDashboard2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Logic to run only the first time the page is loaded
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button1
            Response.Redirect("ViewWalletDetails.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button2
            Response.Redirect("ViewShopsList.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button3
            Response.Redirect("ViewPaymentTransactions.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button4
            Response.Redirect("ViewCashbackTransactions.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button5
            Response.Redirect("ViewAcceptedPaymentTransactions.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button6
            Response.Redirect("ViewAmountReturnedCashback.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button7
            Response.Redirect("AverageSentTransactionAmounts.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button8
            Response.Redirect("LinkedToWallet.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            // Redirect to a new page for Button9
            Response.Redirect("UpdateEarnedPoints.aspx");
        }
    }
}
