using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class TripBeginController : Controller
    {
        private TripBeginRepository _rep = new TripBeginRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Begin Trips";
            ViewBag.Form = "Begin Trips List";

            IEnumerable<TripBeginModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Begin Trips";
            ViewBag.Form = "Begin Trips Registration";

            return View(new TripBeginModel());
        }
        [HttpPost]
        public ActionResult Create(TripBeginModel model)
        {
            ViewBag.Head = "Manage Begin Trips";
            ViewBag.Form = "Begin Trips List";
            if (model.ReferenceDate <= DateTime.Now.Date)
            {
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
            else
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Head = "Manage Begin Trips";
            ViewBag.Form = "Begin Trips Registration";

            TripBeginModel model = new TripBeginModel();
            model = _rep.Get(id);

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(TripBeginModel model)
        {
            ViewBag.Head = "Manage Begin Trips";
            ViewBag.Form = "Begin Trips List";
            if (model.ReferenceDate <= DateTime.Now.Date)
            {
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
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            if(_rep.Delete(id) == 1)
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
