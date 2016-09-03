namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Message
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_Message()
        {
            FORUM_Attachment = new HashSet<FORUM_Attachment>();
            FORUM_Forum = new HashSet<FORUM_Forum>();
            FORUM_MessageHistory = new HashSet<FORUM_MessageHistory>();
            FORUM_Message1 = new HashSet<FORUM_Message>();
            FORUM_Topic1 = new HashSet<FORUM_Topic>();
        }

        [Key]
        public int MessageID { get; set; }

        public int TopicID { get; set; }

        public int? ReplyTo { get; set; }

        public int Position { get; set; }

        public int Indent { get; set; }

        public int UserID { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime Posted { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Message { get; set; }

        [Required]
        [StringLength(39)]
        public string IP { get; set; }

        public DateTime? Edited { get; set; }

        public int Flags { get; set; }

        [StringLength(100)]
        public string EditReason { get; set; }

        public bool IsModeratorChanged { get; set; }

        [StringLength(100)]
        public string DeleteReason { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsDeleted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsApproved { get; set; }

        [StringLength(50)]
        public string BlogPostID { get; set; }

        public int? EditedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Attachment> FORUM_Attachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Forum> FORUM_Forum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_MessageHistory> FORUM_MessageHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Message> FORUM_Message1 { get; set; }

        public virtual FORUM_Message FORUM_Message2 { get; set; }

        public virtual FORUM_Topic FORUM_Topic { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Topic> FORUM_Topic1 { get; set; }
    }
}
