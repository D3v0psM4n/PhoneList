namespace PhoneList.Pages.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactoFechaImportante")]
    public partial class ContactoFechaImportante
    {
        public int Id { get; set; }

        public int ContactoId { get; set; }

        public int FechaImportanteId { get; set; }

        public virtual Contacto Contacto { get; set; }

        public virtual FechaImportante FechaImportante { get; set; }
    }
}
