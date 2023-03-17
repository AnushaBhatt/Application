<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            calculator</div>
        <p>
&nbsp;</p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="enter first no"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="enter second number"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="132px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="submit" />
        </p>
        <p>
&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
            
        </p>
        <p>
            lists:</p>
        <p>
            1.drop down list</p>
        <p>
            &nbsp;</p>
        <p>
            select city: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>kolkata</asp:ListItem>
                <asp:ListItem>bangalore</asp:ListItem>
                <asp:ListItem>chennai</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="submit" />
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/beauty_of_nature_17_211513.jpg" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
