<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RechargeBalance.aspx.cs" Inherits="Telecommunication_System.CustomerPage3.RechargeBalance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recharge Balance</title>
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
        <div>
            <h1>
                Recharge Balance
            </h1>
            Enter Amount to Recharge
            <br />
            <asp:TextBox ID="txtAmount" runat="server" placeholder="Amount"></asp:TextBox>
            <br />                 
            Choose Payment Method            
            <br />
            <asp:RadioButton ID="rbtnCash" runat="server" GroupName="PaymentMethod" Text="Cash" Checked="true" />
            <asp:RadioButton ID="rbtnCredit" runat="server" GroupName="PaymentMethod" Text="Credit" />
            <br />
            <asp:Button ID="btnRecharge" runat="server" Text ="Recharge Balance" OnClick ="Recharge" />
             <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
            <br />
            <asp:Label ID ="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
