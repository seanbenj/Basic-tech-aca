<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="chal4._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF9900;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 492px; width: 676px">
    
        <asp:RadioButton ID="SizeBabyRadioButton" runat="server" Checked="True" GroupName="SizeGroup" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="SizeMamaRadioButton" runat="server" GroupName="SizeGroup" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="SizePapaRadioButton" runat="server" GroupName="SizeGroup" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="CrustThinRadioButton" runat="server" Checked="True" GroupName="CrustGroup" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="CrustDeepRadioButton" runat="server" GroupName="CrustGroup" Text="Deep Dish (+ $2)" />
        <br />
        <br />
        <asp:CheckBox ID="PepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="OnionsCheckBox" runat="server" Text="Onions (+ $0.75)" />
        <br />
        <asp:CheckBox ID="GreenPeppersCheckBox" runat="server" Text="Green Peppers (+ $0.50)" />
        <br />
        <asp:CheckBox ID="RedPeppersCheckBox" runat="server" Text="Red Peppers (+ $0.75)" />
        <br />
        <asp:CheckBox ID="AnchoviesCheckBox" runat="server" Text="Anchovies(+ $2)" />
        <br />
        <h2>Papa Bob&#39;s<span class="auto-style1"> Special Deal</span></h2>
        Save $2.00 When you add&nbsp; Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.<br />
        <br />
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!</div>
    </form>
</body>
</html>
