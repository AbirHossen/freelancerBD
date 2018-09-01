using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using freelancerBD.Entities;
using freelancerBD.Infrastructure;

namespace freelancerBD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Login(User obj)
        {
            using (FreelancerContext db = new FreelancerContext())
            {
                var usr = db.Users.SingleOrDefault(u => u.Name == obj.Name && u.Password == obj.Password);
                if (usr != null)
                {
                    Session["UserID"] = usr.id.ToString();
                    Session["UserName"] = usr.Name.ToString();
                    if (usr.Role == "Admin")
                    {
                        return RedirectToAction("Index", "AdminController");
                    }
                    return ViewBag("Error");

                }
                else
                {
                    ModelState.AddModelError("", "Username or Password Incorrect");
                }
            }
            return View();
        }
    }
}