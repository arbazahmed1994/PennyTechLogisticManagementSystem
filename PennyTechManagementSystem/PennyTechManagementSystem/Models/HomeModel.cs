using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Models
{
    public class HomeModel : BaseModel<HomeModel>
    {

        // VEHICLE Total & Idle --
        public int VehicleCountPrivate { get; set; }
        public int VehicleCountOther { get; set; }
        public int VehicleIdlePrivate { get; set; }
        public int VehicleIdleOther { get; set; }

        // DRIVER Total & Idle
        public int DriverCount { get; set; }
        public int DriverIdle { get; set; }

        // EMPLOYEE Total & Present
        public int EmployeeCount { get; set; }
        public int EmployeePresent { get; set; }

    }
}