<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnresolvedTickets.aspx.cs" Inherits="Telecommunication_System.CustomerPage2.ShowTicketCount" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unresolved Tickets</title>
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
        <h1>Unresolved Tickets</h1>
        </div>
        <div class="container">
            <label for="nationalID">National ID:</label>
            <asp:TextBox ID="NationalID" runat="server" CssClass="input-field" Placeholder="Enter National ID"></asp:TextBox>
            <br />
            <asp:Button ID="search" runat="server" Text="Search" CssClass="button" OnClick="checkinput" />
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass ="button" OnClick="redirectBack"  />
           
            <asp:Label ID="lblMessage" runat="server" CssClas="box" Text="" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
