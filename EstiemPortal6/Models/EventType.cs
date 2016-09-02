using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Models
{
    public class EventType
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string ImageLocation { get; set; }
        public int? Order { get; set; }
    }
}