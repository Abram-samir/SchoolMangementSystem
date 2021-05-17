using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace school.Controllers
{
    public class LanguagesController : Controller
    {
        //
        // GET: /Languages/
        public ActionResult Arabic()
        {
            Session["Lang"] = "ar-EG";
            return Redirect(Request.UrlReferrer.ToString());
        }
        public ActionResult English()
        {
            Session["Lang"] = "en-US";
            return Redirect(Request.UrlReferrer.ToString());
        }
	}
}