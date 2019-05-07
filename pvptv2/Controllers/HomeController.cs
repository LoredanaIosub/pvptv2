using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pvptv2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descoperă frumusețea Brașovului";

            return View();
        }

        public ActionResult Travel()
        {
            ViewBag.Message = "Bucură-te de experiențe minunate";

            return View();
        }

        public ActionResult Activities()
        {
            ViewBag.Message = "Activități";

            return View();
        }

        public ActionResult Relax()
        {
            ViewBag.Message = "Relaxare";

            return View();
        }

        public ActionResult Eat()
        {
            ViewBag.Message = "Mancare buna.";

            return View();
        }

        public ActionResult Play()
        {
            ViewBag.Message = "Play";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Evenimente";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Noutati";

            return View();
        }

        public ActionResult Opinion()
        {
            ViewBag.Message = "Parerea ta!";

            return View();
        }
    }
}