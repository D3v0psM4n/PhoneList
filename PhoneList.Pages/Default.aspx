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
                        <asp:LinkButton ID="ButtonSelect" runat="server" CommandName="Select" Text='<%#Eval("Nombre") %>' CssClass="content_panel-font" />
                        <asp:Label ID="lblIdentify" runat="server" Text='<%#Eval("Id") %>' Visible="false" />
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
                        <asp:Label ID="lblFirstName" runat="server" Visible="false"></asp:Label>
                        <br />
                        <asp:Label ID="lblLastName" runat="server" Visible="false"></asp:Label>
                        <br />
                        <asp:Label ID="lblCompany" runat="server" Visible="false"></asp:Label>
                        <br />

                        <asp:ListView ID="ListOfPhones" runat="server">
                            <ItemTemplate>
                                <asp:Label ID="lblPhone" runat="server" Text='<%# Container.DataItem %>' />
                                <br />
                            </ItemTemplate>
                        </asp:ListView>

                        <asp:ListView ID="ListOfEmails" runat="server">
                            <ItemTemplate>
                                <asp:Label ID="lblEmail" runat="server" Text='<%# Container.DataItem %>' />
                                <br />
                            </ItemTemplate>
                        </asp:ListView>

                        <asp:ListView ID="ListOfDates" runat="server">
                            <ItemTemplate>
                                <asp:Label ID="lblDate" runat="server" Text='<%# Container.DataItem %>' />
                                <br />
                            </ItemTemplate>
                        </asp:ListView>

                    </div>
                </asp:Panel>
            </div>

            <div class="col-md-4">

                <asp:Panel ID="contentPanelRight" runat="server" Visible="false" CssClass="col-md-12">
                    <div class="content_position-center">
                        <asp:Image ID="AvatarImage" runat="server" ImageUrl="../Images/avatar.png" CssClass="content_avatar"/>
                    </div>
                    <br />

                    <div class="content_position-center">
                        <button type="button" class="btn btn-default right-sidebar_size-button">Favoritos</button><br />
                    </div>
                    <div class="content_position-center">
                        <a runat="server" href="~/Pages/Editar" class="btn btn-default right-sidebar_size-button">Editar</a>
                    </div>
                    <div class="content_position-center">
                        <button type="button" class="btn btn-default right-sidebar_size-button">Borrar</button>
                    </div>
                </asp:Panel>

            </div>

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
                    <a runat="server" href="~/Pages/Crear" class="btn btn-primary right-sidebar_size-button">Agregar</a>
                </div>
            </div>
        </div>

    </div>

</asp:Content>
