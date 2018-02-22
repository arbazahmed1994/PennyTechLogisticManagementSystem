using PennyTechManagementSystem.Common;
using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class LoginController : Controller
    {

        private LoginRepository _rep = new LoginRepository();

        public ActionResult Login()
        {
            if (Session["Login"] == "Success")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Login")]
        public ActionResult Login(string Username , string Password)
        {
            string MachineName = System.Net.Dns.GetHostName();

            LoginModel model = new LoginModel();
            try
            {
                Session["Username"] = Username;
                string SessionID = Session.SessionID;
                model = _rep.Authenticate(Username, Password, MachineName, SessionID);
                Session["FullName"] = model.FullName;
                Session["UserCode"] = model.UserCode;
                Session["Login"] = "Success";

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                @ViewBag.Error = ex.Message;
                return View();
            }
        }

        public ActionResult Logout()
        {
            try
            {
                string SessionID = Session.SessionID;
                _rep.Logout(SessionID);
                Session.Clear();
                Session.Abandon();
            }
            catch (Exception)
            {
                
                throw;
            }
            
            return RedirectToAction("Login", "Login");
        }

    }
}
