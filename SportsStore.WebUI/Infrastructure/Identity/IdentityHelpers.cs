using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using SportsStore.WebUI.Models.Identity;
using Microsoft.AspNet.Identity;

namespace SportsStore.WebUI.Infrastructure.Identity
{
    public static class IdentityHelpers
    {
        public static MvcHtmlString GetUserName(this HtmlHelper html, string id)
        {
            AppUserManager mgr = HttpContext.Current.GetOwinContext().GetUserManager<AppUserManager>();

            return new MvcHtmlString(mgr.FindByIdAsync(id).Result.UserName);
        }
    }
}