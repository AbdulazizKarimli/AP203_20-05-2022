using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
