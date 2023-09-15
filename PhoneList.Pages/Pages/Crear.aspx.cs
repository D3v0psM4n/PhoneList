using PhoneList.Pages.Data;
using PhoneList.Pages.Dto;
using PhoneList.Pages.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneList.Pages
{
    public partial class Crear : Page
    {
        ContactoService contactoService = new ContactoService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var phones = contactoService.ObtenerEtiquetaTelefono();
                ddlEtiquetaTelefono.DataSource = phones;
                ddlEtiquetaTelefono.DataBind();

                var emails = contactoService.ObtenerEtiquetaEmail();
                ddlEtiquetaCorreo.DataSource = emails;
                ddlEtiquetaCorreo.DataBind();

                var dates = contactoService.ObtenerEtiquetaFecha();
                ddlEtiquetaFecha.DataSource = dates;
                ddlEtiquetaFecha.DataBind();
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            ContactoRequest contactoRequest = new ContactoRequest()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Compania = txtCompania.Text,
                Telefono = txtTelefono.Text,
                EtiquetaTelefonoId = Convert.ToInt32(ddlEtiquetaTelefono.SelectedValue),
                Email = txtCorreo.Text,
                EtiquetaEmailId = Convert.ToInt32(ddlEtiquetaCorreo.SelectedValue),
                //FechaImportante = txtFecha.Text,
                EtiquetaFechaId = Convert.ToInt32(ddlEtiquetaFecha.SelectedValue)
            };

            contactoService.Crear(contactoRequest);
            Response.Redirect("/");
        }

        protected void ddlEtiquetaTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void ddlEtiquetaCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void ddlEtiquetaFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}