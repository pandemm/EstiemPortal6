namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IST_Issue
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Key { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Created { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public int IssueType { get; set; }

        public int Status { get; set; }

        public int? ModuleDefinitionId { get; set; }

        public int? PageId { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        public int? ReleaseId { get; set; }

        [Column(TypeName = "text")]
        public string FormData { get; set; }

        [Column(TypeName = "text")]
        public string STACKTRACE { get; set; }

        [StringLength(4000)]
        public string OTHER { get; set; }

        [StringLength(200)]
        public string URLREFERRER { get; set; }

        public bool SUBSCRIPTION { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public int ReportingMode { get; set; }

        [MaxLength(50)]
        public byte[] Author { get; set; }

        public Guid? TicketId { get; set; }
    }
}
