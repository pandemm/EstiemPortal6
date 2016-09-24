using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{
    public class StatsViewModel
    {
        public string Name { get; set; }
        public int LoggedInLastMonth { get; set; }
        public int LoggedInLast3Months { get; set; }
        public int LoggedInLastYear { get; set; }
    }
}