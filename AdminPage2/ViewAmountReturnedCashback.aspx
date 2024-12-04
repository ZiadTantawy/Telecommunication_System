<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAmountReturnedCashback.aspx.cs" Inherits="Telecommunication_System.AdminPage2.ViewAmountReturnedCashback" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Amount Returned Cashback</title>
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

        .table-container {
            width: 100%;
            overflow-x: auto;
        }

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

        .back-button {
            background-color: #009688;
            color: white;
            padding: 12px 24px;
            border: none;
            cursor: pointer;
            font-size: 16px;
            width: 100%;
        }

        .back-button:hover {
            background-color: #00796b;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <h1>Amount Returned Cashback</h1>
        </div>

        <div class="container">
            <!-- Mobile Number Input -->
            <label for="txtMobileNumber"><strong>Mobile Number:</strong></label>
            <asp:TextBox ID="txtMobileNumber" runat="server" CssClass="input-field" MaxLength="11" />

            <asp:Button ID="btnSearch" runat="server" Text="Search Cashback Amount" OnClick="btnSearch_Click" CssClass="button" />

            <!-- Display error or status message -->
            <asp:Label ID="lblStatus" runat="server" ForeColor="Red"></asp:Label>

            <!-- Table for displaying Cashback Amount -->
            <div class="table-container">
                <asp:Table ID="tblCashbackAmount" runat="server" CssClass="styled-table">
                </asp:Table>
            </div>

            <!-- Back Button -->
            <asp:Button ID="btnBack" runat="server" Text="Back to Dashboard" OnClick="redirectBack" CssClass="back-button" />
        </div>
    </form>
</body>
</html>
