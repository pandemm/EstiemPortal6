using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{
    public class EventViewModel
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ApplicationStartDate { get; set; }
        public DateTime? ApplicationEndDate { get; set; }
        public string Place { get; set; }
        public int ParticipationFee { get; set; }
        public int MaxParticipants { get; set; }
        public DateTime? CancellationDate { get; set; }
        public int NumberOfRegistered { get; set; }
        public int EventCategory { get; set; }
        public string HomePage { get; set; }
        public string Facebook { get; set; }
        public string Email { get; set; }
    }
}