namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_UserForum
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForumID { get; set; }

        public int AccessMaskID { get; set; }

        public DateTime Invited { get; set; }

        public bool Accepted { get; set; }

        public virtual FORUM_AccessMask FORUM_AccessMask { get; set; }

        public virtual FORUM_Forum FORUM_Forum { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
