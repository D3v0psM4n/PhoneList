<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PhoneList.Pages._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
      <div class="row">
        <div class="col-sm-3 col-md-2 sidebar left-sidebar_color">
            <ul class="nav nav-sidebar">
                <asp:ListView ID="ListContacts" runat="server">
                    <ItemTemplate>
                        <asp:Label ID="Label1" class="sidebar" runat="server" Text='<%# Eval("Nombre")%>'></asp:Label><br />
                    </ItemTemplate>
                </asp:ListView>
            </ul>

        </div>
        <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main content">
            <h4 class="page-header">Contacts</h4>
            <!-- Contenido -->
        </div>
      </div>
    </div>

</asp:Content>
