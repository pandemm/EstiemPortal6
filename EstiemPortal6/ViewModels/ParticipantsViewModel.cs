using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EstiemPortal6.Models;

namespace EstiemPortal6.ViewModels
{
    public class ParticipantsViewModel
    {
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
        [Key]
        public int UserId { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string EventName { get; set; }
        public string LocalGroup { get; set; }
        public int RegistrationStatus { get; set; }
        public DateTime ApplicationDate { get; set; }
        [DisplayName("Motivation Text:")]
        public string MotivationText { get; set; }
        [DisplayName("Are you vegetarian?")]      
        public bool? Vegetarian { get; set; }
        [DisplayName("Do you not eat pork?")]
        public bool? EatPork { get; set; }
        [DisplayName("Do you require a visa?")]
        public bool? RequireVisa { get; set; }


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