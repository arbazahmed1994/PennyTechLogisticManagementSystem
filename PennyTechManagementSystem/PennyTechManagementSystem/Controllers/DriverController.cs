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

    }
}
