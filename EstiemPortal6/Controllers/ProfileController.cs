using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.ViewModels;
using System.Web.Mvc;

namespace EstiemPortal6.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult MyProfile(int UserId)
        {
            //var mapper = config.CreateMapper();
            var db = new EstiemPortalContext();
            var ProfileViewModel = from p in db.PORTAL_ESTIEMUser
                                   where p.UserId == UserId
                                   select new
                                   {

                                   };

            return View();
        }
    }
}