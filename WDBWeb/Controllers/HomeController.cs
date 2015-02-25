using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WDBWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your friendly Austin based IT Consultant";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A brief history of...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to reach out";

            return View();
        }
    }
}
