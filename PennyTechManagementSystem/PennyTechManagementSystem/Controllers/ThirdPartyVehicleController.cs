using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
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

    }
}
