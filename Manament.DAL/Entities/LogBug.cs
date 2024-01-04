namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogBug")]
    public partial class LogBug
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime LogTime { get; set; }

        [StringLength(100)]
        public string LogMessage { get; set; }

        public DateTime CreateAt { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateBy { get; set; }
    }
}
