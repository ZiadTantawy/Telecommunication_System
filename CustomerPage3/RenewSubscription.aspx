<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RenewSubscription.aspx.cs" Inherits="Telecommunication_System.CustomerPage3.RenewSubscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Renew Service Plan</title>
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
        <h1>Renew Service Plan</h1>
        <div>
            Enter Payment Amount
            <br />
            <asp:TextBox 
                 ID="PaymentAmount" 
                 runat="server" 
                 Placeholder="Amount">
            </asp:TextBox>
            <br />
            Choose Payment Method
            <br />
            <asp:RadioButton 
                ID="rbtnCash" 
                runat="server" 
                GroupName="PaymentMethod" 
                Text="Cash" 
                Checked="true" />
            <asp:RadioButton 
                ID="rbtnCredit" 
                runat="server" 
                GroupName="PaymentMethod" 
                Text="Credit" />
            <br />
            Enter Plan ID
            <br />
            <asp:TextBox 
                 ID="PlanID" 
                 runat="server" 
                 Placeholder="Plan ID">
            </asp:TextBox>
            <br />
            <asp:Button 
                ID="btnRenew" 
                runat="server" 
                Text="Renew" 
                OnClick="Renew" />
             <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
