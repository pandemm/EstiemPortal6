using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Models
{
    public class LocalGroup
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int MemberListId { get; set; }
        public int  LRListId { get; set; }
        public string Address { get; set; }
        public string OfficialName { get; set; }
    }
}