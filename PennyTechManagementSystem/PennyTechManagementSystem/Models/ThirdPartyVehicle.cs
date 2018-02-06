
using System;
using System.Collections.Generic;
namespace WindowsFormsApplication2
{
    public class ThirdPartyVehicle
    {
        public string VehicleCode { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleOwnerName { get; set; }
        public System.DateTime RentInDate { get; set; }
        public Nullable<double> RentAmount { get; set; }
        public bool ExpenceMode { get; set; }
        public bool Returned { get; set; }
        public Nullable<System.DateTime> ReturnedDate { get; set; }

        public IEnumerable<VehicleCompany> VehicleCompanyList { get; set; }
        public Nullable<int> VehicleCompany { get; set; }

        public IEnumerable<VehicleType> VehicleTypeList { get; set; }
        public int VehicleType { get; set; }

        public IEnumerable<VehicleBusinessType> VehicleBusinessTypeList { get; set; }
        public Nullable<int> VehicleBusinessType { get; set; }

    }
}
