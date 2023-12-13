using HaberBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberBlogSitesi.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();

        public IActionResult Index()
        {
             
            by.Deger1 = c.Blogs.Include(x => x.Category).ToList();
            return View(by);
        }

        public IActionResult BlogDetay(int id)
        {
            //var blogdetay = c.Blogs.Where(x => x.BlogID == id).ToList();
            //return View(blogdetay);
            var d1 = c.Comments.Where(x => x.BlogID == id).Count().ToString();
            ViewBag.a1 = d1;
            by.Deger1 = c.Blogs.Where(x => x.BlogID == id).Include(x => x.Category).ToList();
            by.Deger2 = c.Comments.Where(x => x.BlogID == id).ToList();
            return View(by);

        }


        public IActionResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return View();
        }


        [HttpPost]
        public IActionResult YorumYap(Comment p)
        {
           
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.Comments.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }



        public PartialViewResult Partial1()
        {
            by.Deger1 = c.Blogs.OrderByDescending(x => x.BlogID).Take(5).ToList();
            return PartialView(by);


        }
    }
}
