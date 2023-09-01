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
        /// <summary>
        /// Declaraciones ejecutadas al cargar la página de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Llamar al método de la conxión
            ContactoService contactoService = new ContactoService();
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
            var linkButton = (LinkButton)item.FindControl("ButtonSelect");

            // 4.Obtengo el nombre de LinkButton (para usarlo posteriormente)
            var nombre = linkButton.Text;
        }

        protected void ListContacts_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
        }
    }
}