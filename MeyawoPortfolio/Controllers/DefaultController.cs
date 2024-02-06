using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MeyawoPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities2 db = new DbMyPortfolioEntities2();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FeaturePartial()
        {
            var values = db.TblFuture.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult ServicePartial() 
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult PortfolioPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult TestimonialPartial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult SocialMediaPartial()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }

        public PartialViewResult ContactPartial()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
    }
}