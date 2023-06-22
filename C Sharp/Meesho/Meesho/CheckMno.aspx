<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckMno.aspx.cs" Inherits="Meesho.CheckMno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <br />
        Enter Otp&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p class="text-center">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" Width="84px" />
    </p>
    <p class="text-center">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p class="text-center">
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
