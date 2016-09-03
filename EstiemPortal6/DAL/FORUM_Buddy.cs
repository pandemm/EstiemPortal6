namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Buddy
    {
        public int ID { get; set; }

        public int FromUserID { get; set; }

        public int ToUserID { get; set; }

        public bool Approved { get; set; }

        public DateTime Requested { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
