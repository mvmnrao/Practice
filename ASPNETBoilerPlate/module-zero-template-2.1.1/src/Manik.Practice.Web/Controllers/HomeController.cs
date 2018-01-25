using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Manik.Practice.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PracticeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}