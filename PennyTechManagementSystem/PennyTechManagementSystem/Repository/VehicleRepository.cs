﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class VehicleRepository : Repository<VehicleModel>
    {
        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetVehicle"; } }
        public override string GetByIDSPName { get { return ""; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return ""; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return ""; } }
        public override string EditSPName { get { return ""; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}