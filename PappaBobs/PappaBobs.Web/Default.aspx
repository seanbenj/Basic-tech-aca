<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PappaBobs.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        
        <div class="page-header">
            <h1>Papa Bob's Pizza</h1>
            <p class="lead">Pizza To Code By</p>
        </div>

        <div class ="form-group">
            <label>Size: </label>
            <asp:DropDownList ID="sizeDropDownList" runat="server"  CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
            <asp:ListItem Text="Choose one..." Selected="True" Value=""></asp:ListItem>
            <asp:ListItem Text="Small (12 Inch - $12)" Value="Small"></asp:ListItem>
            <asp:ListItem Text="Medium(14 Inch - $14)" Value="Medium"></asp:ListItem>
            <asp:ListItem Text="Large(16 Inch - $16)" Value="Large"></asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <div class ="form-group">
            <label>Crust: </label>
            <asp:DropDownList ID="crustDropDownList" runat="server"  CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
            <asp:ListItem Text="Choose one..." Selected="True" Value=""></asp:ListItem>
            <asp:ListItem Text="Regular"  Value="Regular"></asp:ListItem>
            <asp:ListItem Text="Thin" Value="Thin"></asp:ListItem>
            <asp:ListItem Text="Thick (+ $2)" Value="Thick"></asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <div class ="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server"  AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Sausage</label></div>        
        <div class ="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Pepperoni</label></div>        
        <div class ="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server"  AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Onions</label></div>       
        <div class ="checkbox"><label><asp:CheckBox ID="greenpeppersCheckBox" runat="server"  AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> GreenPeppers</label></div>
        
        <p>&nbsp;</p>

        <h3>Deliver To:</h3>

         <div class="form-group">
            <label>Name:</label>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Address:</label>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label>ZipCode:</label>
            <asp:TextBox ID="zipCodeTextBox" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label>Phone:</label>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
        </div>
        
        <p>&nbsp;</p>

        <h3>Payment:</h3>

        <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="paymentGroup" Checked="true" /> Cash:</label></div>
        <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="paymentGroup" /> Credit:</label></div>

        <p>&nbsp;</p>

        <asp:Button ID="orderButton" runat="server" Text="Button" onclick="orderButton_Click"/>
        <asp:Label ID="validationLabel" runat="server" Text="" CssClass="bg-danger" Visible="false"></asp:Label>
        <h3>Total Cost: <asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3>

        <p>&nbsp;</p>

    </div>
    </form>
    <script src="Scripts/jquery-3.2.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
