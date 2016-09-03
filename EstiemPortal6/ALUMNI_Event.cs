namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALUMNI_Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALUMNI_Event()
        {
            ALUMNI_EventParticipant = new HashSet<ALUMNI_EventParticipant>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        public string XmlValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALUMNI_EventParticipant> ALUMNI_EventParticipant { get; set; }
    }
}
