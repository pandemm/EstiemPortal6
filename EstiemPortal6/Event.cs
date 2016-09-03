namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            EventParticipants = new HashSet<EventParticipant>();
        }

        public int Id { get; set; }

        public int? HistoryId { get; set; }

        public int EventType { get; set; }

        public int? RegistrationMode { get; set; }

        public int? ConfirmationType { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Place { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? ApplicationStartDate { get; set; }

        public DateTime? ApplicationEndDate { get; set; }

        public DateTime? CancellationDeadLine { get; set; }

        public int? MaxParticipants { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventParticipant> EventParticipants { get; set; }
    }
}
