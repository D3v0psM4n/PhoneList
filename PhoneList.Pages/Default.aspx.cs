using PhoneList.Pages.Data;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneList.Pages
{
    public partial class _Default : Page
    {
        ModelPhoneDbContext modelPhoneDbContext = new ModelPhoneDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            var contacts = modelPhoneDbContext.Contacto.ToList();
            ListContacts.DataSource = contacts;
            ListContacts.DataBind();
        }
    }
}