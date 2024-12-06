<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RenewSubscription.aspx.cs" Inherits="Telecommunication_System.CustomerPage3.RenewSubscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Renew Service Plan</title>
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
        <div class ="header">
            <h1>
             Renew Service Plan</h1>
        </div>
        <div class="container">
            Enter Payment Amount:
            <br />
            <asp:TextBox 
                 ID="PaymentAmount" 
                 runat="server" 
                  CssClass="input-field"
                 Placeholder="Amount">
              
            </asp:TextBox>
            <br />
           
            Enter Plan ID
            <br />
            <asp:TextBox 
                 ID="PlanID" 
                  CssClass="input-field"
                 runat="server" 
                 Placeholder="Plan ID">
            </asp:TextBox>
            <br />
            <br />
             Choose Payment Method:
             <br />
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
            <br />
            <asp:Button 
                ID="btnRenew" 
                runat="server" 
                Text="Renew" 
                CssClass="button"
                OnClick="Renew" />
             <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="redirectBack" CssClass="button" />
            <br />
            <asp:Label ID="lblMessage" CssClass="box" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
