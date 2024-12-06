﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Last5MonthSub.aspx.cs" Inherits="Telecommunication_System.CustomerPage3.Last5MonthSub" %>

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


      styled-table {
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
      .box {
     padding: 15px;
     margin: 20px 0;
     border-radius: 8px;
     box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
 }
</style>
</head>
<body>
    <form id="form1" runat="server">
          <div class ="header">
        <h1>All Service Plans that your account subscribed to in the past 5 months</h1>
        </div>
         <div class = "container">
            <asp:Label ID="lblMessage" runat="server" Text="" CssClass="box"  Visible="false"></asp:Label><br />
            <asp:GridView ID="GridViewServicePlans" runat="server" CssClass="styled-table"  AutoGenerateColumns="true"></asp:GridView>
             <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
        </div>
    </form>
</body>
</html>
