<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPaymentTransactions.aspx.cs" Inherits="Telecommunication_System.ViewAccountPaymentsDetails" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account Payments Details</title>
    <style>
        .payments-table {
            width: 100%;
            border-collapse: collapse;
            margin: 30px 0;
        }
        .payments-table th, .payments-table td {
            padding: 12px 20px;
            text-align: center;
            border: 1px solid #ddd;
        }
        .payments-table th {
            background-color: #FF9800;
            color: white;
        }
        .payments-table tr:nth-child(even) {
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
        <h1>View Account Payments Details</h1>
        <div>
            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
            <!-- Table for displaying account payments details -->
            <asp:Table ID="tblAccountPaymentsDetails" runat="server" CssClass="payments-table">
            </asp:Table>

            <!-- Back Button -->
            <asp:Button ID="btnBack" runat="server" Text="Back to Dashboard" OnClick="GoBack" CssClass="back-button" />
        </div>
    </form>
</body>
</html>
