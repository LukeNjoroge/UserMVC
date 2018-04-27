using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using UserMVC.Model;
using UserMVC.Models;
using UserMVC.Repository;

namespace UserMVC.Controllers
{
    public class UsersController : Controller
    {
        private UserMVCContext db = new UserMVCContext();

        public ActionResult Details()
        {
            ViewBag.MainPage = "User Management";
            ViewBag.SubPage = "Manage Users";

            return View(db.Users.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MainPage = "User Management";
            ViewBag.SubPage = "Add User";

            UserViewModel uvm = new UserViewModel();
            uvm.RoleList = db.Roles.ToList<Role>();

            GenderRepository gr = new GenderRepository();

            uvm.ListGender = gr.FindAll();
            return View(uvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserViewModel dbUser)
        {
            try
            {
                User nuvm = new User();

                nuvm.FullName = dbUser.UserAdd.FullName;
                nuvm.PhoneNo = dbUser.UserAdd.PhoneNo;
                nuvm.Email = dbUser.UserAdd.Email;
                nuvm.Dob = dbUser.UserAdd.Dob;
                nuvm.RoleID = dbUser.UserAdd.RoleID;
                nuvm.GenderID = dbUser.UserAdd.GenderID;
                nuvm.UserStatus = 1;

                db.Users.Add(nuvm);
                db.SaveChanges();

                int latestUserID = nuvm.UserID;
            }
            catch (Exception UserEx)
            {
                throw UserEx;
            }


            return View(dbUser);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,FullName,PhoneNo,Email,Dob,RoleID,GenderID,UserStatus")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
