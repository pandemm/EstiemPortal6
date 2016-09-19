using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.ViewModels;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace EstiemPortal6.Controllers
{
    public class ProfileController : Controller
    {

        public ActionResult Index(int userid)
        {
            int CurrentUserId = Int32.Parse(User.Identity.GetUserId());
            var db = new EstiemPortalContext();
            var ProfileViewModel = (from p in db.PORTAL_ESTIEMUser
                                   where p.UserId == userid
                                   select new ProfileViewModel
                                   {
                                       UserId = userid,
                                       LocalGroup = (from s in db.ESTIEM_LocalGroup
                                                     where s.Id == p.LocalGroupId
                                                     select s.Name).FirstOrDefault(),
                                       Name = p.FirstNameEnglish + " " + p.LastNameEnglish,
                                       BirthDay = p.Birthday,
                                       NickName = p.NickName,
                                       Interests = p.Interests,
                                       StudyInformation = p.StudyInfo,
                                       StudiesStart = p.StudiesStart,
                                       AttendedEvents = (from s in db.EVENTS_Participants
                                                         where s.RegistrationStatus==0 && s.UserId == p.UserId
                                                         orderby s.EVENTS_Events.StartDate descending
                                                         select s.EVENTS_Events).ToList()

                                       
                                   }).Single();

            return View(ProfileViewModel);
        }
    }
}