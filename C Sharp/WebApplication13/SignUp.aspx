<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication13.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 407px;
            color: #FFFFFF;
        }
        .auto-style3 {
            width: 407px;
            text-align: center;
            font-size: large;
            color: #FFFFFF;
        }
        .auto-style4 {
            width: 407px;
            height: 45px;
        }
        .auto-style5 {
            height: 45px;
        }
        .auto-style6 {
            width: 50%;
            height: 204px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align=Center class="text-white">Sign Up</h1>
   
    <table class="auto-style6" align="center">
        <tr>
            <td class="auto-style3">Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="195px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="36px" Width="195px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Height="51px" Text="Submit" Width="144px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
