namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVENTS_Participants
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime RegistrationDate { get; set; }

        public int RegistrationStatus { get; set; }

        [StringLength(300)]
        public string Comments { get; set; }

        public int? CmStatus { get; set; }

        [StringLength(550)]
        public string MotivationText { get; set; }

        public bool? Vegetarian { get; set; }

        public bool? NoPork { get; set; }

        public bool? VisaRequired { get; set; }

        [StringLength(300)]
        public string Visa_Firstname { get; set; }

        [StringLength(300)]
        public string Visa_Surname { get; set; }

        [StringLength(300)]
        public string Visa_Birthplace { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Visa_Birthdate { get; set; }

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

        [StringLength(300)]
        public string Visa_Address { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Travel_ArrivalDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Travel_DepartureDate { get; set; }

        public string XmlAnswers { get; set; }

        public virtual EVENTS_Events EVENTS_Events { get; set; }
    }
}
