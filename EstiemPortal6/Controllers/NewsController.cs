using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstiemPortal6.Repositories;
using EstiemPortal6.Models;
using System.Text.RegularExpressions;

namespace EstiemPortal6.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult NewsItem(int id)
        {
            var repo = new NewsRepository();
            News news = repo.GetNewsById(id);
            // News items have relative links.
            // Replace relative links with absolute links
            Regex rx = new Regex(@"src=""/[iI]nternal/");
            news.Text = rx.Replace(news.Text, new MatchEvaluator(ReplaceImageUrl));
            return View(news);
        }

        // Move this function to some better class. Helpers?
        static string ReplaceImageUrl(Match m)
        {
            string x = m.ToString();
            return ("src=\"https://www.estiem.org/internal/");
        }

        public ActionResult NewsList(int id)
        {
            var repo = new NewsRepository();
            var category = repo.GetNewsCategory(id);
            // Take only 15 newsitems until ajax is done
            var news = repo.GetNewsByCategory(category).Take(15);
            return PartialView(news);
        }

        public ActionResult AjaxGetData(int id)
        {
            var repo = new NewsRepository();
            var category = repo.GetNewsCategory(id);
            var news = repo.GetNewsByCategory(category);

            return Json(news);
        }

        public class NewsTableData
        {
            public int draw { get; set; }
            public int recordsTotal { get; set; }
            public int recordsFiltered { get; set; }
            public List<News> data { get; set; }
        }
    }
}