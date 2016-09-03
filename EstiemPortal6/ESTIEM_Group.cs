namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTIEM_Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTIEM_Group()
        {
            PORTAL_User1 = new HashSet<PORTAL_User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        public int? AdminUserId { get; set; }

        public int? LocalGroupFilter { get; set; }

        public int? AlumniStatusFilter { get; set; }

        public int? UserStatusFilter { get; set; }

        public int? ParentId { get; set; }

        public bool EmailEnabled { get; set; }

        public bool FilteredAllowExtraMembers { get; set; }

        public Guid Guid { get; set; }

        public int GroupType { get; set; }

        public DateTime? LastChanged { get; set; }

        public bool PublicSubscriptionEnabled { get; set; }

        public int SyncStatus { get; set; }

        public bool MembersCanLeave { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool? IsHidden { get; set; }

        public DateTime? LastSyncDate { get; set; }

        public bool IsDefaultGroup { get; set; }

        public int SenderRestriction { get; set; }

        public bool HasExternalMembers { get; set; }

        public virtual ESTIEM_LocalGroup ESTIEM_LocalGroup { get; set; }

        public virtual PORTAL_Role PORTAL_Role { get; set; }

        public virtual PORTAL_User PORTAL_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORTAL_User> PORTAL_User1 { get; set; }
    }
}
