namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IST_Subscription
    {
        [Key]
        [Column(Order = 0)]
        public Guid ReferencedItemId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string User { get; set; }
    }
}
