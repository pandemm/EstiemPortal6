using EstiemPortal6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Repositories
{
    public class EventParticipantRepository
    {
        EstiemPortalContext db = new EstiemPortalContext();
        public EventParticipant GetEventParticipant(int EventId, int UserId)
        {
            var usrrepo = new UserRepository();
            var evrepo = new EventRepository();
            var evp = (from m in db.EVENTS_Participants
                       where m.EventID == EventId && m.UserId == UserId
                       select new EventParticipant
                       {
                           EventId = m.EventID,
                           UserId = m.UserId,
                           Participant = usrrepo.GetUserById(m.UserId),
                           Event = evrepo.GetEventById(m.EventID),
                           MotivationText = m.MotivationText,
                           CmStatus = m.CmStatus,
                           Comments = m.Comments,
                           NoPork = m.NoPork,
                           RegistrationDate = m.RegistrationDate,
                           RegistrationStatus = m.RegistrationStatus,
                           Travel_ArrivalDate = m.Travel_ArrivalDate,
                           Travel_DepartureDate = m.Travel_DepartureDate,
                           Vegetarian = m.Vegetarian
                     }).FirstOrDefault();
            return evp; 
        }
        public IEnumerable<EventParticipant> GetParticipantsByEventid(int EventId)
        {
            var usrrepo = new UserRepository();
            var evrepo = new EventRepository();
            var evp = from m in db.EVENTS_Participants
                      where m.EventID == EventId
                      select new EventParticipant
                      {
                          EventId = m.EventID,
                          UserId = m.UserId,
                          Participant = usrrepo.GetUserById(m.UserId),
                          Event = evrepo.GetEventById(m.EventID),
                          MotivationText = m.MotivationText,
                          CmStatus = m.CmStatus,
                          Comments = m.Comments,
                          NoPork = m.NoPork,
                          RegistrationDate = m.RegistrationDate,
                          RegistrationStatus = m.RegistrationStatus,
                          Travel_ArrivalDate = m.Travel_ArrivalDate,
                          Travel_DepartureDate = m.Travel_DepartureDate,
                          Vegetarian = m.Vegetarian
                      };
            return evp;
        }

        public void AddEventParticipant(EVENTS_Participants evp)
        {
            // Not needed currently
        }

        public void UpdateEventParticipant(EventParticipant evp)
        {

        }
    }
}