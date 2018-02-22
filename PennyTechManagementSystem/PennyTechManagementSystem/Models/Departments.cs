using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class Department : BaseModel<Department>
    {
        public int DepartmentID { get; set; }

        [Required]
        [Display(Name = "DepartmentName", ResourceType = typeof(NameHandling))]
        public string DepartmentName { get; set; }
        
        [Required]
        [Display(Name = "DepartmentShortName", ResourceType = typeof(NameHandling))]
        public string DepartmentShortName { get; set; }

        [Required]
        [Display(Name = "DepartmentEmail", ResourceType = typeof(NameHandling))]
        public string DepartmentEmail { get; set; }

        [Required]
        [Display(Name = "DepartmentNumber", ResourceType = typeof(NameHandling))]
        public string DepartmentNumber { get; set; }

        [Display(Name = "DepartmentFax", ResourceType = typeof(NameHandling))]
        public string DepartmentFax { get; set; }
    }
}
