namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_EventLog
    {
        [Key]
        public int EventLogID { get; set; }

        public DateTime EventTime { get; set; }

        public int? UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Source { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }

        public int Type { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
