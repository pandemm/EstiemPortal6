using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{

    public abstract class ViewModelBase
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class HomeViewModel : ViewModelBase
    {

    }
}