<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemMaster.aspx.cs" Inherits="Driven_IT.ItemMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp; Transaction Form</strong></p>
<table class="w-100">
    <tr>
        <td style="width: 304px; height: 78px;">Item Id</td>
        <td style="height: 78px">
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ItemDescr" DataValueField="ItemId">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenItConnectionString %>" ProviderName="<%$ ConnectionStrings:DrivenItConnectionString.ProviderName %>" SelectCommand="SELECT [ItemId], [ItemDescr] FROM [ItemMaster]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td style="width: 304px">Transaction Type</td>
        <td>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Mode" Text="Issue" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" GroupName="Mode"  Text="Purchase" />
        </td>
    </tr>
    <tr>
        <td style="width: 304px">Transaction Quantity</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 304px">Transaction Date</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
</table>
<p>
</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit " />
&nbsp;
    
        <asp:Button ID="Button3" runat="server" Text="Delete" />
    
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    :
</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TransId" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="TransId" HeaderText="TransId" InsertVisible="False" ReadOnly="True" SortExpression="TransId" />
                <asp:BoundField DataField="ItemId" HeaderText="ItemId" SortExpression="ItemId" />
                <asp:BoundField DataField="TransType" HeaderText="TransType" SortExpression="TransType" />
                <asp:BoundField DataField="TransQty" HeaderText="TransQty" SortExpression="TransQty" />
                <asp:BoundField DataField="TransDate" HeaderText="TransDate" SortExpression="TransDate" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenItConnectionString %>" DeleteCommand="DELETE FROM [Transactions] WHERE [TransId] = @TransId" InsertCommand="INSERT INTO [Transactions] ([ItemId], [TransType], [TransQty], [TransDate]) VALUES (@ItemId, @TransType, @TransQty, @TransDate)" SelectCommand="SELECT [TransId], [ItemId], [TransType], [TransQty], [TransDate] FROM [Transactions]" UpdateCommand="UPDATE [Transactions] SET [ItemId] = @ItemId, [TransType] = @TransType, [TransQty] = @TransQty, [TransDate] = @TransDate WHERE [TransId] = @TransId">
            <DeleteParameters>
                <asp:Parameter Name="TransId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ItemId" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TransDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ItemId" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TransDate" Type="DateTime" />
                <asp:Parameter Name="TransId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</p>
    <p>
        &nbsp;</p>
    <p>
        
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenItConnectionString %>" DeleteCommand="DELETE FROM [Transactions] WHERE [TransId] = @TransId" InsertCommand="INSERT INTO [Transactions] ([ItemId], [TransType], [TransQty], [TransDate]) VALUES (@ItemId, @TransType, @TransQty, @TransDate)" SelectCommand="SELECT [TransId], [ItemId], [TransType], [TransQty], [TransDate] FROM [Transactions]" UpdateCommand="UPDATE [Transactions] SET [ItemId] = @ItemId, [TransType] = @TransType, [TransQty] = @TransQty, [TransDate] = @TransDate WHERE [TransId] = @TransId">
            <DeleteParameters>
                <asp:Parameter Name="TransId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ItemId" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TransDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ItemId" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TransDate" Type="DateTime" />
                <asp:Parameter Name="TransId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</p>
<p>
</p>
</asp:Content>
