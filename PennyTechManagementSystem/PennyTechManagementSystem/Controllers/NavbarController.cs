using PennyTechManagementSystem.Constant;
using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Controllers
{
    public class NavbarController : Controller
    {
        private NavbarRepository _rep = new NavbarRepository();
        // GET: /Navbar/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TopNav()
        {
            //var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            //var role = identity.Claims.Where(c => c.Type == ClaimTypes.Role)
            //                   .Select(c => c.Value).SingleOrDefault();

            //var navBar = new Navbar();

            IEnumerable<NavbarItem> model = _rep.Get();
            return PartialView("TopNav", model);
        }

        public ActionResult NestedTopNav()
        {
            //var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            //var role = identity.Claims.Where(c => c.Type == ClaimTypes.Role)
            //                   .Select(c => c.Value).SingleOrDefault();

            //var navBar = new Navbar();

            int id = NavbarConstantID.NavID;

            IEnumerable<NavbarItem> model = _rep.Get(id);
            return PartialView("NestedTopNav", model);
        }

    }
}
