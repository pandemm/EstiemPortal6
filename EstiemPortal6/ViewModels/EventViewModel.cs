using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using EstiemPortal6.Models;

namespace EstiemPortal6.ViewModels
{
    public class EventViewModel
    {
        private readonly EstiemPortalContext _dbContext;
        private readonly string _EventId;

        private EventViewModel(EstiemPortalContext dbContext, string id)
        {
            _dbContext = dbContext;
            _EventId = id;
        }

        private EventViewModel(EstiemPortalContext dbContext)
        {
            _dbContext = dbContext;
        }

        //  public static EventViewModel GetEvent(EstiemPortalContext db, HttpContext context)
        // => GetEvent(db, GetEventId(context));
        // Do I need SessionData with Events?

        public static EventViewModel GetEvent(EstiemPortalContext db, string EventId)
            => new EventViewModel(db, EventId);
        public static List<Event> GetListEvents(EstiemPortalContext db)
        {
            var Events = from m in db.Events
                             //join e in db.EventParticipants on m.Id equals e.EventId
                         where m.EndDate > DateTime.Today && m.EventType != 9 && m.EventType != 12 && m.EventParticipants.Count > 0 //Ignores Alumni events and exchanges
                         orderby m.StartDate
                         select m;
            Events.ToList();
            return Events.ToList();
        }
        public Event Event { get; set; }
        /*{
        public string Name { get; set; }
        public int ParticipationFee { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApplicationStartDate { get; set; }


        #region RegistrationStatuses
        //RegistrationStatuses 
        //0 = Registered
        //1 = Waiting
        //2 = Canceled
        //3 = CanceledAfterDeadLine
        //4 = DidNotShowUp
        //5 = Organizer
        //6 = ApplicationWithdrawn

        EstiemPortalContext db = new EstiemPortalContext();
        public virtual List<EventParticipants> Registered
        {
            get { return Registered; }
            set
            {
                var Registered = from m in db.EventParticipants
                                 where m.RegistrationStatus == 0
                                 select m;
            }
        }
        public virtual List<EventParticipants> Waiting
        {
            get { return Waiting; }
            set { var Waiting = from m in db.EventParticipants
                                where m.RegistrationStatus == 1
                                select m;
            }
        }
        public virtual List<EventParticipants> Canceled
        {
            get { return Canceled; }
            set
            {
                var Canceled = from m in db.EventParticipants
                               where m.RegistrationStatus == 2
                               select m;
            }
        }
        public virtual List<EventParticipants> CanceledAfterDeadLine
        {
            get { return CanceledAfterDeadLine; }
            set
            {
                var CanceledAfterDeadLine = from m in db.EventParticipants
                                            where m.RegistrationStatus == 3
                                            select m;
            }
        }
        public virtual List<EventParticipants> DidNotShowUp
        {
            get { return DidNotShowUp; }
            set
            {
                var DidNotShowUp = from m in db.EventParticipants
                                   where m.RegistrationStatus == 4
                                   select m;
            }
        }
        public virtual List<EventParticipants> Organizer
        {
            get { return Organizer; }
            set
            {
                var Organizer = from m in db.EventParticipants
                                where m.RegistrationStatus == 5
                                select m;
            }
        }
        public virtual List<EventParticipants> ApplicationWithdrawn
        {
            get { return ApplicationWithdrawn; }
            set
            {
                var ApplicationWithdrawn = from m in db.EventParticipants
                                           where m.RegistrationStatus == 6
                                           select m;
            }
        }
        #endregion
        }*/
    
        
    }
}