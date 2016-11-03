using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using EstiemPortal6.Models;
using EstiemPortal6.ViewModels;

namespace EstiemPortal6.Models
{
    class FriendsModel
    { 
    public static IEnumerable<FriendsViewModel> GetFriendsForUser(int UserId)
    {
        var db = new EstiemPortalContext();
        // Gets the events you have been to excluding Council Meetings
        var evs = from m in db.EVENTS_Participants
                  where m.UserId == UserId && m.RegistrationStatus == 0 && m.CmStatus == 0
                  select m.EventID;

        var lgid = (from m in db.PORTAL_ESTIEMUser
                    where m.UserId == UserId
                    select m.LocalGroupId).FirstOrDefault();

        var friends = from m in db.EVENTS_Participants
                      where evs.Contains(m.EventID) && m.RegistrationStatus == 0
                      select m.UserId;

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
                   });
        return fvm;

    }




    }

}
