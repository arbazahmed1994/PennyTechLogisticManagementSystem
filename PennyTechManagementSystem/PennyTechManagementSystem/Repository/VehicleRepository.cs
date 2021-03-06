﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class VehicleRepository : Repository<VehicleModel>
    {
        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetVehicle"; } }
        public override string GetByIDSPName { get { return string.Empty; } }
        public override string GetByStringSPName { get { return "GetVehicleByID"; } }
        public override string DeleteSPName { get { return ""; } }
        public override string DeleteByStringSPName { get { return "DeleteVehicle"; } }
        public override string CreateSPName { get { return "CreateVehicle"; } }
        public override string EditSPName { get { return "UpdateVehicle"; } }
        public override string GetByModelSPName { get { return string.Empty; } }


        public IEnumerable<VehicleModel> GetAllVehicle()
        {
            DataSet ds = db.ExecuteDataSet("GetAllVehicle");
            return ds.Tables[0].ConvertToList<VehicleModel>();
        }
    }
}