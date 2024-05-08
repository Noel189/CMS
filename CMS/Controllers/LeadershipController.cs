using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class LeadershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
