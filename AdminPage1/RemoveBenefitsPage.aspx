<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BenefitsPage.aspx.cs" Inherits="Telecommunication_System.AdminPage1.BenefitsPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Remove Benefits</title>
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
        <h1>Remove Benefits for Customer Account</h1>
        <div>
            <label for="txtMobileNumber">Mobile Number:</label>
            <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox><br />
            <label for="txtPlanID">Plan ID:</label>
            <asp:TextBox ID="txtPlanID" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnRemoveBenefits" runat="server" Text="Remove Benefits" OnClick="btnRemoveBenefits_Click" CssClass="button" />
        </div>

        <h2>Status</h2>
        <!-- Table for displaying result -->
        <asp:Label ID="lblStatus" runat="server" Text="" CssClass="status-message"></asp:Label>

        <!-- Back Button -->
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
    </form>
</body>
</html>
