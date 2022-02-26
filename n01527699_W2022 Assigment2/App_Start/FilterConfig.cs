using System.Web;
using System.Web.Mvc;

namespace n01527699_W2022_Assigment2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
