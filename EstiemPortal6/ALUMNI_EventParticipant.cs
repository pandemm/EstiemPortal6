namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALUMNI_EventParticipant
    {
        [Key]
        [Column(Order = 0)]
        public Guid EventId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        public string UserFreeText { get; set; }

        public string XmlValues { get; set; }

        public virtual ALUMNI_Event ALUMNI_Event { get; set; }
    }
}
