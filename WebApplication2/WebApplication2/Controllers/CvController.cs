using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CvController : Controller
    {
        // GET: Cv
        public ActionResult CvIndex()
        {
            return View();
        }
    
        public ActionResult CvEduBack()
        {
            return View();
        }
        public ActionResult CvPro()
        {
            return View();
        }
        public ActionResult CvPRe()
        {
            return View();
        }
    }
}