using Microsoft.AspNetCore.Mvc;

namespace TaskFronttoBack.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
