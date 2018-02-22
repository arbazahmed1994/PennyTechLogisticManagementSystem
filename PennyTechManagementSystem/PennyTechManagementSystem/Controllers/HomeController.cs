using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Constant;
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
    public class HomeController : Controller
    {

        private HomeRepository _rep = new HomeRepository();

        [HttpGet]
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            model = _rep.GetVehicleData();
            ViewBag.TotalVehicle = model.VehicleCountPrivate + model.VehicleCountOther;
            ViewBag.IdleVehicle = model.VehicleIdlePrivate + model.VehicleIdleOther;
            ViewBag.DriverCount = model.DriverCount;
            ViewBag.DriverIdle = model.DriverIdle;
            ViewBag.EmployeeCount = model.EmployeeCount;
            ViewBag.EmployeePresent = model.EmployeePresent;

            return View();
        }
        public ActionResult Logistic(int id)
        {
            NavbarConstantID.NavID = id;
            return View("LogisticDashboard");
        }

        public ActionResult LogisticDashboard()
        {
            ViewBag.Head = "Fleet Management";
            ViewBag.Form = "";

            return View();
        }

        public ActionResult Employee(int id)
        {
            NavbarConstantID.NavID = id;
            return View("EmployeeDashboard");
        }

        public ActionResult EmployeeDashboard()
        {
            ViewBag.Head = "Employees Management";
            ViewBag.Form = "";

            return View();
        }

        public ActionResult VehicleSupplements()
        {
            NavbarConstantID.NavID = 100;
            return View("VehicleSupplementsDashboard");
        }

        public ActionResult VehicleSupplementsDashboard()
        {
            ViewBag.Head = "Vehicle Supplements Dashboard";
            ViewBag.Form = "";

            return View();
        }

        public ActionResult EmployeeSupplements()
        {
            NavbarConstantID.NavID = 101;
            return View("EmployeeSupplementsDashboard");
        }

        public ActionResult EmployeeSupplementsDashboard()
        {
            ViewBag.Head = "Employee Supplements Dashboard";
            ViewBag.Form = "";

            return View();
        }
    }
}
