using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EstiemPortal6.Models;
using EstiemPortal6.ViewModels;
using System.Data.Entity.Core.Objects;
using System.Threading.Tasks;
using PagedList;
using Microsoft.AspNet.Identity;
using System.Net.Mail;
using EstiemPortal6.Repositories;

namespace EstiemPortal6.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {      
        // Returns the default page with events.
        // Todo: Search works however paging should keep the search.
        public ActionResult Index(string searchString, string Filter, int? page)
        {
            var repo = new EventRepository();
            IEnumerable<Event> ev = repo.GetAllEvents();

            if (!string.IsNullOrEmpty(searchString))
            {
                ev = ev.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper())
                                       || s.Place.ToUpper().Contains(searchString.ToUpper())).OrderByDescending(s => s.StartDate);
            }
            else
            {
                switch (Filter)
                {
                    default: //Upcoming events
                    case "upcoming":
                        ev = from m in ev
                               where m.EndDate > DateTime.Today
                               orderby m.StartDate
                               select m;
                        break;
                    case "past":
                        ev = from m in ev
                               where m.EndDate < DateTime.Today
                               orderby m.StartDate descending
                               select m;
                        break;
                    case "application_open":
                        ev = from m in ev
                               where m.ApplicationEndDate > DateTime.Today && m.RegistrationMode == 0
                               orderby m.StartDate
                               select m;
                        break;
                }
            }
            ViewBag.searchString = searchString;
            ViewBag.Filter = Filter;
            int pageSize = 10;
            //If page is null, page number is 1
            int pageNumber = (page ?? 1);
            return View(ev.ToPagedList(pageNumber, pageSize));
        }


        public ActionResult Participants(int eventid, string sortOrder)
        {
            //Todo: Create exception if no eventid
            var db = new EstiemPortalContext();
            var EventParticipants = from m in db.EVENTS_Participants
                                    join User in db.PORTAL_ESTIEMUser on m.UserId equals User.UserId
                                    join lg in db.ESTIEM_LocalGroup on User.LocalGroupId equals lg.Id
                                    where m.EventID == eventid
                                    select new ParticipantsViewModel()
                                    {
                                        Name = User.FirstNameEnglish + " " + User.LastNameEnglish,
                                        LocalGroup  = lg.Name,
                                        RegistrationStatus = m.RegistrationStatus,
                                        ApplicationDate = m.RegistrationDate,
                                        MotivationText = m.MotivationText,
                                        EventName = m.EVENTS_Events.Name
                                        
                                    };
            ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.LGSort = sortOrder == "lg" ? "lg_desc" : "lg";
            ViewBag.RegSort = sortOrder == "reg" ? "reg_desc" : "reg";
            ViewBag.AppSort = sortOrder == "app" ? "app_desc" : "app";

            switch (sortOrder)
            {
                default:
                case "name":
                    EventParticipants = EventParticipants.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    EventParticipants = EventParticipants.OrderByDescending(s => s.Name);
                    break;
                case "lg":
                    EventParticipants = EventParticipants.OrderBy(s => s.LocalGroup);
                    break;
                case "lg_desc":
                    EventParticipants = EventParticipants.OrderByDescending(s => s.LocalGroup);
                    break;
                case "reg":
                    EventParticipants = EventParticipants.OrderBy(s => s.RegistrationStatus);
                    break;
                case "reg_desc":
                    EventParticipants = EventParticipants.OrderByDescending(s => s.RegistrationStatus);
                    break;
                case "app":
                    EventParticipants = EventParticipants.OrderBy(s => s.ApplicationDate);
                    break;
                case "app_desc":
                    EventParticipants = EventParticipants.OrderByDescending(s => s.ApplicationDate);
                    break;
            }
            ViewBag.Id = eventid;
            return View(EventParticipants);
        }

        public ActionResult Event(int id)
        {
            var repo = new EventRepository();
            Event ev = repo.GetEventById(id);
            return View(ev);
        }

        public ActionResult Application(int eventid)
        {
            
            var db = new EstiemPortalContext();
            //var pvm = (from m in db.EVENTS_Participants
            //                        join User in db.PORTAL_ESTIEMUser on m.UserId equals User.UserId
            //                        join lg in db.ESTIEM_LocalGroup on User.LocalGroupId equals lg.Id
            //                        where m.EventID == eventid
            //                        select new ParticipantsViewModel()
            //                        {
            //                            UserId = User.UserId,
            //                            Name = User.FirstNameEnglish + " " + User.LastNameEnglish,
            //                            LocalGroup = lg.Name,
            //                            RegistrationStatus = m.RegistrationStatus,
            //                            ApplicationDate = m.RegistrationDate,
            //                            MotivationText = m.MotivationText,
            //                            EventName = m.EVENTS_Events.Name

            //                        }).FirstOrDefault();

            var pvm = new ParticipantsViewModel();

            pvm = (from m in db.EVENTS_Events
                       where m.Id == eventid
                       select new ParticipantsViewModel()
                       {
                           EventName = m.Name,
                           ApplicationEndDate= m.ApplicationEndDate,
                           RegistrationMode = m.RegistrationMode,
                           Vegetarian = null,
                           EatPork = null,
                           RequireVisa = null
                         }).FirstOrDefault();
            pvm.UserId = Int32.Parse(User.Identity.GetUserId());


            // If registration is not open currently, or registrationmode is not open to public
            // redirect to the events page
            if (pvm.ApplicationEndDate < DateTime.Now || pvm.RegistrationMode != 0)
                Response.Redirect("~/Events/Index");

            return View(pvm);
        }
        [HttpPost]
        public ActionResult Application(ParticipantsViewModel pvm)
        {
            // Add the application to the database
            var db = new EstiemPortalContext();
            var evp = new EVENTS_Participants {
                UserId = pvm.UserId,
                EventID = pvm.EventId,
                RegistrationDate = DateTime.Now,
                RegistrationStatus = 1, // RegistrationStatus 1 means waiting, which is default when applying.
                Comments = "",
                CmStatus = 0,
                MotivationText = pvm.MotivationText,
                Vegetarian = pvm.Vegetarian,
                NoPork = pvm.EatPork,
                VisaRequired = pvm.RequireVisa
            };
            db.EVENTS_Participants.Add(evp);
            db.SaveChanges();
            Response.Redirect("~/Events/Index");
            return View();
        }

    }
}