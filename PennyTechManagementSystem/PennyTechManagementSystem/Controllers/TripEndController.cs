using PennyTechManagementSystem.Common;
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

        public ActionResult IndexEndedList()
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "Ended Trips List";

            IEnumerable<TripBeginModel> EndedTripModel = _rep.GetEndedList();
            return View(EndedTripModel);
        }

        [HttpGet]
        public ActionResult Create( int id )
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";

            TripEndModel model = new TripEndModel();
            
            ProcedureNameHandling.TripBeginList = _repBegin.GetList(id).ToList();
            model.TripBeginList = ProcedureNameHandling.TripBeginList;
            ProcedureNameHandling.TripReference = id;
            ProcedureNameHandling.list = _rep.GetExpenceList().ToList();

            return View(model);
        }
        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Create")]
        public ActionResult Create(TripEndModel model)
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";

            model.TripReferenceID = ProcedureNameHandling.TripReference;
            if (model.EndDate >= DateTime.Now.Date)
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

        public JsonResult Search(string term)
        {
            ViewBag.Head = "Manage End Trip";
            ViewBag.Form = "End Trips List";

            List<string> filterList = ProcedureNameHandling.list.Where(x => x.ExpenceName.ToUpper().Contains(term.ToUpper())).Select(y => y.ExpenceName).ToList();

            return Json(filterList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [MultipleButton(Name = "action" , Argument = "AddRow")]
        public ActionResult AddRow(TripEndModel oldModel , string ExpenceNameValue, decimal AmountValue, string CommentsValue)
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
            oldModel.TripBeginList = ProcedureNameHandling.TripBeginList;
            return View("Create", oldModel);
        }

        
    }
}
