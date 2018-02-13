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
    public class TripEndRepository : Repository<TripEndModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return ""; } }
        public override string GetByIDSPName { get { return ""; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return ""; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateTripEnd"; } }
        public override string EditSPName { get { return ""; } }
        public override string GetByModelSPName { get { return string.Empty; } }


        public IEnumerable<TripExpenceViewModel> GetExpenceList()
        {
            DataSet list = db.ExecuteDataSet("GetExpenceName");
            return list.Tables[0].ConvertToList<TripExpenceViewModel>();
        }

        public IEnumerable<TripBeginModel> GetEndedList()
        {
            DataSet ds = db.ExecuteDataSet("GetEndedTrips");
            return ds.Tables[0].ConvertToList<TripBeginModel>();
        }
    }
}