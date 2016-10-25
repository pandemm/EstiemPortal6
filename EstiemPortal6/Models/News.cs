using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int Priority { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsPublished { get; set; }
        public string Preview { get; set; }
        public string Text { get; set; }
        // Should this be a string or int FK to NewsCategory table?
        // String:
        // Pros: Less Database joins required. Easier to Read
        // Cons: How to do it if I want to change category name?
        // Cons: If newscategories contain more information than Name becomes cumbersome
        // Int: 
        // Pros: Easier to update
        // Cons:More Database joins required
        public IEnumerable<NewsCategory> Categories { get; set; }

    }

    public class NewsCategory : IEquatable<NewsCategory>
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public bool Equals(NewsCategory other)
        {
            if (Equals(this.CategoryId, other.CategoryId))
                return true;
            else
                return false;
        }
    }
}