namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_WatchTopic
    {
        [Key]
        public int WatchTopicID { get; set; }

        public int TopicID { get; set; }

        public int UserID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? LastMail { get; set; }

        public virtual FORUM_Topic FORUM_Topic { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
