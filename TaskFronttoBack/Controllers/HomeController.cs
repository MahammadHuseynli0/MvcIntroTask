using Microsoft.AspNetCore.Mvc;

namespace TaskFronttoBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
