using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class VehicleTypeRepository : Repository<VehicleType>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetVehicleType"; } }
        public override string GetByIDSPName { get { return "GetVehicleTypeByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteVehicleType"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateVehicleType"; } }
        public override string EditSPName { get { return "UpdateVehicleType"; } }
        public override string GetByModelSPName { get { return string.Empty; } }
    }
}