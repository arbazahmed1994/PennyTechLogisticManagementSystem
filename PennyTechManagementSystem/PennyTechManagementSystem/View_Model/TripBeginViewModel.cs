using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.View_Model
{
    public class TripBeginViewModel : BaseModel<TripBeginViewModel>
    {
        public int ReferenceID { get; set; }

        [Display(Name = "VehicleNumber", ResourceType = typeof(NameHandling))]
        public string VehicleNumber { get; set; }

        [Display(Name = "DriverName", ResourceType = typeof(NameHandling))]
        public string DriverName { get; set; }

        [Display(Name = "ReferenceDate", ResourceType = typeof(NameHandling))]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReferenceDate { get; set; }
       
        [Display(Name = "OrderCompanyName", ResourceType = typeof(NameHandling))]
        public string OrderCompanyName { get; set; }

        [Display(Name = "SourceLocation", ResourceType = typeof(NameHandling))]
        public string SourceLocation { get; set; }

        [Display(Name = "DestinationLocation", ResourceType = typeof(NameHandling))]
        public string DestinationLocation { get; set; }

        [Display(Name = "BuiltyNumber", ResourceType = typeof(NameHandling))]
        public string BuiltyNumber { get; set; }

    }
}