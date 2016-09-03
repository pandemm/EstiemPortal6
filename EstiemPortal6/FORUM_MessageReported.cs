namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_MessageReported
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MessageID { get; set; }

        [Column(TypeName = "ntext")]
        public string Message { get; set; }

        public bool? Resolved { get; set; }

        public int? ResolvedBy { get; set; }

        public DateTime? ResolvedDate { get; set; }
    }
}
