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
    public class ThirdPartyVehicleController : Controller
    {

        private ThirdPartyVehicleRepository _rep = new ThirdPartyVehicleRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Third Party Vehicle";
            ViewBag.Form = "Third Party Vehicle List";

            IEnumerable<ThirdPartyVehicle> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Third Party Vehicle";
            ViewBag.Form = "Third Party Vehicle Registration";

            return View(new ThirdPartyVehicle());
        }
        [HttpPost]
        public ActionResult Create(ThirdPartyVehicle model)
        {
            ViewBag.Head = "Manage Third Party Vehicle";
            ViewBag.Form = "Third Party Vehicle Registration";
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

        public ActionResult Delete(string id)
        {
            if (_rep.Delete(id) == 1)
            {
                TempData["Success"] = NameHandling.SuccessMessageDelete;
            }
            else
            {
                TempData["Error"] = NameHandling.ErrorMessage;
            }

            return RedirectToAction("Index");
        }

    }
}
