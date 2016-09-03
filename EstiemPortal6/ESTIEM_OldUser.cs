namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTIEM_OldUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public Guid Guid { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string GivenName { get; set; }

        [Required]
        [StringLength(50)]
        public string FamilyName { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        public int? LocalGroupId { get; set; }

        public int Status { get; set; }

        public int AlumniStatus { get; set; }

        public int? ExchangeLocalGroupId { get; set; }

        public DateTime DeletedAsOf { get; set; }

        public int? DeletedByUserId { get; set; }
    }
}
