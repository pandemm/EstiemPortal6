using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EstiemPortal6.Models;
using EstiemPortal6.Repositories;
using EstiemPortal6.ViewModels;
using System.Data.Entity.Core.Objects;
using System.Threading.Tasks;
using PagedList;

namespace EstiemPortal6.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Inde()
        {
            var db = new EstiemPortalContext();
            var Events = from m in db.Events
                         where m.EndDate > DateTime.Today && m.EventType != 9 && m.EventType != 12 //Ignores Alumni events and exchanges
                         orderby m.StartDate
                         select m;

            return View(Events);
        }


        //Repository shit starts
        private IEventRepository EventRepository;

        public EventsController()
        {
            this.EventRepository = new EventRepository(new EstiemPortalContext());
        }

        public EventsController(IEventRepository EventRepository)
        {
            this.EventRepository = EventRepository;
        }

        public ActionResult Index(string searchString, string Filter, int? page)
        {

            //var events = from s in EventRepository.GetEvents()
            //             select s;
            //IEnumerable<Event> events = new List<Event>();


            // If searched, return to first page
            if (searchString != null)
                page = 1;
            else
                searchString = Filter;
            
            ViewBag.Filter = searchString;
            var events = from s in EventRepository.GetEvents()
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                events = events.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper())
                                       || s.Place.ToUpper().Contains(searchString.ToUpper()));
            }
            else
            { 
            switch (Filter)
            {
                default: //Upcoming events
                case "upcoming":
                    events = from m in EventRepository.GetEvents()                             
                             where m.EndDate > DateTime.Today && m.EventType != 9 && m.EventType != 12 //Ignores Alumni events and exchanges
                             orderby m.StartDate
                             select m;
                    break;
                case "past":
                    events = from m in EventRepository.GetEvents()
                             where m.EndDate < DateTime.Today
                             orderby m.StartDate descending
                             select m;
                    break;
                case "application_open":
                    events = from m in EventRepository.GetEvents()
                             where m.ApplicationEndDate > DateTime.Today && m.RegistrationMode == 0
                             select m;
                    break;
            }
            }
            ViewBag.searchString = searchString;
            ViewBag.Filter = Filter;
            int pageSize = 10;
            //If page is null, page number is 1
            int pageNumber = (page ?? 1);
            return View(events.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Event(int id)
        {
            Event ev = EventRepository.GetEvent(id);
            return View(ev);
        }

        public ActionResult ViewParticipants(int eventid)
        {
            var db = new EstiemPortalContext();
            var EventParticipants = from m in db.EventParticipants
                                    where m.EventId == eventid
                                    select m;
            
            return View(EventParticipants);
        }
    }
}