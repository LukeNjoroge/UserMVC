using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using UserMVC.Models;

namespace UserMVC.Controllers
{
    public class RoleController : Controller
    {
        private UserMVCContext db = new UserMVCContext();
        public ActionResult Details()
        {
            ViewBag.MainPage = "User Management";
            ViewBag.SubPage = "User Roles";

            return View(db.Roles.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MainPage = "Roles";
            ViewBag.SubPage = "Add User";

            Role rolesViewModel = new Role();
            Role rvm = rolesViewModel;

            return View(rvm);
        }
        
        [HttpPost]
        public ActionResult Register(Role dbRoles)
        {
            Role nrvm = new Role();

            nrvm.RoleName = dbRoles.RoleName;
            nrvm.RoleStatus = 1;

            db.Roles.Add(nrvm);
            db.SaveChanges();

            int latestRoleID = nrvm.RoleID;

            return View(dbRoles);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoleID,RoleName,RoleStatus")] Role role)
        {
            if (ModelState.IsValid)
            {
                db.Entry(role).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(role);
        }
    }
}