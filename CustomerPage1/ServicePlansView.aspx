<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServicePlansView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.ServicePlansView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>All service plans</h1>
        <div>
            <!-- Table for displaying customer account data -->
            <asp:Table ID="tblServicePlans" runat="server" CssClass="styled-table">
            </asp:Table>

           <!-- Back Button -->
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
        </div>
    </form>
</body>
</html>
