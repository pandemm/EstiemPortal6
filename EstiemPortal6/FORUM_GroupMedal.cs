namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_GroupMedal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MedalID { get; set; }

        [StringLength(100)]
        public string Message { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Hide { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool OnlyRibbon { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte SortOrder { get; set; }
    }
}
