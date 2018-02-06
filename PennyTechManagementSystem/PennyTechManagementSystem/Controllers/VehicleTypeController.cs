using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class VehicleTypeController : Controller
    {
        private VehicleTypeRepository _rep = new VehicleTypeRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Vehicle Type";
            ViewBag.Form = "Vehicle Type List";

            IEnumerable<VehicleType> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Vehicle Type";
            ViewBag.Form = "Vehicle Type Registration";

            return View(new VehicleType());
        }
        [HttpPost]
        public ActionResult Create(VehicleType model)
        {
            ViewBag.Head = "Manage Vehicle Type";
            ViewBag.Form = "Vehicle Type Registration";

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
            ViewBag.Head = "Manage Vehicle Type";
            ViewBag.Form = "Vehicle Type Updation";

            VehicleType model = new VehicleType();

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
        public ActionResult Edit(VehicleType model)
        {
            ViewBag.Head = "Manage Vehicle Type";
            ViewBag.Form = "Vehicle Type Updation";

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
