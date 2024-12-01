<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Telecommunication_System.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Login
            <div>
                Username<br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div>
                 Password<br />
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="LoginButton" />
        </div>
    </form>
</body>
</html>
