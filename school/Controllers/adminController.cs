using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using school.Models;
using System.Globalization;
using System.Threading;
using System.Web.Security;

namespace school.Controllers
{

    public class adminController : BaseController
    {
        schoolEntities db = new schoolEntities();
        //
        // GET: /admin/
        public ActionResult Home()
        {


            return View();
        }
        //[Authorize(Roles = "adminRole")]
        public ActionResult AdminRegistration()
        {


            return View();
        }
        [HttpPost]
        public ActionResult AdminRegistration(admin ad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Configuration.ProxyCreationEnabled = false;
                    db.admin.Add(ad);
                    Membership.CreateUser(ad.email, ad.pass);
                    //Roles.AddUserToRole(ad.email, "AdminRole");
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("Login","Account");
                }
                return View();
            }
            catch (Exception ex)
            {
                return View(ad);
            }
        }
        [HttpPost]
        public ActionResult Cr(admin ad)
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.admin.Add(ad);
                db.SaveChanges();
                ModelState.Clear();
                return View();
            }
            catch(Exception ex)
            {
                return View(ad);
            }
        }



        [HttpPost]
        public JsonResult AdminList()
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                List<admin> admins = db.admin.ToList();
                return Json(new { Result = "OK", Records = admins });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult UpdateAdmin(admin obj)
        {
            try
            {
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }


        [HttpPost]
        public JsonResult DeleteAdmin(int id)
        {
            try
            {
                admin data = db.admin.Find(id);
                db.admin.Remove(data);
                db.SaveChanges();
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
        public ActionResult index()
        {
            return View(db.parent);
        }

        public ActionResult ParentRegistration()
        {
            ViewBag.parentgender = new SelectList(db.SchoolGender, "id", "gender");
            ViewBag.parentcity = new SelectList(db.parentcity, "id", "city");


            return View();
        }
        [HttpPost]
        public ActionResult ParentRegistration(parent c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //ViewBag.data = db.parent.Add(c);
                    //db.Configuration.ProxyCreationEnabled = false;
                    db.parent.Add(c);
                    db.SaveChanges();
                    //ModelState.Clear();
                    return RedirectToAction("index");
                }
                ViewBag.parentgender = new SelectList(db.SchoolGender, "id", "gender");
                ViewBag.parentcity = new SelectList(db.parentcity, "id", "city");
                return View(c);
            }
            catch (Exception ex)
            {

                ViewBag.parentgender = new SelectList(db.SchoolGender, "id", "gender");
                ViewBag.parentcity = new SelectList(db.parentcity, "id", "city");
                return View(c);
            }
        }


        public ActionResult Update(int id)
        {
            var data = db.parent.Find(id);
            ViewBag.parentg = new SelectList(db.SchoolGender, "id", "gender", data.SchoolGender);
            ViewBag.parentc = new SelectList(db.parentcity, "id", "city",data.parentcity);


            return View(data);
        }
        [HttpPost]
        public ActionResult Update(parent c)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                //ViewBag.data = db.parent.Add(c);
                db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("index");
                //}
                //ViewBag.parentgender = new SelectList(db.parentgender, "id", "gender");
                //ViewBag.parentcity = new SelectList(db.parentcity, "id", "city");
                //return RedirectToAction("ParentRegistration");
            }
            catch (Exception ex)
            {

                ViewBag.parentgender = new SelectList(db.SchoolGender, "id", "gender", c.SchoolGender);
                ViewBag.parentcity = new SelectList(db.parentcity, "id", "city",c.parentcity);
                return View(c);
            }
        }



        public ActionResult Delete(int id)
        {
            var data = db.parent.Find(id);
            ViewBag.parentg = new SelectList(db.SchoolGender, "id", "gender", data.SchoolGender);
            ViewBag.parentc = new SelectList(db.parentcity, "id", "city", data.parentcity);


            return View(data);
        }
        [HttpPost]
        [ActionName("Delete")] //lw mktbtha4 he3tbrha overload
        public ActionResult ConfirmDelete(int id)
        {
            try
            {
    
                parent data = db.parent.Find(id);
                db.parent.Remove(data); 
                db.SaveChanges();
                return RedirectToAction("index");
       
            }
            catch (Exception ex)
            {

                ViewBag.parentgender = new SelectList(db.SchoolGender, "id", "gender");
                ViewBag.parentcity = new SelectList(db.parentcity, "id", "city");
                return View();
            }
        }
        public ActionResult StudentRegistration()
        {
            ViewBag.stgender = new SelectList(db.SchoolGender, "id", "gender");


            return View();
        }
        [HttpPost]
        public ActionResult StudentRegistration(student obj)
        {
            try
            {
              if (ModelState.IsValid)
              {
                  db.student.Add(obj);
                  db.SaveChanges();
                  ModelState.Clear();
                  return RedirectToAction("Home");
              }
              ViewBag.stgender = new SelectList(db.SchoolGender, "id", "gender");
            return View(obj);
            }
            catch (Exception ex)
            {
                ViewBag.stgender = new SelectList(db.SchoolGender, "id", "gender");
                return View(obj); 
            }
            
        }
        public ActionResult SchoolRegistration()
        {


            return View();
        }
        [HttpPost]
        public ActionResult SchoolRegistration(schools obj)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.schools.Add(obj);
                    db.SaveChanges();
                    ModelState.Clear();
                    return View();
                }
                return View();
            }
            catch (Exception ex)
            {
                
            }
            return View();
        }
	}
}