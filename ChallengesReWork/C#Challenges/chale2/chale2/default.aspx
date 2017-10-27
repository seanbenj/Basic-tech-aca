<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="chale2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Simple Calculator<br />
        </strong><span class="auto-style2">
        <br />
        First Value:<asp:TextBox ID="Num1TextBox" runat="server"></asp:TextBox>
        <br />
        Second Value:<asp:TextBox ID="Num2TextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="PlusButton" runat="server" OnClick="PlusButton_Click" Text=" + " />
&nbsp;<asp:Button ID="MinusButton" runat="server" OnClick="MinusButton_Click" Text=" - " />
&nbsp;<asp:Button ID="MultiButton" runat="server" OnClick="MultiButton_Click" Text=" * " />
&nbsp;<asp:Button ID="DivideButton" runat="server" OnClick="DivideButton_Click" Text=" / " />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </span>
    
    </div>
    </form>
</body>
</html>
