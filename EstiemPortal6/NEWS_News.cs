namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NEWS_News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        public int Priority { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public bool IsPublished { get; set; }

        [StringLength(600)]
        public string Preview { get; set; }

        [Column(TypeName = "text")]
        public string Text { get; set; }
    }
}
