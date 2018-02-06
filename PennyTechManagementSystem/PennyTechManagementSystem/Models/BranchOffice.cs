using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class BranchOffice
    {
        public int BranchOfficeID { get; set; }
        public string BranchOfficeName { get; set; }
        public string Address { get; set; }
        public string BranchOfficeNumber { get; set; }
        public string BranchOfficeEmail { get; set; }
    }
}
