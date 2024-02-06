using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        DbMyPortfolioEntities2 db = new DbMyPortfolioEntities2();

        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(TblCategory p)
        {
            db.TblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = db.TblCategory.Find(id);
            db.TblCategory.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.TblCategory.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory p)
        {
            var values = db.TblCategory.Find(p.CategoryID);
            values.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}