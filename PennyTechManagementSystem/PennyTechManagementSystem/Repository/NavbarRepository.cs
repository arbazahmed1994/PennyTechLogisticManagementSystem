using Microsoft.Practices.EnterpriseLibrary.Data;
using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Repository
{
    public class NavbarRepository : Controller
    {
        Database db = Connection.GetDatabase();

        public IEnumerable<NavbarItem> Get()
        {

            DataSet ds = db.ExecuteDataSet("GetNavbar");

            return ds.Tables[0].ConvertToList<NavbarItem>();
        }

        public IEnumerable<NavbarItem> Get(int id)
        {

            DataSet ds = db.ExecuteDataSet("GetNavbarByID" , id);

            return ds.Tables[0].ConvertToList<NavbarItem>();
        }
    }
}