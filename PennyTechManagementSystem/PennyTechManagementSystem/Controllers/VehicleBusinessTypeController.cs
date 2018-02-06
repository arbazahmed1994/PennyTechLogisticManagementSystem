using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class VehicleBusinessTypeController : Controller
    {
        private VehicleBusinessTypeRepository _rep = new VehicleBusinessTypeRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Vehicle Business Type";
            ViewBag.Form = "Vehicle Business Type List";

            IEnumerable<VehicleBusinessType> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Vehicle Business Type";
            ViewBag.Form = "Vehicle Business Type Registration";

            return View(new VehicleBusinessType());
        }
        [HttpPost]
        public ActionResult Create(VehicleBusinessType model)
        {
            ViewBag.Head = "Manage Vehicle Business Type";
            ViewBag.Form = "Vehicle Business Type Registration";

            if (ModelState.IsValid)
            {
                try
                {
                    _rep.Create(model);
                }
                catch (Exception)
                {

                    throw;
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Head = "Manage Vehicle Business Type";
            ViewBag.Form = "Vehicle Business Type Updation";

            VehicleBusinessType model = new VehicleBusinessType();

            try
            {
                model = _rep.Get(id);
            }
            catch (Exception)
            {

                throw;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(VehicleBusinessType model)
        {
            ViewBag.Head = "Manage Vehicle Business Type";
            ViewBag.Form = "Vehicle Business Type Updation";

            if (ModelState.IsValid)
            {
                try
                {
                    _rep.Edit(model);
                }
                catch (Exception)
                {

                    throw;
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {

            if (_rep.Delete(id) == 1)
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
