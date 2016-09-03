namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventParticipant
    {
        public int EventId { get; set; }

        public int UserId { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime RegistrationStatus { get; set; }

        public string Comments { get; set; }

        public int? CmStatus { get; set; }

        public string MotivationText { get; set; }

        public bool? Vegetarian { get; set; }

        public bool? NoPork { get; set; }

        public bool? VisaRequired { get; set; }

        public string Visa_Firstname { get; set; }

        public string Visa_Surname { get; set; }

        public string Visa_Birthplace { get; set; }

        public DateTime? Visa_Birthdate { get; set; }

        public string Visa_Nationality { get; set; }

        public DateTime? Visa_PassportIssuedDate { get; set; }

        public string Visa_PassportIssuedBy { get; set; }

        public string Visa_Address { get; set; }

        public DateTime? Travel_ArrivalDate { get; set; }

        public DateTime? Travel_DepartureDate { get; set; }

        public string XmlAnswers { get; set; }

        public string Visa_PassportNumber { get; set; }

        public DateTime? Visa_PassportExpiryDate { get; set; }

        [Key]
        public int EventParticipationId { get; set; }

        public virtual Event Event { get; set; }

        public virtual User User { get; set; }
    }
}
