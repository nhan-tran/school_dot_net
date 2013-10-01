using System.Web;
using System.Web.Mvc;

namespace nt_lab3_HomeInventory
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}