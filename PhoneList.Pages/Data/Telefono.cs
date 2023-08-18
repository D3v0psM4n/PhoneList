namespace PhoneList.Pages.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telefono")]
    public partial class Telefono
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Telefono()
        {
            ContactoTelefono = new HashSet<ContactoTelefono>();
        }

        public int Id { get; set; }

        public int? EtiquetaId { get; set; }

        [Required]
        [StringLength(15)]
        public string Numero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoTelefono> ContactoTelefono { get; set; }

        public virtual EtiquetaTelefono EtiquetaTelefono { get; set; }
    }
}
