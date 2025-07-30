<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Slip_19_Q_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Overline="False" ForeColor="Black" Text="How is the book ASP.NET with C# by Wrox Publication?"></asp:Label>
        <p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                <asp:ListItem>Good</asp:ListItem>
                <asp:ListItem>Satisfactory</asp:ListItem>
                <asp:ListItem>Bad</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
