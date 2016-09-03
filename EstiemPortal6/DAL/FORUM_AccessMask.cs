namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_AccessMask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_AccessMask()
        {
            FORUM_ForumAccess = new HashSet<FORUM_ForumAccess>();
            FORUM_UserForum = new HashSet<FORUM_UserForum>();
        }

        [Key]
        public int AccessMaskID { get; set; }

        public int BoardID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Flags { get; set; }

        public short SortOrder { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_ForumAccess> FORUM_ForumAccess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_UserForum> FORUM_UserForum { get; set; }
    }
}
