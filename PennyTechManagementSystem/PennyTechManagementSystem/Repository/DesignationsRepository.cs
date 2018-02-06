using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class DesignationsRepository : Repository<Designation>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetDesignations"; } }
        public override string GetByIDSPName { get { return "GetDesignationsByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteDesignations"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateDesignations"; } }
        public override string EditSPName { get { return "UpdateDesignations"; } }
        public override string GetByModelSPName { get { return string.Empty; } }
    }
}