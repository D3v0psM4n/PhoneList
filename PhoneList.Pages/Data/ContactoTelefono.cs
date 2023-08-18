namespace PhoneList.Pages.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactoTelefono")]
    public partial class ContactoTelefono
    {
        public int Id { get; set; }

        public int ContactoId { get; set; }

        public int TelefonoId { get; set; }

        public virtual Contacto Contacto { get; set; }

        public virtual Telefono Telefono { get; set; }
    }
}
