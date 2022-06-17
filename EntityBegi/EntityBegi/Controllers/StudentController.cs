using EntityBegi.Models;
using EntityBegi.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityBegi.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(StudentDetail s1)
        {
            if (ModelState.IsValid)
            {
                studentEntities db = new studentEntities();
                db.StudentDetails.Add(s1);
                db.SaveChanges();
                return RedirectToAction("show");
            }
            return View();
        }
        public ActionResult show()
        {
            var db = new studentEntities();
            var products = db.StudentDetails.ToList();
            return View(products);
        }
        
      [HttpGet]
        public ActionResult ShowEdit(int id)
        {
            var db = new studentEntities();
            var product = (from p in db.StudentDetails where p.id == id select p).SingleOrDefault();
           
            return View(product);

        }
        [HttpPost]
        public ActionResult ShowEdit(StudentDetail s1)
        {
            
            studentEntities db = new studentEntities();
            var user = (from p in db.StudentDetails where p.id == s1.id select p).FirstOrDefault();
            
            user.Name = s1.Name;
            user.Dob = s1.Dob;


            try
            {
                db.SaveChanges();
                return RedirectToAction("show");
            }
            catch (DbEntityValidationException s)
            {
                return View(s1);
            }
            

        }
        public ActionResult delete(int id)
        {
            var db = new studentEntities();
            var user = (from p in db.StudentDetails where p.id == id select p).SingleOrDefault();
            db.StudentDetails.Remove(user);
            db.SaveChanges();
            return RedirectToAction("show");
        }
    }
}