using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class DesignationsController : Controller
    {
        private DesignationsRepository _rep = new DesignationsRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Designations";
            ViewBag.Form = "Designations List";

            IEnumerable<Designation> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Designations";
            ViewBag.Form = "Designations Registration";

            return View(new Designation());
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Head = "Manage Designations";
            ViewBag.Form = "Designations Updation";

            Designation model = new Designation();
            model = _rep.Get(id);

            return View(model);
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
