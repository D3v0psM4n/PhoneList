namespace PhoneList.Pages.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Email")]
    public partial class Email
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Email()
        {
            ContactoEmail = new HashSet<ContactoEmail>();
        }

        public int Id { get; set; }

        public int? EtiquetaId { get; set; }

        [StringLength(150)]
        public string Correo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoEmail> ContactoEmail { get; set; }

        public virtual EtiquetaEmail EtiquetaEmail { get; set; }
    }
}
