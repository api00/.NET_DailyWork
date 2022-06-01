using WebApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            ViewBag.University = "AIUB";
            return View();
        }
        public ActionResult About()
        {
            TempData["data"] = "This is redirected from About";
           return RedirectToAction("Index");
            //return Redirect("/home/dashboard"); if we want to send to another controller
            //return RedirectToAction("Dashboard", "Profie"); //to redirect /profile/dashboard

        }
        public ActionResult InfoStudent()
        {
            Models.Student s1 = new Models.Student();
            s1.id = 2;
            s1.dept = "CSE";
            s1.dob = "11-11-2011";



            return View(s1);
        }
    }
}