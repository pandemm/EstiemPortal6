using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{
    public class CarouselViewModel
    {
        public CarouselViewModel(string Title, string URL, string Content, bool Active)
        {
            this.Title = Title;
            this.URL = URL;
            this.Content = Content;
            this.Active = Active;
        }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Content { get; set; }
        public bool Active { get; set; }

    }
}