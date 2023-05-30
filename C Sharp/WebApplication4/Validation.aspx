<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="WebApplication4.Validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Validation<br />
            <br />
            Age:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="58px" OnClick="Button1_Click" Text="Ok" Width="106px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Result:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
