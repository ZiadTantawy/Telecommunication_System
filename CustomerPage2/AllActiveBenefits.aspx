<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllActiveBenefits.aspx.cs" Inherits="Telecommunication_System.CustomerPage2.AllActiveBenefits" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>All Active Benefits</h1>
       <div>
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
        <asp:GridView ID="GridAllActiveBenefits" runat="server" AutoGenerateColumns="true"></asp:GridView>
        <asp:Label ID="lblMessage" runat="server" Text="" Visible="false"></asp:Label><br />
    </div>
    </form>
</body>
</html>
