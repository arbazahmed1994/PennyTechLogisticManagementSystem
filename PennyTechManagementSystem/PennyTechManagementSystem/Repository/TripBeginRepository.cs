using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class TripBeginRepository : Repository<TripBeginModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetTripBegin"; } }
        public override string GetByIDSPName { get { return string.Empty; } }
        public override string GetByStringSPName { get { return "GetDriverByID"; } }
        public override string DeleteSPName { get { return string.Empty; } }
        public override string DeleteByStringSPName { get { return "DeleteDriver"; } }
        public override string CreateSPName { get { return "CreateTripBegin"; } }
        public override string EditSPName { get { return "UpdateDriver"; } }
        public override string GetByModelSPName { get { return string.Empty; } }
    }
}