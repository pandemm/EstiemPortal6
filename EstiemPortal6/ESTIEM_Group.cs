//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESTIEM_Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTIEM_Group()
        {
            this.PORTAL_User1 = new HashSet<PORTAL_User>();
        }
    
        public int RoleId { get; set; }
        public Nullable<int> AdminUserId { get; set; }
        public Nullable<int> LocalGroupFilter { get; set; }
        public Nullable<int> AlumniStatusFilter { get; set; }
        public Nullable<int> UserStatusFilter { get; set; }
        public Nullable<int> ParentId { get; set; }
        public bool EmailEnabled { get; set; }
        public bool FilteredAllowExtraMembers { get; set; }
        public System.Guid Guid { get; set; }
        public int GroupType { get; set; }
        public Nullable<System.DateTime> LastChanged { get; set; }
        public bool PublicSubscriptionEnabled { get; set; }
        public int SyncStatus { get; set; }
        public bool MembersCanLeave { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public Nullable<bool> IsHidden { get; set; }
        public Nullable<System.DateTime> LastSyncDate { get; set; }
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
