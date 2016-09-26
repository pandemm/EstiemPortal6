using EstiemPortal6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstiemPortal6.Repositories;
using System.Data.Entity.SqlServer;

namespace EstiemPortal6.Controllers
{
    public class StatsController : Controller
    {
        public ActionResult McTools()
        {

            return View();
        }

        public ActionResult TravelersList()
        {
            return View();
        }

        public ActionResult _LoggedInList()
        {
            var lgs = LocalGroupRepository.GetActiveLocalGroups();
            var db = new EstiemPortalContext();

            var lgids = from s in db.ESTIEM_LocalGroup
                        select s.Id;

            var logged = from s in db.ESTIEM_LocalGroup
                         where s.Status == 1 // Make an enum for LocalGroupStatuses
                         select new StatsViewModel() {
                             Name = s.Name,
                             LoggedInLastMonth = (from m in db.PORTAL_PortalUser
                                                  join a in db.PORTAL_ESTIEMUser on m.UserId equals a.UserId
                                                  where SqlFunctions.DateDiff("day", m.LastLogin, DateTime.Now) < 30 &&
                                                  a.LocalGroupId == s.Id
                                                  select m.UserId).Count(),
                            LoggedInLast3Months = (from m in db.PORTAL_PortalUser
                                                   join a in db.PORTAL_ESTIEMUser on m.UserId equals a.UserId
                                                   where SqlFunctions.DateDiff("day", m.LastLogin, DateTime.Now) < 90 &&
                                                   a.LocalGroupId == s.Id
                                                   select m.UserId).Count(),
                            LoggedInLastYear = (from m in db.PORTAL_PortalUser
                                                join a in db.PORTAL_ESTIEMUser on m.UserId equals a.UserId
                                                where SqlFunctions.DateDiff("day", m.LastLogin, DateTime.Now) < 365 &&
                                                a.LocalGroupId == s.Id
                                                select m.UserId).Count()
                         };

            return PartialView(logged);
        }
    }
}