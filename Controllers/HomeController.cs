using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginProject.Models;
using LoginProject.DAL;
using System.Web.Security;


namespace LoginProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Login
        public ActionResult MainPage()
        {
            if (Request.IsAuthenticated)
            {

                FormsAuthentication.SetAuthCookie("Cookie", true);
                return RedirectToAction("Angular", "Admin", new { area = "" });
                
            }
            else
            {
                ModelState.AddModelError("No Data", "Please enter the UserName and Password");
                return View("MainPage");
            }
        }
        //public ActionResult Index(string id)
        //{
        //    if (Request.IsAuthenticated)
        //    {
        //        if (User.Identity.Name == "Admin")
        //        {
        //            return RedirectToAction("Index", "Admin");
                    
        //        }
        //        else
        //        {
        //            return RedirectToAction("Index", "User");
        //        }
        //    }
        //    ViewBag.Message = "Welcome to .Net Learning!";
        //    return View();
        //}
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Validate()
        {
            //Forms Authentication
            string userName = Request.Form["Username"].Trim();
            string Password = Request.Form["Password"].Trim();
            UserDal user = new UserDal();

            List<User> users = (from u in user.users
                                where (u.Username == userName) && (u.Password == Password)
                                select u).ToList<User>();
            if (users.Count == 1)
            {
                FormsAuthentication.SetAuthCookie("Cookie", true);
                return RedirectToAction("Angular", "Admin", new { area = "" });
            }
            else 
            {
                ModelState.AddModelError("No Data", "Please enter the UserName and Password");
                return View("MainPage");
            }

        }
        public ActionResult InsertUserToDatabase(User m)
        {
            if (ModelState.IsValid)
            {
                UserDal dal = new UserDal();
                dal.users.Add(m);
                dal.SaveChanges();
                return RedirectToAction("Angular", "Admin", new { area ="" });
            }
            else
            {
                ModelState.AddModelError("No Data", "Please enter the UserName and Password");
                return View("MainPage");
            }

            
        }

        public ActionResult SendEmail()
        {
            return View();
        }
    }
}