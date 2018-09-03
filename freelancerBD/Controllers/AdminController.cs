using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using freelancerBD.Entities;
using freelancerBD.IService;

namespace freelancerBD.Controllers
{
    public class AdminController : Controller
    {

        private IAdminAction _action;
        private IAdminService _service;

        public AdminController(IAdminAction action,IAdminService service)
        {
            _action = action;
            _service = service;
        }
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            return View(_action.GetAll());


        }
        [HttpGet]
        public ActionResult Profile(int id)
        {
            return View(_service.GetById(id));
            
        }
        public ActionResult ChangePassword(int id)
        {

            return View();
        }
       

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
       
        // GET: Admin/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Admin admin)
        {
            try
            {
                // TODO: Add update logic here
                bool v = _service.Insert(admin);
                if (v == true)
                {
                    ModelState.AddModelError("", "OK");
                }
                if (v == false)
                {
                    ModelState.AddModelError("", "ji");
                }
                return View();

            }
            catch
            {
                return View();
            }
        }


        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(Admin admin)
        {
            try
            {
                // TODO: Add update logic here
                bool v = _service.Update(admin);
                if(v== true)
                {
                    ModelState.AddModelError("", "OK");
                }
                if(v == false)
                {
                    ModelState.AddModelError("", "Success");
                }
                return View();
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
