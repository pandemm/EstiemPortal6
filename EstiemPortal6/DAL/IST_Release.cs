namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IST_Release
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Text { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ReleaseDate { get; set; }

        public bool IsCurrentRelease { get; set; }
    }
}
