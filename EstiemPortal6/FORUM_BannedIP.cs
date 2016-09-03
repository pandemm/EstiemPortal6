namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_BannedIP
    {
        public int ID { get; set; }

        public int BoardID { get; set; }

        [Required]
        [StringLength(15)]
        public string Mask { get; set; }

        public DateTime Since { get; set; }

        [StringLength(128)]
        public string Reason { get; set; }

        public int? UserID { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }
    }
}
