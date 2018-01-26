using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Constant;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class BasicRepository : Repository<BasicModel>
    {
        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return ProcedureNameHandling.GetSP; } }
        public override string GetByIDSPName { get { return ProcedureNameHandling.GetByIdSP; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return ProcedureNameHandling.DeleteSP; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return ProcedureNameHandling.CreateSP; } }
        public override string EditSPName { get { return ProcedureNameHandling.UpdateSP; } }
        public override string GetByModelSPName { get { return string.Empty; } }
    }
}