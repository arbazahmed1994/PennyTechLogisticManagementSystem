using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class VehicleBusinessTypeRepository : Repository<VehicleBusinessType>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetVehicleBusinessType"; } }
        public override string GetByIDSPName { get { return "GetVehicleBusinessTypeByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteVehicleBusinessType"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateVehicleBusinessType"; } }
        public override string EditSPName { get { return "UpdateVehicleBusinessType"; } }
        public override string GetByModelSPName { get { return string.Empty; } }
    }
}