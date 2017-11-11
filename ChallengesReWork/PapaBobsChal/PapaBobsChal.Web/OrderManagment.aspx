<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagment.aspx.cs" Inherits="PapaBobsChal.Web.OrderManagment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>- Order Management -</h1>
        <asp:Label ID="completedLabel" runat="server" Text="YOUR ORDER HAS BEEN COMPLETED!" Visible="false"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:ButtonField Text="Complete" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
