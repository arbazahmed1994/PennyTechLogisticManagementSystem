using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class VehicleCompanyController : Controller
    {

        private VehicleCompanyRepository _rep = new VehicleCompanyRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage Vehicle Company";
            ViewBag.Form = "Vehicle Company List";

            IEnumerable<VehicleCompany> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Head = "Manage Vehicle Company";
            ViewBag.Form = "Vehicle Company Registration";

            return View(new VehicleCompany());
        }
        [HttpPost]
        public ActionResult Create(VehicleCompany model)
        {
            ViewBag.Head = "Manage Vehicle Company";
            ViewBag.Form = "Vehicle Company Registration";

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
            ViewBag.Head = "Manage Vehicle Company";
            ViewBag.Form = "Vehicle Company Updation";

            VehicleCompany model = new VehicleCompany();
            model = _rep.Get(id);

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(VehicleCompany model)
        {
            ViewBag.Head = "Manage Vehicle Company";
            ViewBag.Form = "Vehicle Company Updation";

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
