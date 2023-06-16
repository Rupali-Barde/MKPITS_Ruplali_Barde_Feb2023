<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Transaction_Details.aspx.cs" Inherits="Vendor_Mast1.Transaction_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 593px;
        }
        .auto-style4 {
            width: 593px;
            height: 33px;
        }
        .auto-style5 {
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <div class="auto-style1">
            <strong>Transaction Details</strong><br />
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="Mode" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Issue" />
                </td>
                <td>
                    <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="Mode" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchase" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Transaction Id</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Item Id</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="187px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Transaction Date</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Department Id"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="188px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Vendor Id"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="177px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Quantity</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
