namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_ESTIEMUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstNameEnglish { get; set; }

        [Required]
        [StringLength(20)]
        public string LastNameEnglish { get; set; }

        public int Status { get; set; }

        public int AlumniStatus { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Birthday { get; set; }

        public bool? IsOnMemberList { get; set; }

        public bool IsOnLocalGroupList { get; set; }

        [StringLength(150)]
        public string MobilePhone { get; set; }

        [StringLength(750)]
        public string Homepage { get; set; }

        [StringLength(750)]
        public string Interests { get; set; }

        [StringLength(750)]
        public string CouncilMeetings { get; set; }

        [StringLength(750)]
        public string EstiemActivities { get; set; }

        [StringLength(750)]
        public string OnlineIds { get; set; }

        public bool IsVegetarian { get; set; }

        public bool NoPork { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StudiesStart { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StudiesEnd { get; set; }

        [StringLength(750)]
        public string HomeAddress { get; set; }

        [StringLength(750)]
        public string OtherAddress { get; set; }

        [StringLength(750)]
        public string BusinessAddress { get; set; }

        [StringLength(50)]
        public string BirthName { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Column(TypeName = "image")]
        public byte[] Thumbnail { get; set; }

        public int? LocalGroupId { get; set; }

        public int? ExchangeLocalGroupId { get; set; }

        public int? OldId { get; set; }

        public Guid Guid { get; set; }

        public int MailStatus { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? LastUpdate { get; set; }

        [StringLength(50)]
        public string SkypeName { get; set; }

        [StringLength(750)]
        public string EstiemPositions { get; set; }

        [StringLength(750)]
        public string StudyInfo { get; set; }

        [StringLength(50)]
        public string Hometown { get; set; }

        [StringLength(750)]
        public string DietInfo { get; set; }

        [StringLength(300)]
        public string Visa_Firstname { get; set; }

        [StringLength(300)]
        public string Visa_Surname { get; set; }

        [StringLength(300)]
        public string Visa_Nationality { get; set; }

        [StringLength(300)]
        public string Visa_PassportNumber { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Visa_PassportExpiryDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Visa_PassportIssuedDate { get; set; }

        [StringLength(300)]
        public string Visa_PassportIssuedBy { get; set; }

        public int? Visa_Address { get; set; }

        [StringLength(300)]
        public string Visa_Birthplace { get; set; }

        [StringLength(750)]
        public string EstiemComments { get; set; }
    }
}
