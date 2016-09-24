namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_NntpTopic
    {
        [Key]
        public int NntpTopicID { get; set; }

        public int NntpForumID { get; set; }

        [Required]
        [StringLength(32)]
        public string Thread { get; set; }

        public int TopicID { get; set; }

        public virtual FORUM_NntpForum FORUM_NntpForum { get; set; }

        public virtual FORUM_Topic FORUM_Topic { get; set; }
    }
}
