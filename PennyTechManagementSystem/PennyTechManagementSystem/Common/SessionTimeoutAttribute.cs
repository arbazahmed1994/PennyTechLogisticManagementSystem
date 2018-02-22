using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Common
{

    public class SessionTimeoutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            if (HttpContext.Current.Session["FullName"] == null)
            {
                filterContext.Result = new RedirectResult("~/Login/Logout");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }

}