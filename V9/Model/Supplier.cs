namespace V9.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            MaterialSupplier = new HashSet<MaterialSupplier>();
        }

        [Key]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(12)]
        public string INN { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        public int? QualityRating { get; set; }

        [StringLength(20)]
        public string SupplierType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialSupplier> MaterialSupplier { get; set; }
    }
}
