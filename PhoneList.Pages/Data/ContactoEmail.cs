namespace PhoneList.Pages.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactoEmail")]
    public partial class ContactoEmail
    {
        public int Id { get; set; }

        public int ContactoId { get; set; }

        public int EmailId { get; set; }

        public virtual Contacto Contacto { get; set; }

        public virtual Email Email { get; set; }
    }
}
