<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="slotmachine.aspx.cs" Inherits="CasinoSlotsChal10.slotmachine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Slot1Image" runat="server" />
        <asp:Image ID="Slot2Image" runat="server" />
        <asp:Image ID="Slot3Image" runat="server" />
        <br />
        <br />
        Your Bet:
        <asp:TextBox ID="BetTextBox" runat="server" style="margin-top: 0px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="PlayerMoneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry = 2x Bet.<br />
        2 Cherries = 3x Bet.<br />
        3 Cherries = 4x Bet.<br />
        <br />
        3 Sevens = JACKPOT = 100x Bet.<br />
        <br />
        But if even one bar is pulled then you win NOTHING. </div>
    </form>
</body>
</html>
