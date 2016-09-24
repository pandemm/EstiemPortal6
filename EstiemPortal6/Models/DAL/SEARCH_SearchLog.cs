namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEARCH_SearchLog
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Date { get; set; }

        public int? UserId { get; set; }

        public int? PageId { get; set; }

        public int? PageModuleId { get; set; }

        [StringLength(200)]
        public string URL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string Action { get; set; }

        public int? ResultCount { get; set; }

        public int? Rank { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 3)]
        public string SearchText { get; set; }
    }
}
