using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.ViewModels;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using EstiemPortal6.Models;

namespace EstiemPortal6.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _EventShort()
        {
            var db = new EstiemPortalContext();
            var evvm = (from m in db.EVENTS_Events
                        where (m.EventType != 12 && m.EventType != 9) && m.ApplicationEndDate > DateTime.Now
                        orderby m.ApplicationEndDate
                        select new EventViewModel()
                        {
                            EventId = m.Id,
                            Name = m.Name,
                            StartDate = m.StartDate,
                            EndDate = m.EndDate,
                            ApplicationStartDate = m.ApplicationStartDate,
                            ApplicationEndDate = m.ApplicationEndDate,
                            Place = m.Place,
                        }).Take(6);
            return PartialView(evvm);
        }

        public ActionResult _MainMenu()
        {
            var db = new EstiemPortalContext();
            int currentuser = Int32.Parse(User.Identity.GetUserId());
            var mvvm = (from m in db.PORTAL_ESTIEMUser
                      where m.UserId == currentuser
                      select new MainMenuViewModel()
                      {
                          Name = m.FirstNameEnglish + " " + m.LastNameEnglish,
                          UserId = m.UserId
                      }).FirstOrDefault();
            return PartialView("~/Views/Shared/_MainMenu.cshtml", mvvm);
        }

        public ActionResult _Search()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Search(string searchstring, string searchtype)
        {
            var db = new EstiemPortalContext();

            var people = db.PORTAL_ESTIEMUser.
                Where(x => x.FirstNameEnglish.Contains(searchstring)
                || x.LastNameEnglish.Contains(searchstring));

            var events = db.EVENTS_Events.
                Where(x => x.Name.Contains(searchstring)
                || x.Place.Contains(searchstring));

            var localgroups = db.ESTIEM_LocalGroup.
                Where(x => x.Name.Contains(searchstring));
            return View(people);
        }


        public ActionResult _FriendsList()
        {

            //Todo Check performance of these queries
            int? UserId = Int32.Parse(User.Identity.GetUserId());
            // Currently you need to be logged in to accept every page, but later leave this
            // empty if user is not logged in
            if (UserId == null)
                return View();
            var db = new EstiemPortalContext();
            var evs = from m in db.EVENTS_Participants
                      where m.UserId == UserId && m.RegistrationStatus == 0
                      select m.EventID;

            var lgid = (from m in db.PORTAL_ESTIEMUser
                           where m.UserId == UserId
                           select m.LocalGroupId).FirstOrDefault();

            var friends = from m in db.EVENTS_Participants
                          where evs.Contains(m.EventID) && m.RegistrationStatus == 0
                          select m.UserId;

            // Fix getting the Local Group Id
            var ownlg = from e in db.PORTAL_ESTIEMUser
                        where e.LocalGroupId == lgid
                        select e.UserId;

            var fvm = (from m in db.EVENTS_Participants
                      where friends.Contains(m.UserId) || ownlg.Contains(m.UserId)
                      orderby m.RegistrationDate descending
                      select new FriendsViewModel
                      {
                          Name = (from a in db.PORTAL_User where a.Id == m.UserId select a.UserName).FirstOrDefault(),
                          UserId = m.UserId,
                          EventName = m.EVENTS_Events.Name,
                          EventId = m.EventID
                      }).Take(15);
            return PartialView(fvm);
        }

    }
}