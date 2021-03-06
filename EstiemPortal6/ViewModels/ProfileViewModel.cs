﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{
    public class ProfileViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LocalGroup { get; set; }
        public string Email { get; set; }

        public string ForwardEmail { get; set; }
        public DateTime? BirthDay { get; set; }
        public string NickName { get; set; }
        public string Interests { get; set; }
        public string StudyInformation { get; set; }
        public DateTime? StudiesStart { get; set; }
        public string ProfilePicture { get; set; }
        public ICollection<EVENTS_Events> AttendedEvents { get; set; }

    }
}