namespace Manament.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int ID { get; set; }

        public int MenuID { get; set; }

        [StringLength(50)]
        public string MenuURL { get; set; }

        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }

        public int ParentID { get; set; }

        public int? MenuOrder { get; set; }

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
