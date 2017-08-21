<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.WebForm1" %>

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
        Width:<asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="handleChange" AutoPostBack="True"></asp:TextBox>
        <br />
        Height:<asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="handleChange" AutoPostBack="True"></asp:TextBox>
        <br />
        Length:<asp:TextBox ID="LengthTextBox" runat="server" OnTextChanged="handleChange" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" Text="Ground" GroupName="shipTypes" AutoPostBack="True" OnCheckedChanged="handleChange" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" GroupName="shipTypes" Text="Air" AutoPostBack="True" OnCheckedChanged="handleChange" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton" runat="server" GroupName="shipTypes" Text="Next Day" AutoPostBack="True" OnCheckedChanged="handleChange" />
        <br />
        <asp:Label ID="totalShippingLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
