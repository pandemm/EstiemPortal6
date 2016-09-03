namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_WatchForum
    {
        [Key]
        public int WatchForumID { get; set; }

        public int ForumID { get; set; }

        public int UserID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? LastMail { get; set; }

        public virtual FORUM_Forum FORUM_Forum { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
