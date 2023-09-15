using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneList.Pages.Dto
{
    public class ContactoRequest
    {
        public int Int { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Compania { get; set; }
        public string Telefono { get; set; }
        public int EtiquetaTelefonoId { get; set; }
        public string Email { get; set; }
        public int EtiquetaEmailId { get; set; }
        public DateTime FechaImportante { get; set; }
        public int EtiquetaFechaId { get; set; }
    }
}