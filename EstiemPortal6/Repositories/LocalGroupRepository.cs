using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Repositories
{
    public class LocalGroupRepository
    {
        public static IEnumerable<ESTIEM_LocalGroup> GetLocalGroups()
        {
            var db = new EstiemPortalContext();
            var lgs = from m in db.ESTIEM_LocalGroup
                      where m.Status == 0
                      select m;
            return (lgs);
        }
    }
}