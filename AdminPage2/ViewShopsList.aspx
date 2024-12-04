<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewShopsList.aspx.cs" Inherits="Telecommunication_System.ViewEshopVoucherDetails" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E-shop Voucher Details</title>
    <style>
        .wallet-table {
            width: 100%;
            border-collapse: collapse;
            margin: 30px 0;
        }
        .wallet-table th, .wallet-table td {
            padding: 12px 20px;
            text-align: center;
            border: 1px solid #ddd;
        }
        .wallet-table th {
            background-color: #FF9800;
            color: white;
        }
        .wallet-table tr:nth-child(even) {
            background-color: #f9f9f9;
        }
        .back-button {
            background-color: #009688;
            color: white;
            padding: 12px 24px;
            border: none;
            cursor: pointer;
            font-size: 16px;
        }
        .back-button:hover {
            background-color: #00796b;
        }
        .message {
            color: red;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>View E-shop Voucher Details</h1>
        <div>
            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
            <!-- Table for displaying wallet details -->
            <asp:Table ID="tblEshopVoucherDetails" runat="server" CssClass="wallet-table">
            </asp:Table>

            <!-- Back Button -->
            <asp:Button ID="btnBack" runat="server" Text="Back to Dashboard" OnClick="GoBack" CssClass="back-button" />
        </div>
    </form>
</body>
</html>
