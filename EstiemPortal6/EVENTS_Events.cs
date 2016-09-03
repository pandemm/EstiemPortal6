namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVENTS_Events
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVENTS_Events()
        {
            EVENTS_Participants = new HashSet<EVENTS_Participants>();
        }

        public int Id { get; set; }

        public int? HistoryId { get; set; }

        public int EventType { get; set; }

        public int? RegistrationMode { get; set; }

        public int? ConfirmationType { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Place { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ApplicationStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ApplicationEndDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RetireDeadline { get; set; }

        public int? Maxparticipants { get; set; }

        public int? MaxParticipantsPerLG { get; set; }

        public int? ParticipationFee { get; set; }

        [StringLength(100)]
        public string HomePage { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Facebook { get; set; }

        [StringLength(100)]
        public string Youtube { get; set; }

        public int? ParticipantsListGroupId { get; set; }

        public int? WaitingListGroupId { get; set; }

        [StringLength(50)]
        public string EmailListAlias { get; set; }

        [Column(TypeName = "text")]
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
        public virtual ICollection<EVENTS_Participants> EVENTS_Participants { get; set; }
    }
}
