using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektPZ2.DAL;
using ProjektPZ2.ViewModels;

namespace ProjektPZ2.Controllers
{

    public class HomeController : Controller
    {
        private ProjectContext db = new ProjectContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<PrzetargDateGroup> data = from przetarg in db.Przetargi
                                                 group przetarg by przetarg.DateOfCreate into dateGroup
                                                 select new PrzetargDateGroup()
                                                 {
                                                     DateOfCreate = dateGroup.Key,
                                                     PrzetargCount = dateGroup.Count()
                                                 };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}