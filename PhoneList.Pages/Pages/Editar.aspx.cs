using PhoneList.Pages.Data;
using PhoneList.Pages.Dto;
using PhoneList.Pages.Services;
using System;
using System.Linq;
using System.Web.UI;

namespace PhoneList.Pages
{
    public partial class Editar : Page
    {
        ContactoService contactoService = new ContactoService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var contactoId = Convert.ToInt32(Session["ContactId"]);
                var contacto = contactoService.ObtenerContactoPorId(contactoId);


                // logica para cargar datos del contacto
                txtNombre.Text = contacto.Nombre;
                txtApellido.Text = contacto.Apellido;
                txtCompania.Text = contacto.Compania;


                // metodo para ObtenerTelefonoConEtiqueta
                var telefonosEtiquetaTupla = contactoService.ObtenerTelefonosConEtiquetaPorContactoId(contactoId);

                if (telefonosEtiquetaTupla != null)
                {
                    var telefono = telefonosEtiquetaTupla[0].Item1;
                    var etiqueta = telefonosEtiquetaTupla[0].Item2;
                    txtTelefono.Text = telefono;
                    ddlEtiquetaTelefono.SelectedValue = etiqueta.ToString();
                }
                else
                {
                    txtTelefono.Text = "";
                }


                // metodo para ObtenerTelefonoConEtiqueta
                var emailsEtiquetaTupla = contactoService.ObtenerEmailsConEtiquetaPorContactoId(contactoId);

                if (emailsEtiquetaTupla != null)
                {
                    var email = emailsEtiquetaTupla[0].Item1;
                    var etiqueta = emailsEtiquetaTupla[0].Item2;
                    txtCorreo.Text = email;
                    ddlEtiquetaCorreo.SelectedValue = etiqueta.ToString();
                }
                else
                {
                    txtCorreo.Text = "";
                }


                // metodo para ObtenerFechaConEtiqueta
                var fechasEtiquetaTupla = contactoService.ObtenerFechasConEtiquetaPorContactoId(contactoId);

                if (fechasEtiquetaTupla != null)
                {
                    var fecha = fechasEtiquetaTupla[0].Item1;
                    var etiqueta = fechasEtiquetaTupla[0].Item2;
                    txtFecha.Text = fecha;
                    ddlEtiquetaFecha.SelectedValue = etiqueta.ToString();
                }


                // carga de dropdownlist
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

        protected void btnGuardar_Click(object sender, EventArgs e)
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
                FechaImportante = DateTime.ParseExact(txtFecha.Text, "dd/MM/yyyy", null),
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