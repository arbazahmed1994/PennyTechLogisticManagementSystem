using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class VehicleBusinessType : BaseModel<VehicleBusinessType>
    {
    
        public int VehicleBusinessTypeID { get; set; }

        [Required]
        [Display(Name = "VehicleBusinessTypeName", ResourceType = typeof(NameHandling))]
        public string VehicleBusinessTypeName { get; set; }
    }
}
