<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard1.aspx.cs" Inherits="Telecommunication_System.AdminPage1.AdminDashboard1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Dashboard</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }

        h1 {
            text-align: center;
            color: #4CAF50;
        }

        .dashboard-button {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            margin: 5px 0;
            font-size: 16px;
            cursor: pointer;
            width: 100%;
            text-align: left;
        }

        .dashboard-button:hover {
            background-color: #45a049;
        }

        .dashboard-container {
            max-width: 600px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <h1>Admin Dashboard</h1>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <asp:Button ID="btnCustomerProfiles" runat="server" Text="View Customer Profiles" CssClass="dashboard-button" OnClick="btnCustomerProfiles_Click" /><br />
            <asp:Button ID="btnPhysicalStores" runat="server" Text="View Physical Stores" CssClass="dashboard-button" OnClick="btnPhysicalStores_Click" /><br />
            <asp:Button ID="btnResolvedTickets" runat="server" Text="View Resolved Tickets" CssClass="dashboard-button" OnClick="btnResolvedTickets_Click" /><br />
            <asp:Button ID="btnCustomerAccounts" runat="server" Text="View Customer Accounts & Subscriptions" CssClass="dashboard-button" OnClick="btnCustomerAccounts_Click" /><br />
            <asp:Button ID="btnAccountsByPlan" runat="server" Text="Show Accounts Subscribed to Plan on Date" CssClass="dashboard-button" OnClick="btnAccountsByPlan_Click" /><br />
            <asp:Button ID="btnAccountUsage" runat="server" Text="Show Account Usage per Plan on Date" CssClass="dashboard-button" OnClick="btnAccountUsage_Click" /><br />
            <asp:Button ID="btnRemoveBenefits" runat="server" Text="Remove All Benefits from Account" CssClass="dashboard-button" OnClick="btnRemoveBenefits_Click" /><br />
            <asp:Button ID="btnSmsOffers" runat="server" Text="View All SMS Offers for Account" CssClass="dashboard-button" OnClick="btnSmsOffers_Click" />
        </div>
    </form>
</body>
</html>
