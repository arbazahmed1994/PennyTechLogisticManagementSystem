using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class ExpenceCategoryRepository : Repository<ExpenceCategoryModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetExpenceCategory"; } }
        public override string GetByIDSPName { get { return "GetExpenceCategoryByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteExpenceCategory"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateExpenceCategory"; } }
        public override string EditSPName { get { return "UpdateExpenceCategory"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}