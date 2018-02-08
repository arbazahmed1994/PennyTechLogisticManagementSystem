using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class ExpenceNameRepository : Repository<ExpenceNameModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetExpenceName"; } }
        public override string GetByIDSPName { get { return "GetExpenceNameByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteExpenceName"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateExpenceName"; } }
        public override string EditSPName { get { return "UpdateExpenceName"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}