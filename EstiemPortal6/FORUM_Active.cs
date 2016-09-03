namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Active
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(24)]
        public string SessionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoardID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(39)]
        public string IP { get; set; }

        public DateTime Login { get; set; }

        public DateTime LastActive { get; set; }

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        public int? ForumID { get; set; }

        public int? TopicID { get; set; }

        [StringLength(50)]
        public string Browser { get; set; }

        [StringLength(50)]
        public string Platform { get; set; }

        [StringLength(255)]
        public string ForumPage { get; set; }

        public int? Flags { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }

        public virtual FORUM_Forum FORUM_Forum { get; set; }

        public virtual FORUM_Topic FORUM_Topic { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
