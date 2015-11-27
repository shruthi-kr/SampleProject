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
        #region frontEnd
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult html()
        {
            return View();
        }
        public ActionResult css()
        {
            return View();
        }
        public ActionResult javaScript()
        {
            return View();
        }

        public ActionResult Angular() 
        { 
            return View();
        }

        public ActionResult StarRating()
        {
            return View();
        }
        #endregion

        #region Languages
      
        public ActionResult CSharp()
        {
            return View();
        }
        public ActionResult Asp()
        {
            return View();
        }
        public ActionResult MVC()
        {
            return View();
        }

        public ActionResult webApi()
        {
            return View();
        }

        #endregion

        #region BackEnd

        public ActionResult SQL()
        {
            return View();
        }
        public ActionResult Ado()
        {
            return View();
        }
        public ActionResult EntityFramework()
        {
            return View();
        }

        public ActionResult Linq()
        {
            return View();
        }

        #endregion


    }
}