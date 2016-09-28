using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstiemPortal6.Controllers
{
    public class LocalGroupController : Controller
    {
        // Shows a general Local Group page with a list of all Local Groups
        public ActionResult Index()
        {
            return View();
        }

        // Shows the details of a single Local Group
        public ActionResult LocalGroup()
        {
            return View();
        }
    }
}