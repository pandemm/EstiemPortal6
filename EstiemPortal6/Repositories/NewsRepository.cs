using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.Models;

namespace EstiemPortal6.Repositories
{
    public class NewsRepository
    {
        public News GetNewsById(int id)
        {
            var db = new EstiemPortalContext();
            News news = (from m in db.NEWS_News
                       where m.Id == id
                       select new News
                       {
                           Id = m.Id,
                           Title = m.Title,
                           ImageUrl = m.ImageUrl,
                           Author = m.Author,
                           Created = m.Created,
                           IsPublished = m.IsPublished,
                           Preview = m.Preview,
                           Priority = m.Priority,
                           Text = m.Text,
                           Updated = m.Updated
                       }).FirstOrDefault();
            return news;
        }

        //public IEnumerable<News> GetNewsByCategory(int CategoryId)
        //{
        //}
        public IEnumerable<News> GetAllNews()
        {
            var db = new EstiemPortalContext();
            var news = from m in db.NEWS_News
                       // Before paging, delete after it is implemented

                       where m.Id>9000
                       orderby m.Id descending
                         select new News
                         {
                             Id = m.Id,
                             Title = m.Title,
                             ImageUrl = m.ImageUrl,
                             Author = m.Author,
                             Created = m.Created,
                             IsPublished = m.IsPublished,
                             Preview = m.Preview,
                             Priority = m.Priority,
                             Text = m.Text,
                             Updated = m.Updated
                         };
            return news;
        }

        public IEnumerable<News> GetNewsByCategory(NewsCategory Category)
        {
            var All = GetAllNews();
            var news = from m in All
                       where m.Categories == Category
                       select new News
                       {
                           Id = m.Id,
                           Title = m.Title,
                           ImageUrl = m.ImageUrl,
                           Author = m.Author,
                           Created = m.Created,
                           IsPublished = m.IsPublished,
                           Preview = m.Preview,
                           Priority = m.Priority,
                           Text = m.Text,
                           Updated = m.Updated
                       };
            return news;
        }

    }
}