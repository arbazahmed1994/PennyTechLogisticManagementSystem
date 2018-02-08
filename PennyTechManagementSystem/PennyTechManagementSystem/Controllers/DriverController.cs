using PennyTechManagementSystem.Repository;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class DriverController : Controller
    {

        private DriverRepository _rep = new DriverRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Drivers";
            ViewBag.Form = "Drivers List";
            IEnumerable<Driver> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Drivers";
            ViewBag.Form = "Driver Registration";

            return View(new Driver());
        }
        [HttpPost]
        public ActionResult Create(Driver model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _rep.Create(model);
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Edit(string id)
        {
            ViewBag.Head = "Manage Drivers";
            ViewBag.Form = "Driver Registration";

            Driver model = new Driver();
            model = _rep.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Driver model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _rep.Edit(model);
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(string id)
        {
            if(_rep.Delete(id) == 1)
            {
                TempData["SuccessMessage"] = NameHandling.SuccessMessageDelete;
            }
            else
            {
                TempData["ErrorMessage"] = NameHandling.ErrorMessage;
            }

            return RedirectToAction("Index");
        }

    }
}
