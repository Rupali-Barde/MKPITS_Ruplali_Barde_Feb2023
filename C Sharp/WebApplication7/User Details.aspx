<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User Details.aspx.cs" Inherits="WebApplication7.User_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Address</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mobile No</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">DOB</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Hobbies</td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Music" />
&nbsp;<asp:CheckBox ID="CheckBox2" runat="server" Text="Dancing" />
&nbsp;<asp:CheckBox ID="CheckBox3" runat="server" Text="Reading" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">City</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="194px">
                        <asp:ListItem Value="Nagpur"></asp:ListItem>
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Amarawati</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Ok" Width="107px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        Result :&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
