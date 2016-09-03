namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HTML_HtmlModuleAudit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModuleId { get; set; }

        [Column(TypeName = "ntext")]
        public string Text { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime AuditDate { get; set; }

        public int? AuditUserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string Action { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsMinorEdit { get; set; }

        public int? LastUpdateBy { get; set; }
    }
}
