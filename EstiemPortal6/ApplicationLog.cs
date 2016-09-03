namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplicationLog")]
    public partial class ApplicationLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Message { get; set; }

        [Required]
        [StringLength(1)]
        public string MessageType { get; set; }

        public DateTime AsOf { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        [StringLength(50)]
        public string EventId { get; set; }

        [StringLength(150)]
        public string Sender { get; set; }

        [StringLength(3000)]
        public string Exception { get; set; }

        [StringLength(3000)]
        public string ExtendedProperties { get; set; }

        [StringLength(500)]
        public string UrlReferrer { get; set; }
    }
}
