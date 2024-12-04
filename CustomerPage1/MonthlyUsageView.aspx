<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonthlyUsageView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.MonthlyUsageView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Monthly Usage</h1>
<div>
    <label for="txtMno">Mobile Number:</label>
    <asp:TextBox ID="txtMno" runat="server" CssClass="input-field" Placeholder="Enter Mobile Number"></asp:TextBox>
    <br />
    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click" />
    <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
</div>
<div>
    <asp:Table ID="tblMonthlyUsage" runat="server" CssClass="styled-table">
    </asp:Table>
</div>
    </form>
</body>
</html>
