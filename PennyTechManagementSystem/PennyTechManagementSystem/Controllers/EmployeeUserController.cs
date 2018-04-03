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
        [HttpPost]
        public ActionResult Create(EmployeeUser model)
        {
            ViewBag.Head = "Create Employee";
            ViewBag.Form = "Employees Registration";
            if (ModelState.IsValid)
            {
                model.EntryUser = Convert.ToInt32(Session["UserCode"].ToString());
                try
                {
                    _rep.Create(model);
                }
                catch (Exception)
                {
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Head = "Manage Employee";
            ViewBag.Form = "Employees Updation";

            EmployeeUser model = new EmployeeUser();
            model = _rep.Get(id);

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeUser model)
        {
            ViewBag.Head = "Manage Employee";
            ViewBag.Form = "Employees Updation";
            if (ModelState.IsValid)
            {
                model.EntryUser = Convert.ToInt32(Session["UserCode"].ToString());
                try
                {
                    _rep.Edit(model);
                }
                catch (Exception)
                {
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            int user = Convert.ToInt32(Session["UserCode"].ToString());
            try
            {
                //_rep.DeleteTwo(id, user);
            }
            catch (Exception)
            {
                
            }
            return RedirectToAction("Index");
        }

    }
}
