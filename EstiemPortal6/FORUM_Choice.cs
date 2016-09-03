namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Choice
    {
        [Key]
        public int ChoiceID { get; set; }

        public int PollID { get; set; }

        [Required]
        [StringLength(50)]
        public string Choice { get; set; }

        public int Votes { get; set; }

        [StringLength(255)]
        public string ObjectPath { get; set; }

        [StringLength(50)]
        public string MimeType { get; set; }

        public virtual FORUM_Poll FORUM_Poll { get; set; }
    }
}
