using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneList.Pages.Dto
{
    public class ContactoResponse
    {
        public int Int { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Compania { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string FechaImportante { get; set; }
    }
}