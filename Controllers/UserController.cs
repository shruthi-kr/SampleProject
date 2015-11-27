using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                ViewBag.StatusMessage = id;
            }
            ViewBag.Title = "User";
            return this.View();
        }
    }
}