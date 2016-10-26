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
            var news = repo.GetNewsByCategory(category);
            return PartialView(news);
        }
    }
}