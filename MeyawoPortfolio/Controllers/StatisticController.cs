using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities2 db = new DbMyPortfolioEntities2();

        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.flutterProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.unityProjectCount = db.TblProject.Where(x => x.ProjectCategory == 8).Count();
            ViewBag.isNotReadMessageCount = db.TblContact.Where(x => x.IsRead == false).Count();
            ViewBag.isReadMessageCount = db.TblContact.Where(x => x.IsRead == true).Count();
            ViewBag.lastProjectName = db.LastProjectName().FirstOrDefault();
			ViewBag.serviceCount = db.TblService.Count();
            ViewBag.testimonialCount = db.TblTestimonial.Count();
			return View();
        }
    }
}