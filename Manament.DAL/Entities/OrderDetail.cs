namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DishesID { get; set; }

        public int Quantity { get; set; }

        public double RealPrice { get; set; }

        public DateTime CreateAt { get; set; }

        public byte Is_Delete { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateBy { get; set; }

        public virtual CoffeDish CoffeDish { get; set; }

        public virtual CoffeOrder CoffeOrder { get; set; }
    }
}
