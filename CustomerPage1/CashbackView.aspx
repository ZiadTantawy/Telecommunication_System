<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CashbackView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.CashbackView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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

        .success-box {
            background-color: #d4edda;
            color: #155724;
            border: 1px solid #c3e6cb;
        }

        .error-box {
            background-color: #f8d7da;
            color: #721c24;
            border: 1px solid #f5c6cb;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
        <h1>Cashback</h1>
    </div>
     <div class="container">
    <label for="txtNid">National ID:</label>
    <asp:TextBox ID="txtNid" runat="server" CssClass="input-field" Placeholder="Enter National ID"></asp:TextBox>
    <br />
    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click" />
</div>
<div>
    <asp:Table ID="tblCashback" runat="server" CssClass="styled-table">
    </asp:Table>
</div>
        
        <p>
    <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
        </p>
        
    </form>
</body>
</html>
