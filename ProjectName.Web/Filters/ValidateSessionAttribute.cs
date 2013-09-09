using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectName.Sessions;
using ProjectName.Web.Controllers;
using System.Web.Routing;

namespace ProjectName.Web.Filters
{
    public class ValidateSessionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrWhiteSpace(SessionHandler.Id))
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Login"}));        
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}