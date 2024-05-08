using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
