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
        private BasicRepository BasicRep = new BasicRepository();

        // MODEL LIST

        //Countries
        //public IEnumerable<BasicModel> Countries { get; set; }
        //public IEnumerable<SelectListItem> CountriesList { get; set; }
        //private int _countryID = 0;
        //[Required]
        //[Display(Name = "Country", ResourceType = typeof(NameHandling))]
        //public int CountryID
        //{
        //    get { return _countryID; }
        //    set { _countryID = value; }
        //}

        ////Status
        //public IEnumerable<BasicModel> Status { get; set; }
        //public IEnumerable<SelectListItem> StatusList { get; set; }
        //private int _statusID = 0;
        //[Required]
        //[Display(Name = "Status", ResourceType = typeof(NameHandling))]
        //public int StatusID
        //{
        //    get { return _statusID; }
        //    set { _statusID = value; }
        //}

        ////VehicleType
        //public IEnumerable<VehicleTypeModel> VehicleType { get; set; }
        //public IEnumerable<SelectListItem> VehicleTypeList { get; set; }
        //private int _vehicleTypeID = 0;
        //[Required]
        //[Display(Name = "VehicleType", ResourceType = typeof(NameHandling))]
        //public int VehicleTypeID
        //{
        //    get { return _vehicleTypeID; }
        //    set { _vehicleTypeID = value; }
        //}

        ////VehicleBusinessType
        //public IEnumerable<VehicleBusinessTypeModel> VehicleBusinessType { get; set; }
        //public IEnumerable<SelectListItem> VehicleBusinessTypeList { get; set; }
        //private int _vehicleBusunessType = 0;
        //[Required]
        //[Display(Name = "VehicleBusunessType", ResourceType = typeof(NameHandling))]
        //public int VehicleBusinessTypeID
        //{
        //    get { return _vehicleBusunessType; }
        //    set { _vehicleBusunessType = value; }
        //}

        ////VehicleCompany
        //public IEnumerable<VehicleCompanyModel> VehicleCompany { get; set; }
        //public IEnumerable<SelectListItem> VehicleCompanyList { get; set; }
        //private int _vehicleCompanyID = 0;
        //[Required]
        //[Display(Name = "Company", ResourceType = typeof(NameHandling))]
        //public int VehicleCompanyID
        //{
        //    get { return _vehicleCompanyID; }
        //    set { _vehicleCompanyID = value; }
        //}

        ////Color
        //public IEnumerable<BasicModel> Color { get; set; }
        //public IEnumerable<SelectListItem> ColorList { get; set; }
        //private int _colorID = 0;
        //[Required]
        //[Display(Name = "Color", ResourceType = typeof(NameHandling))]
        //public int ColorID
        //{
        //    get { return _colorID; }
        //    set { _colorID = value; }
        //}

        //// CONSTRUCTOR

        //public VehicleModel() {
        //    CountriesRepository _CountriesRep = new CountriesRepository();
        //    Countries = _CountriesRep.Get();
        //    CountriesList = Countries.ToCountrySelectListItems(CountryID);

        //    ProcedureNameHandling.GetSP = "GetStatus";
        //    Status = BasicRep.Get();
        //    StatusList = Status.ToStatusSelectListItems(StatusID);

        //    VehicleTypeRepository _VehicleTypeRep = new VehicleTypeRepository();
        //    VehicleType = _VehicleTypeRep.Get();
        //    VehicleTypeList = VehicleType.ToVehicleTypeSelectListItems(VehicleTypeID);

        //    VehicleBusinessTypeRepository _VehicleBusinessTypeRep = new VehicleBusinessTypeRepository();
        //    VehicleBusinessType = _VehicleBusinessTypeRep.Get();
        //    VehicleBusinessTypeList = VehicleBusinessType.ToVehicleBusinessTypeSelectListItems(VehicleBusinessTypeID);

        //    VehicleCompanyRepository _VehicleCompanyRep = new VehicleCompanyRepository();
        //    VehicleCompany = _VehicleCompanyRep.Get();
        //    VehicleCompanyList = VehicleCompany.ToVehicleCompanySelectListItems(VehicleCompanyID);

        //    ProcedureNameHandling.GetSP = "GetColor";
        //    Color = BasicRep.Get();
        //    ColorList = Color.ToColorSelectListItems(ColorID);
        //}


        //public string VehicleCode { get; set; }


        //// REQUIRED

        //[Required]
        //[Display(Name = "VehicleNumber", ResourceType = typeof(NameHandling))]
        //public string VehicleNumber { get; set; }

        //[Required]
        //[Display(Name = "VehicleLenght", ResourceType = typeof(NameHandling))]
        //public string VehicleLenght { get; set; }

        //[Required]
        //[Display(Name = "ModelYear", ResourceType = typeof(NameHandling))]
        //public int ModelYear { get; set; }

        //[Required]
        //[Display(Name = "NumberOfWheels", ResourceType = typeof(NameHandling))]
        //public int NumberOfWheels { get; set; }

        //[Required]
        //[Display(Name = "ChasisNumber", ResourceType = typeof(NameHandling))]
        //public string ChasisNumber { get; set; }

        //[Required]
        //[Display(Name = "EngineNumber", ResourceType = typeof(NameHandling))]
        //public string EngineNumber { get; set; }

        //[Required]
        //[Display(Name = "EngineHorsePower", ResourceType = typeof(NameHandling))]
        //public string EngineHorsePower { get; set; }

        //private DateTime _purchaseDate = DateTime.Now.Date;
        //[Required]
        //[DataType(DataType.Date)]
        //[Display(Name = "PurchaseDate", ResourceType = typeof(NameHandling))]
        //[DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}" , ApplyFormatInEditMode = true)]
        //public DateTime PurchaseDate {
        //    get { return _purchaseDate ; }
        //    set { _purchaseDate = value ; } 
        //}

        //[Required]
        //[Display(Name = "PurchaseFrom", ResourceType = typeof(NameHandling))]
        //public string PurchaseFrom { get; set; }

        //private DateTime _manufactureDate = DateTime.Now.Date;
        //[Required]
        //[DataType(DataType.Date)]
        //[Display(Name = "ManufactureDate", ResourceType = typeof(NameHandling))]
        //[DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        //public DateTime ManufactureDate
        //{
        //    get { return _manufactureDate; }
        //    set { _manufactureDate = value; }
        //}

        //[Required]
        //[Display(Name = "ManufacturedFrom", ResourceType = typeof(NameHandling))]
        //public string ManufacturedFrom { get; set; }

        //[Required]
        //[Display(Name = "VehicleModelName", ResourceType = typeof(NameHandling))]
        //public string VehicleModelName { get; set; }

    }
}