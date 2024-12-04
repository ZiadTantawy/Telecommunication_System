<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumptionView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.ConsumptionView" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Plan Consumption</title>
    <style>
        .input-field {
            padding: 8px;
            margin: 5px;
        }
        .button {
            padding: 8px 16px;
            margin: 5px;
            cursor: pointer;
        }
        .styled-table {
            width: 100%;
            border-collapse: collapse;
        }
        .styled-table th, .styled-table td {
            padding: 10px;
            border: 1px solid #ddd;
            text-align: left;
        }
        .styled-table th {
            background-color: #f2f2f2;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Plan Consumption for Input Duration</h1>

        <div>
            <label for="txtplanName">Plan name:</label>
            <asp:TextBox ID="txtplanName" runat="server" CssClass="input-field" Placeholder="Enter Plan name"></asp:TextBox>
            <br />

            <label for="txtstartDate">Start Date:</label>
            <asp:TextBox ID="txtstartDate" runat="server" CssClass="input-field" Placeholder="YYYY-MM-DD"></asp:TextBox>
            <br />

            <label for="txtendDate">End Date:</label>
            <asp:TextBox ID="txtendDate" runat="server" CssClass="input-field" Placeholder="YYYY-MM-DD"></asp:TextBox>
            <br />

            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
        </div>

        <div>
            <asp:Table ID="tblPlanconsumption" runat="server" CssClass="styled-table">
            </asp:Table>
        </div>

    </form>
</body>
</html>
