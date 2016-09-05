using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.ViewModels;
using System.Web.Mvc;

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
                       orderby m.ApplicationEndDate descending
                       select new EventViewModel()
                       {
                           EventId = m.Id,
                           Name = m.Name,
                           StartDate = m.StartDate,
                           EndDate = m.EndDate,
                           ApplicationStartDate = m.ApplicationStartDate,
                           ApplicationEndDate = m.ApplicationEndDate,
                           Place = m.Place,
                       }).Take(5);
            return PartialView(evvm);
        }

        public ActionResult _FriendsList()
        {
            int UserId = 15545;
            var db = new EstiemPortalContext();
            var evs = from m in db.EVENTS_Participants
                      where m.UserId == UserId
                      select m.EventID;

            var friends = from m in db.EVENTS_Participants
                          where evs.Contains(m.EventID)
                          select m.UserId;

            var fvm = (from m in db.EVENTS_Participants
                      where friends.Contains(m.UserId)
                      orderby m.RegistrationDate descending
                      select new FriendsViewModel
                      {
                          Name = (from a in db.PORTAL_User where a.Id == m.UserId select a.UserName).FirstOrDefault(),
                          UserId = m.UserId,
                          EventName = m.EVENTS_Events.Name
                      }).Take(15);
            return PartialView(fvm);
        }
    }
}