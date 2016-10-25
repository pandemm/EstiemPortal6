using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MailingList { get; set; }
        public User Leader { get; set; }
        public List<User> Members { get; set; }
    }
}