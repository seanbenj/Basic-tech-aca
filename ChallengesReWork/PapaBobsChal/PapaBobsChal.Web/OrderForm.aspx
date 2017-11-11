<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderForm.aspx.cs" Inherits="PapaBobsChal.Web.OrderForm" MaintainScrollPositionOnPostBack = "true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Papa Bob&#39;s Pizza</h1><br />
        <h4>Pizza To Code By</h4><br />
        <br />
        <br />
        <div class="form-group">
        Pizza Sizes:<br />
        <asp:DropDownList ID="sizeDropDownList" CssClass="form-control" AutoPostBack="true" runat="server" OnSelectedIndexChanged="recalculateTotalCost">
        <asp:ListItem Text="Please select a size..." Value=""></asp:ListItem>
        <asp:ListItem Text="Small (12&quot; $12)" Value="Small"></asp:ListItem>
        <asp:ListItem Text="Medium (14&quot; $14)" Value="Medium"></asp:ListItem>
        <asp:ListItem Text="Large (16&quot; $16)" Value="Large"></asp:ListItem>
        </asp:DropDownList>
        </div>
        <br />
        <br />
        <div class="form-group">
        Pizza Crusts:<br />
        <asp:DropDownList ID="crustDropDownList" CssClass="form-control" AutoPostBack="true" runat="server" OnSelectedIndexChanged="recalculateTotalCost">
        <asp:ListItem Text="Please select a crust..." Value=""></asp:ListItem>
        <asp:ListItem Text="Regular" Value="Regular"></asp:ListItem>
        <asp:ListItem Text="Thin" Value="Thin"></asp:ListItem>
        <asp:ListItem Text="Thick (+$2)" Value="Thick"></asp:ListItem>
        </asp:DropDownList>
        </div>
        <br />
        <br />
        Pizza Toppings:<br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true" Text="Pepperoni" OnCheckedChanged="recalculateTotalCost"/>
        <br />
        <asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="true" Text="Sausage" OnCheckedChanged="recalculateTotalCost"/>
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="true" Text="Onions" OnCheckedChanged="recalculateTotalCost"/>
        <br />
        <asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="true" Text="Green Peppers" OnCheckedChanged="recalculateTotalCost"/>
        <br />
        <br />
        Deliver To:<br />
        <br />
        <div class="form-group">
        Name:<br />
        <asp:TextBox ID="nameTextBox" CssClass="form-control" AutoPostBack="true" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
        Address:<br />
        <asp:TextBox ID="addressTextBox" CssClass="form-control" AutoPostBack="true" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
        Zip Code:<br />
        <asp:TextBox ID="zipTextBox" CssClass="form-control" AutoPostBack="true" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
        Phone Number:<br />
        <asp:TextBox ID="phoneTextBox" CssClass="form-control" AutoPostBack="true" runat="server"></asp:TextBox>
        </div>
        <br />
        <br />
        <asp:Button ID="orderButton" runat="server" OnClick="orderButton_Click" Text="Order da' Pizza!" />
        <br />
        <br />
        Total Cost: <asp:Label ID="totalLabel" runat="server"></asp:Label>
        <asp:Label ID="errorLabel" CssClass="alert alert-danger" runat="server" Visible="false"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
