<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CashbackView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.CashbackView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Cashback</h1>
<div>
    <label for="txtNid">National ID:</label>
    <asp:TextBox ID="txtMno" runat="server" CssClass="input-field" Placeholder="Enter National ID"></asp:TextBox>
    <br />
    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click" />
    <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
</div>
<div>
    <asp:Table ID="tblCashback" runat="server" CssClass="styled-table">
    </asp:Table>
</div>
        
    </form>
</body>
</html>
