namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PORTAL_User()
        {
            ESTIEM_CorporateInfo = new HashSet<ESTIEM_CorporateInfo>();
            ESTIEM_Group = new HashSet<ESTIEM_Group>();
            ESTIEM_TeamRelation = new HashSet<ESTIEM_TeamRelation>();
            PORTAL_ActionValidation = new HashSet<PORTAL_ActionValidation>();
            PORTAL_PortalUser = new HashSet<PORTAL_PortalUser>();
            ESTIEM_Group1 = new HashSet<ESTIEM_Group>();
            PORTAL_Role = new HashSet<PORTAL_Role>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string GivenName { get; set; }

        [StringLength(50)]
        public string FamilyName { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string HashPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTIEM_CorporateInfo> ESTIEM_CorporateInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTIEM_Group> ESTIEM_Group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTIEM_TeamRelation> ESTIEM_TeamRelation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_ActionValidation> PORTAL_ActionValidation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_PortalUser> PORTAL_PortalUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTIEM_Group> ESTIEM_Group1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_Role> PORTAL_Role { get; set; }
    }
}
