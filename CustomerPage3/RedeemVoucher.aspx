<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedeemVoucher.aspx.cs" Inherits="Telecommunication_System.CustomerPage3.RedeemVoucher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Redeem Voucher
            </h1>
            <asp:TextBox ID ="VoucherID" runat="server" PlaceHolder ="Voucher ID"></asp:TextBox>
            <br />
            <asp:Button ID ="btnRedeemVoucher" runat="server" Text ="Redeem Voucher" OnClick ="Redeem" />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
