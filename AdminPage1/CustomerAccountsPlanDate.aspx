<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAccountsByPlanPage.aspx.cs" Inherits="Telecommunication_System.AdminPage1.CustomerAccountsByPlanPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Accounts by Plan and Date</title>
    <style>
        .styled-table {
            width: 100%;
            border-collapse: collapse;
            margin: 25px 0;
        }
        .styled-table th, .styled-table td {
            padding: 12px 15px;
            text-align: left;
            border: 1px solid #ddd;
        }
        .styled-table th {
            background-color: #4CAF50;
            color: white;
        }
        .styled-table tr:nth-child(even) {
            background-color: #f2f2f2;
        }
        .button {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            cursor: pointer;
        }
        .button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Customer Accounts by Plan and Date</h1>
        <div>
            <label for="txtDate">Subscription Date:</label>
            <asp:TextBox ID="txtDate" runat="server" CssClass="input-field" Placeholder="YYYY-MM-DD"></asp:TextBox>
            <br />
            <label for="txtPlanID">Plan ID:</label>
            <asp:TextBox ID="txtPlanID" runat="server" CssClass="input-field" Placeholder="Enter Plan ID"></asp:TextBox>
            <br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
        </div>
        <div>
            <asp:Table ID="tblCustomerAccounts" runat="server" CssClass="styled-table">
            </asp:Table>
        </div>
    </form>
</body>
</html>
