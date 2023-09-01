using PhoneList.Pages.Data;
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
        ModelPhoneDbContext modelPhoneDbContext = new ModelPhoneDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Compania = txtCompania.Text
            };

            ContactoService contactoService = new ContactoService();
            contactoService.Crear(contacto);
        }
    }
}