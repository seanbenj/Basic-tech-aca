<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostalForm.aspx.cs" Inherits="Chal9PostalCalculator.PostalForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:<asp:TextBox ID="WidthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        Height:<asp:TextBox ID="HeightTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        Length<asp:TextBox ID="LengthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="GroundRadioButton" runat="server" AutoPostBack="True" GroupName="shippingGroup" Text="Ground" OnCheckedChanged="RadioButton_CheckedChanged" />
        <br />
        <asp:RadioButton ID="AirRadioButton" runat="server" AutoPostBack="True" GroupName="shippingGroup" Text="Air" OnCheckedChanged="RadioButton_CheckedChanged" />
        <br />
        <asp:RadioButton ID="NextDayRadioButton" runat="server" AutoPostBack="True" GroupName="shippingGroup" Text="NextDay" OnCheckedChanged="RadioButton_CheckedChanged" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
