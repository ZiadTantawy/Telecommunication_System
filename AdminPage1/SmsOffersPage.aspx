<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountSMSOffers.aspx.cs" Inherits="Telecommunication_System.AdminPage1.AccountSMSOffers" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>SMS Offers for Account</title>
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
        <h1>SMS Offers for Account</h1>

        <!-- Mobile Number Input -->
        <label for="txtMobileNumber">Mobile Number:</label>
        <asp:TextBox ID="txtMobileNumber" runat="server" MaxLength="11" />

        <asp:Button ID="btnSearch" runat="server" Text="Search SMS Offers" OnClick="btnSearch_Click" CssClass="button" />

        <!-- Display error or status message -->
        <asp:Label ID="lblStatus" runat="server" ForeColor="Red"></asp:Label>

        <!-- Table for displaying SMS offers -->
        <asp:Table ID="tblSMSOffers" runat="server" CssClass="styled-table">
        </asp:Table>

        <!-- Back Button -->
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
    </form>
</body>
</html>
