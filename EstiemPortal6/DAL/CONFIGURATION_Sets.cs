namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONFIGURATION_Sets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONFIGURATION_Sets()
        {
            CONFIGURATION_Data = new HashSet<CONFIGURATION_Data>();
            CONFIGURATION_Sets1 = new HashSet<CONFIGURATION_Sets>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? ParentSetId { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public DateTime? LastUsed { get; set; }

        public bool Derivable { get; set; }

        public bool IsProductionSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONFIGURATION_Data> CONFIGURATION_Data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONFIGURATION_Sets> CONFIGURATION_Sets1 { get; set; }

        public virtual CONFIGURATION_Sets CONFIGURATION_Sets2 { get; set; }
    }
}
