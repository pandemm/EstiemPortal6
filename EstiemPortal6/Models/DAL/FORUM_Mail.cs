namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Mail
    {
        [Key]
        public int MailID { get; set; }

        [StringLength(255)]
        public string FromUser { get; set; }

        [StringLength(255)]
        public string FromUserName { get; set; }

        [StringLength(255)]
        public string ToUser { get; set; }

        [StringLength(255)]
        public string ToUserName { get; set; }

        public DateTime Created { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Body { get; set; }

        [Column(TypeName = "ntext")]
        public string BodyHtml { get; set; }

        public int SendTries { get; set; }

        public DateTime? SendAttempt { get; set; }

        public int? ProcessID { get; set; }
    }
}
