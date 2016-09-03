using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{
    public class ParticipantsViewModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string LocalGroup { get; set; }
        public int RegistrationStatus { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string MotivationText { get; set; }
        public string EventName { get; set; }

    }
}