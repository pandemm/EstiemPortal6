using EstiemPortal6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Repositories
{
    public class UserRepository
    {
        public User GetUserById(int id)
        {
            var db = new EstiemPortalContext();
            User usr = (from m in db.PORTAL_ESTIEMUser
                       where m.UserId == id
                       select new User
                       {
                           // Todo: add rest later. Also take a look at which tables the info is currently on
                           UserName = m.FirstNameEnglish + " " + m.LastNameEnglish
                       }).FirstOrDefault();
            return usr;
        } 
    }
}