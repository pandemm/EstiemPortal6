namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONFIGURATION_Keys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONFIGURATION_Keys()
        {
            CONFIGURATION_Data = new HashSet<CONFIGURATION_Data>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int ScopeId { get; set; }

        public bool IsActive { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        public bool? AllowNull { get; set; }

        public bool? IsRequired { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONFIGURATION_Data> CONFIGURATION_Data { get; set; }

        public virtual CONFIGURATION_Scopes CONFIGURATION_Scopes { get; set; }
    }
}
