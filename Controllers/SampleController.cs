using Microsoft.AspNetCore.Mvc;

namespace Tools.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
