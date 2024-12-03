<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard1.aspx.cs" Inherits="Telecommunication_System.AdminPage1.AdminDashboard1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Admin Dashboard</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="View All Customer Profiles" /><br />
            <asp:Button ID="Button2" runat="server" Text="View All Physical Stores" /><br />
            <asp:Button ID="Button3" runat="server" Text="View All Resolved Tickets" /><br />
            <asp:Button ID="Button4" runat="server" Text="View All Customer Accounts & Subscriptions" /><br />
            <asp:Button ID="Button5" runat="server" Text="Show Customer Accounts subscribed to the input plan id on a certain input date" /><br />
            <asp:Button ID="Button6" runat="server" Text=" total usage of the input account on each subscribed plan from a given input date" /><br />
            <asp:Button ID="Button7" runat="server" Text="Remove All benefits from Account" /><br />
            <asp:Button ID="Button8" runat="server" Text="View All SMS offers for account" />
        </div>
    </form>
</body>
</html>
