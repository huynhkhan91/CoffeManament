namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoffeOrder")]
    public partial class CoffeOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoffeOrder()
        {
            CoffeInvoices = new HashSet<CoffeInvoice>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ID { get; set; }

        public int OrderID { get; set; }

        public int TableID { get; set; }

        public DateTime CreateAt { get; set; }

        public byte Is_Delete { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoffeInvoice> CoffeInvoices { get; set; }

        public virtual CoffeTable CoffeTable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
