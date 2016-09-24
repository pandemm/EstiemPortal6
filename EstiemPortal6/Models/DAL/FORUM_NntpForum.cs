namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_NntpForum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_NntpForum()
        {
            FORUM_NntpTopic = new HashSet<FORUM_NntpTopic>();
        }

        [Key]
        public int NntpForumID { get; set; }

        public int NntpServerID { get; set; }

        [Required]
        [StringLength(100)]
        public string GroupName { get; set; }

        public int ForumID { get; set; }

        public int LastMessageNo { get; set; }

        public DateTime LastUpdate { get; set; }

        public bool Active { get; set; }

        public virtual FORUM_Forum FORUM_Forum { get; set; }

        public virtual FORUM_NntpServer FORUM_NntpServer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_NntpTopic> FORUM_NntpTopic { get; set; }
    }
}
