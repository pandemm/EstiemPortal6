namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TAG_TagLink
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TagId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        public DateTime? Created { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ItemId { get; set; }

        public int? xLinkType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string ItemTypeKey { get; set; }

        public virtual TAG_Tag TAG_Tag { get; set; }
    }
}
