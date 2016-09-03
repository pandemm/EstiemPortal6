namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_ForumAccess
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForumID { get; set; }

        public int AccessMaskID { get; set; }

        public virtual FORUM_AccessMask FORUM_AccessMask { get; set; }

        public virtual FORUM_Forum FORUM_Forum { get; set; }

        public virtual FORUM_Group FORUM_Group { get; set; }
    }
}
