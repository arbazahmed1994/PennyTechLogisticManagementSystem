using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class DepartmentRepository : Repository<Department>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetDepartments"; } }
        public override string GetByIDSPName { get { return "GetDepartmentByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteDepartment"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateDepartment"; } }
        public override string EditSPName { get { return "UpdateDepartment"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}