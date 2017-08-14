<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spyAssignerForm.aspx.cs" Inherits="CSLS5challenge1.spyAssignerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/epic-spies-logo.jpg"  Height="190px" Width="190px"/>
    
        <h1 class="auto-style1">Spy New Assignment Form</h1>
        <p class="auto-style1">
            Spy Code Name:<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            New Assignment Name:<asp:TextBox ID="locationTextBox" runat="server"></asp:TextBox>
        </p>
        End Date of Previous Assignment:<asp:Calendar ID="endPrevCalendar" runat="server" SelectedDate="2017-08-14"></asp:Calendar>
        <br />
        <br />
        Start Date of New Assignment:<asp:Calendar ID="starNewCalendar" runat="server" SelectedDate="2017-08-28"></asp:Calendar>
        <br />
        <br />
        Projected End Date of New Assignment:<asp:Calendar ID="endNewCalendar" runat="server" SelectedDate="2017-09-04"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="assignDetail" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
