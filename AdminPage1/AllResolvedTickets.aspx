<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResolvedTicketsView.aspx.cs" Inherits="Telecommunication_System.ResolvedTickets" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resolved Tickets</title>
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
        <h1>Resolved Tickets</h1>
        <div>
            <!-- Table for displaying resolved tickets -->
            <asp:Table ID="tblResolvedTickets" runat="server" CssClass="styled-table">
            </asp:Table>

            <!-- Back Button -->
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
        </div>
    </form>
</body>
</html>
