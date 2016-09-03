namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_prov_Application
    {
        [Key]
        public Guid ApplicationID { get; set; }

        [StringLength(256)]
        public string ApplicationName { get; set; }

        [StringLength(256)]
        public string ApplicationNameLwd { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }
    }
}
