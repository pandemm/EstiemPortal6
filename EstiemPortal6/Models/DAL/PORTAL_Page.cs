namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_Page
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PORTAL_Page()
        {
            PORTAL_PageModule = new HashSet<PORTAL_PageModule>();
            PORTAL_PageRolePermission = new HashSet<PORTAL_PageRolePermission>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int PortalId { get; set; }

        public int PageType { get; set; }

        public int? ParentPageId { get; set; }

        public int PageOrder { get; set; }

        public bool IsVisible { get; set; }

        [StringLength(500)]
        public string Alias { get; set; }

        public bool ShowInMenu { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(200)]
        public string RedirectUrl { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LastUpdate { get; set; }

        public bool IsVirtual { get; set; }

        [StringLength(10)]
        public string Color { get; set; }

        public int? ReviewInterval { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastReviewDate { get; set; }

        public int? LastReviewBy { get; set; }

        [StringLength(20)]
        public string MetaRobots { get; set; }

        [StringLength(50)]
        public string MetaExpires { get; set; }

        public bool OpenInNewWindow { get; set; }

        [StringLength(1500)]
        public string PageScript { get; set; }

        public bool ShowMenu { get; set; }

        public int? IsCorporateVersionOf { get; set; }

        [StringLength(250)]
        public string ReviewSettings { get; set; }

        public string Configuration { get; set; }

        public string Description { get; set; }

        public string Keywords { get; set; }

        public Guid Guid { get; set; }

        public virtual PORTAL_Portal PORTAL_Portal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_PageModule> PORTAL_PageModule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_PageRolePermission> PORTAL_PageRolePermission { get; set; }
    }
}
