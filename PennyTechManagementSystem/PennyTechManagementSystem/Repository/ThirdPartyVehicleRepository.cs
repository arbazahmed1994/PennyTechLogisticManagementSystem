using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class ThirdPartyVehicleRepository : Repository<ThirdPartyVehicle>
    {
        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetThirdPartyVehicle"; } }
        public override string GetByIDSPName { get { return string.Empty; } }
        public override string GetByStringSPName { get { return "GetThirdPartyVehicleByID"; } }
        public override string DeleteSPName { get { return ""; } }
        public override string DeleteByStringSPName { get { return "DeleteThirdPartyVehicle"; } }
        public override string CreateSPName { get { return "CreateThirdPartyVehicle"; } }
        public override string EditSPName { get { return "UpdateThirdPartyVehicle"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}