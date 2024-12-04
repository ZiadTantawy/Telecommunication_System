<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CostumerDashboard.aspx.cs" Inherits="Telecommunication_System.CostumerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Customer Dashboard 3</h1>
        <div>
            <br/>
            <asp:Button ID="btnViewAllShops" runat="server" Text="View All Shops" OnClick="btnViewAllShops_Click" />
            <br/>
            <asp:Button ID="btnServicePlansPast5Month" runat="server" Text="Subscribed Plans Past 5 Months" OnClick="btnViewServicePlansPast5Month" />
            <br/>
            <asp:Button ID="RenewSubscription" runat="server" Text="Renew Subscription" OnClick="btnRenewSubscription" />
            <br/>
            <asp:Button ID="PaymentCashback" runat="server" Text="Payment Cashback Amount" OnClick="btnPaymentCashback" />
            <br/>
            <asp:Button ID="RechargeBalance" runat="server" Text="Recharge Balance" OnClick="btnRechargeBalance"  />
            <br/>
            <asp:Button ID="RedeemVoucher" runat="server" Text="Redeem Voucher" OnClick="btnRedeemVoucher"  />
                        
        </div>
    </form>
</body>
</html>