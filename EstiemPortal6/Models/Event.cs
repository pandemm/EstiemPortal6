namespace EstiemPortal6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;

    public partial class Event
    {
        public Event()
        { }

        [Key]
        public int Id { get; set; }
        public int? HistoryId { get; set; }
        public int EventType { get; set; }
        public int? RegistrationMode { get; set; }
        public int? ConfirmationType { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
       ApplyFormatInEditMode = true)]
        public DateTime? ApplicationStartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
       ApplyFormatInEditMode = true)]
        public DateTime? ApplicationEndDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
       ApplyFormatInEditMode = true)]
        public DateTime? CancellationDeadLine { get; set; }
        public int? MaxParticipants { get; set; }
        public int NumberOfRegistered { get; set; }
        public int? MaxParticipantsperLG { get; set; }
        public int? ParticipationFee { get; set; }
        public string HomePage { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Youtube { get; set; }
        public int? ParticipantsListGroupId { get; set; }
        public int? WaitingListGroupId { get; set; }
        public string EmailListAlias { get; set; }
        public string XmlQuestions { get; set; }
        public int? AdminUserId { get; set; }
        public int? ParentGroupId { get; set; }
        public short? PartyLevel { get; set; }
        public short? SelfDevLevel { get; set; }
        public short? EDevLevel { get; set; }
        public short? AContentLevel { get; set; }
        public short? BContactLevel { get; set; }
        public short? CultureLevel { get; set; }
        public virtual ICollection<EventParticipant> EventParticipants { get; set; }

    }
}