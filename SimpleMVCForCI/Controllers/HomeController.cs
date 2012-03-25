using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVCForCI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Build and Deployed!!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
