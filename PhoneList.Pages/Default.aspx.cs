using PhoneList.Pages.Data;
using PhoneList.Pages.Services;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneList.Pages
{
    public partial class _Default : Page
    {
        // Llamar al método de la conexión
        ContactoService contactoService = new ContactoService();

        /// <summary>
        /// Declaraciones ejecutadas al cargar la página de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Carga los contactos en la barra lateral izquierda
            var contacts = contactoService.ObtenerTodos();

            // Estabelecer la fuente de la DB y vincular al control especificado
            ListContacts.DataSource = contacts;
            ListContacts.DataBind();
        }

        /// <summary>
        /// Declaraciones ejecutadas al seleccionar el elemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ListContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0. Convierto 'sender' de Class object, a Class ListView
            // ya que posee las propiedades del control en tiempo de ejecución
            var listView = (ListView)sender;

            // 1. Obtengo especificamente el indice del elemento seleccionado
            var selectedIndex = listView.SelectedIndex;

            // 2. Accedo a la propiedad Items (un array) para enviar el indice
            var item = listView.Items[selectedIndex];

            // 3. Busco el control anidado ButtonSelect con la propiedad FindControl, 
            // y convierto en LinkButton para acceder a sus propiedades
            var label = (Label)item.FindControl("lblIdentify");

            // 4. Hago visible los datos del contacto en la sección de contenido
            var contacto = contactoService.ObtenerContactoPorId(Convert.ToInt32(label.Text));

            contentPanelLeft.Visible = true;
            contentPanelRight.Visible = true;
            TitleContact.Visible = true;
            lblFirstName.Text = contacto.Nombre;
            lblFirstName.Visible = true;
            lblLastName.Text = contacto.Apellido;
            lblLastName.Visible = true;
            lblCompany.Text = contacto.Compania;
            lblCompany.Visible = true;

            // 4.1 obtener la lista de telefonos
            var telefonos = contactoService.ObtenerTelefonosPorContactoId(contacto.Id);

            ListOfPhones.DataSource = telefonos;
            ListOfPhones.DataBind();

            // 4.2 obtener la lista de emails
            var emails = contactoService.ObtenerEmailsPorContactoId(contacto.Id);

            ListOfEmails.DataSource = emails;
            ListOfEmails.DataBind();

            // 4.3 obtener la lista de fechas
            var fechas = contactoService.ObtenerFechasPorContactoId(contacto.Id);

            ListOfDates.DataSource = fechas;
            ListOfDates.DataBind();
        }

        protected void ListContacts_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
        }
    }
}