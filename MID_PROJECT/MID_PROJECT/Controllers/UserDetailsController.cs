using MID_PROJECT.Models.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MID_PROJECT.Controllers
{
    public class UserDetailsController : Controller
    {
        // GET: UserDetails
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult show()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
     

        [HttpPost]
        public ActionResult Registration(user_details s1)
        {
            if (ModelState.IsValid)
            {
                MIDEntities1 db = new MIDEntities1();
                db.user_details.Add(s1);
                db.SaveChanges();
                TempData["name"] = "Bill";
                return RedirectToAction("Registration");
            }
            return View(s1);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(user_details s1)
        {
            var db = new MIDEntities1();
            var product = (from p in db.user_details where p.email == s1.email && p.password == s1.password select p).SingleOrDefault();
            if (product != null)
            {
                Session["username"] = product.user_id;
                Session["role"] = product.rules;
                if (product.rules.Equals("Admin")) {
                    return RedirectToAction("AdminDashbord");
                }
                
                
            }
            
            return View(s1);
        }
        public ActionResult AdminDashbord()
        {
            return View();
        }
    }
}