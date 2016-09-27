using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EstiemPortal6.Models;
using System.Net;

namespace EstiemPortal6.Repositories
{
    public class EventRepository
    {


        //Basic CRUD operations
        public bool AddEvent(Event ev)
        {
            //Todo: Do later. As only VP of Act adds events it's not urgent
            //Latest when considering a new db schema
            return true;
        }
        
        public Event GetEventById(int evid)
        {
            var db = new EstiemPortalContext();
            var ev = (from m in db.EVENTS_Events
                     where m.Id == evid
                     select new Event
                     {
                         Id = m.Id,
                         EventType = m.EventType,
                         Name = m.Name,
                         Description = m.Description,
                         StartDate = m.StartDate,
                         EndDate = m.EndDate,
                         ApplicationStartDate = m.ApplicationStartDate,
                         ApplicationEndDate = m.ApplicationEndDate,
                         Place = m.Place,
                         ParticipationFee = m.ParticipationFee,
                         MaxParticipants = m.Maxparticipants,
                         CancellationDeadLine = m.RetireDeadline,
                         HomePage = m.HomePage,
                         Facebook = m.Facebook,
                         Email = m.Email,
                         RegistrationMode = m.RegistrationMode,
                         NumberOfRegistered = (from s in db.EVENTS_Participants
                                               where s.RegistrationStatus == 0 && s.EventID == m.Id
                                               select s.UserId).Count()

                     }).Single();
            return ev;
    }

        public IEnumerable<Event> GetAllEvents()
        {
            var db = new EstiemPortalContext();
            var evs = from m in db.EVENTS_Events
                      orderby m.StartDate
                      select new Event
                      {
                          Id = m.Id,
                          EventType = m.EventType,
                          Name = m.Name,
                          Description = m.Description,
                          StartDate = m.StartDate,
                          EndDate = m.EndDate,
                          ApplicationStartDate = m.ApplicationStartDate,
                          ApplicationEndDate = m.ApplicationEndDate,
                          Place = m.Place,
                          ParticipationFee = m.ParticipationFee,
                          MaxParticipants = m.Maxparticipants,
                          CancellationDeadLine = m.RetireDeadline,
                          HomePage = m.HomePage,
                          Facebook = m.Facebook,
                          Email = m.Email,
                          RegistrationMode = m.RegistrationMode,
                          NumberOfRegistered = (from s in db.EVENTS_Participants
                                                where s.RegistrationStatus == 0 && s.EventID == m.Id
                                                select s.UserId).Count()

                      };
            return evs;
        }

        public void EditEvent(Event ev)
        {
            var db = new EstiemPortalContext();
            db.Entry(ev).State = EntityState.Modified;
            db.SaveChanges();
        }

        public bool DeleteEvent(int evid)
        {
            //Todo: Do later.
            //Latest when considering a new db schema
            return true;
        }

        //Other Operations
    }
}