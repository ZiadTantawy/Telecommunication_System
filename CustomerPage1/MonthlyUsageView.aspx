<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonthlyUsageView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.MonthlyUsageView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Monthly Usage</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Monthly Usage</h1>
        <div>
            <!-- Display the mobile number from the session -->
            <label for="lblMobileNumber">Mobile Number:</label>
            <asp:Label ID="lblMobileNumber" runat="server" CssClass="input-field"></asp:Label>
            <br />
            
            <!-- Remove the TextBox input field and just show a label with the number -->
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
