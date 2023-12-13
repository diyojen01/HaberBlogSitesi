using HaberBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberBlogSitesi.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            var deger1 = c.Blogs.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.Categories.Count().ToString();
            ViewBag.d2 = deger2;
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            //by.Deger3 = c.Blogs.Take(3).ToList();  // normal olarak ascending metodunda ilk üç yorumu getirir.
            by.Deger3 = c.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();  // son üç yorumu getirme kodu
            by.Deger2 = c.Comments.OrderByDescending(x => x.CommentID).Take(3).ToList();
            by.Deger4 = c.Categories.ToList();
            return View(by);
        }

        public IActionResult YorumDetay(int id)
        {
            //var blogdetay = c.Blogs.Where(x => x.BlogID == id).ToList();
            //return View(blogdetay);
            //by.Deger1 = c.Blogs.Where(x => x.BlogID == id).ToList();
            //by.Deger2 = c.Comments.Where(x => x.BlogID == id).ToList();
            by.Deger2 = c.Comments.Where(x => x.CommentID == id).ToList();
            return View(by);

        }

        public IActionResult BlogByCategory(int id)
        {
            //var d1 = c.Blogs.Where(x => x.CategoryID == id).Select(y => y.BlogID).FirstOrDefault();
            //var d2 = c.Comments.Where(x => x.BlogID == d1).Count().ToString();
            //ViewBag.b1 = d2;
            var KategoriAd = c.Categories.Where(x => x.CategoryID == id).Select(y => y.CategoryName).FirstOrDefault();
            ViewBag.d1 = KategoriAd;
            var deger = c.Blogs.Where(x => x.CategoryID == id).ToList();
            return View(deger);
        }

    }
}
