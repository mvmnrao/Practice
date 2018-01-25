using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Sample.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.Controllers
{
    [Route("/[controller]"), Route("/")]
    public class HomeController : Controller
    {
        IGreetingService _service;
        public HomeController(IGreetingService service)
        {
            _service = service;
        }

        // GET: /<controller>/
        [Route("[action]"), Route("")]
        public IActionResult Default()
        {            
            GreetingMessage msg = _service.GetGreetingMessage();
            return View(msg);
            //return Content("Hellow, this is Manik.");
        }
    }
}
