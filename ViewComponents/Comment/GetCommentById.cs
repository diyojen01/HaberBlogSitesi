using HaberBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberBlogSitesi.ViewComponents.Comment
{
    public class GetCommentById: ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke(int id)
        {
            var yg = c.Comments.Where(x => x.BlogID == id).ToList();
            return View(yg);


        }

    }
}
