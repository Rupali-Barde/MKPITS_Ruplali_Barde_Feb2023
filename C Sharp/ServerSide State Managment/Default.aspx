<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ServerSide_State_Managment._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">MKP IT SERVICES</h1>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp; :
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </p>
            <p class="lead">MKP IT Services is a leading training, job and staffing services provider in Nagpur. We have over a decade of presence now. Previously we were known as MK Placements and Education Services We also provide services in Pune, Hyderabad, Bangalore, Mumbai, Indore, Bhopal and more cities.   </p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Training And Internship</h2>
                <p>
                    We conduct placements services for freshers, skilled and semi-skilled candidates
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle"> Campus Placement Services</h2>
                <p>
                     Placement services for junior, mid level and senior level recruitment
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle"> Lateral Placement Service</h2>
                <p>
                    Placement services for junior, mid level and senior level recruitment
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
