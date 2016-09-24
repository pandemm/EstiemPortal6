namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Board
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_Board()
        {
            FORUM_AccessMask = new HashSet<FORUM_AccessMask>();
            FORUM_Active = new HashSet<FORUM_Active>();
            FORUM_BannedIP = new HashSet<FORUM_BannedIP>();
            FORUM_BBCode = new HashSet<FORUM_BBCode>();
            FORUM_Category = new HashSet<FORUM_Category>();
            FORUM_Extension = new HashSet<FORUM_Extension>();
            FORUM_Group = new HashSet<FORUM_Group>();
            FORUM_NntpServer = new HashSet<FORUM_NntpServer>();
            FORUM_Rank = new HashSet<FORUM_Rank>();
            FORUM_Registry = new HashSet<FORUM_Registry>();
            FORUM_Smiley = new HashSet<FORUM_Smiley>();
            FORUM_User = new HashSet<FORUM_User>();
        }

        [Key]
        public int BoardID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool AllowThreaded { get; set; }

        [StringLength(255)]
        public string MembershipAppName { get; set; }

        [StringLength(255)]
        public string RolesAppName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_AccessMask> FORUM_AccessMask { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Active> FORUM_Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_BannedIP> FORUM_BannedIP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_BBCode> FORUM_BBCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Category> FORUM_Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Extension> FORUM_Extension { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Group> FORUM_Group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_NntpServer> FORUM_NntpServer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Rank> FORUM_Rank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Registry> FORUM_Registry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Smiley> FORUM_Smiley { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_User> FORUM_User { get; set; }
    }
}
