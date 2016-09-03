namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTIEM_LocalGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTIEM_LocalGroup()
        {
            ESTIEM_Group = new HashSet<ESTIEM_Group>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(2)]
        public string Country { get; set; }

        public int? MemberListId { get; set; }

        public int? LRListId { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(200)]
        public string OfficialName { get; set; }

        public int Status { get; set; }

        [StringLength(100)]
        public string UniversityName { get; set; }

        public int ActiveMemberCount { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MembershipStart { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MembershipEnd { get; set; }

        [Column(TypeName = "ntext")]
        public string FreeText { get; set; }

        public int? BoardResponsibleId { get; set; }

        public int? LocalResponsibleId { get; set; }

        public int? OldId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LastUpdate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Created { get; set; }

        [StringLength(50)]
        public string Coordinates { get; set; }

        public Guid Guid { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias { get; set; }

        [StringLength(50)]
        public string GPSLocation { get; set; }

        public int? MapCoordinateX { get; set; }

        public int? MapCoordinateY { get; set; }

        [StringLength(300)]
        public string LogoPath { get; set; }

        [StringLength(300)]
        public string HomePage { get; set; }

        [StringLength(300)]
        public string Email { get; set; }

        [Column(TypeName = "ntext")]
        public string FreeTextField1 { get; set; }

        [Column(TypeName = "ntext")]
        public string FreeTextField2 { get; set; }

        [Column(TypeName = "ntext")]
        public string FreeTextField3 { get; set; }

        [Column(TypeName = "ntext")]
        public string FreeTextField4 { get; set; }

        [Column(TypeName = "ntext")]
        public string FreeTextField5 { get; set; }

        [Column(TypeName = "ntext")]
        public string FreeTextField6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTIEM_Group> ESTIEM_Group { get; set; }
    }
}
