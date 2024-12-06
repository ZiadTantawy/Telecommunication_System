<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard1.aspx.cs" Inherits="Telecommunication_System.AdminPage1.AdminDashboard1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Dashboard</title>
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
            <h1>Admin Dashboard</h1>
            <asp:Button ID="btnCustomerProfiles" runat="server" Text="View All Customer Profiles" CssClass="dashboard-button" OnClick="btnCustomerProfiles_Click" />
            <asp:Button ID="btnPhysicalStores" runat="server" Text="View All Physical Stores" CssClass="dashboard-button" OnClick="btnPhysicalStores_Click" />
            <asp:Button ID="btnResolvedTickets" runat="server" Text="View All Resolved Tickets" CssClass="dashboard-button" OnClick="btnResolvedTickets_Click" />
            <asp:Button ID="btnCustomerAccounts" runat="server" Text="View All Customer Accounts & Subscriptions" CssClass="dashboard-button" OnClick="btnCustomerAccounts_Click" />
            <asp:Button ID="btnAccountsByPlan" runat="server" Text="Show Accounts Subscribed to a Plan on a Date" CssClass="dashboard-button" OnClick="btnAccountsByPlan_Click" />
            <asp:Button ID="btnAccountUsage" runat="server" Text="View Total Account Usage by Plan" CssClass="dashboard-button" OnClick="btnAccountUsage_Click" />
            <asp:Button ID="btnRemoveBenefits" runat="server" Text="Remove All Benefits from Account" CssClass="dashboard-button" OnClick="btnRemoveBenefits_Click" />
            <asp:Button ID="btnSmsOffers" runat="server" Text="View All SMS Offers for Account" CssClass="dashboard-button" OnClick="btnSmsOffers_Click" />
        </div>
    </form>
</body>
</html>
