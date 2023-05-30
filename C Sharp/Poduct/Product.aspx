<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Poduct.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            ITEM
            <br />
            ItemName:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="233px"></asp:TextBox>
            <br />
            Quantity:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 0px" Width="184px"></asp:TextBox>
&nbsp;
            <br />
            Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Order" />
        </p>
        <p style="text-align: center">
            Total Amount:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
