using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class SermonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
