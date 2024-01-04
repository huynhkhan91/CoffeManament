namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoffeInvoice")]
    public partial class CoffeInvoice
    {
        public int ID { get; set; }

        public int InvoiceID { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceName { get; set; }

        public DateTime CreateAt { get; set; }

        public int EmoloyerID { get; set; }

        public int OrderID { get; set; }

        public byte Is_Delete { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateBy { get; set; }

        public virtual CoffeEmployer CoffeEmployer { get; set; }

        public virtual CoffeOrder CoffeOrder { get; set; }
    }
}
