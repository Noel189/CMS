﻿using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class DonateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
