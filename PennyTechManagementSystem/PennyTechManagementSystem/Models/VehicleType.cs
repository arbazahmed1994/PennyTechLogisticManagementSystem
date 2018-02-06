using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class VehicleType : BaseModel<VehicleType>
    {
        public int VehicleTypeID { get; set; }

        [Required]
        [Display(Name="VehicleTypeName", ResourceType = typeof(NameHandling))]
        public string VehicleTypeName { get; set; }
    }
}
