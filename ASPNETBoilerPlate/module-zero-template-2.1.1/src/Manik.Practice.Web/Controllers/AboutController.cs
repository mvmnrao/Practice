using System.Web.Mvc;

namespace Manik.Practice.Web.Controllers
{
    public class AboutController : PracticeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}