using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class EmployeeUserRepository : Repository<EmployeeUser>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetEmployeeUser"; } }
        public override string GetByIDSPName { get { return "GetEmployeeUserByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteEmployeeUser"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateEmployeeUser"; } }
        public override string EditSPName { get { return "UpdateEmployeeUser"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}