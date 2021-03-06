﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace EstiemPortal6.Controllers
{
    // This means that all the pages under this controller are available only
    // for authenticated users. Remove this later.
    [Authorize]
    public class EventsController : Controller
    {      
        // Returns the default page with events.
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
                               where m.EndDate > DateTime.Today && (m.EventType != 12 && m.EventType != 9)
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
                             where (m.EventType != 12 && m.EventType != 9) && m.ApplicationEndDate > DateTime.Now
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

            // News items have relative links.
            // Replace relative links with absolute links
            Regex rx = new Regex(@"src=""/[iI]nternal/");
            foreach(var e in ev)
            {
               e.Description = rx.Replace(e.Description, new MatchEvaluator(ReplaceImageUrl));
            }
             
            return View(ev.ToPagedList(pageNumber, pageSize));
        }

        //This should have a better place
        static string ReplaceImageUrl(Match m)
        {
            string x = m.ToString();
            return ("src=\"https://www.estiem.org/internal/");
        }



        public ActionResult Participants(int eventid)
        {
            //Todo: Create exception if no eventid
            var db = new EstiemPortalContext();
            var EventParticipants = from m in db.EVENTS_Participants
                                    join User in db.PORTAL_ESTIEMUser on m.UserId equals User.UserId
                                    join lg in db.ESTIEM_LocalGroup on User.LocalGroupId equals lg.Id
                                    where m.EventID == eventid
                                    select new ParticipantsViewModel()
                                    {
                                        UserId = m.UserId,
                                        Name = User.FirstNameEnglish + " " + User.LastNameEnglish,
                                        LocalGroup  = lg.Name,
                                        RegistrationStatus = m.RegistrationStatus,
                                        ApplicationDate = m.RegistrationDate,
                                        MotivationText = m.MotivationText,
                                        EventName = m.EVENTS_Events.Name
                                        
                                    };
            return View(EventParticipants);
        }

        public ActionResult Edit(int id)
        {
            var repo = new EventRepository();
            Event ev = repo.GetEventById(id);
            return View(ev);
        }
        [HttpPost]
        public ActionResult Edit(Event ev)
        {
            return View();
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
            var evrepo = new EventRepository();
            pvm = (from m in db.EVENTS_Events
                   where m.Id == eventid
                   select new ParticipantsViewModel()
                   {
                       Vegetarian = null,
                       EatPork = null,
                       RequireVisa = null
                   }).FirstOrDefault();
            pvm.UserId = Int32.Parse(User.Identity.GetUserId());
            pvm.Event = evrepo.GetEventById(eventid);


            // If registration is not open currently, or registrationmode is not open to public
            // redirect to the events page
            if (pvm.Event.ApplicationEndDate < DateTime.Now || pvm.Event.RegistrationMode != 0)
                Response.Redirect("~/Events/Index");

            return View(pvm);
        }
        [HttpPost]
        public async Task<ActionResult> Application(ParticipantsViewModel pvm)
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
            // Post application info to Slack
            string urlWithAccessToken = "https://hooks.slack.com/services/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";
            Slack slack = new Slack(urlWithAccessToken);
            var evrepo = new EventRepository();
            Event ev = evrepo.GetEventById(pvm.EventId);
            var usrrepo = new UserRepository();
            User usr = usrrepo.GetUserById(pvm.UserId);
            //slack.PostMessage(username: "Estiem Mobile",
            //           text: usr.UserName + " applied for " + ev.Name,
            //           channel: "#estiem-mobile");
            // Slack invite to channel
            // Invite applying user to the group of the event
            // Should this be applying or after registration?
            string parameters = "?token=" +  System.Configuration.ConfigurationManager.AppSettings["SlackToken"] + "?name=" + pvm.Event.Name;
            var resp = await slack.PostToSlack("groups.invite", parameters);
            return View();
        }

        // This is a slack command that returns event that have their application currently open
        [AllowAnonymous]
        public ActionResult application_open()
        {
            var repo = new EventRepository();
            var evs = repo.GetAllEvents();
            var ev = from m in evs
                     where (m.EventType != 12 && m.EventType != 9) && m.ApplicationEndDate > DateTime.Now
                     orderby m.StartDate
                     select new Payload {
                        Channel="estiem-mobile",
                        Text= m.Name + " in " + m.Place + ". Starts at " + m.StartDate + " until " + m.EndDate
                        + ". Application ends on " + m.ApplicationEndDate,
                        Username="lassi"
                     };
            string urlWithAccessToken = "https://hooks.slack.com/services/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";
            return Json(ev, JsonRequestBehavior.AllowGet);
        }

    }
}