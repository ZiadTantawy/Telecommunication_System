<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemPlanAmount.aspx.cs" Inherits="Telecommunication_System.CustomerPage2.RemPlanAmount" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Remaining Plan Amount</title>
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
        <h1>Remaining Plan Amount</h1>
        <div>
            <label for="Mobile number">Mobile Number:</label>
            <asp:TextBox ID="MobileNumber" runat="server" CssClass="input-field" Placeholder="Enter Mobile Number"></asp:TextBox>
            <br />
            <label for="Planname">Plan Name:</label>
            <asp:TextBox ID="PlanName" runat="server" CssClass="input-field" Placeholder="Enter Plan Name"></asp:TextBox>
            <br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="checkinputs" />
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="redirectBack" />
            <br />
        </div>
        <div>
            <asp:Label ID="lblMessage" runat="server" Text="" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
