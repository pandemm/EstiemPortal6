namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_ESTIEMAlumniUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(500)]
        public string Company { get; set; }

        [StringLength(500)]
        public string Career { get; set; }

        [StringLength(500)]
        public string ProfessionalInterests { get; set; }

        [StringLength(500)]
        public string Partner { get; set; }

        [StringLength(500)]
        public string Children { get; set; }

        [StringLength(500)]
        public string AlumniMeetings { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AlumniSince { get; set; }

        [StringLength(500)]
        public string ApplicationText { get; set; }

        public DateTime? ApplicationDate { get; set; }

        public string ContributionInfoXml { get; set; }
    }
}
