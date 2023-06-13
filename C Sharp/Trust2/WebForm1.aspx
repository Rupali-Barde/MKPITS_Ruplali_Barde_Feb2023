<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Trust2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 379px;
        }
        .auto-style4 {
            width: 383px;
        }
        .auto-style5 {
            width: 112%;
            height: 229px;
        }
        .auto-style6 {
            width: 296px;
        }
        .auto-style7 {
            width: 272px;
        }
        .auto-style8 {
            width: 99%;
            height: 220px;
        }
        .auto-style9 {
            width: 403px;
        }
        .auto-style10 {
            width: 93%;
            height: 246px;
        }
        .auto-style11 {
            width: 164px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">Customer Details</td>
                    <td class="auto-style6">Product Details</td>
                    <td class="auto-style9">Transaction</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <table class="auto-style8">
                            <tr>
                                <td class="auto-style11">Customer Name</td>
                                <td>
                                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">Gender</td>
                                <td>
                                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
                                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">Address</td>
                                <td>
                                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">Mobile No</td>
                                <td>
                                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style6">
                        <table class="auto-style5">
                            <tr>
                                <td class="auto-style4">Category</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">ItemName</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">Rate</td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">Balance_Quantity</td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style9">
                        <asp:Panel ID="Panel2" runat="server" Height="270px">
                            <table class="auto-style10">
                                <tr>
                                    <td class="auto-style7">Department</td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList2" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Vendor</td>
                                    <td>
                                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Quantity</td>
                                    <td>
                                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">Transaction Date</td>
                                    <td>
                                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
