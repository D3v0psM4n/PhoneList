<%@ Page Title="Crear" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="PhoneList.Pages.Crear" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Crear contacto</h3>
    <asp:Label ID="Label1" runat="server" Text="Imagen"></asp:Label><br />
    <asp:Button ID="btnLoadImage" runat="server" Text="Subir" /><br /><br />

    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label><br />
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
    <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label><br />
    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox><br />
    <asp:Label ID="lblCompania" runat="server" Text="Compañia:"></asp:Label><br />
    <asp:TextBox ID="txtCompania" runat="server"></asp:TextBox>
</asp:Content>
