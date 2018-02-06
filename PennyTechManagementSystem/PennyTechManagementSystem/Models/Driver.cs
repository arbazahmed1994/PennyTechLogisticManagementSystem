using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class Driver : BaseModel<Driver>
    {
        public string DriverCode { get; set; }

        [Display(Name = "Salary", ResourceType = typeof(NameHandling))]
        public double Salary { get; set; }

        [Display(Name = "DailyPityCash", ResourceType = typeof(NameHandling))]
        public double DailyPityCash { get; set; }


        // REQUIRED --

        [Required]
        [Display(Name = "DriverName", ResourceType = typeof(NameHandling))]
        public string DriverName { get; set; }

        [Required]
        [Display(Name = "DriverMobile", ResourceType = typeof(NameHandling))]
        public string DriverMobile { get; set; }

        [Required]
        [Display(Name = "DriverCNIC", ResourceType = typeof(NameHandling))]
        public string DriverCNIC { get; set; }

        [Required]
        [Display(Name = "DrivingLicenceNumber", ResourceType = typeof(NameHandling))]
        public string DrivingLicenceNumber { get; set; }
    }
}
