using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MainPage = "User Management";
            ViewBag.SubPage = "Home";
            return View();
        }
        public ActionResult Users()
        {
            ViewBag.MainPage = "User Management";
            ViewBag.SubPage = "Manage Users";

            return RedirectToRoute("Users");
        }
        public ActionResult Roles()
        {
            ViewBag.MainPage = "User Management";
            ViewBag.SubPage = "User Roles";

            return RedirectToRoute("Role");
        }
    }
}