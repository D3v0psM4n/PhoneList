<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PhoneList.Pages._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">

        <div class="left-sidebar_color col-sm-3">
            <br />

            <asp:ListView ID="ListContacts" runat="server"
                OnSelectedIndexChanged="ListContacts_SelectedIndexChanged"
                OnSelectedIndexChanging="ListContacts_SelectedIndexChanging"
                AutoPostBack="true">
                <ItemTemplate>
                    <div class="left-sidebar_item">
                        <asp:LinkButton runat="server" ID="ButtonSelect" CommandName="Select" Text='<%#Eval("Nombre") %>' />
                        <asp:Label runat="server" ID="lblIdentify" Text='<%#Eval("Id") %>' Visible="false" />
                    </div>
                    <br />
                </ItemTemplate>
            </asp:ListView>

        </div>

        <div class="col-sm-9">
            <!-- Contenido -->
            <br />
            <br />

            <div class="col-md-8">
                <asp:Panel ID="contentPanelLeft" runat="server" Visible="false" CssClass="panel panel-default col-md-12 content_panel-color">
                    <div class="panel-body">
                        <asp:Label ID="TitleContact" runat="server" Visible="false" CssClass="content_font-bold" Text="Contacts"></asp:Label>
                        <br />
                        <br />

                        <asp:Label ID="lblFirstName" runat="server" Visible="false"></asp:Label><br />
                        <asp:Label ID="lblLastName" runat="server" Visible="false"></asp:Label><br />
                        <asp:Label ID="lblCompany" runat="server" Visible="false"></asp:Label>
                        <asp:Label ID="lblPhone" runat="server" Visible="false"></asp:Label>
                        <asp:Label ID="lblEmail" runat="server" Visible="false"></asp:Label>
                        <asp:Label ID="lblDate" runat="server" Visible="false"></asp:Label>
                        <br />

                        <asp:ListView ID="ListOfPhones" runat="server">
                            <ItemTemplate>
                                <asp:Label ID="Phones" runat="server" Text='<%# Container.DataItem %>' />
                                <br />
                            </ItemTemplate>
                        </asp:ListView>

                    </div>
                </asp:Panel>
            </div>

            <div class="col-md-4">

                <asp:Panel ID="contentPanelRight" runat="server" Visible="false" CssClass="col-md-12">
                    <div class="content_position-center">
                        <asp:Image ID="AvatarImage" runat="server" ImageUrl="#" /><br />
                        <br />
                    </div>

                    <div class="content_position-center">
                        <button type="button" class="btn btn-default right-sidebar_size-button">Favoritos</button><br />
                    </div>
                    <div class="content_position-center">
                        <button type="button" class="btn btn-default right-sidebar_size-button">Editar</button><br />
                    </div>
                    <div class="content_position-center">
                        <button type="button" class="btn btn-default right-sidebar_size-button">Borrar</button>
                    </div>
                </asp:Panel>

            </div>

            <%--            <div class="col-md-8">
            </div>
            <div class="col-md-4">
                <div class="content_position-center">
                    <button type="button" class="btn btn-primary right-sidebar_size-button">Agregar</button>
                </div>
            </div>--%>
        </div>

    </div>

    <div class="row">
        <div class="left-sidebar_color col-sm-3">
            <br />
            <br />
        </div>
        <div class="col-sm-9">

            <div class="col-sm-8"></div>
            <div class="col-sm-4">
                <div class="content_position-center">
                    <button type="button" class="btn btn-primary right-sidebar_size-button">Agregar</button>
                </div>
            </div>
        </div>

    </div>

</asp:Content>
