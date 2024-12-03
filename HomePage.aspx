<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Telecommunication_System.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Telecom System</h1>
            <asp:Button ID="AdminLogin" runat="server" Text="Admin Login" OnClick="AdminLoginBtn" />
            <asp:Button ID="CustomerLogin" runat="server" Text="Customer Login" OnClick="CustomerLoginBtn" />
        </div>
    </form>
</body>
</html>
