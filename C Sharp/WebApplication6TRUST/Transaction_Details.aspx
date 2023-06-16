<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction_Details.aspx.cs" Inherits="WebApplication6TRUST.Transaction_Details" %>

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
            width: 576px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Transaction Details<br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="Mode" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Issue" />
&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="Mode" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchase" />
            <br />
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">Item_Name</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource4" DataTextField="Item_Name" DataValueField="Item_Id">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:trustConnectionString %>" SelectCommand="SELECT [Item_Id], [Item_Name], [Category], [Rate], [Balance_Quantity] FROM [Item_Master]"></asp:SqlDataSource>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:trustConnectionString %>" ProviderName="<%$ ConnectionStrings:trustConnectionString.ProviderName %>" SelectCommand="SELECT [Department_Name], [Department_Id] FROM [Department_Mast]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Transaction_Date</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Department_Name"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3" DataTextField="Department_Name" DataValueField="Department_Id">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:trustConnectionString %>" SelectCommand="SELECT [Department_Id], [Department_Name] FROM [Department_Mast]"></asp:SqlDataSource>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:trustConnectionString %>" SelectCommand="SELECT [Vendor_Id], [Vendor_Name] FROM [Vendor_Mast]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Vendor_Name"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource5" DataTextField="Vendor_Name" DataValueField="Vendor_Id">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:trustConnectionString %>" SelectCommand="SELECT [Vendor_Id], [Vendor_Name] FROM [Vendor_Mast]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Quantitys</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        :
    </form>
</body>
</html>
