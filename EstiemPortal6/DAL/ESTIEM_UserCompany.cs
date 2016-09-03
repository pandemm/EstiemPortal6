namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTIEM_UserCompany
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Branche { get; set; }

        [StringLength(500)]
        public string Division { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(250)]
        public string HomePage { get; set; }

        [StringLength(500)]
        public string LineOfBusiness { get; set; }

        [StringLength(500)]
        public string UserFunction { get; set; }

        [StringLength(500)]
        public string FieldOfWork { get; set; }

        [StringLength(150)]
        public string Position { get; set; }

        [StringLength(500)]
        public string Address { get; set; }
    }
}
