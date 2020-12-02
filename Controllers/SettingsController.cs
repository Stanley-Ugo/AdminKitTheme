using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminKitTheme.Controllers
{
    [Route("/settings")]
    public class SettingsController : Controller
    {
        [Route("/settings")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
