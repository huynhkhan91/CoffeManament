namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CoffeDish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoffeDish()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ID { get; set; }

        public int DishesID { get; set; }

        [Required]
        [StringLength(50)]
        public string DishesName { get; set; }

        [StringLength(100)]
        public string DishesDescription { get; set; }

        public double DishesPrice { get; set; }

        [StringLength(50)]
        public string DishesUrlImage { get; set; }

        public int CategoryID { get; set; }

        public byte Is_Delete { get; set; }

        public DateTime CreateAt { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateBy { get; set; }

        public virtual CoffeCategory CoffeCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
