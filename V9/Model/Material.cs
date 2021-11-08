namespace V9.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            Supplier = new HashSet<Supplier>();
        }

        [Key]
        [StringLength(255)]
        public string Title { get; set; }

        public int CountInPack { get; set; }

        [Required]
        [StringLength(10)]
        public string Unit { get; set; }

        public double? CountInStock { get; set; }

        public double MinCount { get; set; }

        public string Description { get; set; }

        public double Cost { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        [StringLength(255)]
        public string MaterialTypeID { get; set; }

        public virtual MaterialType MaterialType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
