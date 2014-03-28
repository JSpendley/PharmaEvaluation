using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaEvaluation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome";           

            return View();
        }

        public ActionResult TestView()
        {
            return View();
        }

        public ActionResult Download()
        {
            ViewBag.Message = "Click on the link below to begin the download:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
