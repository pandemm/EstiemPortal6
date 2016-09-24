namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_CheckEmail
    {
        [Key]
        public int CheckEmailID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime Created { get; set; }

        [Required]
        [StringLength(32)]
        public string Hash { get; set; }

        public virtual FORUM_User FORUM_User { get; set; }
    }
}
