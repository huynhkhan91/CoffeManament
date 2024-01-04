namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoffeEmployer")]
    public partial class CoffeEmployer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoffeEmployer()
        {
            CoffeInvoices = new HashSet<CoffeInvoice>();
        }

        public int ID { get; set; }

        public int EnployerID { get; set; }

        [Required]
        [StringLength(50)]
        public string EnployerName { get; set; }

        [Required]
        [StringLength(50)]
        public string EUsername { get; set; }

        [Required]
        [StringLength(50)]
        public string EPassword { get; set; }

        public byte? EGender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EBirthday { get; set; }

        [StringLength(50)]
        public string EUrlImage { get; set; }

        public int RoleID { get; set; }

        public byte Is_Delete { get; set; }

        public DateTime CreateAt { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateBy { get; set; }

        public virtual CoffeRole CoffeRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoffeInvoice> CoffeInvoices { get; set; }
    }
}
