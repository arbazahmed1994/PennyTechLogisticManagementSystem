using PennyTechManagementSystem.View_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace PennyTechManagementSystem.Models
{
    public class TripEndModel : BaseModel<TripEndModel>
    {
        
        // CONSTRUCTOR --
        public TripEndModel()
        {
            TripExpenceList = new List<TripExpenceViewModel>();
        }


        // REQUIRED --

        [Required]
        [Display(Name = "FuelLitre", ResourceType = typeof(NameHandling))]
        public decimal FuelLitre { get; set; }

        [Required]
        [Display(Name = "FuelRate", ResourceType = typeof(NameHandling))]
        public decimal FuelRate { get; set; }

        [Required]
        [Display(Name = "FuelAmount", ResourceType = typeof(NameHandling))]
        public decimal FuelAmount { get; set; }

        [DataType(DataType.Date)]
        private DateTime _endDate = DateTime.Now.Date;
        [Required]
        [Display(Name = "EndDate", ResourceType = typeof(NameHandling))]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required]
        public int TripReferenceID { get; set; }


        // UN-REQUIRED --

        public int MainTripID { get; set; }

        public List<TripExpenceViewModel> TripExpenceList { get; set; }

        public string TripExpenceListXML
        {
            get
            {
                XElement xmlElements = new XElement("TripExpenceLists",
                                TripExpenceList.Select(i => new XElement("TripExpenceList",
                                                   new XElement("ExpenceNameID", i.ExpenceNameID),
                                                   new XElement("Amount", i.Amount),
                                                   new XElement("Comments", i.Comments),
                                                   new XElement("ExpenceName", i.ExpenceName))));
                return xmlElements.ToString();
            }
        }

        //public List<TripBeginViewModel> TripBeginList { get; set; }

    }
}