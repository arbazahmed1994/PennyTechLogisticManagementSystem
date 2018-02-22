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
    public class DepartmentController : Controller
    {

        private DepartmentRepository _rep = new DepartmentRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Departments";
            ViewBag.Form = "Departments List";

            IEnumerable<Department> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Departments";
            ViewBag.Form = "Departments Registration";

            return View(new Department());
        }
        [HttpPost]
        public ActionResult Create(Department model)
        {
            ViewBag.Head = "Manage Departments";
            ViewBag.Form = "Departments Registration";

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

    }
}
