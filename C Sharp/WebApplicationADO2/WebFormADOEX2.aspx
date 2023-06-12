<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormADOEX2.aspx.cs" Inherits="WebApplicationADO2.WebFormADOEX2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Total Amount&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Amount Paid
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Cash" />
&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" Text="EMI" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show EMI" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
