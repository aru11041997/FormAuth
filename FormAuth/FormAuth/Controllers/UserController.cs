using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FormAuth.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {
            if (formCollection.Get("UserName")=="Anand" && formCollection.Get("Password") == "Anand")
            {
                FormsAuthentication.SetAuthCookie(formCollection.Get("UserName"), true);
                return View("Success");
            }

                return View("Login");
        }

        [Authorize]
        public ActionResult Success()
        {
            return View();
        }
    }
}