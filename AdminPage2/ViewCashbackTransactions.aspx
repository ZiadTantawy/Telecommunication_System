<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCashbackTransactions.aspx.cs" Inherits="Telecommunication_System.ViewNumOfCashbackDetails" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Number of Cashback Transactions</title>
    <style>
        .cashback-table {
            width: 100%;
            border-collapse: collapse;
            margin: 30px 0;
        }
        .cashback-table th, .cashback-table td {
            padding: 12px 20px;
            text-align: center;
            border: 1px solid #ddd;
        }
        .cashback-table th {
            background-color: #FF9800;
            color: white;
        }
        .cashback-table tr:nth-child(even) {
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
        <h1>Number of Cashback Transactions</h1>
        <div>
            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
            <!-- Table for displaying the number of cashback details -->
            <asp:Table ID="tblNumOfCashbackDetails" runat="server" CssClass="cashback-table">
            </asp:Table>

            <!-- Back Button -->
            <asp:Button ID="btnBack" runat="server" Text="Back to Dashboard" OnClick="GoBack" CssClass="back-button" />
        </div>
    </form>
</body>
</html>
