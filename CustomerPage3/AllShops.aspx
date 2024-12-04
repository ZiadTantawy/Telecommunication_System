<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllShops.aspx.cs" Inherits="Telecommunication_System.CustomerContent3.AllShops" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>All Shop Details</h1>
       <div>
        <asp:GridView ID="GridViewAllShops" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
    </form>
</body>
</html>
