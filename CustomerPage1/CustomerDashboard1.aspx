<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDashboard1.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.CustomerDashboard1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="ServicePlans" Text="view all service plans" />
            <asp:Button ID="Button2" runat="server" OnClick="Consumption" Text="view consumption" />
            <asp:Button ID="Button3" runat="server" OnClick="OtherPlans" Text="view other plans" />
            <asp:Button ID="Button4" runat="server" OnClick="MonthlyUsage" Text="view monthly usage" />
            <asp:Button ID="Button5" runat="server" OnClick="Cashback" Text="view cashback" />
        </div>
    </form>
</body>
</html>
