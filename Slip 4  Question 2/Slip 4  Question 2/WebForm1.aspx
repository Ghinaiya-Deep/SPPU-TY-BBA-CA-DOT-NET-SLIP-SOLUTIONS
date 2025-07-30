<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Slip_4__Question_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="CRUD Operations on Department Table"></asp:Label>
        <p>
&nbsp;</p>
&nbsp;
        <p>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="DeptID" DataSourceID="SqlDataSource1" DefaultMode="Insert" ForeColor="#333333" GridLines="None" Height="93px" Width="388px">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
                <EditRowStyle BackColor="#7C6F57" />
                <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
                <Fields>
                    <asp:BoundField DataField="DeptID" HeaderText="DeptID" ReadOnly="True" SortExpression="DeptID" />
                    <asp:BoundField DataField="DeptName" HeaderText="DeptName" SortExpression="DeptName" />
                    <asp:BoundField DataField="EmployeeName" HeaderText="EmployeeName" SortExpression="EmployeeName" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
            </asp:DetailsView>
        </p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="DeptID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DeptID" HeaderText="DeptID" ReadOnly="True" SortExpression="DeptID" />
                <asp:BoundField DataField="DeptName" HeaderText="DeptName" SortExpression="DeptName" />
                <asp:BoundField DataField="EmployeeName" HeaderText="EmployeeName" SortExpression="EmployeeName" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        s<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Department] WHERE (([DeptID] = ?) OR ([DeptID] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [Department] ([DeptID], [DeptName], [EmployeeName], [Salary]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Department]" UpdateCommand="UPDATE [Department] SET [DeptName] = ?, [EmployeeName] = ?, [Salary] = ? WHERE (([DeptID] = ?) OR ([DeptID] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="DeptID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="DeptID" Type="Int32" />
                <asp:Parameter Name="DeptName" Type="String" />
                <asp:Parameter Name="EmployeeName" Type="String" />
                <asp:Parameter Name="Salary" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="DeptName" Type="String" />
                <asp:Parameter Name="EmployeeName" Type="String" />
                <asp:Parameter Name="Salary" Type="Int32" />
                <asp:Parameter Name="DeptID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
