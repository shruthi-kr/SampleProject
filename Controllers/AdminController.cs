using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginProject.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
     
        public ActionResult Index()
        {
             return View();
        }

        public ActionResult Content(string ContentType)
        {
            ViewBag.Title = ContentType;
            ViewBag.Type = ContentType;
            return View();
        }

        public ActionResult Editor()
        {
            return View();
        }
    }
}