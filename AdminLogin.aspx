<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Telecommunication_System.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Telecom GUC - Admin Login</title>
    <style>
        .dashboard-container {
            text-align: center;
            margin-top: 50px;
        }
        .dashboard-container h1 {
            font-size: 36px;
            color: #333;
        }
        .dashboard-input {
            display: block;
            width: 100%;
            max-width: 300px;
            margin: 10px auto;
            padding: 10px;
            font-size: 16px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
        .dashboard-button {
            display: block;
            width: 100%;
            max-width: 300px;
            margin: 15px auto;
            padding: 10px 20px;
            font-size: 16px;
            color: white;
            background-color: #4CAF50;
            border: none;
            cursor: pointer;
            border-radius: 5px;
            text-align: center;
        }
        .dashboard-button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <h1>Admin Login</h1>
            <asp:TextBox 
                ID="txtAdminID" 
                runat="server" 
                CssClass="dashboard-input" 
                Placeholder="Admin ID">
            </asp:TextBox>
            <asp:TextBox 
                ID="txtPassword" 
                runat="server" 
                CssClass="dashboard-input" 
                TextMode="Password" 
                Placeholder="Password">
            </asp:TextBox>
            <asp:Button 
                ID="Login" 
                runat="server" 
                Text="Login" 
                CssClass="dashboard-button" 
                OnClick="AdminloginRedirect" />
        </div>
    </form>
</body>
</html>

