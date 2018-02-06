using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentShortName { get; set; }
        public string DepartmentEmail { get; set; }
        public string DepartmentNumber { get; set; }
        public string DepartmentFax { get; set; }
    }
}
