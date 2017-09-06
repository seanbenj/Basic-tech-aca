<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameForm.aspx.cs" Inherits="WarChallenge.GameForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        THE GAME OF WAR STARTS NOW!!<br />
        <br />
        <asp:Button ID="playButton" runat="server" OnClick="playButton_Click" Text="PLAY WAR!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
