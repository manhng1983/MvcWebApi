using System.Web;
using System.Web.Mvc;

namespace VS2017Ent.ASPNETWebApp.MvcWebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
