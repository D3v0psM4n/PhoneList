<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PhoneList.Pages._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="row" style="margin-top:25px">
        <div class="col-sm-3" style="margin-top:25px">
            <asp:ListView ID="ListContacts" runat="server" 
                    OnSelectedIndexChanged="ListContacts_SelectedIndexChanged"
                    OnSelectedIndexChanging="ListContacts_SelectedIndexChanging"
                    AutoPostBack="true">
                    <ItemTemplate>
                        <div class="item-contact">
                           <asp:LinkButton runat="server" ID="ButtonSelect" CommandName="Select" Text='<%#Eval("Nombre") %>'/>
                        </div>
                        <br/>
                    </ItemTemplate>
                </asp:ListView>
        </div>
        <div class="col-sm-9">
            <h3>Contacts</h3>
            <asp:Image ID="AvatarImage" runat="server" ImageUrl="#" />
            <!-- Contenido -->
        </div>
</div>

</asp:Content>
