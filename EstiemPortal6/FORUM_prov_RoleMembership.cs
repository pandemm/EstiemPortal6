namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_prov_RoleMembership
    {
        [Key]
        [Column(Order = 0)]
        public Guid RoleID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string UserID { get; set; }
    }
}
