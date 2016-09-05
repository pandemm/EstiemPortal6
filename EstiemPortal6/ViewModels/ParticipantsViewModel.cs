using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{
    public class ParticipantsViewModel
    {
        [Key]
        public int UserId { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string LocalGroup { get; set; }
        public int RegistrationStatus { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string MotivationText { get; set; }
        public string EventName { get; set; }
        public bool Vegetarian { get; set; }
        public bool EatPork { get; set; }
        public bool RequireVisa { get; set; }



    }
    public enum Registration
    {
        Registered,
        Waiting,
        Canceled,
        CanceledAfterDeadLine,
        DidNotShowUp,
        Organizer,
        ApplicationWithdrawn
    }



}