<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

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
<body style="text-align: center">
    <form id="form1" runat="server">
        <div>
            Arithmetic Operations<br />
        </div>
    <hr>

    </hr>

        <table class="auto-style1">
            <tr>
                <td>Number1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Number2<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Result:
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Subtract" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-right: 23px" Text="Multiplication" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="Division" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    </body>
</html>
