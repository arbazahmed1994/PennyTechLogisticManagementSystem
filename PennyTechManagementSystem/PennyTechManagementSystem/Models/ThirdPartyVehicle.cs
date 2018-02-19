using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Models
{
    public class ThirdPartyVehicle : BaseModel<ThirdPartyVehicle>
    {

        //vehicletype
        public IEnumerable<VehicleType> vehicletypeVar { get; set; }
        public IEnumerable<SelectListItem> vehicletypelist { get; set; }
        private int _vehicletypeid = 0;
        [Required]
        [Display(Name = "VehicleType", ResourceType = typeof(NameHandling))]
        public int VehicleType
        {
            get { return _vehicletypeid; }
            set { _vehicletypeid = value; }
        }

        //vehiclebusinesstype
        public IEnumerable<VehicleBusinessType> vehiclebusinesstypeVar { get; set; }
        public IEnumerable<SelectListItem> vehiclebusinesstypelist { get; set; }
        private int _vehiclebusunesstype = 0;
        [Required]
        [Display(Name = "VehicleBusunessType", ResourceType = typeof(NameHandling))]
        public int VehicleBusinessType
        {
            get { return _vehiclebusunesstype; }
            set { _vehiclebusunesstype = value; }
        }

        //vehiclecompany
        public IEnumerable<VehicleCompany> vehiclecompanyVar { get; set; }
        public IEnumerable<SelectListItem> vehiclecompanylist { get; set; }
        private int _vehiclecompanyid = 0;
        [Required]
        [Display(Name = "Company", ResourceType = typeof(NameHandling))]
        public int VehicleCompany
        {
            get { return _vehiclecompanyid; }
            set { _vehiclecompanyid = value; }
        }

        // CONSTRUCTOR --

        public ThirdPartyVehicle()
        {
            VehicleTypeRepository _vehicletyperep = new VehicleTypeRepository();
            vehicletypeVar = _vehicletyperep.Get();
            vehicletypelist = vehicletypeVar.ToVehicleTypeSelectListItems(VehicleType);

            VehicleBusinessTypeRepository _vehiclebusinesstyperep = new VehicleBusinessTypeRepository();
            vehiclebusinesstypeVar = _vehiclebusinesstyperep.Get();
            vehiclebusinesstypelist = vehiclebusinesstypeVar.ToVehicleBusinessTypeSelectListItems(VehicleBusinessType);

            VehicleCompanyRepository _vehiclecompanyrep = new VehicleCompanyRepository();
            vehiclecompanyVar = _vehiclecompanyrep.Get();
            vehiclecompanylist = vehiclecompanyVar.ToVehicleCompanySelectListItems(VehicleCompany);
         }


        // UN-REQUIRED --

        public string VehicleCode { get; set; }

        public string VehicleBusinessTypeName { get; set; }

        public string VehicleCompanyName { get; set; }

        public string VehicleTypeName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "ReturnedDate", ResourceType = typeof(NameHandling))]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReturnedDate { get; set; }

        [Display(Name = "RentAmount", ResourceType = typeof(NameHandling))]
        public double RentAmount { get; set; }

        [Display(Name = "Returned", ResourceType = typeof(NameHandling))]
        public bool Returned { get; set; }

        // REQUIRED --

        [Required]
        [Display(Name = "VehicleNumber", ResourceType = typeof(NameHandling))]
        public string VehicleNumber { get; set; }

        [Required]
        [Display(Name = "VehicleOwnerName", ResourceType = typeof(NameHandling))]
        public string VehicleOwnerName { get; set; }

        [DataType(DataType.Date)]
        private DateTime _rentInDate = DateTime.Now.Date;
        [Required]
        [Display(Name = "RentInDate", ResourceType = typeof(NameHandling))]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RentInDate
        {
            get { return _rentInDate; }
            set { _rentInDate = value; }
        }

        [Required]
        [Display(Name = "ExpenceMode", ResourceType = typeof(NameHandling))]
        public bool ExpenceMode { get; set; }
        
    }
}
