<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherPlansView.aspx.cs" Inherits="Telecommunication_System.CustomerPage1.OtherPlansView" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Other Plans View</title>
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


  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <h1>Explore Other Plans</h1>
        </div>

        <div class="container">
            <!-- Display Mobile Number from Session -->
            <label>Mobile Number:</label>
            <asp:Label ID="lblMobileNo" runat="server" CssClass="input-field" />
            <br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
        </div>
        <div>
            <asp:Table ID="tblOtherPlans" runat="server" CssClass="styled-table">
            </asp:Table>
        </div>
    </form>
</body>
</html>
