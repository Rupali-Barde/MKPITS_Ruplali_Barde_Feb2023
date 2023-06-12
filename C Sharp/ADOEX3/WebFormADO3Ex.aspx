<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormADO3Ex.aspx.cs" Inherits="ADOEX3.WebFormADO3Ex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <p>
            &nbsp;</p>
        <p>
            ProductId&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            ProductTypeId
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1"></asp:TextBox>
        </p>
        <p>
            ProductName
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            ProductPrice<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" />
&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" />
&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Search" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
