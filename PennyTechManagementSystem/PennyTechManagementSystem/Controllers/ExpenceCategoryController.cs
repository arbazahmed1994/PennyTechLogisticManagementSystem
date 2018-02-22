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
    public class ExpenceCategoryController : Controller
    {

        private ExpenceCategoryRepository _rep = new ExpenceCategoryRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Expence Category";
            ViewBag.Form = "Expence Category List";

            IEnumerable<ExpenceCategoryModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Expence Category";
            ViewBag.Form = "Expence Category Registration"; 
            
            return View(new ExpenceCategoryModel());
        }
        [HttpPost]
        public ActionResult Create(ExpenceCategoryModel model)
        {
            ViewBag.Head = "Manage Expence Category";
            ViewBag.Form = "Expence Category Registration"; 

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
            ViewBag.Head = "Manage Expence Category";
            ViewBag.Form = "Expence Category Updation";

            ExpenceCategoryModel model = new ExpenceCategoryModel();
            model = _rep.Get(id);

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ExpenceCategoryModel model)
        {
            ViewBag.Head = "Manage Expence Category";
            ViewBag.Form = "Expence Category Updation";

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
