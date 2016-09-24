namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_ShoutboxMessage
    {
        [Key]
        public int ShoutBoxMessageID { get; set; }

        public int BoardId { get; set; }

        public int? UserID { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }

        [Column(TypeName = "ntext")]
        public string Message { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string IP { get; set; }
    }
}
