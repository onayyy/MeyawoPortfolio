using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioEntities2 db = new DbMyPortfolioEntities2 ();

        public ActionResult Index()
        {
			ViewBag.isNotReadMessageCount = db.TblContact.Where(x => x.IsRead == false).Count();
			ViewBag.projectCount = db.TblProject.Count();
			ViewBag.lastProjectName = db.LastProjectName().FirstOrDefault();
			ViewBag.serviceCount = db.TblService.Count();
            ViewBag.flutterCount = db.TblProject.Where(x => x.TblCategory.CategoryName == "Flutter").Count();
            ViewBag.pythonCount = db.TblProject.Where(x => x.TblCategory.CategoryName == "Python").Count();
            ViewBag.reactNativeCount = db.TblProject.Where(x => x.TblCategory.CategoryName == "React Native").Count();
            ViewBag.unityCount = db.TblProject.Where(x => x.TblCategory.CategoryName == "Unity").Count();
            return View();
        }
        

    }
}