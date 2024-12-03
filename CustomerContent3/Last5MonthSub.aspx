<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Last5MonthSub.aspx.cs" Inherits="Telecommunication_System.CustomerContent3.Last5MonthSub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <div>
       All Service Plans that your account subscribed to in the past 5 months<br/>
    <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label> <br />
    <asp:GridView ID="GridViewServicePlans" runat="server" AutoGenerateColumns="true"></asp:GridView>
</div>
    </form>
</body>
</html>
