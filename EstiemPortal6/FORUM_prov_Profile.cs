namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_prov_Profile
    {
        [Key]
        [StringLength(64)]
        public string UserID { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        [StringLength(255)]
        public string RealName { get; set; }

        [StringLength(255)]
        public string BlogServicePassword { get; set; }

        [StringLength(255)]
        public string GoogleTalk { get; set; }

        [StringLength(255)]
        public string ICQ { get; set; }

        [StringLength(255)]
        public string YIM { get; set; }

        [StringLength(255)]
        public string MSN { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(255)]
        public string XMPP { get; set; }

        [StringLength(255)]
        public string AIM { get; set; }

        [StringLength(400)]
        public string Interests { get; set; }

        [StringLength(255)]
        public string Blog { get; set; }

        public int? Gender { get; set; }

        [StringLength(255)]
        public string BlogServiceUrl { get; set; }

        [StringLength(400)]
        public string Occupation { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

        [StringLength(255)]
        public string Homepage { get; set; }

        [StringLength(255)]
        public string BlogServiceUsername { get; set; }

        [StringLength(255)]
        public string Skype { get; set; }
    }
}
