<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top10payments.aspx.cs" Inherits="Telecommunication_System.CustomerPage2.Top10payments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Last 5 Months Subscription</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Top Payments</h1>
        <div>
            <label for="Mobile number">Mobile Number:</label>
            <asp:TextBox ID="MobileNumber" runat="server" CssClass="input-field" Placeholder="Enter Mobile Number"></asp:TextBox>
            <br />
            <asp:GridView ID="GridViewTopPayments" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <asp:Label ID="lblMessage" runat="server" Text=""  Visible="false"></asp:Label><br />
            <asp:Button ID="Top10" runat="server" Text="Search" OnClick="checkid" />
            <asp:Button ID="backbtn" runat="server" Text="Back" onclick="redirectBack"/>
        </div>
    </form>
</body>
</html>
