using Microsoft.AspNetCore.Mvc;

namespace TaskFronttoBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
