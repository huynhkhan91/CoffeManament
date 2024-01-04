namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Setting")]
    public partial class Setting
    {
        public int ID { get; set; }

        public int SetKey { get; set; }

        [StringLength(100)]
        public string SetValue { get; set; }

        public byte isDeleted { get; set; }

        public DateTime CreateAt { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime ModifiedAt { get; set; }

        [Required]
        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public int? Pin { get; set; }
    }
}
