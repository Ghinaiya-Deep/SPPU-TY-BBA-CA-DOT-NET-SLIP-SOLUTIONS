<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Slip_18_Q_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="157px" Width="144px">
            <asp:ListItem>Image1</asp:ListItem>
            <asp:ListItem>Image2</asp:ListItem>
            <asp:ListItem>Image3</asp:ListItem>
            <asp:ListItem>Image4</asp:ListItem>
        </asp:ListBox>
        <asp:Image ID="Image2" runat="server" Height="204px" />
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
