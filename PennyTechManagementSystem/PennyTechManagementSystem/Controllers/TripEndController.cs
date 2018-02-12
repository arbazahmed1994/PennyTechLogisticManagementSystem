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
        private TripBeginRepository _repBegin = new TripBeginRepository();

        public ActionResult Index()
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "Ready to End Trips List";

            IEnumerable<TripBeginModel> model = _repBegin.Get();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create( int id )
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";

            TripEndModel model = new TripEndModel();

            //model.TripBeginList = _repBegin.GetList(id).ToList();
            ProcedureNameHandling.TripReference = id;
            ProcedureNameHandling.list = _rep.GetExpenceList().ToList();

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(TripEndModel model)
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

        public JsonResult Search(string term)
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";

            List<string> filterList = ProcedureNameHandling.list.Where(x => x.ExpenceName.ToUpper().Contains(term.ToUpper())).Select(y => y.ExpenceName).ToList();

            return Json(filterList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddRow(TripEndModel oldModel, string ExpenceNameValue, decimal AmountValue, string CommentsValue)
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";
            TripExpenceViewModel model = new TripExpenceViewModel();
            model.ExpenceName = ExpenceNameValue;
            model.Amount = AmountValue;
            model.Comments = CommentsValue;
            model.ExpenceNameID = ProcedureNameHandling.list.Where(x => x.ExpenceName.Contains(ExpenceNameValue)).Select(y => y.ExpenceNameID).First();
            oldModel.TripExpenceList.Add(model);
            ExpenceNameValue = "";
            AmountValue = 0;
            CommentsValue = "";
            return View("Create");//, oldModel);
        }

        
    }
}
