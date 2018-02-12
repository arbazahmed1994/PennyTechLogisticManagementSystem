using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.View_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class TripBeginRepository : Repository<TripBeginModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetTripBegin"; } }
        public override string GetByIDSPName { get { return "GetTripBeginByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return string.Empty; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateTripEnd"; } }
        public override string EditSPName { get { return "UpdateDriver"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

        public IEnumerable<TripBeginViewModel> GetList(int id)
        {
            DataSet ds = db.ExecuteDataSet(GetByIDSPName, id);
            return ds.Tables[0].ConvertToList<TripBeginViewModel>();
        }
    }
}