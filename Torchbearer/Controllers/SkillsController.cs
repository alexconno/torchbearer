using Microsoft.AspNetCore.Mvc;

namespace Torchbearer.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
