namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Thanks
    {
        [Key]
        public int ThanksID { get; set; }

        public int ThanksFromUserID { get; set; }

        public int ThanksToUserID { get; set; }

        public int MessageID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ThanksDate { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
