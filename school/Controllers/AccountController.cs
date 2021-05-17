using school.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace school.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

         schoolEntities db = new schoolEntities();
   
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(admin obj)
        {
            if (Membership.ValidateUser(obj.email, obj.pass))
            {

                FormsAuthentication.SetAuthCookie(obj.email, false);

                //if (Roles.IsUserInRole(obj.email, "adminRole"))
                //{
                //    return RedirectToAction("AdminRegistration", "admin");
                //}

                return RedirectToAction("AdminRegistration", "admin");

            }
                       
            return View();
        }

        [HttpPost]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }   
    }
}