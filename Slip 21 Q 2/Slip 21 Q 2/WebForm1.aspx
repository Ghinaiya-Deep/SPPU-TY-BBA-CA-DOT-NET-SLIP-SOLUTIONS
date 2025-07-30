<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Slip_21_Q_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Text="Insert and Update Operations on Employee Table"></asp:Label>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Employee]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Eno" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Eno" HeaderText="Eno" ReadOnly="True" SortExpression="Eno" />
                <asp:BoundField DataField="Ename" HeaderText="Ename" SortExpression="Ename" />
                <asp:BoundField DataField="Edesignation" HeaderText="Edesignation" SortExpression="Edesignation" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                <asp:BoundField DataField="Joindate" HeaderText="Joindate" SortExpression="Joindate" />
            </Columns>
        </asp:GridView>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="Eno" DataSourceID="SqlDataSource1" DefaultMode="Insert" ForeColor="Black" GridLines="Vertical" Height="218px" Width="380px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="Eno" HeaderText="Eno" ReadOnly="True" SortExpression="Eno" />
                <asp:BoundField DataField="Ename" HeaderText="Ename" SortExpression="Ename" />
                <asp:BoundField DataField="Edesignation" HeaderText="Edesignation" SortExpression="Edesignation" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                <asp:BoundField DataField="Joindate" HeaderText="Joindate" SortExpression="Joindate" />
            </Fields>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        </asp:DetailsView>
    </form>
</body>
</html>
