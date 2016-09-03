namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Topic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_Topic()
        {
            FORUM_Active = new HashSet<FORUM_Active>();
            FORUM_FavoriteTopic = new HashSet<FORUM_FavoriteTopic>();
            FORUM_Forum = new HashSet<FORUM_Forum>();
            FORUM_Message = new HashSet<FORUM_Message>();
            FORUM_NntpTopic = new HashSet<FORUM_NntpTopic>();
            FORUM_Topic1 = new HashSet<FORUM_Topic>();
            FORUM_WatchTopic = new HashSet<FORUM_WatchTopic>();
        }

        [Key]
        public int TopicID { get; set; }

        public int ForumID { get; set; }

        public int UserID { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime Posted { get; set; }

        [Required]
        [StringLength(100)]
        public string Topic { get; set; }

        public int Views { get; set; }

        public short Priority { get; set; }

        public int? PollID { get; set; }

        public int? TopicMovedID { get; set; }

        public DateTime? LastPosted { get; set; }

        public int? LastMessageID { get; set; }

        public int? LastUserID { get; set; }

        [StringLength(255)]
        public string LastUserName { get; set; }

        public int NumPosts { get; set; }

        public int Flags { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsDeleted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsQuestion { get; set; }

        public int? AnswerMessageId { get; set; }

        public int? LastMessageFlags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Active> FORUM_Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_FavoriteTopic> FORUM_FavoriteTopic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Forum> FORUM_Forum { get; set; }

        public virtual FORUM_Forum FORUM_Forum1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Message> FORUM_Message { get; set; }

        public virtual FORUM_Message FORUM_Message1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_NntpTopic> FORUM_NntpTopic { get; set; }

        public virtual FORUM_PollGroupCluster FORUM_PollGroupCluster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Topic> FORUM_Topic1 { get; set; }

        public virtual FORUM_Topic FORUM_Topic2 { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }

        public virtual FORUM_User FORUM_User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_WatchTopic> FORUM_WatchTopic { get; set; }
    }
}
