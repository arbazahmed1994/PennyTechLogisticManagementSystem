using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Models
{
    public class TripExpenceDetailModel : BaseModel<TripExpenceDetailModel>
    {

        // ExpenceName
        public IEnumerable<ExpenceNameModel> ExpenceNames { get; set; }
        public IEnumerable<SelectListItem> ExpenceNameList { get; set; }
        private int _expenceNameID = 0;
        [Required]
        [Display(Name = "ExpenceName", ResourceType = typeof(NameHandling))]
        public int ExpenceNameID
        {
            get { return _expenceNameID; }
            set { _expenceNameID = value; }
        }

        // constructor

        public TripExpenceDetailModel()
        {
            ExpenceNameRepository _expenceNameRep = new ExpenceNameRepository();
            ExpenceNames = _expenceNameRep.Get();
            ExpenceNameList = ExpenceNames.ToExpenceNameSelectListItems(ExpenceNameID);
        }  


        // UN-REQUIRED --

        public int TripExpenceID { get; set; }


        [Display(Name = "ExpenceName", ResourceType = typeof(NameHandling))]
        public string ExpenceName { get; set; }


        // REQUIRED --

        [Required]
        [Display(Name = "Amount", ResourceType = typeof(NameHandling))]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "Comments", ResourceType = typeof(NameHandling))]
        public string Comments { get; set; }

    }
}