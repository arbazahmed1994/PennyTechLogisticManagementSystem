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
    public class EmployeeUserController : Controller
    {

        private EmployeeUserRepository _rep = new EmployeeUserRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Employee";
            ViewBag.Form = "Employees List";

            IEnumerable<EmployeeUser> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Create Employee";
            ViewBag.Form = "Employees Registration";

            return View(new EmployeeUser());
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Head = "Update Employee";
            ViewBag.Form = "Employees Updation";

            EmployeeUser model = new EmployeeUser();
            model = _rep.Get(id);

            return View(model);
        }

    }
}
