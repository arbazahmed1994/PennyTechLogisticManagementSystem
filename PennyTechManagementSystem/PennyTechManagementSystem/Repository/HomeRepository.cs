using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public class HomeRepository
    {
        Database db = Connection.GetDatabase();

        public HomeModel GetVehicleData()
        {
            DataSet ds = db.ExecuteDataSet("GetIdleVehicle");
            HomeModel model = new HomeModel();
            model.VehicleCountPrivate = (int)ds.Tables[0].Rows[0][0];
            model.VehicleCountOther = (int)ds.Tables[1].Rows[0][0];
            model.VehicleIdlePrivate = (int)ds.Tables[2].Rows[0][0];
            model.VehicleIdleOther = (int)ds.Tables[3].Rows[0][0];
            model.DriverCount = (int)ds.Tables[4].Rows[0][0];
            model.DriverIdle = (int)ds.Tables[5].Rows[0][0];
            model.EmployeeCount = (int)ds.Tables[6].Rows[0][0];
            model.EmployeePresent = (int)ds.Tables[7].Rows[0][0];
            return model;
        }

    }
}