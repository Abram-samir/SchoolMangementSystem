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
    public class HomeController : BaseController
    {
        //
        // GET: /school/
        schoolEntities db = new schoolEntities();
        public ActionResult HomeWork()
        {
            ViewBag.semesterList = new SelectList(db.Schoolsemester, "id", "semester");


            return View();
        }
        public ActionResult Course()
        {
            ViewBag.CourseSemester = new SelectList(db.Schoolsemester, "id", "semester");


            return View();
        }
        [HttpPost]
        public ActionResult Course(course obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.course.Add(obj);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("HomeWork");
                }                                                                 
                ViewBag.CourseSemester = new SelectList(db.Schoolsemester, "id", "semester");

                return View(obj);
            }
            catch (Exception ex)
            {
                ViewBag.CourseSemester = new SelectList(db.Schoolsemester, "id", "semester");
                return View(obj);
            }
           
        }


        // ------------------ Ajax Call -----------------

        public JsonResult GetCourseDataBySemesterID(int SemID)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var data = db.course.Where(a => a.SemesterId == SemID).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

	}
}