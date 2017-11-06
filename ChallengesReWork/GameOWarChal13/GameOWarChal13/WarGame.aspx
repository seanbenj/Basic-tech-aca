<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WarGame.aspx.cs" Inherits="GameOWarChal13.WarGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        PLAYER 1&#39;s NAME:<br />
        <asp:TextBox ID="player1TextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        PLAYER 2&#39;s NAME:<br />
        <asp:TextBox ID="player2TextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="playButton" runat="server" OnClick="playButton_Click" Text="Play War!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
