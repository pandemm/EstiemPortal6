namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICE_Log
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ServiceId { get; set; }

        [Required]
        [StringLength(100)]
        public string LogName { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        public DateTime Created { get; set; }

        [StringLength(1000)]
        public string Message { get; set; }
    }
}
