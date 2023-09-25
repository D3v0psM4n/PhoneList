<%@ Page Title="Editar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="PhoneList.Pages.Editar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Editar contacto</h3>

    <div class="col-md-6">
        <asp:Image ID="AvatarImage" runat="server" ImageUrl="../Images/avatar.png" CssClass="content_avatar-mini" /><br />
        <br />
        <asp:Button ID="btnLoadImage" runat="server" class="btn btn-default right-sidebar_size-button" Text="Subir" />
        <br />
        <br />

        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label><br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label><br />
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblCompania" runat="server" Text="Compañia:"></asp:Label><br />
        <asp:TextBox ID="txtCompania" runat="server"></asp:TextBox><br />
        <br />
    </div>

    <div class="col-md-6">
        <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label><br />
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblEtiquetaTelefono" runat="server" Text="Etiqueta Teléfono:"></asp:Label><br />
        <asp:DropDownList ID="ddlEtiquetaTelefono" runat="server"
            OnSelectedIndexChanged="ddlEtiquetaTelefono_SelectedIndexChanged"
            AutoPostBack="true" DataTextField="Nombre" DataValueField="Id"
            CssClass="content_size-dropdownlist">
        </asp:DropDownList><br />
        <br />

        <asp:Label ID="lblCorreo" runat="server" Text="Email:"></asp:Label><br />
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblEtiquetaCorreo" runat="server" Text="Etiqueta Email:"></asp:Label><br />
        <asp:DropDownList ID="ddlEtiquetaCorreo" runat="server"
            OnSelectedIndexChanged="ddlEtiquetaCorreo_SelectedIndexChanged"
            AutoPostBack="true" DataTextField="Nombre" DataValueField="Id"
            CssClass="content_size-dropdownlist">
        </asp:DropDownList><br />
        <br />

        <asp:Label ID="lblFecha" runat="server" Text="Fecha importante:"></asp:Label><br />
        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblEtiquetaFecha" runat="server" Text="Etiqueta Fecha:"></asp:Label><br />
        <asp:DropDownList ID="ddlEtiquetaFecha" runat="server"
            OnSelectedIndexChanged="ddlEtiquetaFecha_SelectedIndexChanged"
            AutoPostBack="true" DataTextField="Nombre" DataValueField="Id"
            CssClass="content_size-dropdownlist">
        </asp:DropDownList><br />
        <br />
    </div>

    <div class="row">
        <div class="col-md-6"></div>
        <div class="col-md-6">
            <asp:Button ID="btnGuardar" runat="server" class="btn btn-primary right-sidebar_size-button" Text="Guardar" OnClick="btnGuardar_Click" />
            <a runat="server" href="/" class="btn btn-danger right-sidebar_size-button">Cancelar</a>
        </div>
    </div>

    <%--Script the jquery--%>
    <script>
        $(function () {
            $('#<%= txtFecha.ClientID %>').datepicker(
            {
              dateFormat: 'dd/mm/yy'
            });
        });
    </script>

</asp:Content>
