namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoffeCategory")]
    public partial class CoffeCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoffeCategory()
        {
            CoffeDishes = new HashSet<CoffeDish>();
        }

        public int ID { get; set; }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public byte Is_Delete { get; set; }

        public DateTime CreateAt { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoffeDish> CoffeDishes { get; set; }
    }
}
