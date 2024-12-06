<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentCashback.aspx.cs" Inherits="Telecommunication_System.CustomerPage3.PaymentCashback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Retrive Cashback Amount according to a a certain payment transaction of a specified benefit</h1>
            <asp:TextBox ID="PaymentID" runat="server" Placeholder="Payment ID"></asp:TextBox>
            <br/>
            <asp:TextBox ID="BenefitID" runat="server" Placeholder="Benefit ID"></asp:TextBox>
            <br />
            <asp:Button ID="btnRetrive" runat="server" Text="Retrive Cashback Amount" OnClick="Retrive" />
            <br />
             <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
