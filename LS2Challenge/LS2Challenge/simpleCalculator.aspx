<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="simpleCalculator.aspx.cs" Inherits="LS2Challenge.simpleCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>&nbsp;</h1>
        <h1 class="auto-style2">&nbsp;!Awesome Calculator!</h1>
        <span class="auto-style1">
        <br />
        First Value</span>:<asp:TextBox ID="num1TextBox" runat="server"></asp:TextBox>
        <br />
        <span class="auto-style1">Second Value</span>:<asp:TextBox ID="num2TextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="plusButton" runat="server" OnClick="plusButton_Click" Text="+" Width="39px" />
&nbsp;<asp:Button ID="minusButton" runat="server" Text="-" Width="34px" OnClick="minusButton_Click" />
&nbsp;<asp:Button ID="multiButton" runat="server" Text="*" Width="37px" OnClick="multiButton_Click" />
&nbsp;<asp:Button ID="diviButton" runat="server" Text="/" Width="33px" OnClick="diviButton_Click" />
        <br />
        <br />
        <span class="auto-style3">Heres Your Total</span><br />
        <asp:Label ID="Total" runat="server" BackColor="#00CCFF" BorderColor="Black" BorderStyle="Groove" BorderWidth="1px" Font-Bold="True" Font-Italic="True" Font-Names="Bradley Hand ITC" Font-Size="X-Large" ForeColor="#000066"></asp:Label>
    
    </div>
    </form>
</body>
</html>
