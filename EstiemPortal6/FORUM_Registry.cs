namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Registry
    {
        [Key]
        public int RegistryID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Value { get; set; }

        public int? BoardID { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }
    }
}
