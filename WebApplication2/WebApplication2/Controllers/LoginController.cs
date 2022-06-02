using WebApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginForm(Details obj)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(obj); // obj data send to create view 
        }
    }
}