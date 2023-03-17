<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pic.aspx.cs" Inherits="WebApplication3.pic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="136px" ImageUrl="~/images/beauty_of_nature_17_211513.jpg" Width="267px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="71px" ImageUrl="~/images/beauty_of_nature_17_211513.jpg" Width="216px" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="studid" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="studid" HeaderText="studid" ReadOnly="True" SortExpression="studid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                    <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:e_commerceConnectionString %>" SelectCommand="SELECT * FROM [student]"></asp:SqlDataSource>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink runat="server" NavigateUrl="https://www.google.com/search?q=google&amp;rlz=1C1GTPM_enIN1044IN1044&amp;oq=goo&amp;aqs=chrome.0.0i131i355i433i512j46i131i199i433i465i512j0i131i433i512j69i57j0i131i433i512l4j0i512j0i433i512.161564j0j7&amp;sourceid=chrome&amp;ie=UTF-8">open google</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server" />
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
