using System.Web;
using System.Web.Mvc;

namespace HTTP5112_Lab1_DylanBednar
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
