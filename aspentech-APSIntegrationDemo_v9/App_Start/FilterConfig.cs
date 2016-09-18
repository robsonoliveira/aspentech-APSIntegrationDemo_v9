using System.Web;
using System.Web.Mvc;

namespace aspentech_APSIntegrationDemo_v9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
