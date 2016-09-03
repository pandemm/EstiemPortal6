namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICE_Settings
    {
        [StringLength(100)]
        public string Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Assembly { get; set; }

        [Required]
        [StringLength(150)]
        public string TypeName { get; set; }

        public int Status { get; set; }

        public int Interval { get; set; }
    }
}
