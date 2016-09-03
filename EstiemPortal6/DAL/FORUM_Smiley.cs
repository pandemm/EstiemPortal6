namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Smiley
    {
        [Key]
        public int SmileyID { get; set; }

        public int BoardID { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(50)]
        public string Emoticon { get; set; }

        public byte SortOrder { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }
    }
}
