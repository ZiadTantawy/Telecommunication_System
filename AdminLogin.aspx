<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Telecommunication_System.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Admin Login</h1>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtAdminID" runat="server" placeholder="Admin ID"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" Placeholder="Password"></asp:TextBox>
            <asp:Button ID="Login" runat="server" Text="Login" Onclick="AdminloginRedirect"/>
        </div>
    </form>
</body>
</html>
