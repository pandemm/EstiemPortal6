namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_Module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PORTAL_Module()
        {
            PORTAL_ModuleRolePermission = new HashSet<PORTAL_ModuleRolePermission>();
            PORTAL_PageModule = new HashSet<PORTAL_PageModule>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public int PortalId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LastUpdate { get; set; }

        public bool IsGlobal { get; set; }

        public bool InheritViewPermissions { get; set; }

        public int ModuleDefinitionId { get; set; }

        public bool ShowTitle { get; set; }

        public int? ViewMode { get; set; }

        public string Configuration { get; set; }

        public string Description { get; set; }

        public Guid Guid { get; set; }

        public string CustomConfiguration { get; set; }

        public virtual PORTAL_ModuleDefinition PORTAL_ModuleDefinition { get; set; }

        public virtual PORTAL_Portal PORTAL_Portal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_ModuleRolePermission> PORTAL_ModuleRolePermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_PageModule> PORTAL_PageModule { get; set; }
    }
}
