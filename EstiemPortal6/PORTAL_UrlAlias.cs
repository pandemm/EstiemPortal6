namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_UrlAlias
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Alias { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PortalId { get; set; }

        public int PageId { get; set; }

        [StringLength(50)]
        public string Parameter { get; set; }

        [StringLength(200)]
        public string RedirectUrl { get; set; }

        public int AliasType { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }
    }
}
