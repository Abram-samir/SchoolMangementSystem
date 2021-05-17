using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace school.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["lang"] !=null)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Session["lang"].ToString());   
            }
            
        }
	}
}