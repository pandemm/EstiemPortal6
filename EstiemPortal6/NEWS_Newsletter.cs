namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NEWS_Newsletter
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(30)]
        public string GroupKey { get; set; }

        public DateTime PublicationDate { get; set; }

        public int NewsletterTemplateId { get; set; }
    }
}
