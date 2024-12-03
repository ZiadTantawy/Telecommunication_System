<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CostumerDashboard.aspx.cs" Inherits="Telecommunication_System.CostumerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Customer Dashboard
            <br/>
            <asp:Button ID="btnViewAllShops" runat="server" Text="View All Shops" OnClick="btnViewAllShops_Click" />
            <br/>
            <asp:Button ID="btnServicePlansPast5Month" runat="server" Text="Subscribed Plans Past 5 Months" OnClick="btnViewServicePlansPast5Month" />
            <br/>
            <asp:Button ID="RenewSubscription" runat="server" Text="Renew Subscription" OnClick="btnRenewSubscription" />
                        
        </div>
    </form>
</body>
</html>