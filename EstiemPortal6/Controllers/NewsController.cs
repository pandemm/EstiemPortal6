using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstiemPortal6.Repositories;
using EstiemPortal6.Models;

namespace EstiemPortal6.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult NewsItem(int id)
        {
            var repo = new NewsRepository();
            News news = repo.GetNewsById(id);
            return View(news);
        }

        public ActionResult NewsList(int id)
        {
            var repo = new NewsRepository();
            var category = repo.GetNewsCategory(id);
            var news = repo.GetNewsByCategory(category);
            return PartialView(news);
        }
    }
}