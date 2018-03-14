using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class CitiesRepository : Repository<City>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetCities"; } }
        public override string GetByIDSPName { get { return "GetCitiesByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteCities"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateCities"; } }
        public override string EditSPName { get { return "UpdateCities"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}