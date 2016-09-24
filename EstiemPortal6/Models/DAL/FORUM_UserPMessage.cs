namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_UserPMessage
    {
        [Key]
        public int UserPMessageID { get; set; }

        public int UserID { get; set; }

        public int PMessageID { get; set; }

        public int Flags { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsRead { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsInOutbox { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsArchived { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsDeleted { get; set; }

        public virtual FORUM_PMessage FORUM_PMessage { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
