using Microsoft.AspNetCore.Mvc;

namespace Top5.Controllers
{
    public class FootballController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Number1()
        {
            return View();
        }
    }
}
