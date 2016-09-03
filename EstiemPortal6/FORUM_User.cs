namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_User()
        {
            FORUM_Active = new HashSet<FORUM_Active>();
            FORUM_Buddy = new HashSet<FORUM_Buddy>();
            FORUM_CheckEmail = new HashSet<FORUM_CheckEmail>();
            FORUM_EventLog = new HashSet<FORUM_EventLog>();
            FORUM_FavoriteTopic = new HashSet<FORUM_FavoriteTopic>();
            FORUM_Forum = new HashSet<FORUM_Forum>();
            FORUM_Message = new HashSet<FORUM_Message>();
            FORUM_PMessage = new HashSet<FORUM_PMessage>();
            FORUM_Thanks = new HashSet<FORUM_Thanks>();
            FORUM_Topic = new HashSet<FORUM_Topic>();
            FORUM_Topic1 = new HashSet<FORUM_Topic>();
            FORUM_UserForum = new HashSet<FORUM_UserForum>();
            FORUM_UserPMessage = new HashSet<FORUM_UserPMessage>();
            FORUM_WatchForum = new HashSet<FORUM_WatchForum>();
            FORUM_WatchTopic = new HashSet<FORUM_WatchTopic>();
            FORUM_Group = new HashSet<FORUM_Group>();
        }

        [Key]
        public int UserID { get; set; }

        public int BoardID { get; set; }

        [StringLength(64)]
        public string ProviderUserKey { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime Joined { get; set; }

        public DateTime LastVisit { get; set; }

        [StringLength(39)]
        public string IP { get; set; }

        public int NumPosts { get; set; }

        public int TimeZone { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        [Column(TypeName = "ntext")]
        public string Signature { get; set; }

        [Column(TypeName = "image")]
        public byte[] AvatarImage { get; set; }

        [StringLength(50)]
        public string AvatarImageType { get; set; }

        public int RankID { get; set; }

        public DateTime? Suspended { get; set; }

        [StringLength(50)]
        public string LanguageFile { get; set; }

        [StringLength(50)]
        public string ThemeFile { get; set; }

        public bool OverrideDefaultThemes { get; set; }

        public bool PMNotification { get; set; }

        public int Flags { get; set; }

        public int Points { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsApproved { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsActiveExcluded { get; set; }

        public int? NotificationType { get; set; }

        [Required]
        [StringLength(255)]
        public string DisplayName { get; set; }

        public bool DailyDigest { get; set; }

        public bool AutoWatchTopics { get; set; }

        [StringLength(5)]
        public string Culture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Active> FORUM_Active { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Buddy> FORUM_Buddy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_CheckEmail> FORUM_CheckEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_EventLog> FORUM_EventLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_FavoriteTopic> FORUM_FavoriteTopic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Forum> FORUM_Forum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Message> FORUM_Message { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_PMessage> FORUM_PMessage { get; set; }

        public virtual FORUM_Rank FORUM_Rank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Thanks> FORUM_Thanks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Topic> FORUM_Topic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Topic> FORUM_Topic1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_UserForum> FORUM_UserForum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_UserPMessage> FORUM_UserPMessage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_WatchForum> FORUM_WatchForum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_WatchTopic> FORUM_WatchTopic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Group> FORUM_Group { get; set; }
    }
}
