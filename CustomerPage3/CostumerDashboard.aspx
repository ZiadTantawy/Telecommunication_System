<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CostumerDashboard.aspx.cs" Inherits="Telecommunication_System.CostumerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
      <title>Customer Dashboard 3</title>
    <style>
        .dashboard-container {
            text-align: center;
            margin-top: 50px;
        }
        .dashboard-container h1 {
            font-size: 36px;
            color: #333;
        }
        .dashboard-button {
            display: block;
            width: 100%;
            margin: 15px auto;
            padding: 10px 20px;
            font-size: 16px;
            color: white;
            background-color: #4CAF50;
            border: none;
            cursor: pointer;
            border-radius: 5px;
            text-align: center;
        }
        .dashboard-button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
    <asp:Button ID="Logout" runat="server" Text="Logout" Onclick="AdminlogoutRedirect"/>
         <div class="dashboard-container">
        <h1>Customer Dashboard 3</h1>
            
            <asp:Button ID="btnViewAllShops" runat="server" Text="View All Shops" CssClass="dashboard-button" OnClick="btnViewAllShops_Click" />
            
            <asp:Button ID="btnServicePlansPast5Month" runat="server" Text="Subscribed Plans Past 5 Months" CssClass="dashboard-button" OnClick="btnViewServicePlansPast5Month" />
             
            <asp:Button ID="RenewSubscription" runat="server" Text="Renew Subscription" CssClass="dashboard-button" OnClick="btnRenewSubscription" />
            
            <asp:Button ID="PaymentCashback" runat="server" Text="Payment Cashback Amount" CssClass="dashboard-button" OnClick="btnPaymentCashback" />
             
            <asp:Button ID="RechargeBalance" runat="server" Text="Recharge Balance" CssClass="dashboard-button" OnClick="btnRechargeBalance"  />

            <asp:Button ID="RedeemVoucher" runat="server" Text="Redeem Voucher" CssClass="dashboard-button" OnClick="btnRedeemVoucher"  />

             <asp:Button ID="backbtn" runat="server" CssClass="dashboard-button" Text="Back to Customer Dashboard 2" onclick="CustDashboard2"/>
                        
        </div>
    </form>
</body>
</html>