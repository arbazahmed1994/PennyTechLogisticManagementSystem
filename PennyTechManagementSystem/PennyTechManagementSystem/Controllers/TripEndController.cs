using PennyTechManagementSystem.Constant;
using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using PennyTechManagementSystem.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class TripEndController : Controller
    {

        private TripEndRepository _rep = new TripEndRepository();

        public ActionResult Create()
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";

            ProcedureNameHandling.list = _rep.GetExpenceList().ToList();

            TripEndModel model = new TripEndModel();
            return View(model);
        }

        public JsonResult Search(string term)
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";

            List<string> filterList = ProcedureNameHandling.list.Where(x => x.ExpenceName.ToUpper().Contains(term.ToUpper())).Select(y => y.ExpenceName).ToList();

            return Json(filterList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddRow(TripEndModel oldModel, string ExpenceNameValue, decimal AmountValue, string CommentsValue)
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";
            TripExpenceViewModel model = new TripExpenceViewModel();
            model.ExpenceName = ExpenceNameValue;
            model.Amount = AmountValue;
            model.Comments = CommentsValue;
            //model.ExpenceNameID = Convert.ToInt32(ProcedureNameHandling.list.Where(x => x.ExpenceName.Contains(ExpenceNameValue)).Select(y => y.ExpenceNameID).ToList());
            oldModel.TripExpenceList.Add(model);
            ExpenceNameValue = "";
            AmountValue = 0;
            CommentsValue = "";
            return View("Create", oldModel);
        }

    }
}
