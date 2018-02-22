using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    [SessionTimeout]
    public class VehicleController : Controller
    {
        private VehicleRepository _rep = new VehicleRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Vehicle";
            ViewBag.Form = "Vehicles List";

            IEnumerable<VehicleModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Vehicle";
            ViewBag.Form = "Vehicle Registration";

            return View(new VehicleModel());
        }
        [HttpPost]
        public ActionResult Create(VehicleModel model)
        {
            ViewBag.Head = "Manage Vehicle";
            ViewBag.Form = "Vehicle Registration";

            if (ModelState.IsValid)
            {
                try
                {
                    _rep.Create(model);
                    return RedirectToAction("Index");
                    TempData["Success"] = NameHandling.SuccessSave;
                }
                catch (Exception ex)
                {
                    TempData["Error"] = NameHandling.Error;
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult ViewDetail(string id)
        {
            ViewBag.Head = "Manage Vehicle";
            ViewBag.Form = "Vehicles Detail";

            VehicleModel model = _rep.Get(id);

            return View(model);
        }

        public ActionResult Edit(string id)
        {
            ViewBag.Head = "Manage Vehicle";
            ViewBag.Form = "Vehicle Updation";

            VehicleModel model = new VehicleModel();

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
        public ActionResult Edit(VehicleModel model)
        {
            ViewBag.Head = "Manage Vehicle";
            ViewBag.Form = "Vehicle Updation";

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

        public ActionResult Delete(string id)
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
