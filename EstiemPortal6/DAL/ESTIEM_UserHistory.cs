namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTIEM_UserHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ChangedByUser { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string GivenName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string FamilyName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string FirstNameEnglish { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string LastNameEnglish { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlumniStatus { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        public bool? IsOnMemberList { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsOnLocalGroupList { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string BirthName { get; set; }

        [StringLength(10)]
        public string ImageChange { get; set; }

        public int? LocalGroupId { get; set; }

        public int? ExchangeLocalGroupId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MailStatus { get; set; }

        public DateTime? ChangeDate { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Stamp { get; set; }
    }
}
