<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDashboard2.aspx.cs" Inherits="Telecommunication_System.CustomerPage2.CustomerDashboard2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Dashboard</title>
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
        <div class="dashboard-container">
            <h1>Customer Dashboard</h1>
            <asp:Button ID="btnAllActiveBenefits" runat="server" Text="View All Active Benefits" CssClass="dashboard-button" OnClick="btnAllActiveBenefits_click" />
            <asp:Button ID="btnExtraPlanAmount" runat="server" Text="Calculate Extra Plan Amount" CssClass="dashboard-button" OnClick="btnExtraPlanAmount_click" />
            <asp:Button ID="btnHighestVoucher" runat="server" Text="View Highest Voucher" CssClass="dashboard-button" OnClick="btnHighestVoucher_click" />
            <asp:Button ID="btnRemPlanAmount" runat="server" Text="Calculate Remaining Plan Amount" CssClass="dashboard-button" OnClick="btnRemPlanAmount_click" />
            <asp:Button ID="btnTop10payments" runat="server" Text="Show Top 10 Payments" CssClass="dashboard-button" OnClick="btnTop10payments_click" />
            <asp:Button ID="btnUnresolvedTickets" runat="server" Text="View Unresolved Tickets" CssClass="dashboard-button" OnClick="btnUnresolvedTickets_click" />
        </div>
    </form>
</body>
</html>
