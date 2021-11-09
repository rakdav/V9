namespace V9.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialSupplier")]
    public partial class MaterialSupplier
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string MaterialID { get; set; }

        [Required]
        [StringLength(255)]
        public string SupplierID { get; set; }

        public virtual Material Material { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
