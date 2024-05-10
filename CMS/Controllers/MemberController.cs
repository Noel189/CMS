using CMS.DataAccess.Data;
using CMS.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MemberController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {  
            List<Members> members = _db.Membertbl.ToList(); 
            return View(members);
        }
    }
}
