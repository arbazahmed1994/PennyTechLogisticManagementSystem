using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class DriverRepository : Repository<Driver>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetDriver"; } }
        public override string GetByIDSPName { get { return "GetDriverByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteDriver"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateDriver"; } }
        public override string EditSPName { get { return "UpdateDriver"; } }
        public override string GetByModelSPName { get { return string.Empty; } }
    }
}