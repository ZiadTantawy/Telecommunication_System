<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumptionView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.ConsumptionView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Plan Consumption for Input duration</h1>
            <div>
            <label for="txtDate">Plan name:</label>
            <asp:TextBox ID="txtplanName" runat="server" CssClass="input-field" Placeholder="Enter Plan name"></asp:TextBox>
            <br />
            <label for="txtDate">Start Date:</label>
            <asp:TextBox ID="txtstartDate" runat="server" CssClass="input-field" Placeholder="YYYY-MM-DD"></asp:TextBox>
            <br />
            <label for="txtDate">End Date:</label>
            <asp:TextBox ID="txtendDate" runat="server" CssClass="input-field" Placeholder="YYYY-MM-DD"></asp:TextBox>
            <br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
        </div>
        <div>
            <asp:Table ID="tblPlanconsumption" runat="server" CssClass="styled-table">
            </asp:Table>
        </div>
    </form>
</body>
</html>
