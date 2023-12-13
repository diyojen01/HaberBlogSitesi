using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberBlogSitesi.Models
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Comment> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
        public IEnumerable<Category> Deger4 { get; set; }
    }
}
