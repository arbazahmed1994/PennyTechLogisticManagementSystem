using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
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
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return View();
            }
        }

    }
}
