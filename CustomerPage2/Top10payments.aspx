<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top10payments.aspx.cs" Inherits="Telecommunication_System.CustomerPage2.Top10payments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Last 5 Months Subscription</title>
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
    .box {
    padding: 15px;
    margin: 20px 0;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    }
     .styled-table {
    width: 100%;
    border-collapse: collapse;
    margin: 30px 0;
    }
    .styled-table th, .styled-table td {
        padding: 12px 20px;
        text-align: center;
        border: 1px solid #ddd;
    }
    .styled-table th {
        background-color: #FF9800;
        color: white;
    }
    .styled-table tr:nth-child(even) {
        background-color: #f9f9f9;
    }




</style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="header">
        <h1>Top Payments</h1>
        </div>
         <div class="container">
            <label for="Mobile number">Mobile Number:</label>
            <asp:TextBox ID="MobileNumber" runat="server" CssClass="input-field" Placeholder="Enter Mobile Number"></asp:TextBox>
            <asp:GridView ID="GridViewTopPayments" runat="server" CssClass="styled-table" AutoGenerateColumns="true"></asp:GridView>
            <asp:Label ID="lblMessage" runat="server" Text="" CssClass ="box" Visible="false"></asp:Label><br />
            <asp:Button ID="Top10" runat="server" Text="Search"  CssClass="button" OnClick="checkid" />
            <asp:Button ID="backbtn" runat="server" Text="Back"  CssClass="button" onclick="redirectBack"/>
        </div>
    </form>
</body>
</html>
