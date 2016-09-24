namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Extension
    {
        [Key]
        public int ExtensionID { get; set; }

        public int BoardId { get; set; }

        [Required]
        [StringLength(10)]
        public string Extension { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }
    }
}
