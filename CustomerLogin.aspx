<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLogin.aspx.cs" Inherits="Telecommunication_System.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Telecom GUC - Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Telecom GUC</h1>
        <div>
            <h2>Login</h2>
            <asp:TextBox 
                ID="txtMobileNumber" 
                runat="server" 
                Placeholder="Mobile Number">
            </asp:TextBox>
            <br />
            <asp:TextBox 
                ID="txtPassword" 
                runat="server" 
                TextMode="Password" 
                Placeholder="Password">
            </asp:TextBox>
            <br />
            <asp:Button 
                ID="btnValidate" 
                runat="server" 
                Text="Login" 
                OnClick="btnValidate_Click" />
            <br />
        </div>
    </form>
</body>
</html>

