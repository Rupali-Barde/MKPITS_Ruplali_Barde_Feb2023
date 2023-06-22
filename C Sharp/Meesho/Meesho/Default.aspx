<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Meesho._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        

        <div class="row">
            <section class="col-md-6" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Lowest Prices
Best Quality Shopping </h2>
                <p>
                    <ul>
                        <li>Free Delivery </li>
                        <li>Cash On Delivery</li>
                        <li>Easy Return</li>
                        </ul>

                
                </p>
                
            </section>
           
            <section class="col-md-6" aria-labelledby="hostingTitle">
                <img src="iamge1.jpg" />
            </section>
        </div>

        <hr />

        <div align="center">
           <h3>Top Categories To Choose Form</h3>
        </div>
        <div align="center"> 
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="100%">
            <ItemTemplate>
                <table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 100px;  background-color: #FFFFFF">
                    <tr>
                        <td align="center">
                         <a href='<%# Eval("ProdId","productdetails.aspx?ProdId={0}") %>'>
                        <asp:Image ID="Image1" ImageUrl='<%# Bind("Prodimage", "~/imageprod/{0}") %>' runat="server" Height="100" Width="100" />
                             </a>
                        

                        </td>
                    </tr>
                        <tr>
                        <td align="center">
                            <span > <%# Eval("prodName") %></span><br />
                            <span > <%# Eval("ProdDescription") %></span><br />
                            <span >Rs. <%# Eval("ProdPrice") %> onwards</span><br />

                        </td>
                    </tr>
                </table>
                </ItemTemplate>
                </asp:DataList>
        </div>
        
    </main>

</asp:Content>
