using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbMyPortfolioEntities2 db = new DbMyPortfolioEntities2();

        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult OpenMessage(int id)
        {
            var values = db.TblContact.Find(id);
            values.IsRead = true;
            db.SaveChanges();
            return View(values);
        }

        [HttpPost]
        public ActionResult CreateMessage(TblContact p)
        {
            p.SendDate = DateTime.Now;
            p.IsRead = false;
            db.TblContact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}