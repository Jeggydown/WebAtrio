<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAtrio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <%--<div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>
    <asp:Panel ID="Panel0" VerticAlalign="Top" BackColor="Silver" runat="server">
        <table id="Rechercherid1" style="background-color:Silver; width:100%; height:auto">
			<tr>
				<td>
                    <asp:Label ID="lblLastName" Text="Nom :" runat="server" />
				</td>
                <td>
				    <asp:TextBox ID="txtLastName" runat="server" />
				</td>
			</tr>
			<tr>
				<td>
                    <asp:Label ID="lblFirstName" Text="Prénom :" runat="server" />
				</td>
                <td>
				    <asp:TextBox ID="txtFirstName" runat="server" />
				</td>
			</tr>
			<tr>
				<td>
                    <asp:Label ID="lblDateBirth" Text="Date de naissance :" runat="server" />
				</td>
                <td>
				    <asp:TextBox ID="txtDateBirth" runat="server" TextMode="Date"  placeholder="dd/MM/YYYY"  />
                    <%--<asp:Calendar ID="Calendar1" runat="server" Width="150px" 
                                  DayNameFormat="Shortest" Height="25px" /> --%>
				</td>
			</tr>
        </table>
        <asp:Button ID="btnValidate" runat="server" Text="Sauvegarder" OnClick="btnValidate_Click" />
    </asp:Panel>

    <asp:Panel ID="Panel1" VerticAlalign="Top" BackColor="Silver" runat="server">
        <asp:Button ID="btnShowList" runat="server" Text="Afficher Liste" OnClick="btnShowList_Click" />
        <asp:Repeater runat="server" ID="dataRepeater">
            <HeaderTemplate>
                <table style="background-color:Silver; width:100%; height:auto">
                    <thead>
                        <tr>
                            <td>Nom</td>
                        </tr>
                        <tr>
                            <td>Prénom</td>
                        </tr>
                        <tr>
                            <td>Date de naissance</td>
                        </tr>
                        <tr>
                            <td>Age</td>
                        </tr>
                    </thead>
            </HeaderTemplate>
            <ItemTemplate>
			    <tr>
                    <td>
				        <asp:Label ID="lbl1" runat="server" Text='<%#Eval("LastName") %>' />
				    </td>
			    </tr>
			    <tr>
                    <td>
				        <asp:Label ID="lbl2" runat="server" Text='<%#Eval("FirstName") %>' />
				    </td>
			    </tr>
			    <tr>
                    <td>
				        <asp:Label ID="lbl3" runat="server" Text='<%#Eval("BirthDate") %>' />
				    </td>
			    </tr>
			    <tr>
                    <td>
				        <asp:Label ID="lbl4" runat="server" Text='<%#Eval("Age") %>' />
				    </td>
			    </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </asp:Panel>

</asp:Content>
