namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NEWS_NewsletterTemplate
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Templatetitle { get; set; }

        [Column(TypeName = "ntext")]
        public string HeaderHTML { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentHTML { get; set; }

        [Column(TypeName = "ntext")]
        public string FooterHTML { get; set; }

        [Column(TypeName = "ntext")]
        public string HeaderHTMLmail { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentHTMLmail { get; set; }

        [Column(TypeName = "ntext")]
        public string FooterHTMLmail { get; set; }

        public bool isDefault { get; set; }
    }
}
