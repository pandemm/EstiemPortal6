using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string FirstNameEnglish { get; set; }
        public string LastName { get; set; }
        public string LastNameEnglish { get; set; }
        public char? Gender { get; set; }
        public DateTime? BirthDay { get; set; }

        //Social Medias
        public string MobilePhone { get; set; }
        public string HomePage { get; set; }
        public string Facebook { get; set; }
        public string Skype { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string SnapChat { get; set; }
        //Todo: Make as FK after LG Table is in
        public int? LocalGroupId { get; set; }

    }
}