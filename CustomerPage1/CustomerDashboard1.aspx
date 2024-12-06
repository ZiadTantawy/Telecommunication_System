<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDashboard1.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.CustomerDashboard1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Dashboard 1</title>
      <style>
      .dashboard-container {
          text-align: center;
          margin-top: 50px;
      }
      .dashboard-container h1 {
          font-size: 36px;
          color: #333;
      }
      .dashboard-button {
          display: block;
          width: 100%;
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
         <asp:Button ID="Logout" runat="server" Text="Logout"  Onclick="AdminlogoutRedirect"/>
         <div class="dashboard-container">
            <h1>Customer Dashboard 1</h1>
        
            <asp:Button ID="Button1" runat="server" OnClick="ServicePlans" CssClass="dashboard-button"  Text="view all service plans" />
            <asp:Button ID="Button2" runat="server" OnClick="Consumption" CssClass="dashboard-button" Text="view consumption" />
            <asp:Button ID="Button3" runat="server" OnClick="OtherPlans" CssClass="dashboard-button"  Text="view other plans" />
            <asp:Button ID="Button4" runat="server" OnClick="MonthlyUsage" CssClass="dashboard-button"  Text="view monthly usage" />
            <asp:Button ID="Button5" runat="server" OnClick="Cashback" CssClass="dashboard-button" Text="view cashback" />
            <asp:Button ID="ButtonRedirectToDashboard2" runat="server" CssClass="dashboard-button" OnClick="RedirectToDashboard2" Text="Customer Dashboard 2" />
        </div>
    </form>
</body>
</html>
