using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Models
{
    public class TripBeginModel : BaseModel<TripBeginModel>
    {

        [DataType(DataType.Date)]
        [Required]
        private DateTime _referenceDate = DateTime.Now.Date;
        [Display(Name = "ReferenceDate", ResourceType = typeof(NameHandling))]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReferenceDate
        {
            get { return _referenceDate.Date; }
            set { _referenceDate = value; }
        }

        [Required]
        [Display(Name = "OrderCompanyName", ResourceType = typeof(NameHandling))]
        public string OrderCompanyName { get; set; }

        [Required]
        [Display(Name = "VendorName", ResourceType = typeof(NameHandling))]
        public string VendorName { get; set; }

        [Required]
        [Display(Name = "SourceLocation", ResourceType = typeof(NameHandling))]
        public string SourceLocation { get; set; }

        [Required]
        [Display(Name = "DestinationLocation", ResourceType = typeof(NameHandling))]
        public string DestinationLocation { get; set; }

        [Required]
        [Display(Name = "OrderPersonName", ResourceType = typeof(NameHandling))]
        public string OrderPersonName { get; set; }

        [Display(Name = "OrderPersonContact", ResourceType = typeof(NameHandling))]
        public string OrderPersonContact { get; set; }

        [Required]
        [Display(Name = "ShipmentName", ResourceType = typeof(NameHandling))]
        public string ShipmentName { get; set; }

        [Required]
        [Display(Name = "StartingMeterReading", ResourceType = typeof(NameHandling))]
        public decimal StartingMeterReading { get; set; }

        [Display(Name = "EstimatedTime", ResourceType = typeof(NameHandling))]
        public double EstimatedTime { get; set; }

        [Display(Name = "BuiltyNumber", ResourceType = typeof(NameHandling))]
        public string BuiltyNumber { get; set; }

        [Display(Name = "LoadedWeight", ResourceType = typeof(NameHandling))]
        public decimal LoadedWeight { get; set; }

    }
}