using System.Web;
using System.Web.Mvc;

namespace Banksystem_testprojektGit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
