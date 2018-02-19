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
    public class LoginRepository
    {

        Database db = Connection.GetDatabase();

        public LoginModel Authenticate(string Username, string Password, string MachineName, string SessionID)
        {
            DataSet ds = db.ExecuteDataSet("AuthenticateUser", Username, Password, MachineName, SessionID);
            LoginModel model = new LoginModel();
            return model.ToModel<LoginModel>(ds);
        }

        public int Logout(string SessionID)
        {
            int result = db.ExecuteNonQuery("LogoutUser" , SessionID);
            return result;
        }
    }
}