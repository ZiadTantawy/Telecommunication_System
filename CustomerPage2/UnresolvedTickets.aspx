<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnresolvedTickets.aspx.cs" Inherits="Telecommunication_System.CustomerPage2.ShowTicketCount" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unresolved Tickets</title>
    <style>
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
        <h1>Unresolved Tickets</h1>
        <div>
            <label for="nationalID">National ID:</label>
            <asp:TextBox ID="NationalID" runat="server" CssClass="input-field" Placeholder="Enter National ID"></asp:TextBox>
            <br />
            <asp:Button ID="search" runat="server" Text="Search" onclick="DisplayUnresolvedTickets"/>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
