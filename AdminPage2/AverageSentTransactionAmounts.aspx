<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AverageSentTransactionAmounts.aspx.cs" Inherits="Telecommunication_System.AdminPage2.AverageSentTransactionAmounts" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Average Sent Transaction Amounts</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        .header {
            background-color: #4CAF50;
            color: white;
            padding: 10px;
            text-align: center;
        }

        .container {
            max-width: 800px;
            margin: 30px auto;
            padding: 20px;
            background-color: white;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        .input-field {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            border: 1px solid #ddd;
            border-radius: 4px;
        }

        .button {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            width: 100%;
        }

        .button:hover {
            background-color: #45a049;
        }




    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <h1>Average Sent Transaction Amounts</h1>
        </div>

        <div class="container">
            <!-- Wallet ID Input -->
            <label for="txtWalletID"><strong>Wallet ID:</strong></label>
            <asp:TextBox ID="txtWalletID" runat="server" CssClass="input-field" />

            <!-- Date Range Inputs -->
            <label for="txtStartDate"><strong>Start Date:</strong></label>
            <asp:TextBox ID="txtStartDate" runat="server" CssClass="input-field" TextMode="Date" />

            <label for="txtEndDate"><strong>End Date:</strong></label>
            <asp:TextBox ID="txtEndDate" runat="server" CssClass="input-field" TextMode="Date" />

            <!-- Search Button -->
            <asp:Button ID="btnSearch" runat="server" Text="Get Average Amount" OnClick="btnSearch_Click" CssClass="button" />

            <!-- Display Error or Status Message in Styled Boxes -->
            <asp:Panel ID="pnlStatus" runat="server" Visible="false" CssClass="box">
                <asp:Label ID="lblStatus" runat="server"></asp:Label>
            </asp:Panel>

            <!-- Display Results in a Styled Table -->
            <asp:Table ID="tblResults" runat="server" CssClass="styled-table" Visible="false">
            </asp:Table>

            <!-- Back Button -->
            <asp:Button ID="btnBack" runat="server" Text="Back to Dashboard" OnClick="redirectBack" CssClass="button" />
        </div>
    </form>
</body>
</html>
