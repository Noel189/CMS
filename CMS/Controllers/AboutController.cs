using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
