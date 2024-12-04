<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherPlansView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.OtherPlansView" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Other Plans View</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Explore Other Plans</h1>
        <div>
            <!-- Display Mobile Number from Session -->
            <label>Mobile Number:</label>
            <asp:Label ID="lblMobileNo" runat="server" CssClass="label" />
            <br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
        </div>
        <div>
            <asp:Table ID="tblOtherPlans" runat="server" CssClass="styled-table">
            </asp:Table>
        </div>
    </form>
</body>
</html>
