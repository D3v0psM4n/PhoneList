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
        // Llamar al método de la conxión
        ContactoService contactoService = new ContactoService();

        /// <summary>
        /// Declaraciones ejecutadas al cargar la página de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            var contacts = contactoService.ObtenerTodos();

            // Estabelecer la fuente de la DB y el vinculo al control especificado
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
            // 0.Convierto 'sender' de Class object, a Class ListView
            // ya que posee las propiedades del control en tiempo de ejecución
            var listView = (ListView)sender;

            // 1.Obtengo especificamente el indice del elemento seleccionado
            var selectedIndex = listView.SelectedIndex;

            // 2.Accedo a la propiedad Items (un array) para enviar el indice
            var item = listView.Items[selectedIndex];

            // 3.Busco el control anidado ButtonSelect con la propiedad FindControl, 
            // y convierto en LinkButton para acceder a sus propiedades
            var label = (Label)item.FindControl("lblIdentify");


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

            // obtener la lista de telefonos en una variable
            var telefonos = contactoService.ObtenerTelefonosPorContactoId(contacto.Id);

            ListOfPhones.DataSource = telefonos;
            ListOfPhones.DataBind();
        }

        protected void ListContacts_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
        }
    }
}