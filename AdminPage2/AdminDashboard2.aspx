<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard2.aspx.cs" Inherits="Telecommunication_System.AdminDashboard2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Admin Component 2</div>
        <asp:Button ID="Button1" runat="server" Text="View details of all wallets along with their customer names" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="View the list of all E-shops along with their redeemed voucher’s ids and values" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="View all payments’ transaction details along with their initiated Accounts" OnClick="Button3_Click" />
        </p>
        <asp:Button ID="Button4" runat="server" Text=" View the total number of cashback transactions per each wallet ID" OnClick="Button4_Click" />
        <p>
            <asp:Button ID="Button5" runat="server" Text="Show the number of accepted payment transactions initiated by the input account
during the last year along with the total amount of earned points" OnClick="Button5_Click" />
        </p>
        <asp:Button ID="Button6" runat="server" Text="Show the amount of cashback returned on the input wallet id based on a certain
input plan id" OnClick="Button6_Click" />
        <p>
            <asp:Button ID="Button8" runat="server" Text="Show the average of the sent transaction amounts from the input wallet id within
a certain input duration (Start date and End Date)" OnClick="Button7_Click" />
        </p>
        <p>
            <asp:Button ID="Button7" runat="server" Text="Show if the input mobile Number is linked to a wallet, or not" OnClick="Button8_Click" />
        </p>
        <p>
            <asp:Button ID="Button9" runat="server" Text=" Take mobile number as an input then Update the total number of earned points
that it should have" OnClick="Button9_Click" />
        </p>
    </form>
</body>
</html>
