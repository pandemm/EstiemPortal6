using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{
    public class FriendsViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public ICollection<EVENTS_Participants> Friends { get; set; }
        public string EventName { get; set; }
    }
}