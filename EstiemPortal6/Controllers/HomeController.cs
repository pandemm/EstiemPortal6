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
            //OnAuthenticateRequest();
            //var asd = User.Identity;
            //var aasd = HttpContext.User.Identity.GetUserId();
            //bool isauth = HttpContext.User.Identity.IsAuthenticated;
            //string UserName = User.Identity.Name;
            //int userid = Int32.Parse(User.Identity.GetUserId());
            int UserId = Int32.Parse(User.Identity.GetUserId());
            var db = new EstiemPortalContext();
            var evs = from m in db.EVENTS_Participants
                      where m.UserId == UserId
                      select m.EventID;

            var friends = from m in db.EVENTS_Participants
                          where evs.Contains(m.EventID)
                          select m.UserId;

            var ownlg = from e in db.PORTAL_ESTIEMUser
                        where e.LocalGroupId == UserId
                        select e.UserId;

            var fvm = (from m in db.EVENTS_Participants
                      where friends.Contains(m.UserId) || ownlg.Contains(m.UserId)
                      orderby m.RegistrationDate descending
                      select new FriendsViewModel
                      {
                          Name = (from a in db.PORTAL_User where a.Id == m.UserId select a.UserName).FirstOrDefault(),
                          UserId = m.UserId,
                          EventName = m.EVENTS_Events.Name
                      }).Take(15);
            return PartialView(fvm);
        }

        //public void OnAuthenticateRequest()
        //{
        //    HttpCookie identityCookie = Request.Cookies[".ASPXAUTH"];
        //}

    }
}