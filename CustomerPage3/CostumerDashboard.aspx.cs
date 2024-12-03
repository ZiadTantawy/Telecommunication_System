﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Telecommunication_System
{
    public partial class CostumerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnViewAllShops_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerContent3/AllShops.aspx");
        }
        protected void btnViewServicePlansPast5Month(object sender, EventArgs e)
        {
            Response.Redirect("CustomerContent3/Last5MonthSub.aspx");
        }

        protected void btnRenewSubscription (object sender, EventArgs e)
        {
            Response.Redirect("CustomerContent3/RenewSubscription.aspx");
        }
        

    }
}