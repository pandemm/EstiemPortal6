namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_UserAlbum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_UserAlbum()
        {
            FORUM_UserAlbumImage = new HashSet<FORUM_UserAlbumImage>();
        }

        [Key]
        public int AlbumID { get; set; }

        public int UserID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public int? CoverImageID { get; set; }

        public DateTime Updated { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_UserAlbumImage> FORUM_UserAlbumImage { get; set; }
    }
}
