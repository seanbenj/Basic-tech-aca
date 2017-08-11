<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pizza.aspx.cs" Inherits="LS3Challenge2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            font-weight: 700;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Arial, Helvetica, sans-serif">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="./images/PapaBob.png" />
        <span class="auto-style1">Papa Bob&#39;s Pizza and Software</span><br />
        <br />
        <br />
        <asp:RadioButton ID="babyButton" runat="server" GroupName="sizeGroup" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="papaButton" runat="server" GroupName="sizeGroup" Text="Papa Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="mamaButton" runat="server" GroupName="sizeGroup" Text="Mama Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinButton" runat="server" GroupName="crustGroup" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepButton" runat="server" GroupName="crustGroup" Text="Deep Crust (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$.75)" />
        <br />
        <asp:CheckBox ID="greenPepCheckBox" runat="server" Text="Green Peppers (+$.50)" />
        <br />
        <asp:CheckBox ID="redPepCheckBox" runat="server" Text="Red Peppers (+$.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        <br />
        <br />
        <span class="auto-style2"><strong>Papa Bob&#39;s <span class="auto-style3">Special Deal</span></strong></span><br />
        <br />
        Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your Pizza.<br />
        <br />
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase!" />
        <br />
        <br />
        <asp:Label ID="purchaseLabel" runat="server"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online and pick-up only ... we need a better website!</div>
    </form>
</body>
</html>
