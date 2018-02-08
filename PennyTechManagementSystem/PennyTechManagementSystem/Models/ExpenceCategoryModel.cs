using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Models
{
    public class ExpenceCategoryModel : BaseModel<ExpenceCategoryModel>
    {

        public int ExpenceCategoryID { get; set; }

        [Required]
        [Display(Name = "ExpenceCategoryName" , ResourceType = typeof(NameHandling))]
        public string ExpenceCategoryName { get; set; }

    }
}