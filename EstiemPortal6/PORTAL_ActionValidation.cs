namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_ActionValidation
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        [StringLength(20)]
        public string Action { get; set; }

        public DateTime Created { get; set; }

        public DateTime Expires { get; set; }

        public virtual PORTAL_User PORTAL_User { get; set; }
    }
}
