namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            EventParticipants = new HashSet<EventParticipant>();
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string FirstNameEnglish { get; set; }

        public string LastName { get; set; }

        public string LastNameEnglish { get; set; }

        public DateTime? BirthDay { get; set; }

        public string MobilePhone { get; set; }

        public string HomePage { get; set; }

        public string Facebook { get; set; }

        public string Skype { get; set; }

        public string Twitter { get; set; }

        public string Linkedin { get; set; }

        public string Instagram { get; set; }

        public string SnapChat { get; set; }

        public int? LocalGroupId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventParticipant> EventParticipants { get; set; }
    }
}
