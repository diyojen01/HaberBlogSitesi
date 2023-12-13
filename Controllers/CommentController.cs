using HaberBlogSitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace HaberBlogSitesi.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        Context c = new Context();
        public IActionResult Index(int page=1)
        {
            var degerler = c.Comments.ToList().ToPagedList(page, 3);
            return View(degerler);
        }

        public IActionResult YorumSil(int id)
        {
            var cmt = c.Comments.Find(id);
            c.Comments.Remove(cmt);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
