using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class VehicleCompany : BaseModel<VehicleCompany>
    {
        public int VehicleCompanyID { get; set; }

        [Required]
        [Display(Name = "VehicleCompanyName", ResourceType = typeof(NameHandling))]
        public string VehicleCompanyName { get; set; }
    }
}
