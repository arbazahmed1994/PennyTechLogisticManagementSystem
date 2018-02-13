using PennyTechManagementSystem.Constant;
using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Models
{
    public class VehicleModel : BaseModel<VehicleModel>
    {
        private BasicRepository _basicRep = new BasicRepository();

        // MODEL LIST

        //countries
        public IEnumerable<BasicModel> countries { get; set; }
        public IEnumerable<SelectListItem> countrieslist { get; set; }
        private int _countryid = 0;
        [Required]
        [Display(Name = "Country", ResourceType = typeof(NameHandling))]
        public int CountryID
        {
            get { return _countryid; }
            set { _countryid = value; }
        }

        //status
        public IEnumerable<BasicModel> status { get; set; }
        public IEnumerable<SelectListItem> statuslist { get; set; }
        private int _statusid = 0;
        [Required]
        [Display(Name = "Status", ResourceType = typeof(NameHandling))]
        public int StatusID
        {
            get { return _statusid; }
            set { _statusid = value; }
        }

        //vehicletype
        public IEnumerable<VehicleType> vehicletype { get; set; }
        public IEnumerable<SelectListItem> vehicletypelist { get; set; }
        private int _vehicletypeid = 0;
        [Required]
        [Display(Name = "VehicleType", ResourceType = typeof(NameHandling))]
        public int VehicleTypeID
        {
            get { return _vehicletypeid; }
            set { _vehicletypeid = value; }
        }

        //vehiclebusinesstype
        public IEnumerable<VehicleBusinessType> vehiclebusinesstype { get; set; }
        public IEnumerable<SelectListItem> vehiclebusinesstypelist { get; set; }
        private int _vehiclebusunesstype = 0;
        [Required]
        [Display(Name = "VehicleBusunessType", ResourceType = typeof(NameHandling))]
        public int VehicleBusinessTypeID
        {
            get { return _vehiclebusunesstype; }
            set { _vehiclebusunesstype = value; }
        }

        //vehiclecompany
        public IEnumerable<VehicleCompany> vehiclecompany { get; set; }
        public IEnumerable<SelectListItem> vehiclecompanylist { get; set; }
        private int _vehiclecompanyid = 0;
        [Required]
        [Display(Name = "Company", ResourceType = typeof(NameHandling))]
        public int VehicleCompanyID
        {
            get { return _vehiclecompanyid; }
            set { _vehiclecompanyid = value; }
        }

        //color
        public IEnumerable<BasicModel> color { get; set; }
        public IEnumerable<SelectListItem> colorlist { get; set; }
        private int _colorid = 0;
        [Required]
        [Display(Name = "Color", ResourceType = typeof(NameHandling))]
        public int ColorID
        {
            get { return _colorid; }
            set { _colorid = value; }
        }

        // constructor

        public VehicleModel() {
            ProcedureNameHandling.GetSP = "GetCountry";
            countries = _basicRep.Get();
            countrieslist = countries.ToCountrySelectListItems(CountryID);

            ProcedureNameHandling.GetSP = "GetStatus";
            status = _basicRep.Get();
            statuslist = status.ToStatusSelectListItems(StatusID);

            VehicleTypeRepository _vehicletyperep = new VehicleTypeRepository();
            vehicletype = _vehicletyperep.Get();
            vehicletypelist = vehicletype.ToVehicleTypeSelectListItems(VehicleTypeID);

            VehicleBusinessTypeRepository _vehiclebusinesstyperep = new VehicleBusinessTypeRepository();
            vehiclebusinesstype = _vehiclebusinesstyperep.Get();
            vehiclebusinesstypelist = vehiclebusinesstype.ToVehicleBusinessTypeSelectListItems(VehicleBusinessTypeID);

            VehicleCompanyRepository _vehiclecompanyrep = new VehicleCompanyRepository();
            vehiclecompany = _vehiclecompanyrep.Get();
            vehiclecompanylist = vehiclecompany.ToVehicleCompanySelectListItems(VehicleCompanyID);

            ProcedureNameHandling.GetSP = "GetColor";
            color = _basicRep.Get();
            colorlist = color.ToColorSelectListItems(ColorID);
        }


        public string VehicleCode { get; set; }

        public string CountryName { get; set; }

        public string StatusName { get; set; }

        public string VehicleTypeName { get; set; }

        public string VehicleBusinessTypeName { get; set; }

        public string VehicleCompanyName { get; set; }

        public string ColorName { get; set; }


        // REQUIRED

        [Required]
        [Display(Name = "VehicleNumber", ResourceType = typeof(NameHandling))]
        public string VehicleNumber { get; set; }

        [Required]
        [Display(Name = "VehicleLenght", ResourceType = typeof(NameHandling))]
        public string VehicleLenght { get; set; }

        [Required]
        [Display(Name = "ModelYear", ResourceType = typeof(NameHandling))]
        public int ModelYear { get; set; }

        [Required]
        [Display(Name = "NumberOfWheels", ResourceType = typeof(NameHandling))]
        public int NumberOfWheels { get; set; }

        [Required]
        [Display(Name = "ChasisNumber", ResourceType = typeof(NameHandling))]
        public string ChasisNumber { get; set; }

        [Required]
        [Display(Name = "EngineNumber", ResourceType = typeof(NameHandling))]
        public string EngineNumber { get; set; }

        [Required]
        [Display(Name = "EngineHorsePower", ResourceType = typeof(NameHandling))]
        public string EngineHorsePower { get; set; }

        private DateTime _purchaseDate = DateTime.Now.Date;
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "PurchaseDate", ResourceType = typeof(NameHandling))]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        [Required]
        [Display(Name = "PurchaseFrom", ResourceType = typeof(NameHandling))]
        public string PurchaseFrom { get; set; }

        private DateTime _manufactureDate = DateTime.Now.Date;
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "ManufactureDate", ResourceType = typeof(NameHandling))]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime ManufactureDate
        {
            get { return _manufactureDate; }
            set { _manufactureDate = value; }
        }

        [Required]
        [Display(Name = "ManufacturedFrom", ResourceType = typeof(NameHandling))]
        public string ManufacturedFrom { get; set; }

        [Required]
        [Display(Name = "VehicleModelName", ResourceType = typeof(NameHandling))]
        public string VehicleModelName { get; set; }

    }
}