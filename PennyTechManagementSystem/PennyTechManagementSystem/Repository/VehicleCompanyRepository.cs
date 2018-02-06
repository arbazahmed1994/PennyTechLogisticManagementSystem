using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class VehicleCompanyRepository : Repository<VehicleCompany>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetVehicleCompany"; } }
        public override string GetByIDSPName { get { return "GetVehicleCompanyByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteVehicleCompany"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateVehicleCompany"; } }
        public override string EditSPName { get { return "UpdateVehicleCompany"; } }
        public override string GetByModelSPName { get { return string.Empty; } }
    }
}