namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_prov_Membership
    {
        [Key]
        [StringLength(64)]
        public string UserID { get; set; }

        public Guid ApplicationID { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [Required]
        [StringLength(256)]
        public string UsernameLwd { get; set; }

        [StringLength(256)]
        public string Password { get; set; }

        [StringLength(256)]
        public string PasswordSalt { get; set; }

        [StringLength(256)]
        public string PasswordFormat { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(256)]
        public string EmailLwd { get; set; }

        [StringLength(256)]
        public string PasswordQuestion { get; set; }

        [StringLength(256)]
        public string PasswordAnswer { get; set; }

        public bool? IsApproved { get; set; }

        public bool? IsLockedOut { get; set; }

        public DateTime? LastLogin { get; set; }

        public DateTime? LastActivity { get; set; }

        public DateTime? LastPasswordChange { get; set; }

        public DateTime? LastLockOut { get; set; }

        public int? FailedPasswordAttempts { get; set; }

        public int? FailedAnswerAttempts { get; set; }

        public DateTime? FailedPasswordWindow { get; set; }

        public DateTime? FailedAnswerWindow { get; set; }

        public DateTime? Joined { get; set; }

        [Column(TypeName = "ntext")]
        public string Comment { get; set; }
    }
}
