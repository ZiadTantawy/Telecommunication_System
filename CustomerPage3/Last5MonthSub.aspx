<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Last5MonthSub.aspx.cs" Inherits="Telecommunication_System.CustomerPage3.Last5MonthSub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Last 5 Months Subscription</title>
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
        <h1>All Service Plans that your account subscribed to in the past 5 months</h1>
        <div>
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label><br />
            <asp:GridView ID="GridViewServicePlans" runat="server" AutoGenerateColumns="true"></asp:GridView>
             <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
        </div>
    </form>
</body>
</html>
