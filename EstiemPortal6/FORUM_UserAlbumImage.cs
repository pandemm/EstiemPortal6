namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_UserAlbumImage
    {
        [Key]
        public int ImageID { get; set; }

        public int AlbumID { get; set; }

        [StringLength(255)]
        public string Caption { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        public int Bytes { get; set; }

        [StringLength(50)]
        public string ContentType { get; set; }

        public DateTime Uploaded { get; set; }

        public int Downloads { get; set; }

        public virtual FORUM_UserAlbum FORUM_UserAlbum { get; set; }
    }
}
