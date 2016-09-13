using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Motivation Text:")]
        public string MotivationText { get; set; }
        public string EventName { get; set; }
        [DisplayName("Are you vegetarian?")]      
        public bool? Vegetarian { get; set; }
        [DisplayName("Do you not eat pork?")]
        public bool? EatPork { get; set; }
        [DisplayName("Do you require a visa?")]
        public bool? RequireVisa { get; set; }
        public DateTime? ApplicationStartDate { get; set; }
        public DateTime? ApplicationEndDate { get; set; }
        public int? RegistrationMode { get; set; }


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