using HaberBlogSitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace HaberBlogSitesi.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context c = new Context();
        public IActionResult Index(int page=1)
        {
            var degerler = c.Blogs.Include(x=>x.Category).ToList().ToPagedList(page,3);
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniBlog()
        {
            List<SelectListItem> degerler = (from x in c.Categories.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryID.ToString()

                                             }).ToList();

            ViewBag.dgr = degerler;
            return View();

        }

        [HttpPost]
        public IActionResult YeniBlog(Blog p)
        {
            var per = c.Categories.Where(x => x.CategoryID == p.Category.CategoryID).FirstOrDefault();
            p.Category = per;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult BlogSil(int id)
        {
            var brm = c.Blogs.Find(id);
            c.Blogs.Remove(brm);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BlogGuncelle(int id) 
        {
            var blogvalue = c.Blogs.Find(id);
            List<SelectListItem> degerler = (from x in c.Categories.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryID.ToString()

                                             }).ToList();

            ViewBag.cv = degerler;
            return View(blogvalue);
        }
        [HttpPost]

        public IActionResult BlogGuncelle(Blog p)
        {
            var blg = c.Blogs.Find(p.BlogID);
            blg.CategoryID = p.CategoryID;
            blg.BlogImage = p.BlogImage;
            blg.BlogTitle = p.BlogTitle;
            blg.BlogContent = p.BlogContent;

            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
