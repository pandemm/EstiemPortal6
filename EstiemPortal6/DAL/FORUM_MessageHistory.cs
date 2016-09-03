namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_MessageHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid MessageHistoryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MessageID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "ntext")]
        public string Message { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(39)]
        public string IP { get; set; }

        public DateTime? Edited { get; set; }

        public int? EditedBy { get; set; }

        [StringLength(100)]
        public string EditReason { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsModeratorChanged { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Flags { get; set; }

        public virtual FORUM_Message FORUM_Message { get; set; }
    }
}
