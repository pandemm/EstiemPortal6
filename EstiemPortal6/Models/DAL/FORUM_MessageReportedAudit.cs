namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_MessageReportedAudit
    {
        [Key]
        [Column(Order = 0)]
        public int LogID { get; set; }

        public int? UserID { get; set; }

        public int? MessageID { get; set; }

        public DateTime? Reported { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReportedNumber { get; set; }

        [StringLength(4000)]
        public string ReportText { get; set; }
    }
}
