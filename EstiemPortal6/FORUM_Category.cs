namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORUM_Category()
        {
            FORUM_Forum = new HashSet<FORUM_Forum>();
        }

        [Key]
        public int CategoryID { get; set; }

        public int BoardID { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(255)]
        public string CategoryImage { get; set; }

        public short SortOrder { get; set; }

        public int? PollGroupID { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }

        public virtual FORUM_PollGroupCluster FORUM_PollGroupCluster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORUM_Forum> FORUM_Forum { get; set; }
    }
}
