namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Forum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_Forum()
        {
            FORUM_Active = new HashSet<FORUM_Active>();
            FORUM_Forum1 = new HashSet<FORUM_Forum>();
            FORUM_ForumAccess = new HashSet<FORUM_ForumAccess>();
            FORUM_NntpForum = new HashSet<FORUM_NntpForum>();
            FORUM_Topic1 = new HashSet<FORUM_Topic>();
            FORUM_UserForum = new HashSet<FORUM_UserForum>();
            FORUM_WatchForum = new HashSet<FORUM_WatchForum>();
        }

        [Key]
        public int ForumID { get; set; }

        public int CategoryID { get; set; }

        public int? ParentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public short SortOrder { get; set; }

        public DateTime? LastPosted { get; set; }

        public int? LastTopicID { get; set; }

        public int? LastMessageID { get; set; }

        public int? LastUserID { get; set; }

        [StringLength(255)]
        public string LastUserName { get; set; }

        public int NumTopics { get; set; }

        public int NumPosts { get; set; }

        [StringLength(100)]
        public string RemoteURL { get; set; }

        public int Flags { get; set; }

        [StringLength(50)]
        public string ThemeURL { get; set; }

        [StringLength(128)]
        public string ImageURL { get; set; }

        [StringLength(255)]
        public string Styles { get; set; }

        public int? PollGroupID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsHidden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Active> FORUM_Active { get; set; }

        public virtual FORUM_Category FORUM_Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Forum> FORUM_Forum1 { get; set; }

        public virtual FORUM_Forum FORUM_Forum2 { get; set; }

        public virtual FORUM_Message FORUM_Message { get; set; }

        public virtual FORUM_PollGroupCluster FORUM_PollGroupCluster { get; set; }

        public virtual FORUM_Topic FORUM_Topic { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_ForumAccess> FORUM_ForumAccess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_NntpForum> FORUM_NntpForum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Topic> FORUM_Topic1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_UserForum> FORUM_UserForum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_WatchForum> FORUM_WatchForum { get; set; }
    }
}
