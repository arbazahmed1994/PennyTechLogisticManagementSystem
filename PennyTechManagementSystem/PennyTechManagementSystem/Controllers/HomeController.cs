using PennyTechManagementSystem.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logistic(int id)
        {
            NavbarConstantID.NavID = id;
            return View("LogisticDashboard");
        }

        public ActionResult LogisticDashboard()
        {
            return View();
        }

        public ActionResult Employee(int id)
        {
            NavbarConstantID.NavID = id;
            return View("EmployeeDashboard");
        }

        public ActionResult EmployeeDashboard()
        {
            return View();
        }
    }
}
