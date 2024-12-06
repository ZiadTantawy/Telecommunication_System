<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard2.aspx.cs" Inherits="Telecommunication_System.AdminDashboard2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Dashboard 2</title>
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
         <asp:Button ID="Logout" runat="server" Text="Logout" Onclick="AdminlogoutRedirect"/>
         <div class="dashboard-container">       
             <h1>Admin Dashboard 2</h1>
       
             <asp:Button ID="Button1" runat="server" CssClass="dashboard-button" Text="View details of all wallets along with their customer names" OnClick="Button1_Click" />
       
            <asp:Button ID="Button2" runat="server" CssClass="dashboard-button" Text="View the list of all E-shops along with their redeemed voucher’s ids and values" OnClick="Button2_Click" />
        
        
            <asp:Button ID="Button3" runat="server" CssClass="dashboard-button" Text="View all payments’ transaction details along with their initiated Accounts" OnClick="Button3_Click" />
        
            <asp:Button ID="Button4" runat="server" CssClass="dashboard-button"  Text=" View the total number of cashback transactions per each wallet ID" OnClick="Button4_Click" />
        
            <asp:Button ID="Button5" runat="server" CssClass="dashboard-button" Text="Show the number of accepted payment transactions initiated by the input account
during the last year along with the total amount of earned points" OnClick="Button5_Click" />
        <asp:Button ID="Button6" runat="server" CssClass="dashboard-button" Text="Show the amount of cashback returned on the input wallet id based on a certain
input plan id" OnClick="Button6_Click" />
            <asp:Button ID="Button8" runat="server" CssClass="dashboard-button" Text="Show the average of the sent transaction amounts from the input wallet id within
a certain input duration (Start date and End Date)" OnClick="Button7_Click" /> 
            <asp:Button ID="Button7" runat="server" CssClass="dashboard-button" Text="Show if the input mobile Number is linked to a wallet, or not" OnClick="Button8_Click" />
            <asp:Button ID="Button9" runat="server" CssClass="dashboard-button" Text=" Take mobile number as an input then Update the total number of earned points
that it should have" OnClick="Button9_Click" />
        </div>
    </form>
</body>
</html>
