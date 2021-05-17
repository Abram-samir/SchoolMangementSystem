using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using school.Models;
using System.IO;
using System.Globalization;
using System.Threading;
namespace school.Controllers
{

    public class GASController : BaseController
    {
        schoolEntities db = new schoolEntities();
        //
        // GET: /GAS/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Grades()
        {
            ViewBag.GradeType = new SelectList(db.gradetype, "id", "TypeOfGrade");


            return View();
        }
        [HttpPost]
        public ActionResult Grades(grades obj,HttpPostedFileBase gradefile )
        {
            try
            {
                string PhotoPath = Server.MapPath("~/Docs/Images/");
                string PhotoName = Guid.NewGuid() + Path.GetFileName(gradefile.FileName); //3l4an lw atb3t tokins m3 asm l swra y4lha
                string FinalPhotoPath = Path.Combine(PhotoPath, PhotoName);
                gradefile.SaveAs(FinalPhotoPath);
                if (ModelState.IsValid)
                {
                    obj.gradefile = PhotoName;
                    db.grades.Add(obj);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("Attendance");
                }
                return View(obj);
               
            }

            catch (Exception ex)
            {
                ViewBag.GradeType = new SelectList(db.gradetype, "id", "TypeOfGrade");
                return View(obj); 
            }
           
            }
        public ActionResult Attendance()
        {
            ViewBag.AttendType = new SelectList(db.attendtype, "id", "TypeOfAttend");


            return View();
        }
        [HttpPost]
        public ActionResult Attendance(attendence obj, HttpPostedFileBase attendfile)
        {
            try
            {
                string PhotoPath = Server.MapPath("~/Docs/Images/");
                string PhotoName = Guid.NewGuid() + Path.GetFileName(attendfile.FileName); //3l4an lw atb3t tokins m3 asm l swra y4lha
                string FinalPhotoPath = Path.Combine(PhotoPath, PhotoName);
                attendfile.SaveAs(FinalPhotoPath);
                if (ModelState.IsValid)
                {
                    obj.attendfile = PhotoName;
                    db.attendence.Add(obj);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("Grades");
                }
                return View(obj);

            }

            catch (Exception ex)
            {
                ViewBag.AttendType = new SelectList(db.attendtype, "id", "TypeOfAttend");
                return View(obj);
            }
        }


        public ActionResult Schedule()
        {
            ViewBag.ScheduleType = new SelectList(db.scheduletype, "id", "TypeOfSchedule");


            return View();
        }
        [HttpPost]
        public ActionResult Schedule(schedule obj, HttpPostedFileBase schedulefile)
        {
            try
            {
                string PhotoPath = Server.MapPath("~/Docs/Images/");
                string PhotoName = Guid.NewGuid() + Path.GetFileName(schedulefile.FileName); //3l4an lw atb3t tokins m3 asm l swra y4lha
                string FinalPhotoPath = Path.Combine(PhotoPath, PhotoName);
                schedulefile.SaveAs(FinalPhotoPath);
                if (ModelState.IsValid)
                {
                    obj.schedulefile = PhotoName;
                    db.schedule.Add(obj);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("Grades");
                }
                return View(obj);

            }

            catch (Exception ex)
            {
                ViewBag.ScheduleType = new SelectList(db.scheduletype, "id", "TypeOfSchedule");
                return View(obj);
            }
        }
    }
}