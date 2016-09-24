namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IST_Ticket
    {
        public Guid Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Created { get; set; }

        public int? ReleaseId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TARGETFIXDate { get; set; }

        public int? FINALRELEASEID { get; set; }

        public int? ESTIMATEDFIXTIME { get; set; }

        public int? FINALFIXTIME { get; set; }

        public int PRIORITY { get; set; }

        public int STATUS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FIXDate { get; set; }

        [Required]
        [StringLength(50)]
        public string KEY { get; set; }

        public int TICKETTYPE { get; set; }

        public int? AREAID { get; set; }

        public int? CATEGORYID { get; set; }

        public int? PROJECTID { get; set; }

        [StringLength(500)]
        public string DEPLOYMENTNOTES { get; set; }

        public bool ISGOODY { get; set; }

        public bool INCLUDEINNEXTRELEASE { get; set; }

        public int? GroupId { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        [StringLength(100)]
        public string AssignedUser { get; set; }

        public int ReportingMode { get; set; }
    }
}
