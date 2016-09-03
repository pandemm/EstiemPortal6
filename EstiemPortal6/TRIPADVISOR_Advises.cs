namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIPADVISOR_Advises
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [StringLength(256)]
        public string NameOfPlace { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string Location { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Created { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Category { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime LastUpdated { get; set; }

        public string XmlValues { get; set; }
    }
}
