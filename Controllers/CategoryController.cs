using HaberBlogSitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace HaberBlogSitesi.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        Context c = new Context();
        public IActionResult Index(int page=1)
        {
            var degerler = c.Categories.ToList().ToPagedList(page, 3); ;
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKategori(Category p)
        {
            p.CategoryDescription = "Kategori tanımı";
            c.Categories.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult KategoriSil(int id)
        {
            var ktg = c.Categories.Find(id);
            c.Categories.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult KategoriGuncelle(int id)
        {
            var cg = c.Categories.Find(id);
            return View("KategoriGuncelle", cg);
        }

        [HttpPost]
        public IActionResult KategoriGuncelle(Category p)
        {
            var cg = c.Categories.Find(p.CategoryID);
            cg.CategoryName = p.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
