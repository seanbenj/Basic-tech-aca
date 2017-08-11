<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LS3Challenge1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div aria-busy="True">
    
        Your note taking preferences<br />
        <br />
        <asp:RadioButton ID="pencilButton" runat="server" Text="Pencil" GroupName="noteGroup" />
        <br />
        <asp:RadioButton ID="penButton" runat="server" Text="Pen" GroupName="noteGroup" />
        <br />
        <asp:RadioButton ID="phoneButton" runat="server" Text="Phone" GroupName="noteGroup" />
        <br />
        <asp:RadioButton ID="tabletButton" runat="server" Text="Tablet" GroupName="noteGroup" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" Text="OK" OnClick="okButton_Click" />
        <br />
        <asp:Image ID="selectImage" runat="server" />
        <br />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
