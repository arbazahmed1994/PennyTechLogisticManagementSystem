using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class Designation : BaseModel<Designation>
    {    
        public int DesignationID { get; set; }

        [Required]
        [Display(Name = "DesignationName", ResourceType = typeof(NameHandling))]
        public string DesignationName { get; set; }
    }
}
