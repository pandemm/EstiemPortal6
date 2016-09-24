namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONFIGURATION_Values
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DataId { get; set; }

        [Required]
        [StringLength(200)]
        public string Value { get; set; }
    }
}
