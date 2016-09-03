namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_PortalUser
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PortalId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastLogin { get; set; }

        public int PortalStatus { get; set; }

        public virtual PORTAL_Portal PORTAL_Portal { get; set; }

        public virtual PORTAL_User PORTAL_User { get; set; }
    }
}
