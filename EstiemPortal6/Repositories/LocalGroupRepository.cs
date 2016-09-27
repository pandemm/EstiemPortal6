using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.Models;

namespace EstiemPortal6.Repositories
{
    public class LocalGroupRepository
    {
        public static IEnumerable<LocalGroup> GetActiveLocalGroups()
        {
            var db = new EstiemPortalContext();
            IEnumerable<LocalGroup> lgs = from m in db.ESTIEM_LocalGroup
                      where m.Status == 0 // Todo: Add Enum for statuses
                      select new LocalGroup
                      {
                          //Populate LG Function?
                          Id = m.Id,
                          Name = m.Name

                      };
            return (lgs);
        }

        public IEnumerable<LocalGroup> GetAllLocalGroups()
        {
            var db = new EstiemPortalContext();
            // Possibly add API here, functions still the same
            IEnumerable<LocalGroup> lgs = from m in db.ESTIEM_LocalGroup
                                          select new LocalGroup
                                          {
                                              //Populate LG Function?
                                              Id = m.Id,
                                              Name = m.Name

                                          };
            return lgs;
        }


        public LocalGroup GetLocalGroupById(int lgid)
        {
            var db = new EstiemPortalContext();

            // Todo: Update this when changing to new db schema.
            // Add Region as string to table
            // Possibly add API here, functions still the same
            LocalGroup lg = (from m in db.ESTIEM_LocalGroup
                             where m.Id == lgid
                             select new LocalGroup
                             {
                                 //Populate LG Function?
                                 Id = m.Id,
                                 Name = m.Name

                             }).FirstOrDefault();
            return lg;
        }

        public void EditLocalGroup(LocalGroup lg)
        {
             
        }
        public void DeleteLocalGroup()
        {
            // We haven't deleted LGs so far so not urgent.
            // Should we start or not?
            throw new NotImplementedException();
        }

        public void CreateLocalGroup(LocalGroup lg)
        {
            //Not used too much to be done later.
        }



    }
}