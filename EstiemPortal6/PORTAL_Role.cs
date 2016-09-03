namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PORTAL_Role()
        {
            PORTAL_ModuleRolePermission = new HashSet<PORTAL_ModuleRolePermission>();
            PORTAL_PageRolePermission = new HashSet<PORTAL_PageRolePermission>();
            PORTAL_RoleExternalMember = new HashSet<PORTAL_RoleExternalMember>();
            PORTAL_Portal = new HashSet<PORTAL_Portal>();
            PORTAL_User = new HashSet<PORTAL_User>();
        }

        public int Id { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Alias { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ESTIEM_Group ESTIEM_Group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_ModuleRolePermission> PORTAL_ModuleRolePermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_PageRolePermission> PORTAL_PageRolePermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_RoleExternalMember> PORTAL_RoleExternalMember { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_Portal> PORTAL_Portal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_User> PORTAL_User { get; set; }
    }
}
