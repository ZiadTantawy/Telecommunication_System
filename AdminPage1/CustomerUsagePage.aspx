<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerUsagePage.aspx.cs" Inherits="Telecommunication_System.AdminPage1.CustomerUsagePage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Usage</title>
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
        <h1>Show Total Usage per Plan</h1>
        <div>
            <label for="txtMobileNumber">Mobile Number:</label>
            <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox><br />
            <label for="txtStartDate">Start Date (YYYY-MM-DD):</label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="button" /><br />
        </div>

        <h2>Usage Data</h2>
        <!-- Table to display usage data -->
        <asp:Table ID="tblUsageData" runat="server" CssClass="styled-table"></asp:Table>
        
        <!-- Back Button -->
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
    </form>
</body>
</html>
