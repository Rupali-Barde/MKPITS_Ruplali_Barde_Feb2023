<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1ADO.aspx.cs" Inherits="ADOEx1.WebForm1ADO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    &nbsp;<br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Load" />
        <br />
    </form>
</body>
</html>
