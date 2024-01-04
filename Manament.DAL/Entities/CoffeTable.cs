namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoffeTable")]
    public partial class CoffeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoffeTable()
        {
            CoffeOrders = new HashSet<CoffeOrder>();
        }

        public int ID { get; set; }

        public int TableID { get; set; }

        [Required]
        [StringLength(50)]
        public string TableName { get; set; }

        [StringLength(50)]
        public string TableUrlImage { get; set; }

        public byte Is_Delete { get; set; }

        public DateTime CreateAt { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoffeOrder> CoffeOrders { get; set; }
    }
}
