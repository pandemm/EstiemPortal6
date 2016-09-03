namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_Portal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PORTAL_Portal()
        {
            PORTAL_Module = new HashSet<PORTAL_Module>();
            PORTAL_Page = new HashSet<PORTAL_Page>();
            PORTAL_PortalUser = new HashSet<PORTAL_PortalUser>();
            PORTAL_Role = new HashSet<PORTAL_Role>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Logo { get; set; }

        [StringLength(1000)]
        public string Configuration { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastUpdate { get; set; }

        public int? AdminRoleId { get; set; }

        [Column(TypeName = "ntext")]
        public string KeyWords { get; set; }

        [Required]
        [StringLength(50)]
        public string Cultures { get; set; }

        [StringLength(50)]
        public string PageColors { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool ShowLogin { get; set; }

        public int MenuAreaId { get; set; }

        [StringLength(150)]
        public string LogoLinkUrl { get; set; }

        [Column(TypeName = "ntext")]
        public string BannerTitle { get; set; }

        public string CustomHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_Module> PORTAL_Module { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_Page> PORTAL_Page { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_PortalUser> PORTAL_PortalUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_Role> PORTAL_Role { get; set; }
    }
}
