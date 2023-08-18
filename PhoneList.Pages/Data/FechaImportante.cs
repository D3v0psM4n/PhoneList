namespace PhoneList.Pages.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FechaImportante")]
    public partial class FechaImportante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FechaImportante()
        {
            ContactoFechaImportante = new HashSet<ContactoFechaImportante>();
        }

        public int Id { get; set; }

        public int? EtiquetaId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoFechaImportante> ContactoFechaImportante { get; set; }

        public virtual EtiquetaFecha EtiquetaFecha { get; set; }
    }
}
