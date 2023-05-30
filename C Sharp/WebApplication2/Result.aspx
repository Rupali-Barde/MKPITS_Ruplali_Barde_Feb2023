<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebApplication2.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style2">Result</h1>
            <hr>
            </hr>
        </div>
        <p>
            Subject1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
    
    <table class="auto-style1">
        <tr>
            <td>Subject2<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Subject3<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Total:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Percentage:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                Grade:<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    
    </body>
</html>
