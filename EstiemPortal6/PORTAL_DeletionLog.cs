namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_DeletionLog
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeletedObjectId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeletingUserId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string RealDeletingUserName { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string ObjectType { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string ObjectName { get; set; }
    }
}
