using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        DbMyPortfolioEntities2 db = new DbMyPortfolioEntities2 ();

        public ActionResult Index()
        {
            var values = db.TblFuture.ToList();
            return View(values);
        }

		[HttpGet]
		public ActionResult CreateFeature()
		{
			return View();
		}

		[HttpPost]
		public ActionResult CreateFeature(TblFuture p)
		{
			db.TblFuture.Add(p);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult UpdateFeature(int id)
		{
			var value = db.TblFuture.Find(id);
			return View(value);
		}

		[HttpPost]
		public ActionResult UpdateFeature(TblFuture p)
		{
			var value = db.TblFuture.Find(p.FutureID);
			value.Header = p.Header;
			value.NameSurname = p.NameSurname;
			value.Title = p.Title;
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult DeleteFeature(int id)
		{
			var value = db.TblFuture.Find(id);
			db.TblFuture.Remove(value);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}