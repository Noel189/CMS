﻿using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
