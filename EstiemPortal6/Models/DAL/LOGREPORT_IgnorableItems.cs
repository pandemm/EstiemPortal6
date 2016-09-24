namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOGREPORT_IgnorableItems
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public int IgnoreType { get; set; }
    }
}
