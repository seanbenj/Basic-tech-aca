<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Chal6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="spyImage" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        <br />
        <br />
        <h2>Spy New Assignment Form</h2>
        <br />
        Spy Code Name:&nbsp; <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:&nbsp;
        <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment:<asp:Calendar ID="endPrevCalendar" runat="server">
        </asp:Calendar>
        <br />
        <br />
        Start Date of New Assignment:<asp:Calendar ID="startNewCalendar" runat="server">
        </asp:Calendar>
        <br />
        <br />
        Projected End Date of New Assignment:<asp:Calendar ID="endNewCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
&nbsp;<asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
