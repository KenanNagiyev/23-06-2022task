﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicatask1.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CoruselController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
