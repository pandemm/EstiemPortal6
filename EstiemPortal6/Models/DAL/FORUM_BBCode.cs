namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_BBCode
    {
        [Key]
        public int BBCodeID { get; set; }

        public int BoardID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string OnClickJS { get; set; }

        [Column(TypeName = "ntext")]
        public string DisplayJS { get; set; }

        [Column(TypeName = "ntext")]
        public string EditJS { get; set; }

        [Column(TypeName = "ntext")]
        public string DisplayCSS { get; set; }

        [Column(TypeName = "ntext")]
        public string SearchRegex { get; set; }

        [Column(TypeName = "ntext")]
        public string ReplaceRegex { get; set; }

        [StringLength(1000)]
        public string Variables { get; set; }

        public bool? UseModule { get; set; }

        [StringLength(255)]
        public string ModuleClass { get; set; }

        public int ExecOrder { get; set; }

        public virtual FORUM_Board FORUM_Board { get; set; }
    }
}
