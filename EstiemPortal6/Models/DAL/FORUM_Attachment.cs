namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Attachment
    {
        [Key]
        public int AttachmentID { get; set; }

        public int MessageID { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        public int Bytes { get; set; }

        public int? FileID { get; set; }

        [StringLength(50)]
        public string ContentType { get; set; }

        public int Downloads { get; set; }

        [Column(TypeName = "image")]
        public byte[] FileData { get; set; }

        public virtual FORUM_Message FORUM_Message { get; set; }
    }
}
