<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RechargeBalance.aspx.cs" Inherits="Telecommunication_System.CustomerPage3.RechargeBalance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <br />
            <asp:Label ID ="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
