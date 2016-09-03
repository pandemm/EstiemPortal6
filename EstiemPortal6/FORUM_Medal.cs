namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Medal
    {
        public int BoardID { get; set; }

        [Key]
        public int MedalID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Message { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [StringLength(250)]
        public string MedalURL { get; set; }

        [StringLength(250)]
        public string RibbonURL { get; set; }

        [Required]
        [StringLength(250)]
        public string SmallMedalURL { get; set; }

        [StringLength(250)]
        public string SmallRibbonURL { get; set; }

        public short SmallMedalWidth { get; set; }

        public short SmallMedalHeight { get; set; }

        public short? SmallRibbonWidth { get; set; }

        public short? SmallRibbonHeight { get; set; }

        public byte SortOrder { get; set; }

        public int Flags { get; set; }
    }
}
