using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.View_Model
{
    public class TripExpenceViewModel : BaseModel<TripExpenceViewModel>
    {

        // UN-REQUIRED --

        public int ExpenceNameID { get; set; }

        [Display(Name = "ExpenceName", ResourceType = typeof(NameHandling))]
        public string ExpenceName { get; set; }

        [Display(Name = "Amount", ResourceType = typeof(NameHandling))]
        public decimal Amount { get; set; }

        [Display(Name = "Comments", ResourceType = typeof(NameHandling))]
        public string Comments { get; set; }
    }
}