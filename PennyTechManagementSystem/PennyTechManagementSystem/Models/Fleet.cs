using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Models
{
    public class Fleet
    {    
        public string VehicleCode { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleLenght { get; set; }
        public int ModelYear { get; set; }
        public int NumberOfWheels { get; set; }
        public string ChasisNumber { get; set; }
        public string EngineNumber { get; set; }
        public string EngineHorsePower { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseFrom { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string ManufacturedFrom { get; set; }
        public string VehicleModelName { get; set; }
        public bool IsDepreciated { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedBy { get; set; }
        public bool IsUpdated { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime VehicleEntryDate { get; set; }

        public IEnumerable<Color> ColorList { get; set; }
        public int ColorID { get; set; }

        public IEnumerable<Country> CountryList { get; set; }
        public int CountryID { get; set; }

        public IEnumerable<Status> StatusList { get; set; }
        public int StatusID { get; set; }

        public IEnumerable<VehicleType> VehicleTypeList { get; set; }
        public int VehicleTypeID { get; set; }

        public IEnumerable<VehicleBusinessType> VehicleBusinessTypeList { get; set; }
        public int VehicleBusinessTypeID { get; set; }

        public IEnumerable<VehicleCompany> VehicleCompanyList { get; set; }
        public int VehicleCompanyID { get; set; }

    }
}
