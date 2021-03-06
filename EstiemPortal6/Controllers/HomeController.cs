﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.ViewModels;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using EstiemPortal6.Models;
using EstiemPortal6.Repositories;

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


        public ActionResult _Carousel()
        {
            var car1 = new CarouselViewModel("Want to give feedback?",
                "https://brandfolder.com/slack/logo/slack-primary-logo.png",
                "Join the Slack channel - <a href=\"https://estiem.slack.com/?redir=%2Fmessages%2Festiem-mobile%2F\"><button class=\"btn btn-primary\">Click here</button></a>", true);
            var car2 = new CarouselViewModel("Where is Tom Koolen?",
                "https://www.estiem.org/Internal/GetFile.aspx?File=Images/Internal/Banners/banner2.jpg",
                "", false);
            var car3 = new CarouselViewModel("Tom Koolen Found",
                "https://www.estiem.org/Internal/GetFile.aspx?File=Images/Internal/Banners/banner7.jpg",
                "Check out Events page.", false);
            var car4 = new CarouselViewModel("Want your slide here?",
                "https://www.estiem.org/Internal/GetFile.aspx?File=Images/Internal/Banners/Banner3.jpg",
                "Better find someone who knows how to design stuff.", false);
            var cvm = new List<CarouselViewModel> {
                car1, car2, car3, car4
            };

            return PartialView(cvm);
        }
        [AllowAnonymous]
        public ActionResult _MainMenu()
        {
            if(!User.Identity.IsAuthenticated)
            {
                return PartialView("~/Views/Shared/_MainMenuNotLoggedIn.cshtml");
            }
            // This method should not be needed if I'm able to fix adding claims
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

            // Get currently logged in Users ID
            int? NullableId = Int32.Parse(User.Identity.GetUserId());
            int UserId = NullableId ?? 0;
            // Currently you need to be logged in to accept every page, but later leave this
            // empty if user is not logged in
            var fvm = FriendsModel.GetFriendsForUser(UserId).Take(13);

            return PartialView(fvm);
        }

    }
}