namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_Group()
        {
            FORUM_ForumAccess = new HashSet<FORUM_ForumAccess>();
            FORUM_User = new HashSet<FORUM_User>();
        }

        [Key]
        public int GroupID { get; set; }

        public int BoardID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Flags { get; set; }

        public int? PMLimit { get; set; }

        [StringLength(255)]
        public string Style { get; set; }

        public short SortOrder { get; set; }

        [StringLength(128)]
        public string Description { get; set; }

        public int UsrSigChars { get; set; }

        [StringLength(255)]
        public string UsrSigBBCodes { get; set; }

        [StringLength(255)]
        public string UsrSigHTMLTags { get; set; }

        public int UsrAlbums { get; set; }

        public int UsrAlbumImages { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_ForumAccess> FORUM_ForumAccess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_User> FORUM_User { get; set; }
    }
}
