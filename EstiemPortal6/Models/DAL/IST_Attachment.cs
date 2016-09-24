namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IST_Attachment
    {
        public int ID { get; set; }

        public Guid ReferencedItemId { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string CONTENTTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CREATED { get; set; }

        [StringLength(2000)]
        public string TEXT { get; set; }

        [StringLength(1000)]
        public string REFERENCE { get; set; }

        public int AttachmentType { get; set; }

        public bool IsDeploymentInfo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Attachment { get; set; }

        [StringLength(50)]
        public string Author { get; set; }
    }
}
