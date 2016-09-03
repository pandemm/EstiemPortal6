namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_ModuleDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PORTAL_ModuleDefinition()
        {
            PORTAL_Module = new HashSet<PORTAL_Module>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string ConfigurationTemplate { get; set; }

        public int? ModuleDefinitionTypeId { get; set; }

        [Required]
        [StringLength(150)]
        public string Src { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_Module> PORTAL_Module { get; set; }

        public virtual PORTAL_ModuleDefinitionType PORTAL_ModuleDefinitionType { get; set; }
    }
}
