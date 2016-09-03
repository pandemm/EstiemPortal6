namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Poll
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_Poll()
        {
            FORUM_Choice = new HashSet<FORUM_Choice>();
            FORUM_PollVote = new HashSet<FORUM_PollVote>();
        }

        [Key]
        public int PollID { get; set; }

        [Required]
        [StringLength(255)]
        public string Question { get; set; }

        public DateTime? Closes { get; set; }

        public int? PollGroupID { get; set; }

        public int UserID { get; set; }

        public int? Flags { get; set; }

        [StringLength(255)]
        public string ObjectPath { get; set; }

        [StringLength(50)]
        public string MimeType { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? IsClosedBound { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? AllowMultipleChoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Choice> FORUM_Choice { get; set; }

        public virtual FORUM_PollGroupCluster FORUM_PollGroupCluster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_PollVote> FORUM_PollVote { get; set; }
    }
}
