namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_PollVote
    {
        [Key]
        public int PollVoteID { get; set; }

        public int PollID { get; set; }

        public int? UserID { get; set; }

        [StringLength(39)]
        public string RemoteIP { get; set; }

        public int? ChoiceID { get; set; }

        public virtual FORUM_Poll FORUM_Poll { get; set; }
    }
}
