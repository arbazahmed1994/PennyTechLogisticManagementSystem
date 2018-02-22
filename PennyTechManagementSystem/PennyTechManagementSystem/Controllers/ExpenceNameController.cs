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
    public class ExpenceNameController : Controller
    {

        private ExpenceNameRepository _rep = new ExpenceNameRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Expence Name";
            ViewBag.Form = "Expence Name List";

            IEnumerable<ExpenceNameModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Expence Name";
            ViewBag.Form = "Expence Name Registration";

            return View(new ExpenceNameModel());
        }
        [HttpPost]
        public ActionResult Create(ExpenceNameModel model)
        {
            ViewBag.Head = "Manage Expence Name";
            ViewBag.Form = "Expence Name Registration";

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

        public ActionResult Edit(int id)
        {
            ViewBag.Head = "Manage Expence Name";
            ViewBag.Form = "Expence Name Updation";

            ExpenceNameModel model = new ExpenceNameModel();
            model = _rep.Get(id);

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ExpenceNameModel model)
        {
            ViewBag.Head = "Manage Expence Name";
            ViewBag.Form = "Expence Name Updation";

            if (ModelState.IsValid)
            {
                try
                {
                    _rep.Edit(model);
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
