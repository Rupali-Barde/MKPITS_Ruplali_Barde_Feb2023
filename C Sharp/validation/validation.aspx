<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="validation.validation" %>

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
        .auto-style3 {
            height: 58px;
        }
        .auto-style4 {
            width: 259px;
        }
        .auto-style5 {
            height: 58px;
            width: 259px;
        }
        .auto-style6 {
            width: 259px;
            height: 35px;
        }
        .auto-style7 {
            height: 35px;
        }
        .auto-style8 {
            width: 255px;
        }
        .auto-style9 {
            height: 58px;
            width: 255px;
        }
        .auto-style10 {
            width: 255px;
            height: 35px;
        }
        .auto-style11 {
            width: 259px;
            height: 33px;
        }
        .auto-style12 {
            width: 255px;
            height: 33px;
        }
        .auto-style13 {
            height: 33px;
        }
    </style>
</head>
<body>
    <p class="auto-style2">
        Validation<br />
    </p>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">User Name</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textBox1" ErrorMessage="Please Fill User Name">Enter The User Name</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="textbox2" ControlToValidate="textbox3" ErrorMessage="Please Enter Proper Password">Enter Validate Password</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Re-enter-Password</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style11">Age</td>
                <td class="auto-style12">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Age Is Not Proper" MaximumValue="90" MinimumValue="18">Please Enter Proper Age</asp:RangeValidator>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textbox4" ErrorMessage="Age Field Is Required ">Age Cannot Be Empty. </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Email</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="textbox5" ErrorMessage="Please Enter Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Enter Proper Email</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">DOB</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Enter Proper DOB" OnServerValidate="CustomValidator1_ServerValidate">DOB Is Required Field</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style7"></td>
            </tr>
        </table>
        <div>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
