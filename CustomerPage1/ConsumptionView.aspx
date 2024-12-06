<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumptionView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.ConsumptionView" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Plan Consumption</title>
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
         background-color: #00796b;
     }
 </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class = "header">
          <h1>Plan Consumption for Input Duration</h1>
        </div>
         <div class="container">
            <label for="txtplanName">Plan name:</label>
            <asp:TextBox ID="txtplanName" runat="server" CssClass="input-field" Placeholder="Enter Plan name"></asp:TextBox>
            

            <label for="txtstartDate">Start Date:</label>
            <asp:TextBox ID="txtstartDate" runat="server" CssClass="input-field" Placeholder="YYYY-MM-DD"></asp:TextBox>
            

            <label for="txtendDate">End Date:</label>
            <asp:TextBox ID="txtendDate" runat="server" CssClass="input-field" Placeholder="YYYY-MM-DD"></asp:TextBox>
           

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
