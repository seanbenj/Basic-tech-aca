<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CSLS6Challenge1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" />
        <h3 class="auto-style1">Asset Performance Tracker</h3>
    
    </div>
        <p>
            Asset Name:<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:<asp:TextBox ID="electionTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:<asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="asset1UPButton" runat="server" Text="Add Asset" Width="86px" OnClick="Button1_Click" />
        </p>
        <p aria-busy="False">
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
