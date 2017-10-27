<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Chal3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Your Note Taking Preferences<br />
        <br />
        <asp:RadioButton ID="PencilRadioButton" runat="server" GroupName="noteGroup" Text="Pencil" />
        <br />
        <asp:RadioButton ID="PenRadioButton" runat="server" GroupName="noteGroup" Text="Pen" />
        <br />
        <asp:RadioButton ID="PhoneRadioButton" runat="server" GroupName="noteGroup" Text="Phone" />
        <br />
        <asp:RadioButton ID="TabletRadioButton" runat="server" GroupName="noteGroup" Text="Tablet" />
        <br />
        <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="NoteTakerImage" runat="server" />
    
    </div>
    </form>
</body>
</html>
