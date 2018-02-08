using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Models
{
    public class ExpenceNameModel : BaseModel<ExpenceNameModel>
    {

        // MODEL LIST

        // EXPENCE NAME
        public IEnumerable<ExpenceCategoryModel> ExpenceCategory { get; set; }
        public IEnumerable<SelectListItem> ExpenceCategoryList { get; set; }
        private int _expenceCategoryID = 0;
        [Required]
        [Display(Name = "ExpenceCategoryName", ResourceType = typeof(NameHandling))]
        public int ExpenceCategoryID
        {
            get { return _expenceCategoryID; }
            set { _expenceCategoryID = value; }
        }

         // constructor

        public ExpenceNameModel()
        {
            ExpenceCategoryRepository _expCategoryRep = new ExpenceCategoryRepository();
            ExpenceCategory = _expCategoryRep.Get();
            ExpenceCategoryList = ExpenceCategory.ToExpenceCategorySelectListItems(ExpenceCategoryID);
        }

        public int ExpenceNameID { get; set; }

        [Display(Name = "ExpenceCategoryName", ResourceType = typeof(NameHandling))]
        public string ExpenceCategoryName { get; set; }

        // REQUIRED --

        [Required]
        [Display(Name = "ExpenceName", ResourceType = typeof(NameHandling))]
        public string ExpenceName { get; set; }
    }
}