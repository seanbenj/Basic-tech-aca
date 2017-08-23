<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lottery.aspx.cs" Inherits="CSLS7Challenge2.Lottery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="ranImage1" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="ranImage2" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="ranImage3" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        Your Bet:
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull The Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry - X2 Your Bet<br />
        2 Cherries - X3 Your Bet<br />
        3 Cherries - X4 Your Bet<br />
        3 7&#39;s - X100 Your Bet<br />
        However...if there&#39;s even one BAR you win nothing.</div>
    </form>
</body>
</html>
