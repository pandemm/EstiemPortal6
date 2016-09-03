namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTIEM_TeamRelation
    {
        [Key]
        public int TeamRelationId { get; set; }

        public int UserId { get; set; }

        public int TeamStatus { get; set; }

        [StringLength(50)]
        public string WorkingArea { get; set; }

        public int TeamCategoryId { get; set; }

        public virtual PORTAL_User PORTAL_User { get; set; }
    }
}
