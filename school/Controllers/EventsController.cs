using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using school.Models;
using System.Globalization;
using System.Threading;

namespace school.Controllers
{
    public class EventsController : BaseController
    {
        schoolEntities db = new schoolEntities();
        //
        // GET: /Events/
        

        public ActionResult Report()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Report(reports obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.reports.Add(obj);
                    db.SaveChanges();
                    ModelState.Clear();
                    return View();
                }
                return View(obj);
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }
        public ActionResult Event()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Event(EV obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.EV.Add(obj);
                    db.SaveChanges();
                    ModelState.Clear();
                    return View();
                }
                return View(obj);
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }
        public ActionResult Activity()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Activity(activities obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.activities.Add(obj);
                    db.SaveChanges();
                    ModelState.Clear();
                    return View();
                }
                return View(obj);
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }
    }

}
