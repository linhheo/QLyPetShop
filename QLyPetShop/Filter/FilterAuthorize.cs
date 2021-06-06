using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLyBakery.Filter
{
    public class FilterAuthorize : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated == false)
            {
                filterContext.Result = new RedirectResult("/Accounts/Login");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}