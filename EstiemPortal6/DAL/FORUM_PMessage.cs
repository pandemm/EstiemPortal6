namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_PMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_PMessage()
        {
            FORUM_UserPMessage = new HashSet<FORUM_UserPMessage>();
        }

        [Key]
        public int PMessageID { get; set; }

        public int FromUserID { get; set; }

        public DateTime Created { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Body { get; set; }

        public int Flags { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_UserPMessage> FORUM_UserPMessage { get; set; }
    }
}
