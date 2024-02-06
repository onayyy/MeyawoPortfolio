using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class AdminLayoutController : Controller
    {
        DbMyPortfolioEntities2 db = new DbMyPortfolioEntities2 ();

        public ActionResult _Layout()
        {
            return View();
        }

        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult _SidebarPartial()
        {
            return PartialView();
        }

        public PartialViewResult _ScriptPartial() 
        {
            return PartialView();
        }
    }
}