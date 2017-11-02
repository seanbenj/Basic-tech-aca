<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DartBoard.aspx.cs" Inherits="chal11Darts.DartBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; !VIRTUAL DARTS!<br />
        <br />
        Player1&#39;s Name:&nbsp;
        <asp:TextBox ID="Player1TextBox" runat="server"></asp:TextBox>
&nbsp;<br />
        Player2&#39;s Name:&nbsp;
        <asp:TextBox ID="Player2TextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="playDartsButton" runat="server" OnClick="playDartsButton_Click" Text="Play Darts" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
