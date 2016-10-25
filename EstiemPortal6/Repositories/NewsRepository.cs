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
                             Updated = m.Updated,
                             Categories = from a in db.NEWS_NewsCategories
                                          join b in db.NEWS_Category
                                          on a.CategoryId equals b.Id
                                          where a.NewsId == m.Id
                                          select new NewsCategory
                                          {
                                              CategoryId = a.CategoryId,
                                              Name = b.Name
                                          }
                         };
            return news;
        }

        public IEnumerable<News> GetNewsByCategory(NewsCategory Category)
        {
            var All = GetAllNews();
            var news = from m in All
                       where m.Categories.Contains(Category)
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

        public NewsCategory GetNewsCategory(int id)
        {
            var db = new EstiemPortalContext();
            var category = (from m in db.NEWS_Category
                           where m.Id == id
                           select new NewsCategory
                           {
                               CategoryId = m.Id,
                               Name = m.Name
                           }).FirstOrDefault();
            return category;
        }

    }
}