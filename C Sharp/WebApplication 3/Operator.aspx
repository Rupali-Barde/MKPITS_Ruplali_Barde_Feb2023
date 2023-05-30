<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Operator.aspx.cs" Inherits="WebApplication_3.Operator" %>

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
            OPERATOR<br />
            <br />
            Number1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Number2<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Operator<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" Width="84px" />
            <br />
            <br />
            Result: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
