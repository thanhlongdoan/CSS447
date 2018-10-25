using System.Web.Mvc;
using System.Web.Routing;

namespace CS447.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!Request.IsAuthenticated)
            {
                //filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Login1", id = UrlParameter.Optional }));
                filterContext.Result = RedirectToAction("Login1", "Account", new { area = "" });
            }
            base.OnActionExecuting(filterContext);
        }
    }
}